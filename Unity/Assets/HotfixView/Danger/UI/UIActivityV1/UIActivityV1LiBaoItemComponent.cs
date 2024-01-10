using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1LiBaoItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject ConsumeNumText;
        public GameObject RewardListNode;
        public GameObject ReceiveBtn;
        public GameObject ReceivedImg;

        public int Key;
    }

    public class UIActivityV1LiBaoItemComponentAwakeSystem: AwakeSystem<UIActivityV1LiBaoItemComponent, GameObject>
    {
        public override void Awake(UIActivityV1LiBaoItemComponent self, GameObject gameObject)
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

    public static class UIActivityV1LiBaoItemComponentSystem
    {
        public static void OnUpdateData(this UIActivityV1LiBaoItemComponent self, int key)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            KeyValuePair keyValuePair = ActivityConfigHelper.LiBaoList[key];

            self.Key = key;
            self.ConsumeNumText.GetComponent<Text>().text = $"钻石:{keyValuePair.Value.Split(';')[1]}";
            UICommonHelper.DestoryChild(self.RewardListNode);
            UICommonHelper.ShowItemList(keyValuePair.Value2, self.RewardListNode, self, 0.8f);

            if (activityV1Info.LiBaoBuyIds.Contains(self.Key))
            {
                self.ReceiveBtn.SetActive(false);
                self.ReceivedImg.SetActive(true);
            }
        }

        public static async ETTask OnReceiveBtn(this UIActivityV1LiBaoItemComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetBagLeftSpace() < 6)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足");
                return;
            }

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            if (!activityV1Info.LiBaoAllIds.Contains(self.Key))
            {
                return;
            }

            if (activityV1Info.LiBaoBuyIds.Contains(self.Key))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取");
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (!bagComponent.CheckNeedItem(ActivityConfigHelper.LiBaoList[self.Key].Value))
            {
                FloatTipManager.Instance.ShowFloatTip("未达到条件");
                return;
            }

            C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest()
            {
                ActivityType = ActivityConfigHelper.ActivityV1_LiBao, RewardId = self.Key
            };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.ReceiveBtn.SetActive(false);
            self.ReceivedImg.SetActive(true);
        }
    }
}