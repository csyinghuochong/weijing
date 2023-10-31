using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareTaskComponent: Entity, IAwake
    {
        public GameObject DayProgressImg;
        public GameObject DayListNode;
        public GameObject TaskListNode;
        public GameObject UIWelfareTaskItem;
        public GameObject CompletenessText;
        public GameObject RewardListNode;
        public GameObject ReceivedImg;
        public GameObject ReceiveBtn;
        public List<UIWelfareTaskItemComponent> UIWelfareTaskItemComponents = new List<UIWelfareTaskItemComponent>();
    }

    public class UIWelfareTaskComponentAwakeSystem: AwakeSystem<UIWelfareTaskComponent>
    {
        public override void Awake(UIWelfareTaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.DayProgressImg = rc.Get<GameObject>("DayProgressImg");
            self.DayListNode = rc.Get<GameObject>("DayListNode");
            self.TaskListNode = rc.Get<GameObject>("TaskListNode");
            self.UIWelfareTaskItem = rc.Get<GameObject>("UIWelfareTaskItem");
            self.CompletenessText = rc.Get<GameObject>("CompletenessText");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.ReceivedImg = rc.Get<GameObject>("ReceivedImg");
            self.ReceiveBtn = rc.Get<GameObject>("ReceiveBtn");

            self.UIWelfareTaskItem.SetActive(false);
            self.ReceiveBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnReceiveBtn().Coroutine(); });
            Button[] buttons = self.DayListNode.GetComponentsInChildren<Button>();
            for (int i = 0; i < buttons.Length; i++)
            {
                int i1 = i;
                buttons[i].onClick.AddListener(() => { self.UpdateInfo(i1); });
            }

            self.UpdateInfo(self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay() - 1);
        }
    }

    public static class UIWelfareTaskComponentSystem
    {
        public static void UpdateInfo(this UIWelfareTaskComponent self, int day)
        {
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();

            int currentDay = self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay() - 1;

            self.DayProgressImg.GetComponent<Image>().fillAmount = currentDay / 6f;

            if (day > currentDay || currentDay > 6)
            {
                return;
            }

            int number = 0;
            int commited = 0; // 完成并领取
            List<int> tasks = ConfigHelper.WelfareTaskList[day];
            List<int> roleComoleteTaskList = self.ZoneScene().GetComponent<TaskComponent>().RoleComoleteTaskList;
            for (int i = 0; i < tasks.Count; i++)
            {
                UIWelfareTaskItemComponent uiWelfareTaskItemComponent = null;
                if (number < self.UIWelfareTaskItemComponents.Count)
                {
                    uiWelfareTaskItemComponent = self.UIWelfareTaskItemComponents[number];
                    uiWelfareTaskItemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskItem = GameObject.Instantiate(self.UIWelfareTaskItem);
                    taskItem.SetActive(true);
                    UICommonHelper.SetParent(taskItem, self.TaskListNode);
                    uiWelfareTaskItemComponent = self.AddChild<UIWelfareTaskItemComponent, GameObject>(taskItem);
                    self.UIWelfareTaskItemComponents.Add(uiWelfareTaskItemComponent);
                }

                uiWelfareTaskItemComponent.OnUpdateData(taskComponent.GetTaskById(tasks[i]), day);
                number++;

                if (roleComoleteTaskList.Contains(tasks[i]))
                {
                    commited++;
                }
            }

            for (int k = number; k < self.UIWelfareTaskItemComponents.Count; k++)
            {
                self.UIWelfareTaskItemComponents[k].GameObject.SetActive(false);
            }

            self.CompletenessText.GetComponent<Text>().text = $"完成度:{commited}/{tasks.Count}";

            UICommonHelper.DestoryChild(self.RewardListNode);
            UICommonHelper.ShowItemList(ConfigHelper.WelfareTaskReward[day], self.RewardListNode, self, 0.8f);

            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.WelfareTaskRewards.Contains(day))
            {
                self.ReceiveBtn.SetActive(false);
                self.ReceivedImg.SetActive(true);
            }
            else
            {
                self.ReceiveBtn.SetActive(true);
                self.ReceivedImg.SetActive(false);
            }
        }

        public static async ETTask OnReceiveBtn(this UIWelfareTaskComponent self)
        {
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            int currentDay = self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay() - 1;
            bool canget = TaskHelper.IsDayTaskComplete(taskComponent.RoleComoleteTaskList, currentDay);
            if (!canget)
            {
                FloatTipManager.Instance.ShowFloatTip("所有任务还没有完成！");
                return;
            }

            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.WelfareTaskRewards.Contains(currentDay))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过奖励！");
                return;
            }

            C2M_WelfareTaskRewardRequest request = new C2M_WelfareTaskRewardRequest() { day = currentDay };
            M2C_WelfareTaskRewardResponse response =
                    (M2C_WelfareTaskRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.UpdateInfo(currentDay);
        }
    }
}