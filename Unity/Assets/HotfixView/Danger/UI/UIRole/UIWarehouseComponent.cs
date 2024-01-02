using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum WarehouseEnum: int
    {
        WarehouseRole = 0,
        WarehouseAccount = 1,

        Num,
    }

    public class UIWarehouseComponent: Entity, IAwake
    {
        public GameObject Btn_Type_2;
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

            pageViewComponent.UISubViewType[(int)WarehouseEnum.WarehouseRole] = typeof (UIWarehouseRoleComponent);
            pageViewComponent.UISubViewType[(int)WarehouseEnum.WarehouseAccount] = typeof (UIWarehouseAccountComponent);
            self.UIPageView = pageViewComponent;

            self.Btn_Type_2 = rc.Get<GameObject>("Btn_Type_2");
            self.Btn_Type_2.SetActive(true);

            //IOS适配
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI PageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = PageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UIWarehouseComponentSystem
    {
        public static void OnClickPageButton(this UIWarehouseComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}