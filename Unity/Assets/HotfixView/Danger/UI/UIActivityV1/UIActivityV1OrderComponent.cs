using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.ActivityV1OrderTimer)]
    public class ActivityV1OrderTimer : ATimer<UIActivityV1OrderComponent>
    {
        public override void Run(UIActivityV1OrderComponent self)
        {
            try
            {
                self.OnTimerChouKaTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIActivityV1OrderComponent : Entity, IAwake, IDestroy
    {
        public Text TextLeftTime;
        public Text TextHaveNumber;
        public long OrderTimer;

        public GameObject GetItemList;
        public GameObject UICommonCostItem;

        public UIItemComponent UINeedItem;

        public GameObject GiveItemList;
        public List<UICommonCostItemComponent> UICommonCostItemList = new List<UICommonCostItemComponent>();

        public GameObject ButtonGive;
        public GameObject ButtonChange;
        public int FontSize = 40;
    }

    public class UIActivityV1OrderComponentDestroy : DestroySystem<UIActivityV1OrderComponent>
    {
        public override void Destroy(UIActivityV1OrderComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.OrderTimer);
        }
    }

    public class UIActivityV1OrderComponentAwake : AwakeSystem<UIActivityV1OrderComponent>
    {
        public override void Awake(UIActivityV1OrderComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextLeftTime = rc.Get<GameObject>("TextLeftTime").GetComponent<Text>();
            self.TextHaveNumber = rc.Get<GameObject>("TextHaveNumber").GetComponent<Text>();

            self.GetItemList = rc.Get<GameObject>("GetItemList");
            self.UICommonCostItem = rc.Get<GameObject>("UICommonCostItem");
            self.UICommonCostItem.SetActive(false);

            GameObject uineeditem = rc.Get<GameObject>("UINeedItem");
            self.FontSize = uineeditem.transform.Find("Label_ItemName").GetComponent<Text>().fontSize;
            self.UINeedItem = self.AddChild<UIItemComponent, GameObject>(uineeditem);
            self.UINeedItem.SetFontSize = false;
           

            self.GiveItemList = rc.Get<GameObject>("GiveItemList");

            self.ButtonGive = rc.Get<GameObject>("ButtonGive");
            self.ButtonGive.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.RequestFefreshOrder(2).Coroutine();
            });

            self.ButtonChange = rc.Get<GameObject>("ButtonChange");
            self.ButtonChange.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.RequestFefreshOrder(1).Coroutine();
            });

            self.UpdateInfo().Coroutine();
        }
    }

    public static class UIActivityV1OrderComponentSystem
    {
        public static async ETTask UpdateInfo(this UIActivityV1OrderComponent self)
        {
            C2M_ActivityInfoRequest request = new C2M_ActivityInfoRequest();
            M2C_ActivityInfoResponse response =
                    (M2C_ActivityInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response == null || response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            if (self.IsDisposed)
            {
                return;
            }

            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;

            self.ShowOrderDetail(response.ActivityV1Info.OrderId);
            self.ShowOrderRefreshTime();
            self.UpdateCostItemNumber();
        }

        public static void ShowOrderDetail(this UIActivityV1OrderComponent self, int orderid)
        {
            ActivityOrderItem  activityOrderItem =  ActivityConfigHelper.ActivityOrderItemList[orderid];

            //UICommonHelper.DestoryChild(self.GiveItemList);
            //UICommonHelper.ShowCostItemList(activityOrderItem.Give, self.GiveItemList, self.UICommonCostItem,  self, 1f);

            string[] costItem = activityOrderItem.Give.Split('@');
            for (int i = 0; i < costItem.Length; i++)
            {
                string[] iteminfo = costItem[i].Split(';');
                UICommonCostItemComponent uICommonCostItem = null;
                if (i < self.UICommonCostItemList.Count)
                {
                    uICommonCostItem = self.UICommonCostItemList[i];
                }
                else
                {
                    GameObject commonCostItem2 = GameObject.Instantiate(self.UICommonCostItem);
                    uICommonCostItem = self.AddChild<UICommonCostItemComponent, GameObject>(commonCostItem2);
                    self.UICommonCostItemList.Add(uICommonCostItem);
                    UICommonHelper.SetParent(commonCostItem2, self.GiveItemList);
                }

                self.UICommonCostItemList[i].GameObject.SetActive(true);
                self.UICommonCostItemList[i].UpdateItem(int.Parse(iteminfo[0]), int.Parse(iteminfo[1]));
            }
            for (int  i = costItem.Length; i < self.UICommonCostItemList.Count; i++)
            {
                self.UICommonCostItemList[i].GameObject.SetActive(false);
            }

            UICommonHelper.DestoryChild(self.GetItemList);
            List<RewardItem> rewardItems = ItemHelper.GetRewardItems(activityOrderItem.Get);
            UICommonHelper.ShowItemList(rewardItems, self.GetItemList, self, 1f, true, true);
        }

        public static void ShowOrderRefreshTime(this UIActivityV1OrderComponent self)
        {
            TimerComponent.Instance.Remove(ref self.OrderTimer);
            long refreshTime = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info.OrderLastFefreshTime;
            long leftTime = refreshTime + ActivityConfigHelper.ActivityOrderRefreshTime -  TimeHelper.ServerNow();
            if (leftTime <= 0)
            {
                self.RequestFefreshOrder(3).Coroutine();
            }
            else
            {
                string showstr = UICommonHelper.ShowLeftTime_2(leftTime, GameSettingLanguge.Language);
                self.TextLeftTime.text = string.Format(GameSettingLanguge.LoadLocalization("订单剩余时间:{0}"), showstr);
                self.OrderTimer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Second, TimerType.ActivityV1OrderTimer, self);
            }
        }

        public static void OnTimerChouKaTimer(this UIActivityV1OrderComponent self)
        {
            long refreshTime = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info.OrderLastFefreshTime;
            long leftTime = refreshTime + ActivityConfigHelper.ActivityOrderRefreshTime - TimeHelper.ServerNow();
            if (leftTime <= 0)
            {
                TimerComponent.Instance.Remove(ref self.OrderTimer);
                self.RequestFefreshOrder(3).Coroutine();
            }
            else
            {
                string showstr = UICommonHelper.ShowLeftTime_2(leftTime, GameSettingLanguge.Language);
                self.TextLeftTime.text = string.Format(GameSettingLanguge.LoadLocalization("订单剩余时间:{0}"), showstr);
            }
        }

        public static async ETTask RequestFefreshOrder(this UIActivityV1OrderComponent self, int otype)
        {
            if (otype == 1)
            {
                BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                if (!bagComponent.CheckNeedItem(ActivityConfigHelper.ActivityOrderRefreshItem))
                {
                    ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_ItemNotEnoughError);
                    return;
                }
            }

            C2M_ActivityOrderOperateRequest request = new C2M_ActivityOrderOperateRequest() {  OperatateType  = otype };
            M2C_ActivityOrderOperateResponse response =
                    (M2C_ActivityOrderOperateResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.IsDisposed)
            {
                return;
            }
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            activityComponent.ActivityV1Info = response.ActivityV1Info;
            ActivityV1Info activityV1Info = activityComponent.ActivityV1Info;
            self.ShowOrderDetail(activityV1Info.OrderId);
            self.ShowOrderRefreshTime();
            self.UpdateCostItemNumber();
        }


        public static void UpdateCostItemNumber(this UIActivityV1OrderComponent self)
        {
            string[] iteminfo = ActivityConfigHelper.ActivityOrderRefreshItem.Split(';');
            int itemid = int.Parse(iteminfo[0]);    
            int neednum = int.Parse(iteminfo[1]);

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(  itemid );

            long havenum = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(itemid);
            string showstr = GameSettingLanguge.LoadLocalization("拥有:");
            self.TextHaveNumber.text = $"{showstr}{havenum}";

            self.UINeedItem.UpdateItem( new BagInfo() { ItemID = itemid }, ItemOperateEnum.None );
            self.UINeedItem.Label_ItemNum.SetActive(false);

            self.UINeedItem.Label_ItemName.GetComponent<Text>().text = $"{itemConfig.GetItemName()}*{neednum}";
            self.UINeedItem.Label_ItemName.GetComponent<Text>().fontSize = self.FontSize;
        }

    }
}