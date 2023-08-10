using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIHuntComponent: Entity, IAwake
    {
        public GameObject HuntingTimeText;
        public GameObject HeadImage_No1;
        public GameObject NameText_No1;
        public GameObject HuntNumText_No1;
        public GameObject HuntRankingListNode;
        public GameObject HuntRewardsListNode1;
        public GameObject HuntRewardsListNode2;
        public GameObject HuntRewardsListNode3;
    }

    public class UIHuntComponentAwakesystem: AwakeSystem<UIHuntComponent>
    {
        public override void Awake(UIHuntComponent self)
        {
            self.Awake();
        }
    }

    public static class UIHuntComponentSystem
    {
        public static void Awake(this UIHuntComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.HuntingTimeText = rc.Get<GameObject>("HuntingTimeText");
            self.HeadImage_No1 = rc.Get<GameObject>("HeadImage_No1");
            self.NameText_No1 = rc.Get<GameObject>("NameText_No1");
            self.HuntNumText_No1 = rc.Get<GameObject>("HuntNumText_No1");
            self.HuntRankingListNode = rc.Get<GameObject>("HuntRankingListNode");
            self.HuntRewardsListNode1 = rc.Get<GameObject>("HuntRewardsListNode1");
            self.HuntRewardsListNode2 = rc.Get<GameObject>("HuntRewardsListNode2");
            self.HuntRewardsListNode3 = rc.Get<GameObject>("HuntRewardsListNode3");
            
            self.HeadImage_No1.SetActive(false);
            self.NameText_No1.SetActive(false);
            self.HuntNumText_No1.SetActive(false);

            self.ShowHuntingTime().Coroutine();
            self.ShowHuntRewards().Coroutine();
            self.UpdataRanking().Coroutine();
        }

        /// <summary>
        /// 更新玩家排名信息
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask UpdataRanking(this UIHuntComponent self)
        {
            long instacnid = self.InstanceId;
            C2R_RankShowLieRequest request = new C2R_RankShowLieRequest();
            R2C_RankShowLieResponse response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as R2C_RankShowLieResponse;
            if (response.RankList == null || response.RankList.Count < 1)
            {
                return;
            }

            if (instacnid != self.InstanceId)
            {
                return;
            }

            // 排序
            response.RankList.Sort((x, y) => (int)(y.KillNumber - x.KillNumber));

            // 第一名
            self.HeadImage_No1.SetActive(true);
            self.NameText_No1.SetActive(true);
            self.HuntNumText_No1.SetActive(true);
            self.NameText_No1.GetComponent<Text>().text = response.RankList[0].PlayerName;
            self.HuntNumText_No1.GetComponent<Text>().text = $"狩猎数量:{response.RankList[0].KillNumber}";
            UICommonHelper.ShowOccIcon(self.HeadImage_No1, response.RankList[0].Occ);

            // 其余
            var path = ABPathHelper.GetUGUIPath("Hunt/UIHuntRankingPlayerInfoItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 1; i < response.RankList.Count; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.HuntRankingListNode);
                self.AddChild<UIHuntRankingPlayerInfoItemComponent, GameObject>(go).OnUpdate(response.RankList[i], i + 1);
            }
        }

        /// <summary>
        /// 显示狩猎剩余时间
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask ShowHuntingTime(this UIHuntComponent self)
        {
            while (!self.IsDisposed)
            {
                DateTime nowDateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ClientNow());
                if (nowDateTime.Hour == 21 && nowDateTime.Minute >= 30 && nowDateTime.Minute < 45)
                {
                    self.HuntingTimeText.GetComponent<Text>().text = $"{44 - nowDateTime.Minute}分{60 - nowDateTime.Second}秒";
                }
                else
                {
                    self.HuntingTimeText.GetComponent<Text>().text = "未到活动时间";
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 展示排名奖励
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask ShowHuntRewards(this UIHuntComponent self)
        {
            await ETTask.CompletedTask;
            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(3);
            for (int i = 0; i < rankRewardConfigs.Count; i++)
            {
                if (rankRewardConfigs[i].NeedPoint[0] == 1 && rankRewardConfigs[i].NeedPoint[1] == 1)
                {
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, self.HuntRewardsListNode1, self, 0.9f);
                }
                else if (rankRewardConfigs[i].NeedPoint[0] == 2 && rankRewardConfigs[i].NeedPoint[1] == 3)
                {
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, self.HuntRewardsListNode2, self, 0.9f);
                }
                else if (rankRewardConfigs[i].NeedPoint[0] == 4 && rankRewardConfigs[i].NeedPoint[1] == 10)
                {
                    UICommonHelper.ShowItemList(rankRewardConfigs[i].RewardItems, self.HuntRewardsListNode3, self, 0.9f);
                }
            }
        }
    }
}