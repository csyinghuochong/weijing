using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{ 
    public class UIPetChouKaGetComponent : Entity, IAwake
    {
        public GameObject ImageStarList;
        public GameObject PetSkillNode;
        public GameObject Text_PetName;
        public GameObject Text_PetLevel;
        public GameObject Text_Tip;
        public GameObject RawImage;
        public GameObject Btn_Close;
        public GameObject Text_Quality;
        public GameObject UIPetSkinIcon;
        public GameObject Text_FightValue;

        public List<UICommonSkillItemComponent> PetSkillUIList = new List<UICommonSkillItemComponent>();
        public GameObject[] PetZiZhiItemList = new GameObject[6];
        public GameObject[] PetZiZhiItemAddList = new GameObject[6];
        public UIPetSkinIconComponent PetSkinIconComponent;
        public UIModelShowComponent uIModelShowComponent;

        public GameObject NewSkinName;
        public GameObject PiFuJiHuo;
    }


    public class UIPetChouKaGetComponentAwakeSystem : AwakeSystem<UIPetChouKaGetComponent>
    {
        public override void Awake(UIPetChouKaGetComponent self)
        {
            self.PetSkillUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageStarList = rc.Get<GameObject>("ImageStarList");
            self.PetSkillNode = rc.Get<GameObject>("PetSkillNode");
            self.Text_PetName = rc.Get<GameObject>("Text_PetName");
            self.Text_PetLevel = rc.Get<GameObject>("Text_PetLevel");
            self.Text_Quality = rc.Get<GameObject>("Text_Quality");
            self.UIPetSkinIcon = rc.Get<GameObject>("UIPetSkinIcon");
            self.Text_FightValue = rc.Get<GameObject>("Text_FightValue");

            self.NewSkinName = rc.Get<GameObject>("NewSkinName");
            self.PiFuJiHuo = rc.Get<GameObject>("PiFuJiHuo");

            for (int i = 0; i < self.PetZiZhiItemList.Length; i++)
            {
                self.PetZiZhiItemList[i] = rc.Get<GameObject>("PetZiZhiItem" + (i + 1));
            }

            self.Text_Tip = rc.Get<GameObject>("Text_Tip");
            self.RawImage = rc.Get<GameObject>("RawImage");

            GameObject UIPetSkinIcon = rc.Get<GameObject>("UIPetSkinIcon");
            self.PetSkinIconComponent = self.AddChild<UIPetSkinIconComponent, GameObject>(UIPetSkinIcon);

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            ButtonHelp.AddListenerEx(self.Btn_Close, () => { self.OnBtn_Close(); });
        }
    }

    public static class UIPetChouKaGetComponentSystem
    {

        public static  void InitModelShowView(this UIPetChouKaGetComponent self, RolePetInfo rolePetInfo)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>( "UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);

            //PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            self.uIModelShowComponent.ShowOtherModel("Pet/" + petSkinConfig.SkinID.ToString()).Coroutine();

        }

        public static void OnBtn_Close(this UIPetChouKaGetComponent self)
        {
            UIHelper.Remove(  self.DomainScene(), UIType.UIPetChouKaGet );
        }

        public static void OnInitUI(this UIPetChouKaGetComponent self, RolePetInfo rolePetInfo, List<KeyValuePair> oldSkins, bool showSkin = false, RolePetInfo oldRolePetInfo = null)
        {
            try
            {
                self.InitModelShowView(rolePetInfo);

                PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);

                bool newSkin = true;
                for (int p = 0; p < oldSkins.Count; p++)
                {
                    if (oldSkins[p].KeyId != rolePetInfo.ConfigId)
                    {
                        continue;
                    }
                    if (oldSkins[p].Value.Contains(rolePetInfo.SkinId.ToString()))
                    {
                        newSkin = false;
                        break;
                    }
                }

                //获取此模型是否被激活
                if (newSkin == true)
                {
                    self.NewSkinName.SetActive(true);
                    self.PiFuJiHuo.SetActive(true);
                }
                else
                {
                    self.NewSkinName.SetActive(false);
                    self.PiFuJiHuo.SetActive(false);
                }

                self.Text_Tip.GetComponent<Text>().text = $"{petConfig.PetName}";
                self.PetSkinIconComponent.OnUpdateUI(rolePetInfo.SkinId, true);

                self.UpdateSkillList(rolePetInfo, oldRolePetInfo);
                self.UpdateAttribute(rolePetInfo, oldRolePetInfo);

                self.Text_FightValue.GetComponent<Text>().text = PetHelper.PetPingJia(rolePetInfo).ToString();

            }
            catch (Exception ex)
            {
                Log.Error("PetChouKaError: " + ex.ToString());
            }
        }

        public static  void UpdateSkillList(this UIPetChouKaGetComponent self, RolePetInfo rolePetInfo, RolePetInfo oldPetInfo = null)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < rolePetInfo.PetSkill.Count; i++)
            {
                UICommonSkillItemComponent ui_item = null;
                if (i < self.PetSkillUIList.Count)
                {
                    ui_item = self.PetSkillUIList[i];
                    ui_item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.PetSkillNode);
                    ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(bagSpace);
                    self.PetSkillUIList.Add(ui_item);

                    if (oldPetInfo != null) {
                        if (oldPetInfo.PetSkill.Contains(rolePetInfo.PetSkill[i]) == false) {
                            ui_item.NewSkillHint.SetActive(true);
                        }
                    }
                }
                ui_item.OnUpdateUI(rolePetInfo.PetSkill[i], ABAtlasTypes.PetSkillIcon);
            }

            for (int i = rolePetInfo.PetSkill.Count; i < self.PetSkillUIList.Count; i++)
            {
                self.PetSkillUIList[i].GameObject.SetActive(false);
            }
        }

        public static void UpdateAttribute(this UIPetChouKaGetComponent self, RolePetInfo rolePetInfo, RolePetInfo oldPetInfo = null)
        {
            for (int i = 0; i < self.ImageStarList.transform.childCount; i++)
            {
                //self.ImageStarList.transform.GetChild(i).gameObject.SetActive(rolePetInfo.Star > i);
                if (rolePetInfo.Star > i)
                {
                    self.StartShowImg(self.ImageStarList.transform.GetChild(i).gameObject);
                }
            }

            self.Text_PetName.GetComponent<Text>().text = rolePetInfo.PetName;
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
          
            self.Text_PetLevel.GetComponent<Text>().text = rolePetInfo.PetLv.ToString() + "级";
            ExpConfig expConfig = ExpConfigCategory.Instance.Get(rolePetInfo.PetLv);

            self.Text_Quality.GetComponent<Text>().text = UICommonHelper.GetPetQualityName(petConfig.PetQuality);
            self.Text_Quality.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(petConfig.PetQuality);

            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Hp, petConfig.ZiZhi_Hp_Max);
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Act, petConfig.ZiZhi_Act_Max);
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Def, petConfig.ZiZhi_Def_Max);
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Adf, petConfig.ZiZhi_Adf_Max);
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_MageAct, petConfig.ZiZhi_MageAct_Max);
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_ChengZhang, petConfig.ZiZhi_ChengZhang_Max);
            if (oldPetInfo != null)
            {
                self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiAddValue").GetComponent<Text>().text = string.Format("(提升" + (rolePetInfo.ZiZhi_Hp - oldPetInfo.ZiZhi_Hp) + "点)");
                self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiAddValue").GetComponent<Text>().text = string.Format("(提升" + (rolePetInfo.ZiZhi_Act - oldPetInfo.ZiZhi_Act) + "点)");
                self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiAddValue").GetComponent<Text>().text = string.Format("(提升" + (rolePetInfo.ZiZhi_Def - oldPetInfo.ZiZhi_Def) + "点)");
                self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiAddValue").GetComponent<Text>().text = string.Format("(提升" + (rolePetInfo.ZiZhi_Adf - oldPetInfo.ZiZhi_Adf) + "点)");
                self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiAddValue").GetComponent<Text>().text = string.Format("(提升" + (rolePetInfo.ZiZhi_MageAct - oldPetInfo.ZiZhi_MageAct) + "点)");
                self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiAddValue").GetComponent<Text>().text = string.Format("(提升" + (rolePetInfo.ZiZhi_ChengZhang - oldPetInfo.ZiZhi_ChengZhang) + "点)");
            }
            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Hp * 1f / petConfig.ZiZhi_Hp_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Act * 1f / petConfig.ZiZhi_Act_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Def * 1f / petConfig.ZiZhi_Def_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Adf * 1f / petConfig.ZiZhi_Adf_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_MageAct * 1f / petConfig.ZiZhi_MageAct_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_ChengZhang * 1f / (float)petConfig.ZiZhi_ChengZhang_Max, 0f, 1f), 1f, 1f);
        }

        public static void StartShowImg(this UIPetChouKaGetComponent self, GameObject startObj)
        {

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, "Start_2");
            startObj.GetComponent<Image>().sprite = sp;

        }

    }

}
