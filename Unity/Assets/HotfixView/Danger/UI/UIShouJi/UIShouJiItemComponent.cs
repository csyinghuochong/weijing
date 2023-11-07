using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIShouJiItemComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Label_HaveTag;
        public GameObject Label_StarNum;
        public GameObject GameObject;
        public GameObject Label_ItemName;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
        public List<string> AssetPath = new List<string>();
    }


    public class UIShouJiItemComponentAwakeSystem : AwakeSystem<UIShouJiItemComponent, GameObject>
    {
        public override void Awake(UIShouJiItemComponent self, GameObject go)
        {
            self.GameObject = go;
            self.Label_ItemName = go.Get<GameObject>("Label_ItemName");
            self.Image_ItemIcon = go.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = go.Get<GameObject>("Image_ItemQuality");
            self.Label_HaveTag = go.Get<GameObject>("Label_HaveTag");
            self.Label_StarNum = go.Get<GameObject>("Label_StarNum");
        }
    }    
    public class UIShouJiItemComponentDestroy: DestroySystem<UIShouJiItemComponent>
    {
        public override void Destroy(UIShouJiItemComponent self)
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

    public static class UIShouJiItemComponentSystem
    {
        public static void  OnUpdateUI(this UIShouJiItemComponent self, int chapterId, ShouJiItemConfig shouJiItemConfig)
        {
            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(shouJiItemConfig.ItemID);
            long instanceid = self.InstanceId;
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            if (instanceid != self.InstanceId)
            {
                return;
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

            self.Label_ItemName.GetComponent<Text>().text = itemconfig.ItemName;
            self.Label_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconfig.ItemQuality);

            self.Label_StarNum.GetComponent<Text>().text = shouJiItemConfig.StartNum.ToString();
            ShoujiComponent shoujiComponent = self.ZoneScene().GetComponent<ShoujiComponent>();
            bool have = shoujiComponent.HaveShouJiItem(chapterId,shouJiItemConfig.ItemID);
            self.Label_HaveTag.GetComponent<Text>().text = have ? "已拥有" : "未拥有";
            self.Label_HaveTag.GetComponent<Text>().color =have ? Color.green : Color.white;
            UICommonHelper.SetImageGray(self.Image_ItemIcon, !have);
            UICommonHelper.SetImageGray(self.Image_ItemQuality, !have);
        }
    }
}
