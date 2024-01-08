using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum WarehouseEnum: int
    {
        WarehouseRole = 0,
        WarehouseAccount = 1,
        WarehouseGem = 2,

        Num,
    }

    public class UIWarehouseComponent: Entity, IAwake
    {
        public GameObject Btn_Type_3;
        public UIPageViewComponent UIPageView;
        public GameObject FunctionSetBtn;
    }

    public class UIWarehouseComponentAwakeSystem: AwakeSystem<UIWarehouseComponent>
    {
        public override void Awake(UIWarehouseComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)WarehouseEnum.Num];
            pageViewComponent.UISubViewPath = new string[(int)WarehouseEnum.Num];
            pageViewComponent.UISubViewType = new Type[(int)WarehouseEnum.Num];

            pageViewComponent.UISubViewPath[(int)WarehouseEnum.WarehouseRole] = ABPathHelper.GetUGUIPath("Main/Role/UIWarehouseRole");
            pageViewComponent.UISubViewPath[(int)WarehouseEnum.WarehouseAccount] = ABPathHelper.GetUGUIPath("Main/Role/UIWarehouseAccount");
            pageViewComponent.UISubViewPath[(int)WarehouseEnum.WarehouseGem] = ABPathHelper.GetUGUIPath("Main/Role/UIWarehouseGem");
            
            pageViewComponent.UISubViewType[(int)WarehouseEnum.WarehouseRole] = typeof (UIWarehouseRoleComponent);
            pageViewComponent.UISubViewType[(int)WarehouseEnum.WarehouseAccount] = typeof (UIWarehouseAccountComponent);
            pageViewComponent.UISubViewType[(int)WarehouseEnum.WarehouseGem] = typeof(UIWarehouseGemComponent);
            self.UIPageView = pageViewComponent;

            self.Btn_Type_3 = rc.Get<GameObject>("Btn_Type_3");
            self.Btn_Type_3.SetActive(GMHelp.GmAccount.Contains( self.ZoneScene().GetComponent<AccountInfoComponent>().Account ));

            //IOS适配
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI PageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = PageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.CheckHandler = (int page) => { return self.CheckPageButton_1(page); };
            uIPageButtonComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UIWarehouseComponentSystem
    {
        public static bool CheckPageButton_1(this UIWarehouseComponent self, int page)
        {
            if (page != (int)WarehouseEnum.WarehouseGem)
            {
                return true;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.RechargeNumber) < 298)
            {
                FloatTipManager.Instance.ShowFloatTip("充值金额298开启");
                return false;
            }
            return true;
        }

        public static void OnClickPageButton(this UIWarehouseComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}