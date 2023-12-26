using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum WelfarePageEnum
    {
        Login,
        Task,
        Draw,
        Invest,
        Draw2,

        Number
    }

    public class UIWelfareComponent: Entity, IAwake, IDestroy
    {
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIWelfareComponentAwake: AwakeSystem<UIWelfareComponent>
    {
        public override void Awake(UIWelfareComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)WelfarePageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)WelfarePageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)WelfarePageEnum.Number];

            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Login] = ABPathHelper.GetUGUIPath("Main/Activity/UIActivityLogin");
            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Task] = ABPathHelper.GetUGUIPath("Main/Welfare/UIWelfareTask");
            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Draw] = ABPathHelper.GetUGUIPath("Main/Welfare/UIWelfareDraw");
            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Invest] = ABPathHelper.GetUGUIPath("Main/Welfare/UIWelfareInvest");
            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Draw2] = ABPathHelper.GetUGUIPath("Main/Welfare/UIWelfareDraw2");

            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Login] = typeof(UIActivityLoginComponent);
            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Task] = typeof (UIWelfareTaskComponent);
            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Draw] = typeof (UIWelfareDrawComponent);
            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Invest] = typeof (UIWelfareInvestComponent);
            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Draw2] = typeof (UIWelfareDraw2Component);

            self.UIPageView = pageViewComponent;

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageViewComponent;

            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.RegisterReddot(ReddotType.WelfareLogin, self.Reddot_WelfareLogin);
            redPointComponent.RegisterReddot(ReddotType.WelfareTask, self.Reddot_WelfareTask);
            redPointComponent.RegisterReddot(ReddotType.WelfareDraw, self.Reddot_WelfareDraw);
        }
    }

    public class UIWelfareComponentDestroy : DestroySystem<UIWelfareComponent>
    {
        public override void Destroy(UIWelfareComponent self)
        {
            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.UnRegisterReddot(ReddotType.WelfareLogin, self.Reddot_WelfareLogin);
            redPointComponent.UnRegisterReddot(ReddotType.WelfareTask, self.Reddot_WelfareTask);
            redPointComponent.UnRegisterReddot(ReddotType.WelfareDraw, self.Reddot_WelfareDraw);
        }
    }
     
    public static class UIWelfareComponentSystem
    {

        public static void Reddot_WelfareLogin(this UIWelfareComponent self, int num)
        {
            self.UIPageButton.SetButtonReddot((int)WelfarePageEnum.Login, num > 0);
        }

        public static void Reddot_WelfareTask(this UIWelfareComponent self, int num)
        {
            self.UIPageButton.SetButtonReddot((int)WelfarePageEnum.Task, num > 0);
        }

        public static void Reddot_WelfareDraw(this UIWelfareComponent self, int num)
        {
            self.UIPageButton.SetButtonReddot((int)WelfarePageEnum.Draw, num > 0);
        }

        public static void OnClickPageButton(this UIWelfareComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}