using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetInfoShowComponent : Entity, IAwake<GameObject>
    {

        public int Weizhi; //-1左 1 右边
        public PetOperationType BagOperationType;

        public GameObject Text_PetLevel;
        public GameObject Img_PetHeroIon;
        public GameObject Img_PeteroQuality;
        public GameObject Text_PetExp;
        public GameObject ImageExpValue;
        public GameObject Text_PetName;
        public GameObject PetSkillNode;

        public List<UICommonSkillItemComponent> PetSkillUIList;
        public GameObject[] PetZiZhiItemList = new GameObject[6];

        public GameObject ImageStarList;
        public GameObject Btn_QieHuan;
        public GameObject GameObject;
    }

    [ObjectSystem]
    public class UIPetInfoShowComponentAwakeSystem : AwakeSystem<UIPetInfoShowComponent, GameObject>
    {
        public override void Awake(UIPetInfoShowComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            self.PetSkillUIList = new List<UICommonSkillItemComponent>();
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_PetLevel = rc.Get<GameObject>("Text_PetLevel");
            self.Img_PetHeroIon = rc.Get<GameObject>("Img_PetHeroIon");

            self.Img_PeteroQuality = rc.Get<GameObject>("Img_PeteroQuality");
            self.Img_PeteroQuality.GetComponent<Button>().onClick.AddListener(() => { self.OnClickSelect().Coroutine(); });

            self.Text_PetExp = rc.Get<GameObject>("Text_PetExp");
            self.ImageExpValue = rc.Get<GameObject>("ImageExpValue");
            self.Text_PetName = rc.Get<GameObject>("Text_PetName");
            self.PetSkillNode = rc.Get<GameObject>("PetSkillNode");

            for (int i = 0; i < self.PetZiZhiItemList.Length; i++)
            {
                self.PetZiZhiItemList[i] = rc.Get<GameObject>("PetZiZhiItem" + (i+1));
            }

            self.ImageStarList = rc.Get<GameObject>("ImageStarList");

            self.Btn_QieHuan = rc.Get<GameObject>("Btn_QieHuan");
            self.Btn_QieHuan.GetComponent<Button>().onClick.AddListener(() => { self.OnClickSelect().Coroutine(); });
        }
    }

    public static class UIPetInfoShowComponentSystem
    {
        public static async ETTask OnClickSelect(this UIPetInfoShowComponent self)
        {
            UI uIpet = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            uIpet.GetComponent<UIPetComponent>().PetItemWeizhi = self.Weizhi;

            UI ui = await UIHelper.Create( self.DomainScene(), UIType.UIPetSelect );
            ui.GetComponent<UIPetSelectComponent>().OnSetType(self.BagOperationType);
        }

        public static async ETTask UpdateSkillList(this UIPetInfoShowComponent self, RolePetInfo rolePetInfo)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            List<int> zhuanzhuids = new List<int>();
            string[] zhuanzhuskills = petConfig.ZhuanZhuSkillID.Split(';');
            for (int i = 0; i < zhuanzhuskills.Length; i++)
            {
                if (zhuanzhuskills[i].Length > 1)
                {
                    zhuanzhuids.Add(int.Parse(zhuanzhuskills[i]));
                }
            }
            List<int> skills = new List<int>();
            for (int i = 0; i < rolePetInfo.PetSkill.Count; i++)
            {
                if (zhuanzhuids.Contains(rolePetInfo.PetSkill[i]))
                {
                    skills.Insert(0, rolePetInfo.PetSkill[i]);
                }
                else
                {
                    skills.Add(rolePetInfo.PetSkill[i]);
                }
            }

            for (int i = 0; i < skills.Count; i++)
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
                    ui_item = self.AddChild< UICommonSkillItemComponent, GameObject >( bagSpace);
                    self.PetSkillUIList.Add(ui_item);
                }
                ui_item.OnUpdateUI(skills[i], ABAtlasTypes.PetSkillIcon);
            }

            for (int i = skills.Count; i < self.PetSkillUIList.Count; i++)
            {
                self.PetSkillUIList[i].GameObject.SetActive(false);
            }
        }

        public static void UpdateAttribute(this UIPetInfoShowComponent self, RolePetInfo rolePetInfo)
        {
            /*
            for (int i = 0; i < self.ImageStarList.transform.childCount; i++)
            {
                self.ImageStarList.transform.GetChild(i).gameObject.SetActive(rolePetInfo.Star > i);
            }
            */
            self.Text_PetName.GetComponent<Text>().text = rolePetInfo.PetName;
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petSkinConfig.IconID.ToString());
            self.Img_PetHeroIon.GetComponent<Image>().sprite = sp;

            self.Text_PetLevel.GetComponent<Text>().text = rolePetInfo.PetLv.ToString() + GameSettingLanguge.LoadLocalization("级");
            ExpConfig expConfig = ExpConfigCategory.Instance.Get(rolePetInfo.PetLv);

            string expStr = rolePetInfo.PetExp.ToString();
            string upExpStr = expConfig.UpExp.ToString();

            if (rolePetInfo.PetExp >= 10000) 
            {
                expStr = (int)(rolePetInfo.PetExp / 10000) + GameSettingLanguge.LoadLocalization("万");
            }

            if (expConfig.UpExp >= 10000)
            {
                upExpStr = (int)(expConfig.UpExp / 10000) + GameSettingLanguge.LoadLocalization("万");
            }

            self.Text_PetExp.GetComponent<Text>().text = string.Format("{0}/{1}", expStr, upExpStr);
            self.ImageExpValue.transform.localScale = new Vector3(Mathf.Clamp(rolePetInfo.PetExp * 1f / expConfig.UpExp, 0f, 1f), 1f, 1f);

            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Hp, petConfig.ZiZhi_Hp_Max);
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Act, petConfig.ZiZhi_Act_Max);
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Def, petConfig.ZiZhi_Def_Max);
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Adf, petConfig.ZiZhi_Adf_Max);
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_MageAct, petConfig.ZiZhi_MageAct_Max); 
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", UICommonHelper.ShowFloatValue(rolePetInfo.ZiZhi_ChengZhang), UICommonHelper.ShowFloatValue((float)petConfig.ZiZhi_ChengZhang_Max));

            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Hp * 1f / petConfig.ZiZhi_Hp_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Act * 1f / petConfig.ZiZhi_Act_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Def * 1f / petConfig.ZiZhi_Def_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Adf * 1f / petConfig.ZiZhi_Adf_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_MageAct * 1f / petConfig.ZiZhi_MageAct_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_ChengZhang * 1f / (float)petConfig.ZiZhi_ChengZhang_Max, 0f, 1f), 1f, 1f);
        }

        public static void CheckNoPet(this UIPetInfoShowComponent self, bool havepet)
        {
            //self.ImageStarList.SetActive(havepet && !GlobalHelp.IsBanHaoMode);
            self.Img_PetHeroIon.SetActive(havepet);
            self.Text_PetLevel.SetActive(havepet);
            self.Text_PetExp.SetActive(havepet);
            self.ImageExpValue.SetActive(havepet);
            for (int i = 0; i < self.PetZiZhiItemList.Length; i++)
            {
                self.PetZiZhiItemList[i].SetActive(havepet);
            }
            for (int i = 0; i < self.PetSkillUIList.Count; i++)
            {
                self.PetSkillUIList[i].GameObject.SetActive(false);
            }
        }

        public static void OnInitData(this UIPetInfoShowComponent self, RolePetInfo rolePetInfo)
        {
            self.CheckNoPet(rolePetInfo != null);
            if (rolePetInfo == null)
            {
                self.Text_PetName.GetComponent<Text>().text = "未选择宠物";
                return;
            }

            self.UpdateSkillList(rolePetInfo).Coroutine();
            self.UpdateAttribute(rolePetInfo);
        }

    }

}
