using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICommonCostItemComponent : Entity, IAwake, IAwake<GameObject>
    {
        public GameObject Label_ItemName;
        public GameObject Label_ItemNum;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
    }

    [ObjectSystem]
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

    public static class UICommonCostItemComponentSystem
    {
        public static void UpdateItem(this UICommonCostItemComponent self, int itemId, int itemNum)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);

            self.Label_ItemName.GetComponent<Text>().text = itemConfig.ItemName;

            self.Label_ItemNum.GetComponent<Text>().text = $"{bagComponent.GetItemNumber(itemId)}/{itemNum}";

            self.Label_ItemNum.GetComponent<Text>().color = (itemNum< bagComponent.GetItemNumber(itemId)) ? Color.green : Color.red;

            Sprite sp =  ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;

            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemConfig.ItemQuality);
            self.Image_ItemQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
        }
    }
}
