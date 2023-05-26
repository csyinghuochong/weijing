using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public enum PaiMaiPageEnum : int
    {
        PaiMaiShop = 0,
        PaiMaiBuy = 1,
        PaiMaiSell = 2,
        PaiMaiDuiHuan =3,
        Number,
    }

    public class UIPaiMaiComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
        public Dictionary<long, PaiMaiShopItemInfo> PaiMaiShopItemInfos = new Dictionary<long, PaiMaiShopItemInfo>();       //快捷存储列表
    }

    public class UIPaiMaiComponentAwakeSystem : AwakeSystem<UIPaiMaiComponent>
    {
        public override void Awake(UIPaiMaiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)PaiMaiPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)PaiMaiPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)PaiMaiPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)PaiMaiPageEnum.PaiMaiShop] = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiShop");
            pageViewComponent.UISubViewPath[(int)PaiMaiPageEnum.PaiMaiBuy] = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiBuy");
            pageViewComponent.UISubViewPath[(int)PaiMaiPageEnum.PaiMaiSell] = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiSell");
            pageViewComponent.UISubViewPath[(int)PaiMaiPageEnum.PaiMaiDuiHuan] = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiDuiHuan");

            pageViewComponent.UISubViewType[(int)PaiMaiPageEnum.PaiMaiShop] = typeof(UIPaiMaiShopComponent);
            pageViewComponent.UISubViewType[(int)PaiMaiPageEnum.PaiMaiBuy] = typeof(UIPaiMaiBuyComponent);
            pageViewComponent.UISubViewType[(int)PaiMaiPageEnum.PaiMaiSell] = typeof(UIPaiMaiSellComponent);
            pageViewComponent.UISubViewType[(int)PaiMaiPageEnum.PaiMaiDuiHuan] = typeof(UIPaiMaiDuiHuanComponet);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI ui = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageButtonComponent = ui.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageButtonComponent;
        }
    }


    public class UIPaiMaiComponentDestroySystem : DestroySystem<UIPaiMaiComponent>
    {
        public override void Destroy(UIPaiMaiComponent self)
        {
        }
    }

    public static class UIPaiMaiComponentSystem
    {

        public static void OnClickPageButton(this UIPaiMaiComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }

}
