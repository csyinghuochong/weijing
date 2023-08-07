using System;
using UnityEngine;

namespace ET
{
    public enum JueXingEnum : int
    {
        Show = 0,

        Number,
    }

    public class UIJueXingComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }

    public class UIJueXingComponentAwake : AwakeSystem<UIJueXingComponent>
    {

        public override void Awake(UIJueXingComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)JueXingEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)JueXingEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)JueXingEnum.Number];

            pageViewComponent.UISubViewPath[(int)JueXingEnum.Show] = ABPathHelper.GetUGUIPath("Main/JueXing/UIJueXingShow");
           
            pageViewComponent.UISubViewType[(int)JueXingEnum.Show] = typeof(UIJueXingShowComponent);
           
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });

            self.UIPageButtonComponent = uIPageButtonComponent;
            self.UIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UIJueXingComponentSystem
    {

        public static void OnClickPageButton(this UIJueXingComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}