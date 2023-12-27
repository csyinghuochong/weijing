using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1ChouKaItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject ClickBtn;
        public GameObject NumText;
        public GameObject RewardListNode;
        public GameObject ReceivedImg;

        public int Key;
    }

    public class UIActivityV1ChouKaItemComponentAwakeSystem: AwakeSystem<UIActivityV1ChouKaItemComponent, GameObject>
    {
        public override void Awake(UIActivityV1ChouKaItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ClickBtn = rc.Get<GameObject>("ClickBtn");
            self.NumText = rc.Get<GameObject>("NumText");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.ReceivedImg = rc.Get<GameObject>("ReceivedImg");

            self.ClickBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn().Coroutine(); });
        }
    }

    public static class UIActivityV1ChouKaItemComponentSystem
    {
        public static void OnUpdateData(this UIActivityV1ChouKaItemComponent self, int key)
        {
            self.Key = key;
            self.NumText.GetComponent<Text>().text = $"今日抽奖次数x{key}";
            UICommonHelper.ShowItemList(ActivityConfigHelper.ChouKaNumberReward[key], self.RewardListNode, self, 0.8f);

            self.ReceivedImg.SetActive(self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info.ChouKaNumberReward.Contains(self.Key));
        }

        public static async ETTask OnClickBtn(this UIActivityV1ChouKaItemComponent self)
        {
            if (!ActivityConfigHelper.ChouKaNumberReward.ContainsKey(self.Key))
            {
                return;
            }

            if (self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info.ChouKaNumberReward.Contains(self.Key))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取");
                return;
            }

            if (UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.V1ChouKaNumber) <
                self.Key)
            {
               FloatTipManager.Instance.ShowFloatTip("前置条件不足");
                return;
            }

            C2M_ActivityRewardRequest request =
                    new C2M_ActivityRewardRequest() { ActivityType = ActivityConfigHelper.ActivityV1_ChouKa, RewardId = self.Key };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.ReceivedImg.SetActive(true);
        }
    }
}