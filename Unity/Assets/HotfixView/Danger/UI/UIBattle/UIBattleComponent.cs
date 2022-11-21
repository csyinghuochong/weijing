using System;
using UnityEngine;

namespace ET
{
    public enum BattlePageEnum : int
    {
        Enter = 0,
        Task = 1,
        Shop = 2,

        Number,
    }

    public class UIBattleComponent : Entity, IAwake, IDestroy
    {
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    [ObjectSystem]
    public class UIBattleComponentAwakeSystem : AwakeSystem<UIBattleComponent>
    {
        public override void Awake(UIBattleComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)BattlePageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)BattlePageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)BattlePageEnum.Number];

            pageViewComponent.UISubViewPath[(int)BattlePageEnum.Enter] = ABPathHelper.GetUGUIPath("BattleDungeon/UIBattleEnter");
            pageViewComponent.UISubViewPath[(int)BattlePageEnum.Task] = ABPathHelper.GetUGUIPath("BattleDungeon/UIBattleTask");
            pageViewComponent.UISubViewPath[(int)BattlePageEnum.Shop] = ABPathHelper.GetUGUIPath("BattleDungeon/UIBattleShop");
            
            pageViewComponent.UISubViewType[(int)BattlePageEnum.Enter] = typeof(UIBattleEnterComponent);
            pageViewComponent.UISubViewType[(int)BattlePageEnum.Task] = typeof(UIBattleTaskComponent);
            pageViewComponent.UISubViewType[(int)BattlePageEnum.Shop] = typeof(UIBattleShopComponent);
           
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

    public static class UIBattleComponentSystem
    {

        public static void OnClickPageButton(this UIBattleComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
