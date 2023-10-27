using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareTaskItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject IconImg;
        public GameObject TaskNameText;
        public GameObject TaskDescText;
        public GameObject RewardListNode;
        public GameObject ReceiveBtn;
        public GameObject ReceivedImg;

        public GameObject GameObject;
        public TaskPro TaskPro;
        public int Day;
    }

    public class UIWelfareTaskItemComponentAwakeSystem: AwakeSystem<UIWelfareTaskItemComponent, GameObject>
    {
        public override void Awake(UIWelfareTaskItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.IconImg = rc.Get<GameObject>("IconImg");
            self.TaskNameText = rc.Get<GameObject>("TaskNameText");
            self.TaskDescText = rc.Get<GameObject>("TaskDescText");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.ReceiveBtn = rc.Get<GameObject>("ReceiveBtn");
            self.ReceivedImg = rc.Get<GameObject>("ReceivedImg");

            self.ReceiveBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnReceiveBtn().Coroutine(); });
        }
    }

    public static class UIWelfareTaskItemComponentSystem
    {
        public static void OnUpdateData(this UIWelfareTaskItemComponent self, TaskPro taskPro, int day)
        {
            self.TaskPro = taskPro;
            self.Day = day;
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);

            self.TaskNameText.GetComponent<Text>().text = taskConfig.TaskName;
            self.TaskDescText.GetComponent<Text>().text = taskConfig.TaskDes;

            if (!ComHelp.IfNull(taskConfig.ItemID))
            {
                UICommonHelper.DestoryChild(self.RewardListNode);
                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = 1, ItemNum = taskConfig.TaskCoin });
                rewardItems.Add(new RewardItem() { ItemID = 2, ItemNum = taskConfig.TaskExp });
                rewardItems.AddRange(TaskHelper.GetTaskRewards(taskPro.taskID));
                UICommonHelper.ShowItemList(rewardItems, self.RewardListNode, self, 0.8f);
            }

            self.ReceiveBtn.SetActive(taskPro.taskStatus != (int)TaskStatuEnum.Commited);
            self.ReceivedImg.SetActive(taskPro.taskStatus == (int)TaskStatuEnum.Commited);
        }

        public static async ETTask OnReceiveBtn(this UIWelfareTaskItemComponent self)
        {
            if (self.TaskPro.taskStatus < (int)TaskStatuEnum.Completed)
            {
                FloatTipManager.Instance.ShowFloatTip("任务还没有完成！");
                return;
            }

            if (self.TaskPro.taskStatus == (int)TaskStatuEnum.Commited)
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过奖励！");
                return;
            }

            int error = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskPro.taskID, 0);

            if (error == 0)
            {
                self.GetParent<UIWelfareTaskComponent>().UpdateInfo(self.Day);
            }
        }
    }
}