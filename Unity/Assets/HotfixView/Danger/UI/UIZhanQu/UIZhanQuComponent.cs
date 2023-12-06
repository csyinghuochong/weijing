using System;
using UnityEngine;

namespace ET
{
    public enum ZhanQuPageEnum : int
    {
        Level = 0,
        Combat = 1,
		FirstWin = 2,

		Number ,
    }

    public class UIZhanQuComponent : Entity, IAwake
	{
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;

        public ActivityComponent ActivityComponent;
    }


	public class UIZhanQuComponentAwakeSystem : AwakeSystem<UIZhanQuComponent>
	{
		public override void Awake(UIZhanQuComponent self)
		{
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

			GameObject pageView = rc.Get<GameObject>("SubViewNode");
			UI uiPageView = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", pageView);

			UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
			pageViewComponent.UISubViewList = new UI[(int)ZhanQuPageEnum.Number];
			pageViewComponent.UISubViewPath = new string[(int)ZhanQuPageEnum.Number];
			pageViewComponent.UISubViewType = new Type[(int)ZhanQuPageEnum.Number];

			pageViewComponent.UISubViewPath[(int)ZhanQuPageEnum.Level] = ABPathHelper.GetUGUIPath("Main/ZhanQu/UIZhanQuLevel");
			pageViewComponent.UISubViewPath[(int)ZhanQuPageEnum.Combat] = ABPathHelper.GetUGUIPath("Main/ZhanQu/UIZhanQuCombat");
			pageViewComponent.UISubViewPath[(int)ZhanQuPageEnum.FirstWin] = ABPathHelper.GetUGUIPath("Main/ZhanQu/UIFirstWin");

			pageViewComponent.UISubViewType[(int)ZhanQuPageEnum.Level] = typeof(UIZhanQuLevelComponent);
			pageViewComponent.UISubViewType[(int)ZhanQuPageEnum.Combat] = typeof(UIZhanQuCombatComponent);
			pageViewComponent.UISubViewType[(int)ZhanQuPageEnum.FirstWin] = typeof(UIFirstWinComponent);

			self.UIPageView = pageViewComponent;

			//单选组件
			GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
			UI uiPage = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", BtnItemTypeSet);
			//IOS适配
			IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));
			UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
			uIPageViewComponent.SetClickHandler((int page) => {
				self.OnClickPageButton(page);
			});

			self.UIPageButton = uIPageViewComponent;
			self.ActivityComponent = self.ZoneScene().GetComponent<ActivityComponent>();

            self.UIPageButton.OnSelectIndex(0);
        }
	}

	public static class UIZhanQuComponentSystem
	{
		public static void OnClickPageButton(this UIZhanQuComponent self, int page)
		{
			self.UIPageView.OnSelectIndex(page).Coroutine();
		}

        public static void  OnClickGoToFirstWin(this UIZhanQuComponent self, int bossId)
        {
            self.UIPageButton.OnSelectIndex((int)ZhanQuPageEnum.FirstWin, false);
            self.UIPageView.OnSelectIndex((int)ZhanQuPageEnum.FirstWin).Coroutine();
        }
    }
}
