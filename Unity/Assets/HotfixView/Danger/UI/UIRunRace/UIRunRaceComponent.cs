using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRunRaceComponent: Entity, IAwake
    {
        public GameObject RewardsListNode1;
        public GameObject RewardsListNode2;
        public GameObject RewardsListNode3;
        public GameObject RewardsListNode4;
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

            self.RewardsListNode1 = rc.Get<GameObject>("RewardsListNode1");
            self.RewardsListNode2 = rc.Get<GameObject>("RewardsListNode2");
            self.RewardsListNode3 = rc.Get<GameObject>("RewardsListNode3");
            self.RewardsListNode4 = rc.Get<GameObject>("RewardsListNode4");
            self.EnterBtn = rc.Get<GameObject>("EnterBtn");

            self.ShowHuntRewards();
            self.EnterBtn.GetComponent<Button>().onClick.AddListener(() => self.OnEnterBtn().Coroutine());
        }

        public static void ShowHuntRewards(this UIRunRaceComponent self)
        {
            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(5);
            for (int i = 0; i < rankRewardConfigs.Count; i++)
            {
                if (rankRewardConfigs[i].NeedPoint[0] == 1 && rankRewardConfigs[i].NeedPoint[1] == 1)
                {
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, self.RewardsListNode1, self, 0.9f);
                }
                else if (rankRewardConfigs[i].NeedPoint[0] == 2 && rankRewardConfigs[i].NeedPoint[1] == 3)
                {
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, self.RewardsListNode2, self, 0.9f);
                }
                else if (rankRewardConfigs[i].NeedPoint[0] == 4 && rankRewardConfigs[i].NeedPoint[1] == 10)
                {
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, self.RewardsListNode3, self, 0.9f);
                }
                else if (rankRewardConfigs[i].NeedPoint[0] == 11 && rankRewardConfigs[i].NeedPoint[1] == 20)
                {
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, self.RewardsListNode4, self, 0.9f);
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