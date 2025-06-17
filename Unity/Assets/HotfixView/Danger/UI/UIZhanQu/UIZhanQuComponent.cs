using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum ZhanQuPageEnum : int
    {
        Level = 0,
        Combat = 1,
		FirstWin = 2,

		Number ,
    }

    public class UIZhanQuComponent : Entity, IAwake, IDestroy
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
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
	}
	
	public class UIZhanQuComponentDestroySystem : DestroySystem<UIZhanQuComponent>
	{
		public override void Destroy(UIZhanQuComponent self)
		{
			DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
		}
	}

	public static class UIZhanQuComponentSystem
	{
		public static void OnLanguageUpdate(this UIZhanQuComponent self)
		{
			Transform tt = self.UIPageButton.GetParent<UI>().GameObject.transform;

			int childCount = tt.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform transform = tt.transform.GetChild(i);

				Transform XuanZhong = transform.Find("XuanZhong");
				if (XuanZhong)
				{
					RectTransform rt = XuanZhong.GetComponent<RectTransform>();
					Vector2 size = rt.sizeDelta;
					size.x = GameSettingLanguge.Language == 0? 100f : 200f;
					rt.sizeDelta = size;
                    
					Text text = XuanZhong.GetComponentInChildren<Text>();
					if (text)
					{
						text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
					}
				}

				Transform WeiXuanZhong = transform.Find("WeiXuanZhong");
				if (WeiXuanZhong)
				{
					RectTransform rt = WeiXuanZhong.GetComponent<RectTransform>();
					Vector2 size = rt.sizeDelta;
					size.x = GameSettingLanguge.Language == 0? 100f : 200f;
					rt.sizeDelta = size;
                    
					Text text = WeiXuanZhong.GetComponentInChildren<Text>();
					if (text)
					{
						text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
					}
				}
			}
		}
		
		public static void OnClickPageButton(this UIZhanQuComponent self, int page)
		{
			self.UIPageView.OnSelectIndex(page).Coroutine();
		}

        public static async ETTask OnClickGoToFirstWin(this UIZhanQuComponent self, int bossId)
        {
            self.UIPageButton.OnSelectIndex((int)ZhanQuPageEnum.FirstWin, false);
            UI ui=  await self.UIPageView.OnSelectIndex((int)ZhanQuPageEnum.FirstWin);
            ui.GetComponent<UIFirstWinComponent>().BossId = bossId;
        }
    }
}
