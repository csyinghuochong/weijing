using System;
using UnityEngine;

namespace ET 
{
    public enum FenXiangPageEnum : int
    {
        Set = 0,
        FuLi = 1,

        Number,
    }

    public class UIFenXiangComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }

    [ObjectSystem]
    public class UIFenXiangComponentAwake : AwakeSystem<UIFenXiangComponent>
    {
        public override void Awake(UIFenXiangComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)FenXiangPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)FenXiangPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)FenXiangPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)FenXiangPageEnum.Set] = ABPathHelper.GetUGUIPath("Main/FenXiang/UIFenXiangSet");
         
            pageViewComponent.UISubViewType[(int)FenXiangPageEnum.Set] = typeof(UIFenXiangSetComponent);
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

    public static class UIFenXiangComponentSystem
    {
        public static void OnClickPageButton(this UIFenXiangComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
