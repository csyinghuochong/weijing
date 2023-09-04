using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDemonComponent: Entity, IAwake
    {
        public GameObject RewardsListNode;
        public GameObject Rewards;
        public GameObject EnterBtn;
    }

    public class UIDemonComponentAwakeSystem: AwakeSystem<UIDemonComponent>
    {
        public override void Awake(UIDemonComponent self)
        {
            self.Awake();
        }
    }

    public static class UIDemonComponentSystem
    {
        public static void Awake(this UIDemonComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RewardsListNode = rc.Get<GameObject>("RewardsListNode");
            self.Rewards = rc.Get<GameObject>("Rewards");
            self.EnterBtn = rc.Get<GameObject>("EnterBtn");

            self.ShowRewards();
            self.EnterBtn.GetComponent<Button>().onClick.AddListener(() => self.OnEnterBtn().Coroutine());
        }

        public static void ShowRewards(this UIDemonComponent self)
        {
            // 阵营胜利奖励
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(100);
            ReferenceCollector refer = self.Rewards.GetComponent<ReferenceCollector>();
            refer.Get<GameObject>("TextTip").GetComponent<Text>().text =
                    $"阵营胜利奖励";
            UICommonHelper.ShowItemList(globalValueConfig.Value, refer.Get<GameObject>("RewardsListNode"), self, 0.9f);

            // 积分奖励
            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(5);
            for (int i = 0; i < rankRewardConfigs.Count; i++)
            {
                GameObject go = GameObject.Instantiate(self.Rewards);
                ReferenceCollector re = go.GetComponent<ReferenceCollector>();
                re.Get<GameObject>("TextTip").GetComponent<Text>().text =
                        $"{rankRewardConfigs[i].NeedPoint[0]}~{rankRewardConfigs[i].NeedPoint[1]}积分奖励";
                UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, re.Get<GameObject>("RewardsListNode").gameObject, self, 0.9f);
                UICommonHelper.SetParent(go, self.RewardsListNode);
            }
        }

        public static async ETTask OnEnterBtn(this UIDemonComponent self)
        {
            C2R_RankDemonRequest request = new C2R_RankDemonRequest();
            R2C_RankDemonResponse response = (R2C_RankDemonResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.Demon, BattleHelper.GetSceneIdByType(SceneTypeEnum.Demon)).Coroutine();

            UIHelper.Remove(self.ZoneScene(), UIType.UIDemon);
        }
    }
}