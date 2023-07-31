using System;
using UnityEngine;

namespace ET
{
    public enum EquipmentIncreasePageEnum: int
    {
        EquipmentIncreaseShow = 0,
        RoleXiLianTransfer = 1,
        Number
    }

    /// <summary>
    /// 装备增幅
    /// </summary>
    public class UIEquipmentIncreaseComponent: Entity, IAwake, IDestroy
    {
        public UI UIPageButton;
        public UIPageViewComponent UIPageView;
        public GameObject FunctionSetBtn;
    }

    public class UIEquipmentIncreaseComponentAwakeSystem: AwakeSystem<UIEquipmentIncreaseComponent>
    {
        public override void Awake(UIEquipmentIncreaseComponent self)
        {
            self.Awake();
        }
    }

    public class UIEquipmentIncreaseComponentDestroyStstem: DestroySystem<UIEquipmentIncreaseComponent>
    {
        public override void Destroy(UIEquipmentIncreaseComponent self)
        {
            self.Destroy();
        }
    }

    public static class UIEquipmentIncreaseComponentSystem
    {
        public static void Awake(this UIEquipmentIncreaseComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)EquipmentIncreasePageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)EquipmentIncreasePageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)EquipmentIncreasePageEnum.Number];

            pageViewComponent.UISubViewPath[(int)EquipmentIncreasePageEnum.EquipmentIncreaseShow] =
                    ABPathHelper.GetUGUIPath("Main/EquipmentIncrease/UIEquipmentIncreaseShow");
            pageViewComponent.UISubViewType[(int)EquipmentIncreasePageEnum.EquipmentIncreaseShow] = typeof (UIEquipmentIncreaseShowComponent);

            pageViewComponent.UISubViewPath[(int)EquipmentIncreasePageEnum.RoleXiLianTransfer] =
                    ABPathHelper.GetUGUIPath("Main/RoleXiLian/UIRoleXiLianTransfer");
            pageViewComponent.UISubViewType[(int)EquipmentIncreasePageEnum.RoleXiLianTransfer] = typeof (UIRoleXiLianTransferComponent);

            self.UIPageView = pageViewComponent;

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uiPage;

            //IOS适配
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));
        }

        public static void Destroy(this UIEquipmentIncreaseComponent self)
        {
        }

        public static void OnClickPageButton(this UIEquipmentIncreaseComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void OnEquipmentIncreaseReturn(this UIEquipmentIncreaseComponent self)
        {
            UI equipmentIncrease = self.UIPageView.UISubViewList[(int)EquipmentIncreasePageEnum.EquipmentIncreaseShow];
            equipmentIncrease?.GetComponent<UIEquipmentIncreaseShowComponent>().OnUpdateUI();
        }
    }
}