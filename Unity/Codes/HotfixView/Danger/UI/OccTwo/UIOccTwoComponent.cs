
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIOccTwoComponent : Entity, IAwake
    {
        public GameObject Image_ZhiYe;
        public GameObject Image_ZhiYe_4;

        public GameObject Image_WuQi_Zhuan;
        public GameObject Image_WuQi_Type;

        public GameObject ButtonOccTwo;
        public GameObject Button_ZhiYe_Select;
        public GameObject Button_ZhiYe_3;
        public GameObject Button_ZhiYe_2;
        public GameObject Button_ZhiYe_1;
        public List<GameObject> Button_ZhiYe_List = new List<GameObject>();

        public GameObject OccNengLi_1;
        public GameObject OccNengLi_2;
        public GameObject OccNengLi_3;

        public GameObject SkillContainer;
        public GameObject Text_ZhiYe_4;
        public GameObject Text_ZhiYe_3;
        public GameObject Text_ZhiYe_2;
        public GameObject Text_ZhiYe_1;
        public GameObject Text_ZhiYe;

        public GameObject closeButton;
        public GameObject ButtonOccReset;

        public GameObject Lab_HuJia;
        public GameObject Lab_WuQi;

        public int OccTwoId;

        public Dictionary<int, string> showType = new Dictionary<int, string>()
        {
            {  1,  GameSettingLanguge.LoadLocalization("剑类") },
            {  2,  GameSettingLanguge.LoadLocalization("刀类") },
            {  3,  GameSettingLanguge.LoadLocalization("法杖") },
            {  4,  GameSettingLanguge.LoadLocalization("魔法书") },
            {  11,  GameSettingLanguge.LoadLocalization("布甲") },
            {  12,  GameSettingLanguge.LoadLocalization("轻甲") },
            {  13,  GameSettingLanguge.LoadLocalization("重甲") },
        };
    }

    [ObjectSystem]
    public class UIOccTwoComponentAwakeSystem : AwakeSystem<UIOccTwoComponent>
    {
        public override void Awake(UIOccTwoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Button_ZhiYe_List.Clear();

            self.Image_ZhiYe_4 = rc.Get<GameObject>("Image_ZhiYe_4");
            self.Image_ZhiYe = rc.Get<GameObject>("Image_ZhiYe");

            self.Image_WuQi_Zhuan = rc.Get<GameObject>("Image_WuQi_Zhuan");
            self.Image_WuQi_Type = rc.Get<GameObject>("Image_WuQi_Type");

            self.OccNengLi_1 = rc.Get<GameObject>("OccNengLi_1");
            self.OccNengLi_2 = rc.Get<GameObject>("OccNengLi_2");
            self.OccNengLi_3 = rc.Get<GameObject>("OccNengLi_3");

            self.Button_ZhiYe_Select = rc.Get<GameObject>("Button_ZhiYe_Select");
            self.Button_ZhiYe_3 = rc.Get<GameObject>("Button_ZhiYe_3");
            self.Button_ZhiYe_3.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_ZhiYe(2); });
            self.Button_ZhiYe_2 = rc.Get<GameObject>("Button_ZhiYe_2");
            self.Button_ZhiYe_2.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_ZhiYe(1); });
            self.Button_ZhiYe_1 = rc.Get<GameObject>("Button_ZhiYe_1");
            self.Button_ZhiYe_1.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_ZhiYe(0); });
            self.SkillContainer = rc.Get<GameObject>("SkillContainer");
            self.Button_ZhiYe_List.Add( self.Button_ZhiYe_1);
            self.Button_ZhiYe_List.Add( self.Button_ZhiYe_2);
            self.Button_ZhiYe_List.Add( self.Button_ZhiYe_3);

            self.ButtonOccTwo = rc.Get<GameObject>("ButtonOccTwo");
            ButtonHelp.AddListenerEx(self.ButtonOccTwo, () => { self.OnClickOccTwo();   });

            self.Text_ZhiYe_4 = rc.Get<GameObject>("Text_ZhiYe_4");
            self.Text_ZhiYe_3 = rc.Get<GameObject>("Text_ZhiYe_3");
            self.Text_ZhiYe_2 = rc.Get<GameObject>("Text_ZhiYe_2");
            self.Text_ZhiYe_1 = rc.Get<GameObject>("Text_ZhiYe_1");
            self.Text_ZhiYe = rc.Get<GameObject>("Text_ZhiYe");

            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickOccTwoui(); });

            self.ButtonOccReset = rc.Get<GameObject>("ButtonOccReset");
            self.ButtonOccReset.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonOccReset().Coroutine(); });

            self.Lab_HuJia = rc.Get<GameObject>("Lab_HuJia");
            self.Lab_WuQi = rc.Get<GameObject>("Lab_WuQi");

            self.OnInitUI();
        }
    }

    public static class UIOccTwoComponentSystem
    {

        public static void OnClickOccTwo(this UIOccTwoComponent self)
        {
            OccupationTwoConfig occupationTwoConfig = OccupationTwoConfigCategory.Instance.Get(self.OccTwoId);
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "转职", $"是否转职为：{occupationTwoConfig.OccupationName}", () =>
            {
                self.RequestChangeOcc().Coroutine();
            }).Coroutine();
        }

        public static async ETTask RequestChangeOcc(this UIOccTwoComponent self)
        {
            bool ifChange = await self.ZoneScene().GetComponent<SkillSetComponent>().ChangeOccTwoRequest(self.OccTwoId);
            //if (ifChange)
            //{
            //    UIHelper.Remove(self.DomainScene(), UIType.UIOccTwo).Coroutine();
            //}
        }

        public static void OnInitUI(this UIOccTwoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(occ);
            self.Text_ZhiYe.GetComponent<Text>().text = occupationConfig.OccupationName;

            int[] OccTwoID = occupationConfig.OccTwoID;
            self.Text_ZhiYe_1.GetComponent<Text>().text = OccupationTwoConfigCategory.Instance.Get(OccTwoID[0]).OccupationName;
            self.Text_ZhiYe_2.GetComponent<Text>().text = OccupationTwoConfigCategory.Instance.Get(OccTwoID[1]).OccupationName;
            self.Text_ZhiYe_3.GetComponent<Text>().text = OccupationTwoConfigCategory.Instance.Get(OccTwoID[2]).OccupationName;

            int occTwo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.OccTwo;
            List<int> occTwoList = new List<int>(OccTwoID);
            int index = occTwoList.IndexOf(occTwo);
            index = index < 0 ? 0 : index;
            self.OnButton_ZhiYe(index);

            self.Button_ZhiYe_1.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"OccTwo_{OccTwoID[0]}");
            self.Button_ZhiYe_2.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"OccTwo_{OccTwoID[1]}");
            self.Button_ZhiYe_3.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"OccTwo_{OccTwoID[2]}");

            self.Image_ZhiYe.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"Occ_{occ}");
        }

        public static void OnButton_ZhiYe(this UIOccTwoComponent self, int index)
        {
            UICommonHelper.SetParent(self.Button_ZhiYe_Select, self.Button_ZhiYe_List[index]);

            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(occ);
            self.OnSelectZhiYe(occupationConfig.OccTwoID[index]);
        }

        public static void OnSelectZhiYe(this UIOccTwoComponent self, int occTwoId)
        {
            self.OccTwoId = occTwoId;
            OccupationTwoConfig occupationTwoConfig = OccupationTwoConfigCategory.Instance.Get(occTwoId);
            self.Text_ZhiYe_4.GetComponent<Text>().text = occupationTwoConfig.OccupationName;
            UICommonHelper.DestoryChild( self.SkillContainer );

            self.Image_WuQi_Zhuan.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite( ABAtlasTypes.OtherIcon, $"HuJia_{occupationTwoConfig.ArmorMastery}" );
            self.Image_WuQi_Type.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"WuQi_{occupationTwoConfig.WeaponType}");

            self.Lab_HuJia.GetComponent<Text>().text = self.showType[occupationTwoConfig.ArmorMastery]+"专精";
            self.Lab_WuQi.GetComponent<Text>().text = self.showType[occupationTwoConfig.WeaponType] + "专精";

            self.Image_ZhiYe_4.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"OccTwo_{occupationTwoConfig.Id}");

            self.OccNengLi_1.transform.Find("Text_NengLiValue").GetComponent<Text>().text = occupationTwoConfig.Capacitys[0].ToString();
            self.OccNengLi_2.transform.Find("Text_NengLiValue").GetComponent<Text>().text = occupationTwoConfig.Capacitys[1].ToString();
            self.OccNengLi_3.transform.Find("Text_NengLiValue").GetComponent<Text>().text = occupationTwoConfig.Capacitys[2].ToString();

            self.OccNengLi_1.transform.Find("ImageProgress").GetComponent<Image>().fillAmount = occupationTwoConfig.Capacitys[0] * 1f / 100;
            self.OccNengLi_2.transform.Find("ImageProgress").GetComponent<Image>().fillAmount = occupationTwoConfig.Capacitys[1] * 1f / 100;
            self.OccNengLi_3.transform.Find("ImageProgress").GetComponent<Image>().fillAmount = occupationTwoConfig.Capacitys[2] * 1f / 100;

            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetSkillItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            int[] skills = occupationTwoConfig.ShowTalentSkill;
            for (int i = 0; i < skills.Length; i++)
            {
                GameObject skillItem = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(skillItem, self.SkillContainer);
                skillItem.SetActive(true);
                skillItem.transform.localScale = Vector3.one * 1f;

                UICommonSkillItemComponent ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>( skillItem);
                ui_item.OnUpdateUI(skills[i]);
            }
        }

        public static async ETTask OnButtonOccReset(this UIOccTwoComponent self)
        {
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(29);
            int needGold = int.Parse(globalValueConfig.Value);
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "技能点重置",
                $"是否花费{needGold}钻石重置技能点",
                () =>
                {
                    self.RequestReset(2).Coroutine();
                }).Coroutine();

            await ETTask.CompletedTask;
        }

        public static async ETTask RequestReset(this UIOccTwoComponent self, int operation)
        {
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(29);
            int needGold = int.Parse(globalValueConfig.Value);
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Diamond < needGold)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_DiamondNotEnoughError);
                return;
            }

            C2M_SkillOperation c2M_SkillSet = new C2M_SkillOperation() { OperationType = operation };
            M2C_SkillOperation m2C_SkillSet = (M2C_SkillOperation)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);
            if (m2C_SkillSet.Error != 0)
            {
                return;
            }
            self.ZoneScene().GetComponent<SkillSetComponent>().OnOccReset();
        }

        public static void OnClickOccTwoui(this UIOccTwoComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIOccTwo).Coroutine() ;
        }

        public static void InitSubItemView(this UIOccTwoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            int[] OccTwoID = OccupationConfigCategory.Instance.Get(occ).OccTwoID;

            for (int i = 0; i < OccTwoID.Length; i++)
            {
                GameObject taskTypeItem = rc.Get<GameObject>("UIOccTwoItem" + i.ToString());
                UI ui_1 = self.AddChild<UI, string, GameObject>( "UIOccTwoItem_" + i.ToString(), taskTypeItem);
                UIOccTwoItemComponent uIItemComponent = ui_1.AddComponent<UIOccTwoItemComponent>();
                uIItemComponent.SetOccTwoId(OccTwoID[i]).Coroutine();
            }
        }
    }
}
