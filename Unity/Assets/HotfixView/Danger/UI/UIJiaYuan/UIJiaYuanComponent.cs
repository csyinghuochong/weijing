using System;
using UnityEngine;

namespace ET
{
    public enum JiaYuanPageEnum : int
    { 
        ZuoQi = 0,
        Number,
    }

    public class UIJiaYuanComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public UIPageButtonComponent UIPageButton;
        public UIPageViewComponent UIPageView;
    }

    [ObjectSystem]
    public class UIJiaYuanComponentAwake : AwakeSystem<UIJiaYuanComponent>
    {
        public override void Awake(UIJiaYuanComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)JiaYuanPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)JiaYuanPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)JiaYuanPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)JiaYuanPageEnum.ZuoQi] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanZuoQi");
            pageViewComponent.UISubViewType[(int)JiaYuanPageEnum.ZuoQi] = typeof(UIJiaYuanZuoQiComponent);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);
            self.UIPageButton = pageButton.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton.OnSelectIndex(0);
        }
    }

    public static class UIJiaYuanComponentSystem
    {
        public static void OnClickPageButton(this UIJiaYuanComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
