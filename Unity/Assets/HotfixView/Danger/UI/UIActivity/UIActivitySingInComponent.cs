using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public class UIActivitySingInComponent : Entity, IAwake
    {
        public GameObject Img_lingQu2;
        public GameObject Btn_Com2;
        public GameObject ItemListNode;
        public GameObject Btn_Com;
        public GameObject Img_lingQu;
        public GameObject RewardListNode;
        public GameObject RewardListNode2;

        public List<UIActivitySingInItemComponent> ItemUIList = new List<UIActivitySingInItemComponent>();
        public int ActivityId;
    }


    [ObjectSystem]
    public class UIActivitySingInComponentAwakeSystem : AwakeSystem<UIActivitySingInComponent>
    {
        public override void Awake(UIActivitySingInComponent self)
        {
            self.ItemUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.Img_lingQu = rc.Get<GameObject>("Img_lingQu");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.RewardListNode2 = rc.Get<GameObject>("RewardListNode2");
            self.Img_lingQu2 = rc.Get<GameObject>("Img_lingQu2");

            self.Btn_Com = rc.Get<GameObject>("Btn_Com");
            ButtonHelp.AddListenerEx(  self.Btn_Com, ()=> { self.OnBtn_Com_Sign().Coroutine();  } );

            self.Btn_Com2 = rc.Get<GameObject>("Btn_Com2");
            ButtonHelp.AddListenerEx(self.Btn_Com2, () => { self.OnBtn_Com_Sign2().Coroutine(); });

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIActivitySingInComponentSystem
    {

        public static async ETTask OnInitUI(this UIActivitySingInComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Activity/UIActivitySingInItem");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();

            int curDay = 0;
            long serverNow = TimeHelper.ServerNow();
            bool isSign = ComHelp.GetDateByTime(serverNow) == ComHelp.GetDateByTime(activityComponent.LastSignTime);
            curDay = activityComponent.TotalSignNumber;
            if (activityComponent.TotalSignNumber < 30 && !isSign)
            {
                curDay++;
            }

            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 23)
                {
                    continue;
                }

                GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(bagSpace, self.ItemListNode);

                UIActivitySingInItemComponent uIItemComponent = self.AddChild<UIActivitySingInItemComponent, GameObject>(bagSpace);
                uIItemComponent.OnUpdateUI(activityConfigs[i], (int activityId) => { self.OnClickSignItem(activityId);  });
                uIItemComponent.SetSignState(curDay, isSign);
                self.ItemUIList.Add(uIItemComponent);
            }
            self.Img_lingQu.SetActive(isSign);
            self.Btn_Com.SetActive(!isSign);
            self.ItemUIList[curDay-1].OnImage_ItemButton();

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.Img_lingQu2.SetActive(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeSign) == 2 );
        }

        public static void OnClickSignItem(this UIActivitySingInComponent self, int activityId)
        {
            self.ActivityId = activityId;

            ActivityConfig ActivityConfig = null;
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 23)
                {
                    continue;
                }
                if (activityConfigs[i].Id == activityId)
                {
                    ActivityConfig = activityConfigs[i];
                }
            }
            for (int i = 0; i < self.ItemUIList.Count; i++)
            {
                self.ItemUIList[i].SetSelected(ActivityConfig.Id);
            }

            UICommonHelper.DestoryChild(self.RewardListNode);
            UICommonHelper.ShowItemList(ActivityConfig.Par_3,  self.RewardListNode, self, 1f).Coroutine();

            UICommonHelper.DestoryChild(self.RewardListNode2);
            UICommonHelper.ShowItemList(ActivityConfig.Par_2, self.RewardListNode2, self, 1f).Coroutine();

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            long serverNow = TimeHelper.ServerNow();
            bool isSign = ComHelp.GetDateByTime(serverNow) == ComHelp.GetDateByTime(activityComponent.LastSignTime);
            bool ifShow = int.Parse(ActivityConfig.Par_1) <= activityComponent.TotalSignNumber || isSign;
            self.Img_lingQu.SetActive(ifShow);
            self.Btn_Com.SetActive(!ifShow);
        }

        public static async ETTask OnBtn_Com_Sign2(this UIActivitySingInComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeSign) != 1)
            {
                FloatTipManager.Instance.ShowFloatTip("不满足领取条件");
                return;
            }

            C2M_ActivityRechargeSignRequest     request     = new C2M_ActivityRechargeSignRequest() { ActivityType = 23, ActivityId = self.ActivityId };
            M2C_ActivityRechargeSignResponse response = (M2C_ActivityRechargeSignResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.Img_lingQu2.SetActive(true);
        }

        public static async ETTask OnBtn_Com_Sign(this UIActivitySingInComponent self)
        {

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (activityComponent.TotalSignNumber == 30)
            {
                FloatTipManager.Instance.ShowFloatTip("已领完全部奖励！");
                return;
            }
            long serverNow = TimeHelper.ServerNow();
            if (ComHelp.GetDateByTime(serverNow) == ComHelp.GetDateByTime(activityComponent.LastSignTime))
            {
                FloatTipManager.Instance.ShowFloatTip("当日奖励已领取！");
                return;
            }

            C2M_ActivityReceiveRequest c2M_ItemHuiShouRequest = new C2M_ActivityReceiveRequest() { ActivityType = 23, ActivityId = self.ActivityId };
            M2C_ActivityReceiveResponse r2c_roleEquip = (M2C_ActivityReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
            {
                return;
            }

            activityComponent.TotalSignNumber++;
            activityComponent.LastSignTime = serverNow;
            activityComponent.ActivityReceiveIds.Add(self.ActivityId);

            self.OnClickSignItem(self.ActivityId);
        }
    }
}
