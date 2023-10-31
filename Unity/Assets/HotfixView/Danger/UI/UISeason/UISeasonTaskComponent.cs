using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonTaskComponent: Entity, IAwake
    {
        public GameObject SeasonTaskList;
        public GameObject LinkShowSet;
        public GameObject LinkDi;
        public GameObject UISeasonDayTaskItem;
        public GameObject SeasonDayTaskListNode;
        public GameObject DayTaskScrollView;
        public GameObject SeasonTaskScrollView;
        public GameObject TaskNameText;
        public GameObject ProgressText;
        public GameObject TaskDescText;
        public GameObject RewardListNode;
        public GameObject GetBtn;
        public GameObject AcvityedImg;

        public TaskPro TaskPro;
        public int TaskType;
        public UIPageButtonComponent UIPageButtonComponent;
        public List<UISeasonDayTaskItemComponent> UISeasonDayTaskComponentList = new List<UISeasonDayTaskItemComponent>();
    }

    public class UISeasonTaskComponentAwakeSystem: AwakeSystem<UISeasonTaskComponent>
    {
        public override void Awake(UISeasonTaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.SeasonTaskList = rc.Get<GameObject>("SeasonTaskList");
            self.LinkShowSet = rc.Get<GameObject>("LinkShowSet");
            self.LinkDi = rc.Get<GameObject>("LinkDi");
            self.SeasonDayTaskListNode = rc.Get<GameObject>("SeasonDayTaskListNode");
            self.UISeasonDayTaskItem = rc.Get<GameObject>("UISeasonDayTaskItem");
            self.DayTaskScrollView = rc.Get<GameObject>("DayTaskScrollView");
            self.SeasonTaskScrollView = rc.Get<GameObject>("SeasonTaskScrollView");
            self.TaskNameText = rc.Get<GameObject>("TaskNameText");
            self.ProgressText = rc.Get<GameObject>("ProgressText");
            self.TaskDescText = rc.Get<GameObject>("TaskDescText");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.GetBtn = rc.Get<GameObject>("GetBtn");
            self.AcvityedImg = rc.Get<GameObject>("AcvityedImg");

            self.UISeasonDayTaskItem.SetActive(false);
            self.GetBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnGetBtn(); });

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((page) => { self.OnClickPageButton(page); });
            self.UIPageButtonComponent = uIPageViewComponent;
            self.UIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UISeasonTaskComponentSystem
    {
        public static void OnClickPageButton(this UISeasonTaskComponent self, int page)
        {
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            if (page == 0)
            {
                self.TaskType = 0;
                self.SeasonTaskScrollView.SetActive(true);
                self.DayTaskScrollView.SetActive(false);
                //赛季任务。  主任务面板要屏蔽赛季任务
                //服务器只记录当前的赛季任务。 小于此任务id的为已完成任务, 客户端需要显示所有的赛季任务
                //C2M_TaskCommitRequest         提交任务
                List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().RoleTaskList;
                for (int i = 0; i < taskPros.Count; i++)
                {
                    TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPros[i].taskID);
                    if (taskConfig.TaskType == TaskTypeEnum.Season)
                    {
                        self.TaskPro = taskPros[i];
                    }
                }

                int index = 0;
                foreach (TaskConfig taskConfig in TaskConfigCategory.Instance.GetAll().Values)
                {
                    if (taskConfig.TaskType == TaskTypeEnum.Season)
                    {
                        self.SeasonTaskList.transform.GetChild(index).GetComponent<Button>().onClick.AddListener(() =>
                        {
                            self.UpdateInfo(taskConfig.Id);
                        });
                        // self.SeasonTaskList.transform.GetChild(index).GetComponentInChildren<Text>().text = taskConfig.Id.ToString();
                        if (taskConfig.Id < self.TaskPro.taskID)
                        {
                            self.SeasonTaskList.transform.GetChild(index).GetComponent<Text>().text = "已完成";
                            self.LinkShowSet.transform.GetChild(index).gameObject.SetActive(true);
                        }
                        else
                        {
                            self.LinkShowSet.transform.GetChild(index).gameObject.SetActive(false);
                        }
                        

                        index++;
                    }
                }

                if (self.TaskPro != null)
                {
                    self.UpdateInfo(self.TaskPro.taskID);
                }

                for (int i = index; i < self.SeasonTaskList.transform.childCount; i++)
                {
                    self.SeasonTaskList.transform.GetChild(i).gameObject.SetActive(false);
                }

                for (int i = index; i < self.LinkShowSet.transform.childCount; i++)
                {
                    self.LinkShowSet.transform.GetChild(i).gameObject.SetActive(false);
                }

                for (int i = index; i < self.LinkDi.transform.childCount; i++)
                {
                    self.LinkDi.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            else
            {
                self.TaskType = 1;
                self.SeasonTaskScrollView.SetActive(false);
                self.DayTaskScrollView.SetActive(true);
                //赛季每日任务
                List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().TaskCountryList;
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
                    if (taskConfig.TaskType != TaskCountryType.Season)
                    {
                        continue;
                    }

                    UISeasonDayTaskItemComponent ui_1 = null;
                    if (number < self.UISeasonDayTaskComponentList.Count)
                    {
                        ui_1 = self.UISeasonDayTaskComponentList[number];
                        ui_1.GameObject.SetActive(true);
                    }
                    else
                    {
                        GameObject taskTypeItem = GameObject.Instantiate(self.UISeasonDayTaskItem);
                        taskTypeItem.SetActive(true);
                        UICommonHelper.SetParent(taskTypeItem, self.SeasonDayTaskListNode);
                        ui_1 = self.AddChild<UISeasonDayTaskItemComponent, GameObject>(taskTypeItem);
                        self.UISeasonDayTaskComponentList.Add(ui_1);
                    }

                    ui_1.OnUpdateData(taskPros[i]);
                    number++;
                }

                for (int k = number; k < self.UISeasonDayTaskComponentList.Count; k++)
                {
                    self.UISeasonDayTaskComponentList[k].GameObject.SetActive(false);
                }

                if (self.UISeasonDayTaskComponentList.Count > 0)
                {
                    self.UpdateInfo(self.UISeasonDayTaskComponentList[0].TaskPro);
                }
            }
        }

        public static void UpdateInfo(this UISeasonTaskComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;
            TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPro.taskID);

            self.TaskNameText.GetComponent<Text>().text = taskConfig.TaskName;
            self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " +
                    string.Format("{0}/{1}", taskPro.taskTargetNum_1, taskConfig.TargetValue);

            self.TaskDescText.GetComponent<Text>().text = taskConfig.TaskDes;
            if (!ComHelp.IfNull(taskConfig.RewardItem))
            {
                UICommonHelper.DestoryChild(self.RewardListNode);
                UICommonHelper.ShowItemList(taskConfig.RewardItem, self.RewardListNode, self, 0.8f, true);
            }

            self.AcvityedImg.SetActive(taskPro.taskStatus == (int)TaskStatuEnum.Commited);
            self.GetBtn.SetActive(taskPro.taskStatus != (int)TaskStatuEnum.Commited);
        }

        public static void UpdateInfo(this UISeasonTaskComponent self, int taskId)
        {
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskId);
            self.TaskNameText.GetComponent<Text>().text = taskConfig.TaskName;
            if (taskId < self.TaskPro.taskID)
            {
                self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " +
                        string.Format("{0}/{1}", taskConfig.TargetValue, taskConfig.TargetValue[0]);
                self.AcvityedImg.SetActive(true);
                self.GetBtn.SetActive(false);
            }
            else if (taskId == self.TaskPro.taskID)
            {
                self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " +
                        string.Format("{0}/{1}", self.TaskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
                self.AcvityedImg.SetActive(self.TaskPro.taskStatus == (int)TaskStatuEnum.Commited);
                self.GetBtn.SetActive(self.TaskPro.taskStatus != (int)TaskStatuEnum.Commited);
            }
            else
            {
                self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " +
                        string.Format("{0}/{1}", 0, taskConfig.TargetValue[0]);
                self.AcvityedImg.SetActive(false);
                self.GetBtn.SetActive(false);
            }

            self.TaskDescText.GetComponent<Text>().text = taskConfig.TaskDes;
            if (!ComHelp.IfNull(taskConfig.ItemID))
            {
                UICommonHelper.DestoryChild(self.RewardListNode);
                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = 1, ItemNum = taskConfig.TaskCoin });
                rewardItems.Add(new RewardItem() { ItemID = 2, ItemNum = taskConfig.TaskExp });
                rewardItems.AddRange(TaskHelper.GetTaskRewards(taskId));
                UICommonHelper.ShowItemList(rewardItems, self.RewardListNode, self, 0.8f);
            }
        }

        public static  void OnGetBtn(this UISeasonTaskComponent self)
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

            if (self.TaskType == 0)
            {
                self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskPro.taskID, 0).Coroutine();
            }
            else
            {
                self.ZoneScene().GetComponent<TaskComponent>().SendCommitTaskCountry(self.TaskPro.taskID).Coroutine();
            }
        }
    }
}