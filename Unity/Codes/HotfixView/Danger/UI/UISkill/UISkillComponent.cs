using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public enum SkillPageEnum : int
    {
        SkillLearn = 0,
        SkillSet = 1,
        SkillMake = 2,

        Number,
        //SkillTianFu
    }

    public class UISkillComponent : Entity, IAwake, IDestroy
    {
        public GameObject Btn_CloseUI;

        public UIPageViewComponent UIPageView;
        public UI uIPageView;
    }

    [ObjectSystem]
    public class UISkillComponentAwakeSystem : AwakeSystem<UISkillComponent>
    {
        public override void Awake(UISkillComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();

            pageViewComponent.UISubViewList = new UI[(int)SkillPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)SkillPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)SkillPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)SkillPageEnum.SkillLearn] = ABPathHelper.GetUGUIPath("Main/Skill/UISkillLearn");
            pageViewComponent.UISubViewPath[(int)SkillPageEnum.SkillSet] = ABPathHelper.GetUGUIPath("Main/Skill/UISkillSet");
            pageViewComponent.UISubViewPath[(int)SkillPageEnum.SkillMake] = ABPathHelper.GetUGUIPath("Main/Skill/UISkillMake");

            pageViewComponent.UISubViewType[(int)SkillPageEnum.SkillLearn] = typeof(UISkillLearnComponent);
            pageViewComponent.UISubViewType[(int)SkillPageEnum.SkillSet] = typeof(UISkillSetComponent);
            pageViewComponent.UISubViewType[(int)SkillPageEnum.SkillMake] = typeof(UISkillMakeComponent);

            self.UIPageView = pageViewComponent;
            self.Btn_CloseUI = rc.Get<GameObject>("Btn_CloseUI");
            self.Btn_CloseUI.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseSkillSet(); });

            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiJoystick = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", BtnItemTypeSet);
            self.uIPageView = uiJoystick;
            UIPageButtonComponent uIPageViewComponent = uiJoystick.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);

            DataUpdateComponent.Instance.AddListener(DataType.SkillSetting, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillUpgrade, self);
            DataUpdateComponent.Instance.AddListener(DataType.OnActiveTianFu, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillReset, self);
        }
    }

    [ObjectSystem]
    public class UISkillComponentDestroySystem : DestroySystem<UISkillComponent>
    {
        public override void Destroy(UISkillComponent self)
        {

            DataUpdateComponent.Instance.RemoveListener(DataType.SkillSetting, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillUpgrade, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.OnActiveTianFu, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillReset, self);
        }
    }


    public static class UISkillComponentSystem
    {

        public static void OnActiveTianFu(this UISkillComponent self)
        {
            //self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillTianFu].GetComponent<UISkillTianFuComponent>().OnActiveTianFu();
        }

        public static void OnSkillReset(this UISkillComponent self)
        {
            self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillLearn].GetComponent<UISkillLearnComponent>().UpdateLeftSp();
        }

        public static void OnSkillUpgrade(this UISkillComponent self, string DataParams)
        {
            self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillLearn].GetComponent<UISkillLearnComponent>().OnSkillUpgrade(DataParams);
        }

        public static void OnSkillSetUpdate(this UISkillComponent self)
        {
            self.UIPageView.UISubViewList[(int)SkillPageEnum.SkillSet].GetComponent<UISkillSetComponent>().OnSkillSetting();
        }

        public static void OnCloseSkillSet(this UISkillComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UISkill).Coroutine();
        }

        public static void OnClickPageButton(this UISkillComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
