using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLearnComponent : Entity, IAwake,IDestroy
    {
        public GameObject SkillInfoPanel;
        public GameObject SkillInfoconImg;
        public GameObject SkillInfoNameText;
        public GameObject NowText;
        public GameObject NextText;
        public GameObject ConsumeText;
        public GameObject SkillInfoLearnBtn;
        public GameObject ScrollView_1_2;
        public GameObject ScrollView_3;
        public GameObject SkillItemListNode;
        public GameObject UISkillLearnSkillItem;
        public GameObject ButtonReset;
        public GameObject ButtonMax;
        public GameObject Text_LeftSp;
       
        public GameObject SkillListNode;
        public GameObject UISkillLearnItem;
        public GameObject Obj_Text_ZhuanZhiHint;
        public GameObject Obj_Text_SkillTypeShow;

        public SkillPro SkillPro;
        public List<UISkillLearnItemComponent> SkillUIList = new List<UISkillLearnItemComponent>();
        public List<UISkillLearnSkillItemComponent> SkillLearnSkillItemComponents = new List<UISkillLearnSkillItemComponent>();
        public UIPageButtonComponent UIPageButton;
        public bool LinShiSkillStatus;
        public List<string> AssetPath = new List<string>();
    }


    public class UISkillLearnComponentAwakeSystem : AwakeSystem<UISkillLearnComponent>
    {
        public override void Awake(UISkillLearnComponent self)
        {
            self.SkillUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.SkillInfoPanel = rc.Get<GameObject>("SkillInfoPanel");
            self.SkillInfoconImg = rc.Get<GameObject>("SkillInfoconImg");
            self.SkillInfoNameText = rc.Get<GameObject>("SkillInfoNameText");
            self.NowText = rc.Get<GameObject>("NowText");
            self.NextText = rc.Get<GameObject>("NextText");
            self.ConsumeText = rc.Get<GameObject>("ConsumeText");
            self.SkillInfoLearnBtn = rc.Get<GameObject>("SkillInfoLearnBtn");
            self.ScrollView_1_2 = rc.Get<GameObject>("ScrollView_1_2");
            self.ScrollView_3 = rc.Get<GameObject>("ScrollView_3");
            self.SkillItemListNode = rc.Get<GameObject>("SkillItemListNode");
            self.UISkillLearnSkillItem = rc.Get<GameObject>("UISkillLearnSkillItem");
            self.UISkillLearnSkillItem.SetActive(false);
            
            self.Text_LeftSp = rc.Get<GameObject>("Text_LeftSp");
            self.SkillListNode = rc.Get<GameObject>("SkillListNode");
            self.UISkillLearnItem = rc.Get<GameObject>("UISkillLearnItem");
            self.UISkillLearnItem.SetActive(false);
            self.ButtonMax = rc.Get<GameObject>("ButtonMax");
            self.Obj_Text_ZhuanZhiHint = rc.Get<GameObject>("Text_ZhuanZhiHint");
            self.Obj_Text_SkillTypeShow = rc.Get<GameObject>("Text_SkillTypeShow");
            self.ButtonReset = rc.Get<GameObject>("ButtonReset");
            
            self.SkillInfoPanel.SetActive(false);
            self.ScrollView_3.SetActive(false);

            self.SkillInfoLearnBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnSkillInfoLearnBtn();});
            ButtonHelp.AddListenerEx( self.ButtonReset, () => {
                self.OnButtonReset(1).Coroutine();
            } );

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton = uIPageViewComponent;

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
        }
    }
    public class UISkillLearnComponentDestroy: DestroySystem<UISkillLearnComponent>
    {
        public override void Destroy(UISkillLearnComponent self)
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
    public static class UISkillLearnComponentSystem
    {
        public static void OnClickPageButton(this UISkillLearnComponent self,  int page)
        {
            self.InitSkillList(page).Coroutine();
        }

        public static async ETTask OnButtonReset(this UISkillLearnComponent self, int operation)
        {
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(20);
            int needGold = int.Parse(globalValueConfig.Value);
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Gold < needGold)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_GoldNotEnoughError);
                return;
            }

            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "技能点重置",
                $"是否花费{needGold}金币重置技能点",
                () =>
                {
                    self.RequestReset(operation).Coroutine();
                }).Coroutine();

            await ETTask.CompletedTask;
        }

        public static async ETTask  RequestReset(this UISkillLearnComponent self, int operation)
        {
            C2M_SkillOperation c2M_SkillSet = new C2M_SkillOperation() { OperationType = operation };
            M2C_SkillOperation m2C_SkillSet = (M2C_SkillOperation)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);
            if (m2C_SkillSet.Error != 0)
            {
                return;
            }
            if (c2M_SkillSet.OperationType == 1)
            {
                HintHelp.GetInstance().DataUpdate(DataType.SkillReset);
            }
            if (c2M_SkillSet.OperationType == 2)
            {
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>(); 
                userInfoComponent.UserInfo.OccTwo = 0;
                HintHelp.GetInstance().DataUpdate(DataType.SkillReset);
            }

            self.InitSkillList(self.UIPageButton.CurrentIndex).Coroutine();
        }

        public static void OnUpdateUI(this UISkillLearnComponent self)
        {
            self.UIPageButton.OnSelectIndex(0);
            self.UpdateLeftSp();
        }

        public static bool IsZhuDongSkill(this UISkillLearnComponent self, int skilltype)
        {
            return skilltype == 1 || skilltype == 6;
        }

        public static async ETTask InitSkillList(this UISkillLearnComponent self, int page)
        {
            if (page <= 1) // 主动、被动
            {
                self.SkillInfoPanel.SetActive(false);
                self.ScrollView_3.SetActive(false);
                self.ScrollView_1_2.SetActive(true);
                
                self.SkillUIList.Clear();
                UICommonHelper.DestoryChild(self.SkillListNode);
                
                List<SkillPro> skillPros = self.ZoneScene().GetComponent<SkillSetComponent>().SkillList;
                List<SkillPro> showSkillPros = new List<SkillPro>();
                showSkillPros.AddRange(skillPros);

                //临时增加显示
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                int occ = userInfoComponent.UserInfo.Occ;
                int occTwo = userInfoComponent.UserInfo.OccTwo;
                if (occTwo != 0 && self.LinShiSkillStatus == false)
                {
                    OccupationTwoConfig occTwoCof = OccupationTwoConfigCategory.Instance.Get(occTwo);
                    for (int i = 0; i < occTwoCof.ShowPassiveSkill.Length; i++)
                    {
                        SkillPro pro = new SkillPro();
                        pro.SkillID = occTwoCof.ShowPassiveSkill[i];
                        showSkillPros.Add(pro);
                    }

                    self.LinShiSkillStatus = true;
                }

                int number = 0;
                for (int i = 0; i < showSkillPros.Count; i++)
                {

                    SkillPro skillPro = showSkillPros[i];
                    if (skillPro.SkillSetType == (int)SkillSetEnum.Item)
                    {
                        continue;
                    }

                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillPro.SkillID);
                    if (skillConfig.IsShow == 1)
                    {
                        continue;
                    }

                    //page ==0 主动 1被动
                    if (page == 0 && !self.IsZhuDongSkill(skillConfig.SkillType))
                    {
                        continue;
                    }

                    if (page == 1 && self.IsZhuDongSkill(skillConfig.SkillType))
                    {
                        continue;
                    }

                    //屏蔽强化技能
                    if (SkillHelp.IsQiangHuaSkill(occ, skillPro.SkillID))
                    {
                        continue;
                    }

                    //根据类型显示
                    UISkillLearnItemComponent uI = null;
                    if (number < self.SkillUIList.Count)
                    {
                        uI = self.SkillUIList[number];
                        uI.GameObject.SetActive(true);
                    }
                    else
                    {
                        GameObject skillItem = GameObject.Instantiate(self.UISkillLearnItem);
                        skillItem.SetActive(true);
                        UICommonHelper.SetParent(skillItem, self.SkillListNode);
                        uI = self.AddChild<UISkillLearnItemComponent, GameObject>(skillItem);
                        uI.SetClickHander((SkillPro skillpro) => { self.OnSelectSkill(skillpro); });
                        self.SkillUIList.Add(uI);
                    }

                    number++;
                    uI.OnUpdateUI(showSkillPros[i]);
                }

                for (int i = number; i < self.SkillUIList.Count; i++)
                {
                    self.SkillUIList[i].GameObject.SetActive(false);
                }

                if (self.SkillUIList.Count > 0)
                {
                    self.SkillUIList[0].OnImg_Button();
                }
            }
            else if (page == 2) // 强化
            {
                self.ScrollView_1_2.SetActive(false);
                self.ScrollView_3.SetActive(true);
                self.SkillInfoPanel.SetActive(true);

                self.SkillLearnSkillItemComponents.Clear();
                UICommonHelper.DestoryChild(self.SkillItemListNode);
                List<SkillPro> skillPros = self.ZoneScene().GetComponent<SkillSetComponent>().SkillList;
                List<SkillPro> showSkillPros = new List<SkillPro>();
                showSkillPros.AddRange(skillPros);

                //临时增加显示
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                int occ = userInfoComponent.UserInfo.Occ;
                int occTwo = userInfoComponent.UserInfo.OccTwo;
                if (occTwo != 0 && self.LinShiSkillStatus == false)
                {
                    OccupationTwoConfig occTwoCof = OccupationTwoConfigCategory.Instance.Get(occTwo);
                    for (int i = 0; i < occTwoCof.ShowPassiveSkill.Length; i++)
                    {
                        SkillPro pro = new SkillPro();
                        pro.SkillID = occTwoCof.ShowPassiveSkill[i];
                        showSkillPros.Add(pro);
                    }

                    self.LinShiSkillStatus = true;
                }

                int number = 0;
                for (int i = 0; i < showSkillPros.Count; i++)
                {

                    SkillPro skillPro = showSkillPros[i];
                    if (skillPro.SkillSetType == (int)SkillSetEnum.Item)
                    {
                        continue;
                    }

                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillPro.SkillID);
                    // if (skillConfig.IsShow == 1)
                    // {
                    //     continue;
                    // }

                    //page ==0 主动 1被动
                    if (page == 0 && !self.IsZhuDongSkill(skillConfig.SkillType))
                    {
                        continue;
                    }

                    if (page == 1 && self.IsZhuDongSkill(skillConfig.SkillType))
                    {
                        continue;
                    }

                    //强化技能
                    if (page == 2 && !SkillHelp.IsQiangHuaSkill(occ, skillPro.SkillID))
                    {
                        continue;
                    }

                    //根据类型显示
                    UISkillLearnSkillItemComponent uI = null;
                    if (number < self.SkillLearnSkillItemComponents.Count)
                    {
                        uI = self.SkillLearnSkillItemComponents[number];
                        uI.GameObject.SetActive(true);
                    }
                    else
                    {
                        GameObject skillItem = GameObject.Instantiate(self.UISkillLearnSkillItem);
                        skillItem.SetActive(true);
                        UICommonHelper.SetParent(skillItem, self.SkillItemListNode);
                        uI = self.AddChild<UISkillLearnSkillItemComponent, GameObject>(skillItem);
                        uI.SetClickHander((skillpro) => { self.OnUpdateSkillInfoPanel(skillpro); });
                        self.SkillLearnSkillItemComponents.Add(uI);
                    }

                    number++;
                    uI.OnUpdateUI(showSkillPros[i]);
                }

                for (int i = number; i < self.SkillLearnSkillItemComponents.Count; i++)
                {
                    self.SkillLearnSkillItemComponents[i].GameObject.SetActive(false);
                }

                if (self.SkillLearnSkillItemComponents.Count > 0)
                {
                    self.SkillLearnSkillItemComponents[0].OnImg_Button();
                }
            }

            await TimerComponent.Instance.WaitFrameAsync();
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.OpenUI, UIType.UISkill);
        }

        /// <summary>
        /// 更新技能面板信息
        /// </summary>
        /// <param name="self"></param>
        /// <param name="skillPro"></param>
        public static void OnUpdateSkillInfoPanel(this UISkillLearnComponent self, SkillPro skillPro)
        {
            foreach (UISkillLearnSkillItemComponent itemComponent in self.SkillLearnSkillItemComponents)
            {
                if (itemComponent.SkillPro == skillPro)
                {
                    itemComponent.BorderImg.SetActive(true);
                }
                else
                {
                    itemComponent.BorderImg.SetActive(false);
                }
            }
            self.SkillPro = skillPro;
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillPro.SkillID);

            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }

            self.SkillInfoNameText.GetComponent<Text>().text = skillConfig.SkillName;
            self.SkillInfoconImg.GetComponent<Image>().sprite = sp;

            self.NowText.GetComponent<Text>().text = skillConfig.SkillDescribe;
            if (skillConfig.NextSkillID != 0)
            {
                SkillConfig skillNextConfig = SkillConfigCategory.Instance.Get(skillConfig.NextSkillID);
                self.NextText.GetComponent<Text>().text = skillNextConfig.SkillDescribe;
                self.ConsumeText.GetComponent<Text>().text = $"消耗技能点:{skillConfig.CostSPValue}";
            }
            else
            {
                self.NextText.GetComponent<Text>().text = "";
                self.ConsumeText.GetComponent<Text>().text = $"达到最大级";
            }
        }

        /// <summary>
        /// 升级强化技能
        /// </summary>
        /// <param name="self"></param>
        public static void OnSkillInfoLearnBtn(this UISkillLearnComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(self.SkillPro.SkillID);
            
            int playerLv = userInfo.Lv;
            if (userInfo.Sp < skillConfig.CostSPValue)
            {
                FloatTipManager.Instance.ShowFloatTip("技能点不足！!");
                return;
            }
            if (playerLv < skillConfig.LearnRoseLv)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！!");
                return;
            }
            if (skillConfig.NextSkillID == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已满级！!");
                return;
            }
            self.ZoneScene().GetComponent<SkillSetComponent>().ActiveSkillID(self.SkillPro.SkillID).Coroutine();
        }
        
        public static void OnSelectSkill(this UISkillLearnComponent self, SkillPro skillPro)
        {
            self.SkillPro = skillPro;

            for (int i = 0; i < self.SkillUIList.Count; i++)
            {
                self.SkillUIList[i].OnSetSelected(skillPro.SkillID);
            }
        }

        public static void UpdateLeftSp(this UISkillLearnComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            self.Text_LeftSp.GetComponent<Text>().text = $"剩余技能点: {userInfo.Sp}";
        }

        public static void OnSkillUpgrade(this UISkillLearnComponent self, string dataparams)
        {
            ////只刷新对应的技能
            string[] sArray = dataparams.Split('_');
            int newSkill = int.Parse(sArray[1]);

            for (int i = 0; i < self.SkillUIList.Count; i++)
            {
                UISkillLearnItemComponent uISkillSetItemComponent = self.SkillUIList[i];
                SkillPro sp = uISkillSetItemComponent.SkillPro;
                if (sp.SkillID == newSkill)
                {
                    uISkillSetItemComponent.OnUpdateUI(sp);
                }

                uISkillSetItemComponent.ShowReddot();
            }

            for (int i = 0; i < self.SkillLearnSkillItemComponents.Count; i++)
            {
                UISkillLearnSkillItemComponent uiSkillLearnSkillItemComponent = self.SkillLearnSkillItemComponents[i];
                SkillPro sp = uiSkillLearnSkillItemComponent.SkillPro;
                if (sp.SkillID == newSkill)
                {
                    uiSkillLearnSkillItemComponent.OnUpdateUI(sp);
                    uiSkillLearnSkillItemComponent.OnImg_Button();
                }
            }

            self.UpdateLeftSp();
        }
    }
}
