using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1ConsumeItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject ConsumeNumText;
        public GameObject RewardListNode;
        public GameObject ReceiveBtn;
        public GameObject ReceivedImg;

        public int Key;
    }

    public class UIActivityV1ConsumeItemComponentAwakeSystem: AwakeSystem<UIActivityV1ConsumeItemComponent, GameObject>
    {
        public override void Awake(UIActivityV1ConsumeItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ConsumeNumText = rc.Get<GameObject>("ConsumeNumText");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.ReceiveBtn = rc.Get<GameObject>("ReceiveBtn");
            self.ReceivedImg = rc.Get<GameObject>("ReceivedImg");

            self.ReceivedImg.SetActive(false);
            self.ReceiveBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnReceiveBtn().Coroutine(); });
        }
    }

    public static class UIActivityV1ConsumeItemComponentSystem
    {
        public static void OnUpdateData(this UIActivityV1ConsumeItemComponent self, int key)
        {
            self.Key = key;
            self.ConsumeNumText.GetComponent<Text>().text = $"{self.Key}钻石";
            UICommonHelper.DestoryChild(self.RewardListNode);
            UICommonHelper.ShowItemList(ActivityConfigHelper.ConsumeDiamondReward[key], self.RewardListNode, self, 0.8f);

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            if (activityV1Info.ConsumeDiamondReward.Contains(self.Key))
            {
                self.ReceiveBtn.SetActive(false);
                self.ReceivedImg.SetActive(true);
            }
        }

        public static async ETTask OnReceiveBtn(this UIActivityV1ConsumeItemComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetBagLeftCell() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足");
                return;
            }

            if (!ActivityConfigHelper.ConsumeDiamondReward.ContainsKey(self.Key))
            {
                return;
            }

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            if (activityV1Info.ConsumeDiamondReward.Contains(self.Key))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取");
                return;
            }

            if (UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsLong(NumericType.V1DayCostDiamond) <
                self.Key)
            {
                FloatTipManager.Instance.ShowFloatTip("未达到条件");
                return;
            }

            C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest()
            {
                ActivityType = ActivityConfigHelper.ActivityV1_Consume, RewardId = self.Key
            };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info.ConsumeDiamondReward.Add(self.Key);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.ReceiveBtn.SetActive(false);
            self.ReceivedImg.SetActive(true);
        }
    }
}