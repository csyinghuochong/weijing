using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public enum SkillPageEnum : int
    {
        SkillLearn = 0,
        SkillSet = 1,
        SkillTianFu = 2,
        SkillMake = 3,
        SkillLifeShield = 4,

        Number,
    }

    public class UISkillComponent : Entity, IAwake, IDestroy
    {
        public GameObject Btn_Life;
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }


    public class UISkillComponentAwakeSystem : AwakeSystem<UISkillComponent>
    {
        public override void Awake(UISkillComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");

            self.Btn_Life = rc.Get<GameObject>("Btn_Life");
            self.Btn_Life.SetActive(true);
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            UI uiPageView = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();

            pageViewComponent.UISubViewList = new UI[(int)SkillPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)SkillPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)SkillPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)SkillPageEnum.SkillLearn] = ABPathHelper.GetUGUIPath("Main/Skill/UISkillLearn");
            pageViewComponent.UISubViewPath[(int)SkillPageEnum.SkillSet] = ABPathHelper.GetUGUIPath("Main/Skill/UISkillSet");
            pageViewComponent.UISubViewPath[(int)SkillPageEnum.SkillMake] = ABPathHelper.GetUGUIPath("Main/Skill/UISkillMake");
            pageViewComponent.UISubViewPath[(int)SkillPageEnum.SkillTianFu] = ABPathHelper.GetUGUIPath("Main/Skill/UISkillTianFu");
            pageViewComponent.UISubViewPath[(int)SkillPageEnum.SkillLifeShield] = ABPathHelper.GetUGUIPath("Main/Skill/UISkillLifeShield");
            
            pageViewComponent.UISubViewType[(int)SkillPageEnum.SkillLearn] = typeof(UISkillLearnComponent);
            pageViewComponent.UISubViewType[(int)SkillPageEnum.SkillSet] = typeof(UISkillSetComponent);
            pageViewComponent.UISubViewType[(int)SkillPageEnum.SkillMake] = typeof(UISkillMakeComponent);
            pageViewComponent.UISubViewType[(int)SkillPageEnum.SkillTianFu] = typeof(UISkillTianFuComponent);
            pageViewComponent.UISubViewType[(int)SkillPageEnum.SkillLifeShield] = typeof(UISkillLifeShieldComponent);

            self.UIPageView = pageViewComponent;

            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiJoystick = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiJoystick.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageViewComponent;    

            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));

            DataUpdateComponent.Instance.AddListener(DataType.SkillSetting, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillUpgrade, self);
            DataUpdateComponent.Instance.AddListener(DataType.OnActiveTianFu, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillReset, self);

            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.RegisterReddot(ReddotType.SkillUp, self.Reddot_SkillUp);
            self.GetParent<UI>().OnShowUI = () => 
            {
                self.OnShowUI().Coroutine();
            };
        }
    }


    public class UISkillComponentDestroySystem : DestroySystem<UISkillComponent>
    {
        public override void Destroy(UISkillComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillSetting, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillUpgrade, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.OnActiveTianFu, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillReset, self);

            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent?.UnRegisterReddot(ReddotType.SkillUp, self.Reddot_SkillUp);
        }
    }

    public static class UISkillComponentSystem
    {

        public static async ETTask OnShowUI(this UISkillComponent self)
        {
            await TimerComponent.Instance.WaitAsync(500);
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.OpenUI, UIType.UISkill);
        }


        public static void Reddot_SkillUp(this UISkillComponent self, int num)
        {
            self.UIPageButton.SetButtonReddot((int)SkillPageEnum.SkillLearn, num > 0);
        }

        public static void OnActiveTianFu(this UISkillComponent self)
        {
            self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillTianFu].GetComponent<UISkillTianFuComponent>().OnActiveTianFu();
        }

        public static void OnSkillReset(this UISkillComponent self)
        {
            self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillLearn].GetComponent<UISkillLearnComponent>().UpdateLeftSp();
        }

        public static void OnSkillUpgrade(this UISkillComponent self, string DataParams)
        {
            self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillLearn].GetComponent<UISkillLearnComponent>().OnSkillUpgrade(DataParams);
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.SkillUp, "0");
        }

        public static void OnSkillSetUpdate(this UISkillComponent self)
        {
            UI uI_1 = self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillLearn];
            if (uI_1!=null)
            {
                uI_1.GetComponent<UISkillLearnComponent>().InitSkillList(0).Coroutine();
            }
            UI uI_2 = self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillSet];
            if (uI_2 != null)
            {
                uI_2.GetComponent<UISkillSetComponent>().OnSkillSetting();
            }
        }

        public static void OnCloseSkillSet(this UISkillComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UISkill);
        }

        public static void OnClickPageButton(this UISkillComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
