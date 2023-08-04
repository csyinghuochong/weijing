using System;
using UnityEngine;

namespace ET
{

    public enum FashionEnum : int
    {
        Show = 0,
        Suit = 1,

        Number,
    }

    public class UIFashionComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }

    public class UIFashionComponentAwake : AwakeSystem<UIFashionComponent>
    {

        public override void Awake(UIFashionComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)FashionEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)FashionEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)FashionEnum.Number];

            pageViewComponent.UISubViewPath[(int)FashionEnum.Show] = ABPathHelper.GetUGUIPath("Main/Fashion/UIFashionShow");
            pageViewComponent.UISubViewPath[(int)FashionEnum.Suit] = ABPathHelper.GetUGUIPath("Main/Fashion/UIFashionSuit");
       

            pageViewComponent.UISubViewType[(int)FashionEnum.Show] = typeof(UIFashionShowComponent);
            pageViewComponent.UISubViewType[(int)FashionEnum.Suit] = typeof(UIFashionSuitComponent);
            
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

    public static class UIFashionComponentSystem
    {

        public static void OnClickPageButton(this UIFashionComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}