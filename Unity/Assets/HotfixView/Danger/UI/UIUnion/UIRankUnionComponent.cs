using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankUnionComponent: Entity, IAwake, IDestroy
    {
        public GameObject TaskListNode;
        public GameObject RankingListNode;
        public GameObject RewardsListNode1;
        public GameObject RewardsListNode2;
        public GameObject RewardsListNode3;
        public string AssetPath = string.Empty;


        public List<UIHuntTaskItemComponent> TaskList = new List<UIHuntTaskItemComponent>();
    }

    public class UIRankUnionComponentDestroy : DestroySystem<UIRankUnionComponent>
    {
        public override void Destroy(UIRankUnionComponent self)
        {
            if (!string.IsNullOrEmpty(self.AssetPath))
            {
                ResourcesComponent.Instance.UnLoadAsset(self.AssetPath);
            }
        }
    }


    public class UIRankUnionComponentAwakeSystem: AwakeSystem<UIRankUnionComponent>
    {
        public override void Awake(UIRankUnionComponent self)
        {
            self.Awake();
        }
    }

    public static class UIRanUnionComponentSystem
    {
        public static void Awake(this UIRankUnionComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TaskListNode = rc.Get<GameObject>("TaskListNode");
            self.RankingListNode = rc.Get<GameObject>("RankingListNode");
            self.RewardsListNode1 = rc.Get<GameObject>("RewardsListNode1");
            self.RewardsListNode2 = rc.Get<GameObject>("RewardsListNode2");
            self.RewardsListNode3 = rc.Get<GameObject>("RewardsListNode3");

            self.UpdateRanking().Coroutine();
            self.ShowHuntRewards();
            self.UpdateTaskCountrys();
        }

        public static async ETTask UpdateRanking(this UIRankUnionComponent self)
        {
            long instacnid = self.InstanceId;
            C2R_RankUnionRaceRequest request = new C2R_RankUnionRaceRequest();
            R2C_RankUnionRaceResponse response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as R2C_RankUnionRaceResponse;
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

            var path = ABPathHelper.GetUGUIPath("Main/Union/UIRankUnionItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            self.AssetPath = path;
            for (int i = 0; i < response.RankList.Count; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.RankingListNode);
                self.AddChild<UIRankUnionItemComponent, GameObject>(go).OnUpdate(response.RankList[i], i + 1);
            }
        }

        public static void ShowHuntRewards(this UIRankUnionComponent self)
        {
            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(4);
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
            }
        }
         public static void UpdateTaskCountrys(this UIRankUnionComponent self)
        {
            List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().TaskCountryList;
            string path = ABPathHelper.GetUGUIPath("Main/Union/UIRankUnionTaskItem");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            taskPros.Sort(delegate(TaskPro a, TaskPro b)
            {
                int commita = a.taskStatus == (int)TaskStatuEnum.Commited? 1 : 0;
                int commitb = b.taskStatus == (int)TaskStatuEnum.Commited? 1 : 0;
                int completea = a.taskStatus == (int)TaskStatuEnum.Completed? 1 : 0;
                int completeb = b.taskStatus == (int)TaskStatuEnum.Completed? 1 : 0;

                if (commita == commitb)
                    return completeb - completea; //可以领取的在前
                else
                    return commitb - commita; //已经完成的在前
            });

            int number = 0;
            for (int i = 0; i < taskPros.Count; i++)
            {
                TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPros[i].taskID);
                if (taskConfig.TaskType != TaskCountryType.UnionRace)
                {
                    continue;
                }

                UIHuntTaskItemComponent ui_1 = null;
                if (number < self.TaskList.Count)
                {
                    ui_1 = self.TaskList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.TaskListNode);
                    ui_1 = self.AddChild<UIHuntTaskItemComponent, GameObject>(taskTypeItem);
                    self.TaskList.Add(ui_1);
                }

                ui_1.OnUpdateData(taskPros[i]);
                number++;
            }

            for (int k = number; k < self.TaskList.Count; k++)
            {
                self.TaskList[k].GameObject.SetActive(false);
            }
        }
    }
}