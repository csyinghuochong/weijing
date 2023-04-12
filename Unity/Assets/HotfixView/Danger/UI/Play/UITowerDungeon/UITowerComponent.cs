using System;
using UnityEngine;

namespace ET
{
    public enum TowerPageEnum : int
    {
        Dungeon = 0,
        Shop = 1,

        Number,
    }

    public class UITowerComponent : Entity, IAwake, IDestroy
    {
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }


    public class UITowerComponentAwake : AwakeSystem<UITowerComponent>
    {
        public override void Awake(UITowerComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)TowerPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)TowerPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)TowerPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)TowerPageEnum.Dungeon] = ABPathHelper.GetUGUIPath("TowerDungeon/UITowerDungeon");
            pageViewComponent.UISubViewPath[(int)TowerPageEnum.Shop] = ABPathHelper.GetUGUIPath("TowerDungeon/UITowerShop");
            
            pageViewComponent.UISubViewType[(int)TowerPageEnum.Dungeon] = typeof(UITowerDungeonComponent);
            pageViewComponent.UISubViewType[(int)TowerPageEnum.Shop] = typeof(UITowerShopComponent);
       
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

    public static class UITowerComponentSystem
    {

        public static void OnClickPageButton(this UITowerComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
