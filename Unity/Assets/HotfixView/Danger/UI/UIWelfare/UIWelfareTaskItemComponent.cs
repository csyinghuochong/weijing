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
        public GameObject ReceiveImg;

        public GameObject GameObject;
        public int TaskConfigId;
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
            self.ReceiveImg = rc.Get<GameObject>("ReceiveImg");

            self.ReceiveBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnReceiveBtn().Coroutine(); });
        }
    }

    public static class UIWelfareTaskItemComponentSystem
    {
        public static void OnUpdateData(this UIWelfareTaskItemComponent self, int taskConfigId, bool canSee)
        {
            self.TaskConfigId = taskConfigId;
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskConfigId);

            self.TaskNameText.GetComponent<Text>().text = taskConfig.TaskName;
            self.TaskDescText.GetComponent<Text>().text = taskConfig.TaskDes;

            if (!ComHelp.IfNull(taskConfig.ItemID))
            {
                UICommonHelper.DestoryChild(self.RewardListNode);
                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = 1, ItemNum = taskConfig.TaskCoin });
                rewardItems.Add(new RewardItem() { ItemID = 2, ItemNum = taskConfig.TaskExp });
                rewardItems.AddRange(TaskHelper.GetTaskRewards(self.TaskConfigId));
                UICommonHelper.ShowItemList(rewardItems, self.RewardListNode, self, 0.8f);
            }

            if (canSee)
            {
                if (!self.ZoneScene().GetComponent<TaskComponent>().RoleComoleteTaskList.Contains(taskConfigId))
                {
                    self.ReceiveBtn.SetActive(true);
                    self.ReceiveImg.SetActive(false);
                }
                else
                {
                    self.ReceiveBtn.SetActive(false);
                    self.ReceiveImg.SetActive(true);
                }
            }
            else
            {
                self.ReceiveBtn.SetActive(false);
                self.ReceiveImg.SetActive(false);
            }
        }

        public static async ETTask OnReceiveBtn(this UIWelfareTaskItemComponent self)
        {
            if (self.ZoneScene().GetComponent<TaskComponent>().RoleComoleteTaskList.Contains(self.TaskConfigId))
            {
                FloatTipManager.Instance.ShowFloatTip("任务已经提交!");
                return;
            }

            int error = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskConfigId, 0);

            if (error == 0)
            {
                self.ReceiveBtn.SetActive(false);
                self.ReceiveImg.SetActive(true);
                self.GetParent<UIWelfareTaskComponent>().UpdateInfo(self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay() - 1).Coroutine();
            }
        }
    }
}