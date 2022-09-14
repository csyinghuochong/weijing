using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLearnComponent : Entity, IAwake
    {
        public GameObject ButtonReset;
        public GameObject ButtonMax;
        public GameObject Text_LeftSp;
       
        public GameObject SkillListNode;
        public GameObject Obj_Text_ZhuanZhiHint;
        public GameObject Obj_Text_SkillTypeShow;

        public SkillPro SkillPro;
        public List<UI> SkillUIList = new List<UI>();
        public UIPageButtonComponent UIPageButton;
        public bool LinShiSkillStatus;
    }

    [ObjectSystem]
    public class UISkillLearnComponentAwakeSystem : AwakeSystem<UISkillLearnComponent>
    {
        public override void Awake(UISkillLearnComponent self)
        {
            self.SkillUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_LeftSp = rc.Get<GameObject>("Text_LeftSp");
            self.SkillListNode = rc.Get<GameObject>("SkillListNode");
            self.ButtonMax = rc.Get<GameObject>("ButtonMax");
            self.Obj_Text_ZhuanZhiHint = rc.Get<GameObject>("Text_ZhuanZhiHint");
            self.Obj_Text_SkillTypeShow = rc.Get<GameObject>("Text_SkillTypeShow");
            self.ButtonReset = rc.Get<GameObject>("ButtonReset");

            ButtonHelp.AddListenerEx( self.ButtonReset, () => {
                self.OnButtonReset(1).Coroutine();
            } );

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton = uIPageViewComponent;
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
            if (userInfoComponent.UserInfo.Diamond < needGold)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_DiamondNotEnoughError);
                return;
            }

            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "技能点重置",
                $"是否花费{needGold}钻石重置技能点",
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
                self.ZoneScene().GetComponent<SkillSetComponent>().OnSkillReset();
            }
            if (c2M_SkillSet.OperationType == 2)
            {
                self.ZoneScene().GetComponent<SkillSetComponent>().OnOccReset();
            }

            self.InitSkillList(self.UIPageButton.CurrentIndex).Coroutine();
        }

        public static void OnUpdateUI(this UISkillLearnComponent self)
        {
            self.UIPageButton.OnSelectIndex(0);
            self.UpdateLeftSp();
        }

        public static async ETTask InitSkillList(this UISkillLearnComponent self, int page)
        {
            self.SkillUIList.Clear();
            UICommonHelper.DestoryChild(self.SkillListNode);
            string path = ABPathHelper.GetUGUIPath("Main/Skill/UISkillLearnItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            List<SkillPro> skillPros = self.ZoneScene().GetComponent<SkillSetComponent>().SkillList;
            List<SkillPro> showSkillPros = new List<SkillPro>();
            showSkillPros.AddRange(skillPros);

            //临时增加显示
            int occTwo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.OccTwo;
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
                if (showSkillPros[i].SkillSetType == (int)SkillSetEnum.Item)
                {
                    continue;
                }

                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(showSkillPros[i].SkillID);
                if (skillConfig.IsShow == 1)
                {
                    continue;
                }
                //page ==0 主动 1被动
                if (skillConfig.SkillType == 1 && page != 0)
                {
                    continue;
                }
                if (skillConfig.SkillType != 1 && page == 0)
                {
                    continue;
                }

                //根据类型显示
                UI uI = null;
                if (number < self.SkillUIList.Count)
                {
                    uI = self.SkillUIList[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject skillItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(skillItem, self.SkillListNode);
                    uI = self.AddChild<UI, string, GameObject>( "skill_Item_" + i, skillItem);
                    UISkillLearnItemComponent uISkillSetItemComponent = uI.AddComponent<UISkillLearnItemComponent>();
                    uISkillSetItemComponent.SetClickHander((SkillPro skillpro) => { self.OnSelectSkill(skillpro); });
                    self.SkillUIList.Add(uI);
                }
                number++;
                uI.GetComponent<UISkillLearnItemComponent>().OnUpdateUI(showSkillPros[i]);
            }
            for (int i = number; i < self.SkillUIList.Count; i++)
            {
                self.SkillUIList[i].GameObject.SetActive(false);
            }

            //if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.OccTwo >= 0)
            //{
            //    self.Obj_Text_ZhuanZhiHint.SetActive(false);
            //}
            //else 
            //{
            //    self.Obj_Text_ZhuanZhiHint.SetActive(true);
            //}
            if (self.SkillUIList.Count > 0)
            {
                self.SkillUIList[0].GetComponent<UISkillLearnItemComponent>().OnImg_Button();
            }
        }

        public static void OnSelectSkill(this UISkillLearnComponent self, SkillPro skillPro)
        {
            self.SkillPro = skillPro;

            for (int i = 0; i < self.SkillUIList.Count; i++)
            {
                self.SkillUIList[i].GetComponent<UISkillLearnItemComponent>().OnSetSelected(skillPro.SkillID);
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

            UISkillLearnItemComponent uISkillSetItemComponent;
            for (int i = 0; i < self.SkillUIList.Count; i++)
            {
                uISkillSetItemComponent = self.SkillUIList[i].GetComponent<UISkillLearnItemComponent>();
                SkillPro sp = uISkillSetItemComponent.SkillPro;
                if (sp.SkillID == newSkill)
                {
                    uISkillSetItemComponent.OnUpdateUI(sp);
                }
            }

            self.UpdateLeftSp();
        }
    }
}
