using System.Collections.Generic;
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

        public List<UICommonSkillItemComponent> PetSkillUIList = new List<UICommonSkillItemComponent>();
        public GameObject[] PetZiZhiItemList = new GameObject[6];
        public UIPetSkinIconComponent PetSkinIconComponent;
        public UIModelShowComponent uIModelShowComponent;
    }

    [ObjectSystem]
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

        public static async ETTask InitModelShowView(this UIPetChouKaGetComponent self, RolePetInfo rolePetInfo)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>( "UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            self.uIModelShowComponent.ShowOtherModel("Pet/" + petConfig.PetModel.ToString()).Coroutine();
        }

        public static void OnBtn_Close(this UIPetChouKaGetComponent self)
        {
            UIHelper.Remove(  self.DomainScene(), UIType.UIPetChouKaGet ).Coroutine();
        }

        public static void OnInitUI(this UIPetChouKaGetComponent self, RolePetInfo rolePetInfo, bool showSkin = false)
        {
            self.InitModelShowView(rolePetInfo).Coroutine();

            PetConfig petConfig = PetConfigCategory.Instance.Get( rolePetInfo.ConfigId );
            self.Text_Tip.GetComponent<Text>().text = $"{petConfig.PetName}";
            self.PetSkinIconComponent.OnUpdateUI(rolePetInfo.SkinId, true);
            self.UIPetSkinIcon.SetActive(showSkin);
            self.UpdateSkillList(rolePetInfo).Coroutine();
            self.UpdateAttribute(rolePetInfo);
        }

        public static async ETTask UpdateSkillList(this UIPetChouKaGetComponent self, RolePetInfo rolePetInfo)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetSkillItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

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
                    ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>( bagSpace);
                    self.PetSkillUIList.Add(ui_item);
                }
                ui_item.OnUpdateUI(rolePetInfo.PetSkill[i], ABAtlasTypes.PetSkillIcon);
            }

            for (int i = rolePetInfo.PetSkill.Count; i < self.PetSkillUIList.Count; i++)
            {
                self.PetSkillUIList[i].GameObject.SetActive(false);
            }
        }

        public static void UpdateAttribute(this UIPetChouKaGetComponent self, RolePetInfo rolePetInfo)
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
