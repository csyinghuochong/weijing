using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1WeeklyCardItemComponent : Entity, IAwake<GameObject>
    {

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

         
            //self.ReceiveBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnReceiveBtn().Coroutine(); });
        }
    }

    public static class UIActivityV1WeeklyCardItemComponentSystem
    {
        public static void OnUpdateData(this UIActivityV1WeeklyCardItemComponent self, int type, int key)
        {
            self.Type = type;
            self.Key = key;
           
        }

        public static async ETTask OnReceiveBtn(this UIActivityV1WeeklyCardItemComponent self)
        {
            
            C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest()
            {
                ActivityType = ActivityConfigHelper.ActivityV1_Consume,
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