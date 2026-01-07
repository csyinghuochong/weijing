using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1PointsShunXuItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject ConsumeNumText;
        public GameObject RewardListNode;
        public GameObject ReceiveBtn;
        public GameObject ReceivedImg;
        public Action OnRecvHandler;

        public int Key;
    }

    public class UIActivityV1PointsShunXuItemComponentAwake : AwakeSystem<UIActivityV1PointsShunXuItemComponent, GameObject>
    {
        public override void Awake(UIActivityV1PointsShunXuItemComponent self, GameObject gameObject)
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

    public static class UIActivityV1PointsShunXuItemComponentSystem
    {
        public static void OnUpdateData(this UIActivityV1PointsShunXuItemComponent self, int key, Action action)
        {
            self.Key = key;
            self.OnRecvHandler = action;
            self.ConsumeNumText.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}积分"), self.Key);
            UICommonHelper.DestoryChild(self.RewardListNode);
            UICommonHelper.ShowItemList(ActivityConfigHelper.PointsShunXuRewardList[key], self.RewardListNode, self, 1f);

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            if (activityV1Info.PointsReward.Contains(self.Key))
            {
                self.ReceiveBtn.SetActive(false);
                self.ReceivedImg.SetActive(true);
            }
        }

        public static async ETTask OnReceiveBtn(this UIActivityV1PointsShunXuItemComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetBagLeftCell() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("背包空间不足"));
                return;
            }

            string rewarditem = ActivityConfigHelper.PointsShunXuRewardList[self.Key];
            int needcell = ItemHelper.GetNeedCell(rewarditem);
            Log.ILog.Debug($"needcell:{needcell}");
            if (self.ZoneScene().GetComponent<BagComponent>().GetBagLeftCell() < needcell)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("背包空间不足"));
                return;
            }

            if (!ActivityConfigHelper.PointsShunXuRewardList.ContainsKey(self.Key))
            {
                return;
            }

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            int getnextRewardId = ActivityConfigHelper.GetNextShunXuReward(activityV1Info.PointsShuxuReward);
            if (getnextRewardId == 0)
            {
                return;
            }
            
            if (self.Key < getnextRewardId)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已经领取"));
                return;
            }

            if (self.Key > getnextRewardId)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请按顺序领取"));
                return;
            }

            int points = (int)(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.V1TotalPoints);
            if (points < self.Key)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("未达到条件"));
                return;
            }

            C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest()
            {
                ActivityType = ActivityConfigHelper.ActivityV1_PointsShunXu,
                RewardId = self.Key
            };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info.PointsShuxuReward = self.Key;

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.ReceiveBtn.SetActive(false);
            self.ReceivedImg.SetActive(true);
            self.OnRecvHandler?.Invoke();
        }
    }
}