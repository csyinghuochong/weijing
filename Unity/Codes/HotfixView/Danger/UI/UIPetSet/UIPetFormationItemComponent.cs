using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPetFormationItemComponent : Entity, IAwake<GameObject>
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
    }

    [ObjectSystem]
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
            self.BeginDragHandler?.Invoke(self.RolePetInfo, pdata);
        }

        public static void Draging(this UIPetFormationItemComponent self, PointerEventData pdata)
        {
            self.DragingHandler?.Invoke(self.RolePetInfo, pdata);
        }

        public static void EndDrag(this UIPetFormationItemComponent self, PointerEventData pdata)
        {
            self.EndDragHandler?.Invoke(self.RolePetInfo, pdata);
        }


        public static void OnInitUI(this UIPetFormationItemComponent self, RolePetInfo rolePetInfo, bool fighting = false)
        {
            self.RolePetInfo= rolePetInfo;
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            self.ImageIcon.GetComponent<Image>().sprite = sp;
            self.ImageFight.SetActive(fighting);
            self.TextLv.GetComponent<Text>().text = $"等级: {rolePetInfo.PetLv}";
            self.TextName.GetComponent<Text>().text = rolePetInfo.PetName;
        }
    }
}
