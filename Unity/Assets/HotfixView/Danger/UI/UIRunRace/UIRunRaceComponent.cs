using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRunRaceComponent: Entity, IAwake
    {
        public GameObject RewardsListNode;
        public GameObject Rewards;
        public GameObject EnterBtn;
    }

    public class UIRunRaceComponentAwakeSystem: AwakeSystem<UIRunRaceComponent>
    {
        public override void Awake(UIRunRaceComponent self)
        {
            self.Awake();
        }
    }

    public static class UIRunRaceComponentSystem
    {
        public static void Awake(this UIRunRaceComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RewardsListNode = rc.Get<GameObject>("RewardsListNode");
            self.Rewards = rc.Get<GameObject>("Rewards");
            self.EnterBtn = rc.Get<GameObject>("EnterBtn");

            self.ShowHuntRewards();
            self.EnterBtn.GetComponent<Button>().onClick.AddListener(() => self.OnEnterBtn().Coroutine());
        }

        public static void ShowHuntRewards(this UIRunRaceComponent self)
        {
            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(5);

            for (int i = 0; i < rankRewardConfigs.Count; i++)
            {
                if (i == 0)
                {
                    ReferenceCollector re = self.Rewards.GetComponent<ReferenceCollector>();
                    re.Get<GameObject>("TextTip").GetComponent<Text>().text =
                            $"第{rankRewardConfigs[i].NeedPoint[0]}名奖励";
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, re.Get<GameObject>("RewardsListNode"), self, 0.9f);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.Rewards);
                    ReferenceCollector re = go.GetComponent<ReferenceCollector>();
                    re.Get<GameObject>("TextTip").GetComponent<Text>().text =
                            $"第{rankRewardConfigs[i].NeedPoint[0]}~{rankRewardConfigs[i].NeedPoint[1]}名奖励";
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, re.Get<GameObject>("RewardsListNode").gameObject, self, 0.9f);
                    UICommonHelper.SetParent(go, self.RewardsListNode);
                }
            }
        }

        public static async ETTask OnEnterBtn(this UIRunRaceComponent self)
        {
            C2R_RankRunRaceRequest reqeuest = new C2R_RankRunRaceRequest();
            R2C_RankRunRaceResponse r2C_Rank =
                    (R2C_RankRunRaceResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reqeuest);
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.RunRace, BattleHelper.GetSceneIdByType(SceneTypeEnum.RunRace)).Coroutine();
            UIHelper.Remove(self.ZoneScene(), UIType.UIRunRace);
        }
    }
}