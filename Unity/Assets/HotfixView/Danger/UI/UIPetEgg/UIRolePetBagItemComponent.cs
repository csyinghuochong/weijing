using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRolePetBagItemComponent: Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Label_ItemName;
        public GameObject Image_ItemButton;
        public GameObject Image_XuanZhong;
        public GameObject Image_ItemIcon;

        public GameObject GameObject;
        public Action<RolePetInfo> ClickHandler;
        public RolePetInfo RolePetInfo;
        public List<string> AssetPath = new List<string>();
    }

    public class UIRolePetBagItemComponentAwake: AwakeSystem<UIRolePetBagItemComponent, GameObject>
    {
        public override void Awake(UIRolePetBagItemComponent self, GameObject gameObject)
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

    public class UIRolePetBagItemComponentDestroy: DestroySystem<UIRolePetBagItemComponent>
    {
        public override void Destroy(UIRolePetBagItemComponent self)
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

    public static class UIRolePetBagItemComponentSystem
    {
        public static void OnImage_ItemButton(this UIRolePetBagItemComponent self)
        {
            self.ClickHandler(self.RolePetInfo);
        }

        public static void SetSelected(this UIRolePetBagItemComponent self, long petid)
        {
            self.Image_XuanZhong.SetActive(self.RolePetInfo.Id == petid);
        }

        public static void SetClickHandler(this UIRolePetBagItemComponent self, Action<RolePetInfo> action)
        {
            self.ClickHandler = action;
        }

        public static void OnInitUI(this UIRolePetBagItemComponent self, RolePetInfo rolePetInfo)
        {
            self.RolePetInfo = rolePetInfo;

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petSkinConfig.IconID.ToString());
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