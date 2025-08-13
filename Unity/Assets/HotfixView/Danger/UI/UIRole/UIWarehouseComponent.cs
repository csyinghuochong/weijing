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

    public class UIWarehouseComponent: Entity, IAwake, IDestroy
    {
        public GameObject Btn_Type_3;
        public UIPageViewComponent UIPageView;
        public GameObject FunctionSetBtn;
        public UIPageButtonComponent UIPageButtonComponent;
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
            self.Btn_Type_3.SetActive(true);

            //IOS适配
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI PageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = PageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.CheckHandler = (int page) => { return self.CheckPageButton_1(page); };
            uIPageButtonComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageButtonComponent.OnSelectIndex(0);
            self.UIPageButtonComponent = uIPageButtonComponent;
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIWarehouseComponentDestroySystem : DestroySystem<UIWarehouseComponent>
    {
        public override void Destroy(UIWarehouseComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIWarehouseComponentSystem
    {
        public static void OnLanguageUpdate(this UIWarehouseComponent self)
        {
            Transform tt = self.UIPageButtonComponent.GetParent<UI>().GameObject.transform;

            int childCount = tt.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = tt.transform.GetChild(i);

                Transform XuanZhong = transform.Find("XuanZhong");
                if (XuanZhong)
                {
                    Text text = XuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }

                Transform WeiXuanZhong = transform.Find("WeiXuanZhong");
                if (WeiXuanZhong)
                {
                    Text text = WeiXuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }
            }
        }

        public static async ETTask UpdateSkillMakePlan2(this UIWarehouseComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.GemWarehouseOpen) == 1)
            {
                return;
            }
            C2M_SkillOperation c2M_SkillOperation = new C2M_SkillOperation() { OperationType = 4 };
            M2C_SkillOperation m2C_SkillOperation = (M2C_SkillOperation)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillOperation);
            self.UIPageButtonComponent.OnSelectIndex(2);
        }

        public static bool CheckPageButton_1(this UIWarehouseComponent self, int page)
        {
            if (page != (int)WarehouseEnum.WarehouseGem)
            {
                return true;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int rechargeNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeNumber);
            int gemOpen = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.GemWarehouseOpen);
            int needRecharge = 0;
            if (GlobalHelp.GetPlatform() == 7 || GameSettingLanguge.Language == 1)
            {
                needRecharge = 50;
            }
            else
            {
                needRecharge = 298;
            }
            if (gemOpen == 1)
            {
                return true;
            }

            string tip = string.Empty;
            if (rechargeNumber < needRecharge)
            {
                tip = string.Format(GameSettingLanguge.LoadLocalization("当前充值金额累计达到{0}元，将自动开启宝石仓库，当前充值金额{1}元"), needRecharge, rechargeNumber);
            }
            else
            {
                tip = string.Format(GameSettingLanguge.LoadLocalization("当前充值金额累计达到{0}元，将自动开启宝石仓库，您目前已经满足条件，请点击开启"), needRecharge);
            }

            PopupTipHelp.OpenPopupTipWithButtonText(self.ZoneScene(), GameSettingLanguge.LoadLocalization("开启栏位"), tip, () =>
            {
                if (rechargeNumber < needRecharge)
                {
                    FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("充值额度不足！"));
                }
                else
                {
                    self.UpdateSkillMakePlan2().Coroutine();
                }

            }, () =>
            {
                UIHelper.Create(self.ZoneScene(), UIType.UIRecharge).Coroutine();
            }, GameSettingLanguge.LoadLocalization("开启"), GameSettingLanguge.LoadLocalization("前往充值")).Coroutine();
            
            return false;
        }

        public static void OnClickPageButton(this UIWarehouseComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}