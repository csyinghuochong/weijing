using System;
using UnityEngine;


namespace ET
{
    public enum RoleXiLianPageEnum : int
	{
		RoleXiLianShow = 0,
		RoleXiLianLevel = 1,
		RoleXiLianSkill = 2,
		Number
	}

	public class UIRoleXiLianComponent : Entity, IAwake, IDestroy
	{
		public UI UIPageButton;
		public UIPageViewComponent UIPageView;
	}

	[ObjectSystem]
	public class UIRoleXiLianComponentAwakeSystem : AwakeSystem<UIRoleXiLianComponent>
	{
		public override void Awake(UIRoleXiLianComponent self)
		{
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

			GameObject pageView = rc.Get<GameObject>("SubViewNode");
			UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
			UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
			pageViewComponent.UISubViewList = new UI[(int)RoleXiLianPageEnum.Number];
			pageViewComponent.UISubViewPath = new string[(int)RoleXiLianPageEnum.Number];
			pageViewComponent.UISubViewType = new Type[(int)RoleXiLianPageEnum.Number];

			pageViewComponent.UISubViewPath[(int)RoleXiLianPageEnum.RoleXiLianShow] = ABPathHelper.GetUGUIPath("Main/RoleXiLian/UIRoleXiLianShow");
			pageViewComponent.UISubViewType[(int)RoleXiLianPageEnum.RoleXiLianShow] = typeof(UIRoleXiLianShowComponent);

			pageViewComponent.UISubViewPath[(int)RoleXiLianPageEnum.RoleXiLianLevel] = ABPathHelper.GetUGUIPath("Main/RoleXiLian/UIRoleXiLianLevel");
			pageViewComponent.UISubViewType[(int)RoleXiLianPageEnum.RoleXiLianLevel] = typeof(UIRoleXiLianLevelComponent);

			pageViewComponent.UISubViewPath[(int)RoleXiLianPageEnum.RoleXiLianSkill] = ABPathHelper.GetUGUIPath("Main/RoleXiLian/UIRoleXiLianSkill");
			pageViewComponent.UISubViewType[(int)RoleXiLianPageEnum.RoleXiLianSkill] = typeof(UIRoleXiLianSkillComponent);
			self.UIPageView = pageViewComponent;

			//单选组件
			GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
			UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
			UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
			uIPageViewComponent.SetClickHandler((int page) => {
				self.OnClickPageButton(page);
			});
			uIPageViewComponent.OnSelectIndex(0);
			self.UIPageButton = uiPage;
		}
	}

	[ObjectSystem]
	public class UIRoleXiLianComponentDestroySystem : DestroySystem<UIRoleXiLianComponent>
	{
		public override void Destroy(UIRoleXiLianComponent self)
		{
		}
	}

	public static class UIRoleXiLianComponentSystem
	{
		public static void OnClickPageButton(this UIRoleXiLianComponent self, int page)
		{
			self.UIPageView.OnSelectIndex(page).Coroutine();
		}
	}
}
