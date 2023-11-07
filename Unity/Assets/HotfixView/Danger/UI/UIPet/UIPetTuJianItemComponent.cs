using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetTuJianItemComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Label_ItemName;
        public GameObject Image_ItemButton;
        public GameObject Image_XuanZhong;
        public GameObject Image_ItemIcon;

        public GameObject GameObject;
        public Action<int> ClickHandler;
        public int PetId;
        public List<string> AssetPath = new List<string>();
    }


    public class UIPetTuJianItemComponentAwake : AwakeSystem<UIPetTuJianItemComponent, GameObject>
    {
        public override void Awake(UIPetTuJianItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;

            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");

            self.Image_ItemButton = rc.Get<GameObject>("Image_ItemButton");
            self.Image_ItemButton.GetComponent<Button>().onClick.AddListener(self.OnImage_ItemButton);

            self.Image_XuanZhong = rc.Get<GameObject>("Image_XuanZhong");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");

        }
    }
    
    public class UIPetTuJianItemComponentDestroy: DestroySystem<UIPetTuJianItemComponent>
    {
        public override void Destroy(UIPetTuJianItemComponent self)
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

    public static class UIPetTuJianItemComponentSystem
    {

        public static void OnImage_ItemButton(this UIPetTuJianItemComponent self)
        {
            self.ClickHandler(self.PetId);
        }

        public static void SetSelected(this UIPetTuJianItemComponent self, int petid)
        {
            self.Image_XuanZhong.SetActive(self.PetId == petid);
        }

        public static void SetClickHandler(this UIPetTuJianItemComponent self, Action<int> action)
        { 
            self.ClickHandler = action; 
        }

        public static void OnInitUI(this UIPetTuJianItemComponent self, int petid)
        {
            self.PetId = petid;

            PetConfig petConfig = PetConfigCategory.Instance.Get(petid);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
            self.Label_ItemName.GetComponent<Text>().text = petConfig.PetName;
        }
    }
}
