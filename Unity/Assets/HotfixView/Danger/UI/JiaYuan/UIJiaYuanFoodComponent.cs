using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
	public enum JiaYuanFoodEnum : int
	{
		Purchase = 0,
		Cooking = 1,
		Cookbook = 2,
		Number,
	}

	public class UIJiaYuanFoodComponent : Entity, IAwake
	{
		public GameObject SubViewNode;
		public GameObject FunctionSetBtn;

		public UIPageButtonComponent UIPageButton;
		public UIPageViewComponent UIPageView;
	}


	public class UIJiaYuanFoodComponentAwake : AwakeSystem<UIJiaYuanFoodComponent>
	{
		public override void Awake(UIJiaYuanFoodComponent self)
		{
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)JiaYuanFoodEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)JiaYuanFoodEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)JiaYuanFoodEnum.Number];

            pageViewComponent.UISubViewPath[(int)JiaYuanFoodEnum.Purchase] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPurchase");
            pageViewComponent.UISubViewPath[(int)JiaYuanFoodEnum.Cooking] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanCooking");
            pageViewComponent.UISubViewPath[(int)JiaYuanFoodEnum.Cookbook] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanCookbook");
           
            pageViewComponent.UISubViewType[(int)JiaYuanFoodEnum.Purchase] = typeof(UIJiaYuanPurchaseComponent);
            pageViewComponent.UISubViewType[(int)JiaYuanFoodEnum.Cooking] = typeof(UIJiaYuanCookingComponent);
            pageViewComponent.UISubViewType[(int)JiaYuanFoodEnum.Cookbook] = typeof(UIJiaYuanCookbookComponent);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            self.UIPageButton = pageButton.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton.OnSelectIndex(0);

        }
    }

    public static class UIJiaYuanFoodComponentSystem
    {
        public static void OnClickPageButton(this UIJiaYuanFoodComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}