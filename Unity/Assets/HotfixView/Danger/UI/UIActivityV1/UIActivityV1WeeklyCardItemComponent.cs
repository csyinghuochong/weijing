using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1WeeklyCardItemComponent : Entity, IAwake<GameObject>
    {

        public Text TextDayIndex;
        public GameObject ItemRewardList;
        public GameObject ButtonReceive;     //可领取状态
        public GameObject CompleteStatu;     //已领取状态
        public GameObject NoActivatedStatu;  //未激活状态
        public GameObject GameObject;
        public int Type;
        public int Key;
    }

    public class UIActivityV1WeeklyCardItemComponentAwake : AwakeSystem<UIActivityV1WeeklyCardItemComponent, GameObject>
    {
        public override void Awake(UIActivityV1WeeklyCardItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            Transform transform = gameObject.transform;
            self.ItemRewardList = transform.Find("ItemRewardList").gameObject;
            self.ButtonReceive = transform.Find("ButtonReceive").gameObject; 
            self.CompleteStatu = transform.Find("CompleteStatu").gameObject; 
            self.TextDayIndex = transform.Find("TextDayIndex").gameObject.GetComponent<Text>();
            self.NoActivatedStatu = transform.Find("NoActivatedStatu").gameObject;

            self.ButtonReceive.GetComponent<Button>().onClick.AddListener(() => { self.OnReceiveBtn().Coroutine(); });
        }
    }

    public static class UIActivityV1WeeklyCardItemComponentSystem
    {
        public static void OnUpdateData(this UIActivityV1WeeklyCardItemComponent self, int type, int key)
        {
            self.Type = type ;
            self.Key = key;

            self.TextDayIndex.text = ActivityConfigHelper.ConvertToChineseDay(key + 1);

            List<string> rewardlists = ActivityConfigHelper.ActivityV1WeeklyCardReward[type - ActivityConfigHelper.ActivityV1_GoldWeeklyCard + 1];
            string rewarditem = rewardlists[key];

            UICommonHelper.DestoryChild( self.ItemRewardList );
            UICommonHelper.ShowItemList(rewarditem, self.ItemRewardList, self);

            self.ButtonReceive.SetActive(false);//可领取状态
            self.CompleteStatu.SetActive(false);//已领取状态
            self.NoActivatedStatu.SetActive(false);//未激活状态

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene() );
            long weeklycardtime = 0;
            int status = 3;
            List<int> recvlis = new List<int>();
            if (self.Type == ActivityConfigHelper.ActivityV1_GoldWeeklyCard)
            {
                weeklycardtime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.GoldWeeklyCard);
                recvlis = activityComponent.ActivityV1Info.GoldWeeklyCardRewards;
                if (recvlis.Contains(self.Key))
                {
                    status = 2;
                }
            }
            if(self.Type == ActivityConfigHelper.ActivityV1_DiamondWeeklyCard)
            {
                weeklycardtime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.DiamondWeeklyCard);
                recvlis = activityComponent.ActivityV1Info.DiamondWeeklyCardRewards;
                if (recvlis.Contains(self.Key))
                {
                    status = 2;
                }
            }

            long servertime = TimeHelper.ServerNow();
            int diffday = ComHelp.GetDaysDiffByDate(servertime, weeklycardtime );

            //过了7天依然可以领取
            if (status != 2 &&  diffday >= 7 && weeklycardtime>0 && servertime > weeklycardtime && recvlis.Count < 7)
            {
                status = 1;
            }
            else
            {
                if (status != 2 && (diffday < rewardlists.Count) && (diffday >= self.Key))
                {
                    status = 1;
                }
                if (diffday >= 7 || servertime < weeklycardtime)
                {
                    status = 3;
                }

            }
            self.ButtonReceive.SetActive(status == 1);
            self.CompleteStatu.SetActive(status == 2);
            self.NoActivatedStatu.SetActive(status == 3);
        }

        public static async ETTask OnReceiveBtn(this UIActivityV1WeeklyCardItemComponent self)
        {
            Log.ILog.Debug($"OnReceiveBtn:  {self.Type}  {self.Key}");

            Scene zonescene = self.ZoneScene();
            ActivityComponent activityComponent = zonescene.GetComponent<ActivityComponent>();
            C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest()
            {
                ActivityType = self.Type ,
                RewardId = self.Key
            };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success || response == null)
            {
                return;
            }
            activityComponent.ActivityV1Info = response.ActivityV1Info;
            if (self.IsDisposed)
            {
                return;
            }
            self.GetParent<UIActivityV1WeeklyCardComponent>().OnWeeklyCardUpdate();
        }
    }
}