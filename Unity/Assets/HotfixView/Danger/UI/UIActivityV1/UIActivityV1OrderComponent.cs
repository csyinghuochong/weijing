using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1OrderComponent : Entity, IAwake
    {
        public Text TextLeftTime;
        public Text TextHaveNumber;

        public GameObject GetItemList;
        public GameObject UICommonCostItem;

        public GameObject GiveItemList;
        public List<UICommonCostItemComponent> UICommonCostItemList = new List<UICommonCostItemComponent>();

        public GameObject ButtonGive;
        public GameObject ButtonChange;
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

            self.GiveItemList = rc.Get<GameObject>("GiveItemList");

            self.ButtonGive = rc.Get<GameObject>("ButtonGive");
            self.ButtonGive.GetComponent<Button>().onClick.AddListener(() =>
            {
               
            });

            self.ButtonChange = rc.Get<GameObject>("ButtonChange");
            self.ButtonChange.GetComponent<Button>().onClick.AddListener(() =>
            {

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
            self.ShowOrderRefreshTime(response.ActivityV1Info.OrderLastFefreshTime);
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

        public static void ShowOrderRefreshTime(this UIActivityV1OrderComponent self, long refreshTime)
        { 
            
        }

        public static void UpdateCostItemNumber(this UIActivityV1OrderComponent self)
        { 
            
        }

    }
}