using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITuZhiMakeNeedComponent : Entity, IAwake,IDestroy
    {
        public GameObject Image_EventTrigger;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
        public GameObject Label_ItemNum;
        public GameObject Label_ItemName;
        public List<string> AssetPath = new List<string>();
    }


    public class UITuZhiMakeNeedComponentAwakeSystem : AwakeSystem<UITuZhiMakeNeedComponent>
    {
        public override void Awake(UITuZhiMakeNeedComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Image_EventTrigger = rc.Get<GameObject>("Image_EventTrigger");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");
        }
    }
    public class UITuZhiMakeNeedComponentDestroy: DestroySystem<UITuZhiMakeNeedComponent>
    {
        public override void Destroy(UITuZhiMakeNeedComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }
    public static class UITuZhiMakeNeedComponentSystem
    {

        public static void UpdateItem(this UITuZhiMakeNeedComponent self, int itemId, int needNumber)
        {
            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(itemId);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
            string path1 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
            Sprite sp1 = ResourcesComponent.Instance.LoadAsset<Sprite>(path1);
            if (!self.AssetPath.Contains(path1))
            {
                self.AssetPath.Add(path1);
            }
            self.Image_ItemQuality.GetComponent<Image>().sprite = sp1;

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            long haveNumber = bagComponent.GetItemNumber(itemId);
            self.Label_ItemNum.GetComponent<Text>().text = string.Format("{0}/{1}", haveNumber, needNumber);

            if (haveNumber >= needNumber)
            {
                self.Label_ItemNum.GetComponent<Text>().color = new Color(130f / 255f, 255f / 255f, 0f / 255f);
            }
            else
            {
                self.Label_ItemNum.GetComponent<Text>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
            }

            self.Label_ItemName.GetComponent<Text>().text = itemconfig.ItemName;
            self.Label_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconfig.ItemQuality);

        }
    }
}
