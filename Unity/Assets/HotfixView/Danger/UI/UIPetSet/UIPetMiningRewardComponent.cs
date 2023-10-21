using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningRewardComponent : Entity, IAwake
    {
        public GameObject ImageClose;

        public GameObject BuildingList2;
        public GameObject UIPetMiningRewardItem;

        public List<UIPetMiningRewardItemComponent> RewardItemList = new List<UIPetMiningRewardItemComponent>();
    }

    public class UIPetMiningRewardComponentAwake : AwakeSystem<UIPetMiningRewardComponent>
    {
        public override void Awake(UIPetMiningRewardComponent self)
        {
            self.RewardItemList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImageClose = rc.Get<GameObject>("ImageClose");
            self.ImageClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetMiningReward );  });

            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");
            self.UIPetMiningRewardItem = rc.Get<GameObject>("UIPetMiningRewardItem");
            self.UIPetMiningRewardItem.SetActive(false);

            self.OnInitUI();
        }
    }

    public static class UIPetMiningRewardComponentSystem
    {
        public static void OnInitUI(this UIPetMiningRewardComponent self)
        {
            //foreach (var item in keyValuePairs)
            //{
            //    GameObject gameObject = GameObject.Instantiate( self.UIPetMiningRewardItem);
            //    gameObject.SetActive(true);
            //    UICommonHelper.SetParent(gameObject, self.BuildingList2);

            //    UIPetMiningRewardItemComponent uIPetMining = self.AddChild<UIPetMiningRewardItemComponent, GameObject>(gameObject);
            //    uIPetMining.OnInitUI( item.Key, item.Value );
            //    self.RewardItemList.Add(uIPetMining);   
            //}

            List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().TaskCountryList;
            taskPros.Sort(delegate (TaskPro a, TaskPro b)
            {
                int commita = a.taskStatus == (int)TaskStatuEnum.Commited ? 1 : 0;
                int commitb = b.taskStatus == (int)TaskStatuEnum.Commited ? 1 : 0;
                int completea = a.taskStatus == (int)TaskStatuEnum.Completed ? 1 : 0;
                int completeb = b.taskStatus == (int)TaskStatuEnum.Completed ? 1 : 0;

                if (commita == commitb)
                    return completeb - completea;       //可以领取的在前
                else
                    return commitb - commita;           //已经完成的在前
            });

            int number = 0;
            for (int i = 0; i < taskPros.Count; i++)
            {
                TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPros[i].taskID);
                if (taskConfig.TaskType != TaskCountryType.Mine)
                {
                    continue;
                }

                UIPetMiningRewardItemComponent ui_1 = null;
                if (number < self.RewardItemList.Count)
                {
                    ui_1 = self.RewardItemList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(self.UIPetMiningRewardItem);
                    taskTypeItem.SetActive(true);
                    UICommonHelper.SetParent(taskTypeItem, self.BuildingList2);
                    ui_1 = self.AddChild<UIPetMiningRewardItemComponent, GameObject>(taskTypeItem);
                    self.RewardItemList.Add(ui_1);
                }

                ui_1.OnInitUI(taskPros[i]);
                number++;
            }
        }
    }
}