using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMakeItemComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Image_Select;
        public GameObject Btn_XuanZhong;
        public GameObject Lab_PetName;
        public GameObject ItemHeroIon;
        public GameObject ImageQuality;

        public int ItemID;
        public int MakeID;
        public Action<int> ActionClick;
        public GameObject GameObject;
        
        public List<string> AssetPath = new List<string>();
    }


    public class UIMakeItemComponentAwakeSystem : AwakeSystem<UIMakeItemComponent, GameObject>
    {
        public override void Awake(UIMakeItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Btn_XuanZhong = rc.Get<GameObject>("Btn_XuanZhong");
            self.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.ItemHeroIon = rc.Get<GameObject>("ItemHeroIon");
            self.ImageQuality = rc.Get<GameObject>("ImageQuality");
            self.Image_Select = rc.Get<GameObject>("Image_Select");

            self.Btn_XuanZhong.GetComponent<Button>().onClick.AddListener(() => { self.OnClickItem(); });
        }

    }
    public class UIMakeItemComponentDestroy : DestroySystem<UIMakeItemComponent>
    {
        public override void Destroy(UIMakeItemComponent self)
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

    public static class UIMakeItemComponentSystem
    {

        public static void OnUpdateUI(this UIMakeItemComponent self, int makeId)
        {
            self.MakeID = makeId;
            self.ItemID = EquipMakeConfigCategory.Instance.Get(makeId).MakeItemID;

            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(self.ItemID);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ItemHeroIon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
            string path2 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
            Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path2);
            if (!self.AssetPath.Contains(path2))
            {
                self.AssetPath.Add(path2);
            }
            self.ImageQuality.GetComponent<Image>().sprite = sp2;

            self.Lab_PetName.GetComponent<Text>().text = itemconfig.ItemName;
            self.Lab_PetName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColorDi(itemconfig.ItemQuality);
        }

        public static void SetClickAction(this UIMakeItemComponent self, Action<int> action)
        {
            self.ActionClick = action;
        }

        public static void OnClickItem(this UIMakeItemComponent self)
        {
            self.ActionClick(self.MakeID);
        }
    }
}

