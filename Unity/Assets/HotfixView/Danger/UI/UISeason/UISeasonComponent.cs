using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum SeasonPageEnum
    {
        Home = 0,
        Task = 1,
        JingHe = 2,
        Store = 3,
        Number,
    }

    public class UISeasonComponent: Entity, IAwake, IDestroy
    {
        public GameObject ImageButton;
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public UIPageViewComponent UIPageView;
    }

    public class UISeasonComponentAwakeSystem: AwakeSystem<UISeasonComponent>
    {
        public override void Awake(UISeasonComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();

            pageViewComponent.UISubViewList = new UI[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.Home] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonHome");
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.Task] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonTask");
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.JingHe] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonJingHe");
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.Store] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonStore");

            pageViewComponent.UISubViewType[(int)SeasonPageEnum.Home] = typeof (UISeasonHomeComponent);
            pageViewComponent.UISubViewType[(int)SeasonPageEnum.Task] = typeof (UISeasonTaskComponent);
            pageViewComponent.UISubViewType[(int)SeasonPageEnum.JingHe] = typeof (UISeasonJingHeComponent);
            pageViewComponent.UISubViewType[(int)SeasonPageEnum.Store] = typeof (UISeasonStoreComponent);
            self.UIPageView = pageViewComponent;

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChengJiu(); });

            self.SubViewNode = rc.Get<GameObject>("SubViewNode");
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiJoystick = self.AddChild<UI, string, GameObject>("FunctionBtnSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiJoystick.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);

            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));
        }
    }

    public static class UISeasonComponentSystem
    {
        public static void OnClickPageButton(this UISeasonComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void OnCloseChengJiu(this UISeasonComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UISeason);
        }
    }
}