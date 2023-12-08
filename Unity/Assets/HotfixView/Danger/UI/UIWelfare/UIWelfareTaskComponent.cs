using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareTaskComponent: Entity, IAwake,IDestroy
    {
        public GameObject DayProgressImg;
        public GameObject DayListNode;
        public GameObject TaskListNode;
        public GameObject UIWelfareTaskItem;
        public GameObject CompletenessText;
        public GameObject RewardListNode;
        public GameObject ReceivedImg;
        public GameObject ReceiveBtn;

        public int Day;
        public List<UIWelfareTaskItemComponent> UIWelfareTaskItemComponents = new List<UIWelfareTaskItemComponent>();
        public List<string> AssetPath = new List<string>();
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
            self.ReceiveBtn.SetActive(false);
            self.ReceivedImg.SetActive(false);
            self.ReceiveBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnReceiveBtn().Coroutine(); });

            int currentDay = self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay() - 1;
            for (int i = 0; i < self.DayListNode.transform.childCount; i++)
            {
                if (i <= currentDay)
                {
                    Image image = self.DayListNode.transform.GetChild(i).GetComponent<Image>();
                    string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, "Img_82");
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }
                    image.sprite = sp;
                    image.rectTransform.localScale = new Vector3(1.1f, 1.1f, 1f);
                }
                else
                {
                    UICommonHelper.SetImageGray(self.DayListNode.transform.GetChild(i).gameObject, true);
                }
            }

            Button[] buttons = self.DayListNode.GetComponentsInChildren<Button>();
            for (int i = 0; i < buttons.Length; i++)
            {
                int i1 = i;
                buttons[i].onClick.AddListener(() => { self.UpdateInfo(i1); });
            }

            self.UpdateInfo(currentDay);
        }
    }
    public class UIWelfareTaskComponentDestroy: DestroySystem<UIWelfareTaskComponent>
    {
        public override void Destroy(UIWelfareTaskComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }
    public static class UIWelfareTaskComponentSystem
    {
        public static void UpdateInfo(this UIWelfareTaskComponent self, int day)
        {
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();

            int currentDay = self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay() - 1;

            self.DayProgressImg.GetComponent<Image>().fillAmount = currentDay / 6f;

            if (day > currentDay)
            {
                return;
            }

            if (day > 6)
            {
                day = 6;
            }

            self.Day = day;

            int number = 0;
            int commited = 0; // 完成并领取
            List<int> tasks = ConfigHelper.WelfareTaskList[day];
            List<int> roleComoleteTaskList = self.ZoneScene().GetComponent<TaskComponent>().RoleComoleteTaskList;
            for (int i = 0; i < tasks.Count; i++)
            {
                TaskPro taskPro = taskComponent.GetTaskById(tasks[i]);
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(tasks[i]);
                if (taskPro == null && roleComoleteTaskList.Contains(tasks[i]))
                {
                    taskPro = new TaskPro();
                    taskPro.taskID = tasks[i];
                    taskPro.taskTargetNum_1 = taskConfig.TargetValue[0];
                    taskPro.taskStatus = (int)TaskStatuEnum.Commited;
                    Log.Debug($"已完成的任务 {tasks[i]}");
                }

                if (taskPro == null)
                {
                    Log.Error($"未领取的任务 {tasks[i]}");
                    taskPro = new TaskPro();
                    taskPro.taskID = tasks[i];
                    taskPro.taskTargetNum_1 = 0;
                    taskPro.taskStatus = (int)TaskStatuEnum.Accepted;
                }

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

                uiWelfareTaskItemComponent.OnUpdateData(taskPro, day);
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

            self.CompletenessText.GetComponent<Text>().text = $"当天完成度:{commited}/{tasks.Count}";

            UICommonHelper.DestoryChild(self.RewardListNode);
            UICommonHelper.ShowItemList(ConfigHelper.WelfareTaskReward[day], self.RewardListNode, self, 1f);
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

            bool canget = TaskHelper.IsDayTaskComplete(taskComponent.RoleComoleteTaskList, self.Day);
            if (!canget)
            {
                FloatTipManager.Instance.ShowFloatTip("所有任务还没有完成！");
                return;
            }
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.WelfareTaskRewards.Contains(self.Day))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过奖励！");
                return;
            }

            C2M_WelfareTaskRewardRequest request = new C2M_WelfareTaskRewardRequest() { day = self.Day };
            M2C_WelfareTaskRewardResponse response =
                    (M2C_WelfareTaskRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                userInfoComponent.UserInfo.WelfareTaskRewards.Add(self.Day);
            }
            self.ZoneScene().GetComponent<ReddotComponent>().UpdateReddont(ReddotType.WelfareTask);
            self.UpdateInfo(self.Day);
        }
    }
}