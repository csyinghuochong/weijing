using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIMakeLearnItemComponent : Entity,IAwake<GameObject>,IDestroy
    {
        public GameObject ImageSelect;
        public GameObject Label_LearnLv;
        public GameObject Label_ItemName;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
        public GameObject ImageButton;

        public int MakeId;
        public Action<int> ClickHandler;
        public GameObject GameObject;
        
        public List<string> AssetPath = new List<string>();
    }


    public class UIMakeLearnItemComponentAwakeSystem : AwakeSystem<UIMakeLearnItemComponent, GameObject>
    {
        public override void Awake(UIMakeLearnItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Label_LearnLv = rc.Get<GameObject>("Label_LearnLv");
            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnImageButton();
            });
        }
    }
    public class UIMakeLearnItemComponentDestroy : DestroySystem<UIMakeLearnItemComponent>
    {
        public override void Destroy(UIMakeLearnItemComponent self)
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
    public static class UIMakeLearnItemComponentSystem
    {
        public static void SetSelected(this UIMakeLearnItemComponent self, int makeid)
        {
            self.ImageSelect.SetActive(self.MakeId == makeid);
        }

        public static void OnImageButton(this UIMakeLearnItemComponent self)
        {
            self.ClickHandler(self.MakeId);
        }

        public static void SetClickHandler(this UIMakeLearnItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnUpdateUI(this UIMakeLearnItemComponent self, int makeid)
        {
            self.MakeId = makeid;

            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeid);
            self.Label_LearnLv.GetComponent<Text>().text = string.Format("学习等级:{0}级", equipMakeConfig.LearnLv);

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equipMakeConfig.MakeItemID);
            self.Label_ItemName.GetComponent<Text>().text = itemConfig.ItemName;
            self.Label_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemConfig.ItemQuality);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
            
            string ItemQuality = FunctionUI.GetInstance().ItemQualiytoPath(itemConfig.ItemQuality);
            string path2 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, ItemQuality);
            Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path2);
            if (!self.AssetPath.Contains(path2))
            {
                self.AssetPath.Add(path2);
            }
            self.Image_ItemQuality.GetComponent<Image>().sprite = sp2;
        }

    }

}
