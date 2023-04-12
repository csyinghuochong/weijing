using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	public enum JiaYuanDaEnum : int
	{
		Pro = 0,
        Show = 1,

        Number,
	}

	public class UIJiaYuanDaShiComponent : Entity, IAwake, IDestroy
	{
		public GameObject SubViewNode;
		public GameObject FunctionSetBtn;

		public UIPageViewComponent UIPageView;
		public UIPageButtonComponent UIPageButtonComponent;
	}


    public class UIJiaYuanDaShiComponentAwake : AwakeSystem<UIJiaYuanDaShiComponent>
    {
        public override void Awake(UIJiaYuanDaShiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionSetBtn", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)JiaYuanDaEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)JiaYuanDaEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)JiaYuanDaEnum.Number];

            pageViewComponent.UISubViewPath[(int)JiaYuanDaEnum.Pro] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanDaShiPro");
            pageViewComponent.UISubViewPath[(int)JiaYuanDaEnum.Show] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanDaShiShow");

            pageViewComponent.UISubViewType[(int)JiaYuanDaEnum.Pro] = typeof(UIJiaYuanDaShiProComponent);
            pageViewComponent.UISubViewType[(int)JiaYuanDaEnum.Show] = typeof(UIJiaYuanDaShiShowComponent);
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

    public static class UIJiaYuanDaShiComponentSystem
    {
        public static void OnClickPageButton(this UIJiaYuanDaShiComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
