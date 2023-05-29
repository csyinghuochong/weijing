using System;
using UnityEngine;


namespace ET
{
    public enum RoleXiLianPageEnum : int
	{
		RoleXiLianShow		= 0,
		RoleXiLianLevel		= 1,
		RoleXiLianSkill		= 2,
		RoleXiLianTransfer	= 3,
		RoleXiLianInherit	= 4,
		Number
	}

	public class UIRoleXiLianComponent : Entity, IAwake, IDestroy
	{
		public UI UIPageButton;
		public UIPageViewComponent UIPageView;
		public GameObject FunctionSetBtn;
	}


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

			pageViewComponent.UISubViewPath[(int)RoleXiLianPageEnum.RoleXiLianTransfer] = ABPathHelper.GetUGUIPath("Main/RoleXiLian/UIRoleXiLianTransfer");
			pageViewComponent.UISubViewType[(int)RoleXiLianPageEnum.RoleXiLianTransfer] = typeof(UIRoleXiLianTransferComponent);

			pageViewComponent.UISubViewPath[(int)RoleXiLianPageEnum.RoleXiLianInherit] = ABPathHelper.GetUGUIPath("Main/RoleXiLian/UIRoleXiLianInherit");
			pageViewComponent.UISubViewType[(int)RoleXiLianPageEnum.RoleXiLianInherit] = typeof(UIRoleXiLianInheritComponent);
			
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

			//IOS适配
			self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
			IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));
		}
	}


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

		public static void OnXiLianReturn(this UIRoleXiLianComponent self)
		{
			UI xilianshou = self.UIPageView.UISubViewList[(int)RoleXiLianPageEnum.RoleXiLianShow];
			xilianshou?.GetComponent<UIRoleXiLianShowComponent>().OnXiLianReturn();
		}
	}
}
