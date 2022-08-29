using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMakeNeedComponent : Entity, IAwake<GameObject>
    {

        public GameObject Image_EventTrigger;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
        public GameObject Label_ItemNum;
        public GameObject Label_ItemName;

        public GameObject GameObject;
    }

    [ObjectSystem]
    public class UIMakeNeedComponentAwakeSystem : AwakeSystem<UIMakeNeedComponent, GameObject>
    {
        public override void Awake(UIMakeNeedComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Image_EventTrigger = rc.Get<GameObject>("Image_EventTrigger");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");
        }
    }

    public static class UIMakeNeedComponentSystem
    {

        public static void UpdateItem(this UIMakeNeedComponent self, int itemId, int needNumber)
        {
            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(itemId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
            self.Image_ItemQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconStr);

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            long haveNumber = bagComponent.GetItemNumber(itemId);
            self.Label_ItemNum.GetComponent<Text>().text = string.Format("{0}/{1}", haveNumber, needNumber);

            if (haveNumber >= needNumber)
            {
                self.Label_ItemNum.GetComponent<Text>().color = new Color(130f / 255f, 255f / 255f, 0f / 255f);
            }
            else {
                self.Label_ItemNum.GetComponent<Text>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
            }

            self.Label_ItemName.GetComponent<Text>().text = itemconfig.ItemName;
            self.Label_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconfig.ItemQuality);

        }
    }
}
