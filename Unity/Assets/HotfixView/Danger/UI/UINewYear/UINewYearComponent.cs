using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public enum NewYearPageEnum : int
    {
        CollectionWord = 0,
        Number,
    }

    public class UINewYearComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }

    [ObjectSystem]
    public class UINewYearComponentAwake : AwakeSystem<UINewYearComponent>
    {
        public override void Awake(UINewYearComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)NewYearPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)NewYearPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)NewYearPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.CollectionWord] = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearCollectionWord");
           
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.CollectionWord] = typeof(UINewYearCollectionWordComponent);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageButtonComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });
            self.UIPageButtonComponent = uIPageButtonComponent;
            self.UIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UINewYearComponentAwakeSystem
    {
        public static void OnClickPageButton(this UINewYearComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
