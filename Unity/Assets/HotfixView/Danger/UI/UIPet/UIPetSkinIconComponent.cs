using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetSkinIconComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject GameObject;
        public GameObject TextSkinName;
        public GameObject Image_ItemButton;
        public GameObject Image_XuanZhong;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
        public GameObject JiHuoSet;
        public Action<int> ClickHandler;
        public int SkinId;
        public List<string> AssetPath = new List<string>();
    }


    public class UIPetSkinIconComponentAwakeSystem : AwakeSystem<UIPetSkinIconComponent, GameObject>
    {
        public override void Awake(UIPetSkinIconComponent self, GameObject go)
        {
            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
            self.GameObject = go;
            self.TextSkinName = rc.Get<GameObject>("TextSkinName");
            self.Image_ItemButton = rc.Get<GameObject>("Image_ItemButton");
            self.Image_XuanZhong = rc.Get<GameObject>("Image_XuanZhong");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
            self.JiHuoSet = rc.Get<GameObject>("JiHuoSet");

            self.Image_XuanZhong.SetActive(false);
            self.Image_ItemButton.GetComponent<Button>().onClick.AddListener( self.OnImage_ItemButton);
        }
    }
    public class UIPetSkinIconComponentDestroy: DestroySystem<UIPetSkinIconComponent>
    {
        public override void Destroy(UIPetSkinIconComponent self)
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
    public static class UIPetSkinIconComponentSystem
    {

        public static void SetClickHandler(this UIPetSkinIconComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnImage_ItemButton(this UIPetSkinIconComponent self)
        {
            self.ClickHandler( self.SkinId );
        }

        public static void OnSelected(this UIPetSkinIconComponent self, int skinId)
        {
            self.Image_XuanZhong.SetActive( self.SkinId == skinId );
        }

        public static void OnUpdateUI(this UIPetSkinIconComponent self, int skinId, bool unlocked)
        {
            self.SkinId = skinId;
            PetSkinConfig skillConfig = PetSkinConfigCategory.Instance.Get(skinId);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon,  skillConfig.IconID.ToString());
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
            self.TextSkinName.GetComponent<Text>().text = skillConfig.Name;
            UICommonHelper.SetImageGray(self.Image_ItemIcon, !unlocked);
            UICommonHelper.SetImageGray(self.Image_ItemQuality, !unlocked);
            if (unlocked)
            {
                self.JiHuoSet.SetActive(true);
            }
            else
            {
                self.JiHuoSet.SetActive(false);
            }
        }
    }
}
