using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPetFormationItemComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject ImageFight;
        public GameObject ImageBack;
        public GameObject TextLv;
        public GameObject TextName;
        public GameObject ImageIcon;
        public GameObject GameObject;

        public Action<RolePetInfo, PointerEventData> BeginDragHandler;
        public Action<RolePetInfo, PointerEventData> DragingHandler;
        public Action<RolePetInfo, PointerEventData> EndDragHandler;
        public RolePetInfo RolePetInfo;
        
        public List<string> AssetPath = new List<string>();
    }


    public class UIPetFormationItemComponentAwakeSystem : AwakeSystem<UIPetFormationItemComponent, GameObject>
    {
        public override void Awake(UIPetFormationItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextLv = rc.Get<GameObject>("TextLv");
            self.TextName = rc.Get<GameObject>("TextName");
            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.ImageBack = rc.Get<GameObject>("ImageBack");
            self.ImageFight = rc.Get<GameObject>("ImageFight");

            ButtonHelp.AddEventTriggers(self.ImageIcon, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.ImageIcon, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.ImageIcon, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
        }
    }
    public class UIPetFormationItemComponentDestroy : DestroySystem<UIPetFormationItemComponent>
    {
        public override void Destroy(UIPetFormationItemComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UIPetFormationItemComponentSystem
    {
        public static void SetFighting(this UIPetFormationItemComponent self, bool fighting)
        {
            self.ImageFight.SetActive(fighting);
        }

        public static void SetDragEnable(this UIPetFormationItemComponent self, bool enabled)
        {
            self.ImageIcon.GetComponent<EventTrigger>().enabled = enabled;
        }

        public static void BeginDrag(this UIPetFormationItemComponent self, PointerEventData pdata)
        {
            if (self.ImageFight.activeSelf)
            {
                FloatTipManager.Instance.ShowFloatTip("请先下阵！");
                return;
            }    

            self.BeginDragHandler?.Invoke(self.RolePetInfo, pdata);
        }

        public static void Draging(this UIPetFormationItemComponent self, PointerEventData pdata)
        {
            if (self.ImageFight.activeSelf)
            {
                return;
            }
            self.DragingHandler?.Invoke(self.RolePetInfo, pdata);
        }

        public static void EndDrag(this UIPetFormationItemComponent self, PointerEventData pdata)
        {
            if (self.ImageFight.activeSelf)
            {
                return;
            }
            self.EndDragHandler?.Invoke(self.RolePetInfo, pdata);
        }


        public static void OnInitUI(this UIPetFormationItemComponent self, RolePetInfo rolePetInfo, bool fighting = false)
        {
            self.RolePetInfo= rolePetInfo;
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ImageIcon.GetComponent<Image>().sprite = sp;
            self.ImageFight.SetActive(fighting);
            self.TextLv.GetComponent<Text>().text = $"等级: {rolePetInfo.PetLv}";
            self.TextName.GetComponent<Text>().text = rolePetInfo.PetName;
        }
    }
}
