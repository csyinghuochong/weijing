using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1WeeklyCardItemComponent : Entity, IAwake<GameObject>
    {

        public Text TextDayIndex;
        public GameObject ItemRewardList;
        public GameObject ButtonReceive;
        public GameObject CompleteStatu;
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

            List<string> rewardlist = ActivityConfigHelper.ActivityV1WeeklyCardReward[type - ActivityConfigHelper.ActivityV1_GoldWeeklyCard + 1];
            string rewarditem = rewardlist[key];

            UICommonHelper.DestoryChild( self.ItemRewardList );
            UICommonHelper.ShowItemList(rewarditem, self.ItemRewardList, self);
        }

        public static async ETTask OnReceiveBtn(this UIActivityV1WeeklyCardItemComponent self)
        {
            
            C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest()
            {
                ActivityType = self.Type ,
                RewardId = self.Key
            };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info.ConsumeDiamondReward.Add(self.Key);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

          
        }
    }
}