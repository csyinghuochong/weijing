using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICommonCostItemComponent : Entity, IAwake, IAwake<GameObject>,IDestroy
    {
        public GameObject Image_ItemButton;
        public GameObject Label_ItemName;
        public GameObject Label_ItemNum;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
        public GameObject GameObject;

        public int ItemId;
        public List<string> AssetPath = new List<string>();
    }


    public class UICommonCostItemComponentAwakeSystem : AwakeSystem<UICommonCostItemComponent, GameObject>
    {
        public override void Awake(UICommonCostItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;

            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Image_ItemButton = rc.Get<GameObject>("Image_ItemButton");
            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
            
            self.Image_ItemButton.GetComponent<Button>().onClick.AddListener(self.OnClickUIItem);
        }
    }
    public class UICommonCostItemComponentDestroy : DestroySystem<UICommonCostItemComponent>
    {
        public override void Destroy(UICommonCostItemComponent self)
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
    public static class UICommonCostItemComponentSystem
    {
        public static void OnClickUIItem(this UICommonCostItemComponent self)
        {
            if (self.ItemId == 0)
            {
                return;
            }
            
            //弹出Tips
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = new BagInfo() { ItemID = self.ItemId };
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void UpdateItem(this UICommonCostItemComponent self, int itemId, int itemNum)
        {
            self.ItemId = itemId;
            
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);

            self.Label_ItemName.GetComponent<Text>().text = itemConfig.GetItemName();

            //显示字
            //self.Label_ItemNum.GetComponent<Text>().text = $"{bagComponent.GetItemNumber(itemId)}/{itemNum}";
            self.Label_ItemNum.GetComponent<Text>().text = $"{UICommonHelper.NumToWString(bagComponent.GetItemNumber(itemId))}/{UICommonHelper.NumToWString(itemNum)}";
            //显示颜色
            self.Label_ItemNum.GetComponent<Text>().color = (itemNum< bagComponent.GetItemNumber(itemId)) ? Color.green : Color.red;
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;

            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemConfig.ItemQuality);
            string path2 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
            Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path2);
            self.Image_ItemQuality.GetComponent<Image>().sprite = sp2;
        }
    }
}
