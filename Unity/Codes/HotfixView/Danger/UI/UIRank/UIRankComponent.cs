using System;
using UnityEngine;

namespace ET
{

    public enum RankPageEnum : int
    { 
        RankShow = 0,
        RankReward = 1,
        RankNum = 2,
    }

    public class UIRankComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public UI UIPageButton;
        public UIPageViewComponent UIPageView;
    }


    [ObjectSystem]
    public class UIRankComponentAwakeSystem : AwakeSystem<UIRankComponent>
    {
        public override void Awake(UIRankComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)RankPageEnum.RankNum];
            pageViewComponent.UISubViewPath = new string[(int)RankPageEnum.RankNum];
            pageViewComponent.UISubViewType = new Type[(int)RankPageEnum.RankNum];
            pageViewComponent.UISubViewPath[(int)RankPageEnum.RankShow] = ABPathHelper.GetUGUIPath("Main/Rank/UIRankShow");
            pageViewComponent.UISubViewPath[(int)RankPageEnum.RankReward] = ABPathHelper.GetUGUIPath("Main/Rank/UIRankReward");
            pageViewComponent.UISubViewType[(int)RankPageEnum.RankShow] = typeof(UIRankShowComponent);
            pageViewComponent.UISubViewType[(int)RankPageEnum.RankReward] = typeof(UIRankRewardComponent);
            self.UIPageView = pageViewComponent;

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            self.UIPageButton = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = self.UIPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UIRankComponentSystem
    {
        public static void OnClickPageButton(this UIRankComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }

}
