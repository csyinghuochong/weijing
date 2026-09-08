using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetFenJieTipItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
        public GameObject ImageXuanzhong;
        public GameObject Img_PetHeroIon;
        public GameObject Lab_PetName;
        public GameObject Lab_PetLv;
        public GameObject ImageDiButton;
        public GameObject Lab_JiNeng;

        public RolePetInfo RolePetInfo;
        public Action<long> ClickPetHandler;
        public List<string> AssetPath = new List<string>();
    }

    public class UIPetFenJieTipItemComponentAwakeSystem : AwakeSystem<UIPetFenJieTipItemComponent, GameObject>
    {
        public override void Awake(UIPetFenJieTipItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageXuanzhong = rc.Get<GameObject>("ImageXuanzhong");
            self.ImageXuanzhong.SetActive(false);
            self.Img_PetHeroIon = rc.Get<GameObject>("Img_PetHeroIon");
            self.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.Lab_PetLv = rc.Get<GameObject>("Lab_PetLv");
            self.Lab_JiNeng = rc.Get<GameObject>("Lab_JiNeng");
            self.ImageDiButton = rc.Get<GameObject>("ImageDiButton");
            ButtonHelp.AddListenerEx(self.ImageDiButton, () => { self.OnClickPetItem(); });
        }
    }

    public class UIPetFenJieTipItemComponentDestroy : DestroySystem<UIPetFenJieTipItemComponent>
    {
        public override void Destroy(UIPetFenJieTipItemComponent self)
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

    public static class UIPetFenJieTipItemComponentSystem
    {
        public static void SetClickHandler(this UIPetFenJieTipItemComponent self, Action<long> action)
        {
            self.ClickPetHandler = action;
        }

        public static void OnClickPetItem(this UIPetFenJieTipItemComponent self)
        {
            if (self.RolePetInfo == null)
            {
                return;
            }

            self.ClickPetHandler?.Invoke(self.RolePetInfo.Id);
        }

        public static void OnSelectUI(this UIPetFenJieTipItemComponent self, RolePetInfo rolePetInfo)
        {
            self.ImageXuanzhong.SetActive(rolePetInfo != null && self.RolePetInfo != null && self.RolePetInfo.Id == rolePetInfo.Id);
        }

        public static void OnInitData(this UIPetFenJieTipItemComponent self, RolePetInfo rolePetInfo)
        {
            self.RolePetInfo = rolePetInfo;
            if (rolePetInfo == null)
            {
                return;
            }

            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petSkinConfig.IconID.ToString());
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }

            self.Img_PetHeroIon.GetComponent<Image>().sprite = sp;
            self.Lab_PetName.GetComponent<Text>().text = MulLanguageHelper.ShowPetName(rolePetInfo.PetName);
            self.Lab_PetLv.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("评分: {0}"), PetHelper.PetPingJia(rolePetInfo));
            self.Lab_JiNeng.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("技能: {0}"), rolePetInfo.PetSkill.Count);
        }
    }
}
