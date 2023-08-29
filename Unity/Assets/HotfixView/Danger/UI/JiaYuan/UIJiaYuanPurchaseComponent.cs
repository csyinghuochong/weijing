

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.CanvasScaler;

namespace ET
{
    [Timer(TimerType.JiaYuanPurchaseTimer)]
    public class JiaYuanPurchaseTimer : ATimer<UIJiaYuanPurchaseComponent>
    {
        public override void Run(UIJiaYuanPurchaseComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIJiaYuanPurchaseComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public GameObject Text_Time;
        public GameObject ScorllListNode;
        public GameObject ButtonRefresh;

        public JiaYuanComponent JiaYuanComponent;
        public List<UIJiaYuanPurchaseItemComponent> UIJiaYuanPurchases = new List<UIJiaYuanPurchaseItemComponent>();
    }


    public class UIJiaYuanPurchaseComponentAwake : AwakeSystem<UIJiaYuanPurchaseComponent>
    {
        public override void Awake(UIJiaYuanPurchaseComponent self)
        {
            self.UIJiaYuanPurchases.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Time = rc.Get<GameObject>("Text_Time");
            self.ScorllListNode = rc.Get<GameObject>("ScorllListNode");

            self.JiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.JiaYuanPurchaseTimer, self);

            self.ButtonRefresh = rc.Get<GameObject>("ButtonRefresh");
            ButtonHelp.AddListenerEx(self.ButtonRefresh, () => { self.OnButtonRefresh();  });

            self.OnUpdateUI();
            self.ShowCDTime();
        }
    }

    public class UIJiaYuanPurchaseComponentDestroy : DestroySystem<UIJiaYuanPurchaseComponent>
    {
        public override void Destroy(UIJiaYuanPurchaseComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIJiaYuanPurchaseComponentSystem
    {

        public static  void OnButtonRefresh(this UIJiaYuanPurchaseComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            long jiayuanzijin = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.JiaYuanFund;
            int refreshtime = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.JiaYuanPurchaseRefresh);
            long needzijin = refreshtime >= 1 ? JiaYuanHelper.JiaYuanPurchaseRefresh : 0;

            if (refreshtime >= 3)
            {
                FloatTipManager.Instance.ShowFloatTip("今日次数不足!");
                return;
            }
            if (jiayuanzijin < needzijin)
            {
                FloatTipManager.Instance.ShowFloatTip("家园资金不足!");
                return;
            }

            if (needzijin > 0)
            {
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "家园刷新", $"是否花费{needzijin}家园资金刷新", () =>
                {
                    self.RquestFresh().Coroutine();
                }, null).Coroutine();
            }
            else
            {
                self.RquestFresh().Coroutine();
            }
        }

        public static async ETTask RquestFresh(this UIJiaYuanPurchaseComponent self)
        {
            C2M_JiaYuanPurchaseRefresh request = new C2M_JiaYuanPurchaseRefresh();
            M2C_JiaYuanPurchaseRefresh m2C_JiaYuan = (M2C_JiaYuanPurchaseRefresh)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (self.IsDisposed || m2C_JiaYuan.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.ZoneScene().GetComponent<JiaYuanComponent>().PurchaseItemList_7 = m2C_JiaYuan.PurchaseItemList;
            self.OnUpdateUI();
        }

        public static void OnTimer(this UIJiaYuanPurchaseComponent self)
        {
            long removeid = 0;
            for (int i = self.UIJiaYuanPurchases.Count - 1; i >= 0; i--)
            {
                bool leftTime= self.UIJiaYuanPurchases[i].UpdateLeftTime();
                if (leftTime)
                {
                    continue;
                }

                self.UIJiaYuanPurchases[i].GameObject.SetActive(false);
                removeid = self.UIJiaYuanPurchases[i].JiaYuanPurchaseItem.PurchaseId;
            }

            if (removeid > 0)
            {
                for (int k = self.JiaYuanComponent.PurchaseItemList_7.Count - 1; k >= 0; k--)
                {
                    if (self.JiaYuanComponent.PurchaseItemList_7[k].PurchaseId == removeid)
                    {
                        self.JiaYuanComponent.PurchaseItemList_7.RemoveAt(k);
                    }
                }
            }

            self.ShowCDTime();
        }

        public static void ShowCDTime(this UIJiaYuanPurchaseComponent self)
        {
            DateTime dateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
            long curTime = dateTime.Hour * 60 * 60 + dateTime.Minute * 60 + dateTime.Second;
            long cdTime = 0;
            if (dateTime.Hour < 12)
            {
                cdTime = 12 * 60 * 60 - curTime;
            }
            else
            {
                cdTime = 24 * 60 * 60 - curTime;
            }
            self.Text_Time.GetComponent<Text>().text = $"刷新倒计时: {TimeHelper.ShowLeftTime(cdTime * 1000)}";
        }

        public static void OnUpdateItem(this UIJiaYuanPurchaseComponent self)
        {
            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIJiaYuanPurchaseComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPurchaseItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < self.JiaYuanComponent.PurchaseItemList_7.Count; i++)
            {
                JiaYuanPurchaseItem jiaYuanPurchaseItem = self.JiaYuanComponent.PurchaseItemList_7[i];
                UIJiaYuanPurchaseItemComponent uIJiaYuanPurchaseItem = null;
                if (i < self.UIJiaYuanPurchases.Count)
                {
                    uIJiaYuanPurchaseItem = self.UIJiaYuanPurchases[i];
                    uIJiaYuanPurchaseItem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.ScorllListNode);
                    uIJiaYuanPurchaseItem = self.AddChild<UIJiaYuanPurchaseItemComponent, GameObject>(itemSpace);
                    self.UIJiaYuanPurchases.Add(uIJiaYuanPurchaseItem);
                }
                uIJiaYuanPurchaseItem.OnUpdateUI(jiaYuanPurchaseItem, self.OnUpdateItem);
            }

            for (int i = self.JiaYuanComponent.PurchaseItemList_7.Count; i < self.UIJiaYuanPurchases.Count; i++)
            {
                self.UIJiaYuanPurchases[i].GameObject.SetActive(false);
            }
        }
    }
}
