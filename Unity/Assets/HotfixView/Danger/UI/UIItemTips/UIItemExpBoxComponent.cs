using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIItemExpBoxComponent: Entity, IAwake
    {
        public GameObject Label_ItemNum;
        public GameObject ImageButton;
        public GameObject Text_ZuanShi;
        public GameObject Btn_ZuanShiOpen;
        public GameObject Btn_MianFeiOpen;
        public InputField PriceInputField;
        public GameObject Btn_Cost;
        public GameObject Btn_Add;

        public UIItemComponent UICommonItem;
        public BagInfo BagInfo;
        public int WorldPlayerLv;
        public int Price;
        public int UseNum;
        public bool IsHoldDown;
    }

    public class UIItemExpBoxComponentAwakeSystem: AwakeSystem<UIItemExpBoxComponent>
    {
        public override void Awake(UIItemExpBoxComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Text_ZuanShi = rc.Get<GameObject>("Text_ZuanShi");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.ImageButton(); });

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem);

            self.Btn_ZuanShiOpen = rc.Get<GameObject>("Btn_ZuanShiOpen");
            ButtonHelp.AddListenerEx(self.Btn_ZuanShiOpen, () => { self.OnButtonOpen(1).Coroutine(); });
            self.Btn_MianFeiOpen = rc.Get<GameObject>("Btn_MianFeiOpen");
            ButtonHelp.AddListenerEx(self.Btn_MianFeiOpen, () => { self.OnButtonOpen(2).Coroutine(); });

            self.PriceInputField = rc.Get<GameObject>("PriceInputField").GetComponent<InputField>();
            self.PriceInputField.onValueChanged.AddListener((string value) => { self.OnChange(value); });

            self.Btn_Cost = rc.Get<GameObject>("Btn_Cost");
            self.Btn_Add = rc.Get<GameObject>("Btn_Add");

            ButtonHelp.AddEventTriggers(self.Btn_Cost, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(pdata).Coroutine(); },
                EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_Cost, (PointerEventData pdata) => { self.PointerUp_Btn_CostNum(pdata); },
                EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Btn_Add, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(pdata).Coroutine(); },
                EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_Add, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(pdata); }, EventTriggerType.PointerUp);
        }
    }

    public static class UIItemExpBoxComponentSystem
    {
        public static void OnInitUI(this UIItemExpBoxComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            string[] expInfos = itemConfig.ItemUsePar.Split('@');
            self.Price = int.Parse(expInfos[0]);
            self.UICommonItem.UpdateItem(bagInfo, ItemOperateEnum.None);
            self.UpdateNumber();
            self.worldLv().Coroutine();
        }

        public static void OnAddNum(this UIItemExpBoxComponent self)
        {
            self.UseNum += 1;
            if (self.UseNum >= self.BagInfo.ItemNum)
            {
                self.UseNum = self.BagInfo.ItemNum;
            }

            self.PriceInputField.SetTextWithoutNotify(self.UseNum.ToString());
            self.Text_ZuanShi.GetComponent<Text>().text = (self.UseNum * self.Price).ToString();
        }

        public static void OnCostNum(this UIItemExpBoxComponent self)
        {
            self.UseNum -= 1;
            if (self.UseNum <= 1)
            {
                self.UseNum = 1;
            }

            self.PriceInputField.SetTextWithoutNotify(self.UseNum.ToString());
            self.Text_ZuanShi.GetComponent<Text>().text = (self.UseNum * self.Price).ToString();
        }

        public static async ETTask PointerDown_Btn_CostNum(this UIItemExpBoxComponent self, PointerEventData pdata)
        {
            int interval = 0;
            self.IsHoldDown = true;
            self.OnCostNum();
            while (self.IsHoldDown)
            {
                interval++;
                if (interval > 60)
                {
                    self.OnCostNum();
                }

                if (self.UseNum == 1)
                {
                    break;
                }

                await TimerComponent.Instance.WaitFrameAsync();
            }
        }

        public static void PointerUp_Btn_CostNum(this UIItemExpBoxComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static async ETTask PointerDown_Btn_AddNum(this UIItemExpBoxComponent self, PointerEventData pdata)
        {
            int interval = 0;
            self.IsHoldDown = true;
            self.OnAddNum();
            while (self.IsHoldDown)
            {
                interval++;
                if (interval > 60)
                {
                    self.OnAddNum();
                }

                if (self.UseNum >= self.BagInfo.ItemNum)
                {
                    break;
                }

                await TimerComponent.Instance.WaitFrameAsync();
            }
        }

        public static void PointerUp_Btn_AddNum(this UIItemExpBoxComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static async ETTask worldLv(this UIItemExpBoxComponent self)
        {
            C2R_WorldLvRequest request = new C2R_WorldLvRequest();
            R2C_WorldLvResponse response = (R2C_WorldLvResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.IsDisposed)
            {
                return;
            }

            RankingInfo rankingInfo = response.ServerInfo.RankingInfo;

            if (rankingInfo != null)
            {
                self.WorldPlayerLv = rankingInfo.PlayerLv;
            }
        }

        public static long UpdateNumber(this UIItemExpBoxComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            self.BagInfo = bagComponent.GetBagInfo(self.BagInfo.BagInfoID);
            if (self.BagInfo == null)
            {
                return 0;
            }

            self.UseNum = self.BagInfo.ItemNum;
            self.Label_ItemNum.GetComponent<Text>().text = self.BagInfo.ItemNum.ToString();
            self.PriceInputField.text = self.BagInfo.ItemNum.ToString();
            self.Text_ZuanShi.GetComponent<Text>().text = (self.UseNum * self.Price).ToString();
            return self.BagInfo.ItemNum;
        }

        public static void OnChange(this UIItemExpBoxComponent self, string str)
        {
            int num = 0;
            try
            {
                num = int.Parse(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            if (num <= 0 || num > self.BagInfo.ItemNum)
            {
                return;
            }

            self.UseNum = num;
            self.Text_ZuanShi.GetComponent<Text>().text = (self.UseNum * self.Price).ToString();
        }

        /// <summary>
        /// 1 钻石开启 2免费开启
        /// </summary>
        /// <par;f"></param>
        /// <param name="openType"></param>
        /// <returns></returns>
        public static async ETTask OnButtonOpen(this UIItemExpBoxComponent self, int openType)
        {
            if (self.UseNum > self.BagInfo.ItemNum || self.UseNum <= 0)
            {
                return;
            }

            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            if (ServerHelper.GetOpenServerDay(!GlobalHelp.IsOutNetMode, accountInfoComponent.ServerId) <= 1)
            {
                //开区第一天
                if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv + 3 > self.WorldPlayerLv)
                {
                    FloatTipManager.Instance.ShowFloatTip($"等级第一的玩家为:{self.WorldPlayerLv}级,开服第一天低于第一等级玩家3级内才可使用!");
                    return;
                }
            }

            if (openType == 1 && self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Diamond < self.UseNum * self.Price)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_DiamondNotEnoughError);
                return;
            }

            long instanceid = self.InstanceId;
            await self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo, openType + ";" + self.UseNum);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            if (self.UpdateNumber() <= 0)
            {
                self.ImageButton();
            }
        }

        public static void ImageButton(this UIItemExpBoxComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIItemExpBox);
        }
    }
}