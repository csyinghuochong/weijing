using System;
using UnityEngine;

namespace ET
{
    public enum CampPageEnum : int
    {
        Strength = 0,
        Reward = 1,
        Select = 2,
        ShouLie = 3,
        FuLi = 4,
        Shop = 5,

        Number,
    }

    public class UICampComponent : Entity, IAwake
    {
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    [ObjectSystem]
    public class UIZhenYingComponentAwakeSystem : AwakeSystem<UICampComponent>
    {
        public override void Awake(UICampComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)CampPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)CampPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)CampPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)CampPageEnum.Strength] = ABPathHelper.GetUGUIPath("Main/Camp/UICampStrength");
            pageViewComponent.UISubViewPath[(int)CampPageEnum.Reward] = ABPathHelper.GetUGUIPath("Main/Camp/UICampReward");
            pageViewComponent.UISubViewPath[(int)CampPageEnum.Select] = ABPathHelper.GetUGUIPath("Main/Camp/UICampSelect");
            pageViewComponent.UISubViewPath[(int)CampPageEnum.ShouLie] = ABPathHelper.GetUGUIPath("Main/Camp/UICampShouLie");
            pageViewComponent.UISubViewPath[(int)CampPageEnum.FuLi] = ABPathHelper.GetUGUIPath("Main/Camp/UICampFuLi");
            pageViewComponent.UISubViewPath[(int)CampPageEnum.Shop] = ABPathHelper.GetUGUIPath("Main/Camp/UICampShop");

            pageViewComponent.UISubViewType[(int)CampPageEnum.Strength] = typeof(UICampStrengthComponent);
            pageViewComponent.UISubViewType[(int)CampPageEnum.Reward] = typeof(UICampRewardComponent);
            pageViewComponent.UISubViewType[(int)CampPageEnum.Select] = typeof(UICampSelectComponent);
            pageViewComponent.UISubViewType[(int)CampPageEnum.ShouLie] = typeof(UICampShouLieComponent);
            pageViewComponent.UISubViewType[(int)CampPageEnum.FuLi] = typeof(UICampFuLiComponent);
            pageViewComponent.UISubViewType[(int)CampPageEnum.Shop] = typeof(UICampShopComponent);
            self.UIPageView = pageViewComponent;

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageViewComponent;
        }
    }

    public static class UIZhenYingComponentSystem
    {

        public static void OnClickPageButton(this UICampComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
