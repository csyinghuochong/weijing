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

        Number
    }

    public class UIWelfareComponent: Entity, IAwake
    {
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIWelfareComponentAwakesystem: AwakeSystem<UIWelfareComponent>
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

            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Login] = ABPathHelper.GetUGUIPath("Main/Welfare/UIWelfareLogin");
            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Task] = ABPathHelper.GetUGUIPath("Main/Welfare/UIWelfareTask");
            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Draw] = ABPathHelper.GetUGUIPath("Main/Welfare/UIWelfareDraw");
            pageViewComponent.UISubViewPath[(int)WelfarePageEnum.Invest] = ABPathHelper.GetUGUIPath("Main/Welfare/UIWelfareInvest");

            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Login] = typeof (UIWelfareLoginComponent);
            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Task] = typeof (UIWelfareTaskComponent);
            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Draw] = typeof (UIWelfareDrawComponent);
            pageViewComponent.UISubViewType[(int)WelfarePageEnum.Invest] = typeof (UIWelfareInvestComponent);

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
        }
    }

    public static class UIWelfareComponentSystem
    {
        public static void OnClickPageButton(this UIWelfareComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}