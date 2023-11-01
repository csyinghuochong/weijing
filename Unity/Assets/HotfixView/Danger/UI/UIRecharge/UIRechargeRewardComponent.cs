using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{

    public class UIRechargeRewardComponent : Entity, IAwake
    {
        public GameObject ButtonClose;
        public GameObject ImageReceived;
        public GameObject ButtonReward;
        public GameObject BuildingList;

        public GameObject UICommonItem;
        public List<UIItemComponent> UIItemList = new List<UIItemComponent>();  


        public UIPageButtonComponent UIPageButton;
    }


    public class UIRechargeRewardComponentAwake : AwakeSystem<UIRechargeRewardComponent>
    {
        public override void Awake(UIRechargeRewardComponent self)
        {
            self.UIItemList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();


            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(self.OnButtonClose);

            self.ImageReceived = rc.Get<GameObject>("ImageReceived");

            self.ButtonReward = rc.Get<GameObject>("ButtonReward");

            self.BuildingList = rc.Get<GameObject>("BuildingList");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);

           GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageViewComponent;
        }
    }

    public static class UIRechargeRewardComponentSystem
    {

        public static void OnButtonClose(this UIRechargeRewardComponent self)
        {
            UIHelper.Remove( self.ZoneScene(), UIType.UIRechargeReward );
        }

        public static async ETTask OnButtonReward(this UIRechargeRewardComponent self)
        {
            int page = self.UIPageButton.CurrentIndex;
            int rechargeNumber = page == 0 ? 50 : 98;

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.RechargeReward.Contains(rechargeNumber))
            {
                FloatTipManager.Instance.ShowFloatTip("当前奖励已领取");
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeNumber) < rechargeNumber)
            {
                FloatTipManager.Instance.ShowFloatTip($"充值金额不足 {rechargeNumber}元");
                return;
            }
                 
            C2M_RechargeRewardRequest   request = new C2M_RechargeRewardRequest() { RechargeNumber = rechargeNumber };
            M2C_RechargeRewardResponse response = (M2C_RechargeRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error == ErrorCode.ERR_Success)
            {
                userInfoComponent.UserInfo.RechargeReward.Add(rechargeNumber);
            }
            if (self.InstanceId == 0)
            {
                return;
            }

            self.UpdateUI(page);
        }

        public static void UpdateUI(this UIRechargeRewardComponent self, int page)
        {
            int rechargeNumber = page == 0 ? 50 : 98;
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.ButtonReward.SetActive(!userInfoComponent.UserInfo.RechargeReward.Contains(rechargeNumber));
            self.ImageReceived.SetActive(userInfoComponent.UserInfo.RechargeReward.Contains(rechargeNumber));

            string reward = ConfigHelper.RechargeReward[rechargeNumber];
            List<RewardItem> rewardItems = ItemHelper.GetRewardItems(reward);
            for (int i = 0; i < rewardItems.Count; i++)
            {
                UIItemComponent uIItem = null;

                if (i < self.UIItemList.Count)
                {
                    uIItem = self.UIItemList[i];
                    uIItem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject gameObject = GameObject.Instantiate( self.UICommonItem );
                    gameObject.SetActive(true);
                    UICommonHelper.SetParent( gameObject , self.BuildingList);
                    uIItem = self.AddChild<UIItemComponent, GameObject>(gameObject);
                    self.UIItemList.Add( uIItem );  
                }
                BagInfo bagInfo = new BagInfo() { ItemID = rewardItems[i].ItemID, ItemNum = rewardItems[i].ItemNum };
                uIItem.UpdateItem(bagInfo,  ItemOperateEnum.None);
            }
            for (int i = rewardItems.Count;i < self.UIItemList.Count; i++)
            {
                self.UIItemList[i].GameObject.SetActive(false); 
            }
        }

        public static void OnClickPageButton(this UIRechargeRewardComponent self, int page)
        {
            self.UpdateUI(page);
        }
    }
}