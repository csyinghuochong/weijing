using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIMakeItemComponent : Entity, IAwake<GameObject>
    {

        public GameObject Btn_XuanZhong;
        public GameObject Lab_PetName;
        public GameObject ItemHeroIon;
        public GameObject ImageQuality;

        public int ItemID;
        public int MakeID;
        public Action<int> ActionClick;
        public GameObject GameObject;
    }

    [ObjectSystem]
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

            self.Btn_XuanZhong.GetComponent<Button>().onClick.AddListener(() => { self.OnClickItem(); });
        }

    }


    public static class UIMakeItemComponentSystem
    {

        public static void OnUpdateUI(this UIMakeItemComponent self, int makeId)
        {
            self.MakeID = makeId;
            self.ItemID = EquipMakeConfigCategory.Instance.Get(makeId).MakeItemID;

            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(self.ItemID);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            self.ItemHeroIon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
            self.ImageQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconStr);

            self.Lab_PetName.GetComponent<Text>().text = itemconfig.ItemName;
            self.Lab_PetName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconfig.ItemQuality);
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

