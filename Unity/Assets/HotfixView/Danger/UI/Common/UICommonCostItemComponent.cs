using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICommonCostItemComponent : Entity, IAwake, IAwake<GameObject>,IDestroy
    {
        public GameObject Label_ItemName;
        public GameObject Label_ItemNum;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;

        public List<string> AssetPath = new List<string>();
    }


    public class UICommonCostItemComponentAwakeSystem : AwakeSystem<UICommonCostItemComponent, GameObject>
    {
        public override void Awake(UICommonCostItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
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
        public static void UpdateItem(this UICommonCostItemComponent self, int itemId, int itemNum)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);

            self.Label_ItemName.GetComponent<Text>().text = itemConfig.ItemName;

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
            Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path2))
            {
                self.AssetPath.Add(path2);
            }
            self.Image_ItemQuality.GetComponent<Image>().sprite = sp2;
        }
    }
}
