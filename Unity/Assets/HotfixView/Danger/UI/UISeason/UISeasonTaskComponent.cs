using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonTaskComponent: Entity, IAwake
    {
        public GameObject SeasonTaskListNode;
        public GameObject UISeasonTaskItem;
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

        public TaskPro TaskPro; // 进行中的赛季任务 或 选中的每日任务
        public int TaskType;
        public int CompeletTaskId;
        public UIPageButtonComponent UIPageButtonComponent;
        public List<UISeasonTaskItemComponent> UISeasonTaskItemComponentList = new List<UISeasonTaskItemComponent>();
        public List<UISeasonDayTaskItemComponent> UISeasonDayTaskItemComponentList = new List<UISeasonDayTaskItemComponent>();
    }

    public class UISeasonTaskComponentAwakeSystem: AwakeSystem<UISeasonTaskComponent>
    {
        public override void Awake(UISeasonTaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.SeasonTaskListNode = rc.Get<GameObject>("SeasonTaskListNode");
            self.UISeasonTaskItem = rc.Get<GameObject>("UISeasonTaskItem");
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

            self.UISeasonTaskItem.SetActive(false);
            self.UISeasonDayTaskItem.SetActive(false);
            self.GetBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnGetBtn().Coroutine(); });

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
            if (page == 0)
            {
                self.TaskType = 0;
                self.SeasonTaskScrollView.SetActive(true);
                self.DayTaskScrollView.SetActive(false);
                //赛季任务。  主任务面板要屏蔽赛季任务
                //服务器只记录当前的赛季任务。 小于此任务id的为已完成任务, 客户端需要显示所有的赛季任务
                self.CompeletTaskId =
                        (int)UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>()[NumericType.SeasonTask];
                List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().RoleTaskList;
                for (int i = 0; i < taskPros.Count; i++)
                {
                    TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPros[i].taskID);
                    if (taskConfig.TaskType == TaskTypeEnum.Season)
                    {
                        self.TaskPro = taskPros[i];
                        break;
                    }
                }

                // 玩家身上没有赛季任务则可以任务全部完成
                if (self.TaskPro == null && self.CompeletTaskId > 0)
                {
                    self.TaskPro = new TaskPro() { taskID = self.CompeletTaskId };
                }

                int count = 0;
                Vector3 lastPosition = new Vector3(-250, 0, 0);
                int dre = 1;
                foreach (TaskConfig taskConfig in TaskConfigCategory.Instance.GetAll().Values)
                {
                    if (taskConfig.TaskType == TaskTypeEnum.Season && taskConfig.Id <= self.TaskPro.taskID)
                    {
                        if (count != 0)
                        {
                            lastPosition.x += 250 * dre;
                        }

                        if (count / 2 % 2 == 0)
                        {
                            dre = 1;
                        }
                        else
                        {
                            dre = -1;
                        }

                        if (count >= self.UISeasonTaskItemComponentList.Count)
                        {
                            GameObject go = UnityEngine.Object.Instantiate(self.UISeasonTaskItem);
                            UISeasonTaskItemComponent ui = self.AddChild<UISeasonTaskItemComponent, GameObject>(go);
                            self.UISeasonTaskItemComponentList.Add(ui);
                            go.SetActive(true);
                            UICommonHelper.SetParent(go, self.SeasonTaskListNode);

                            ui.Item.GetComponent<RectTransform>().localPosition = lastPosition;
                            if (dre == 1)
                            {
                                ui.Img_line.GetComponent<RectTransform>().localPosition = new Vector3(87, -42, 0);
                                ui.Img_line.GetComponent<RectTransform>().transform.Rotate(0, 0, 150);
                            }
                            else
                            {
                                ui.Img_line.GetComponent<RectTransform>().localPosition = new Vector3(-124, -64, 0);
                                ui.Img_line.GetComponent<RectTransform>().transform.Rotate(0, 0, -150);
                            }
                        }

                        self.UISeasonTaskItemComponentList[count].OnUpdateData(taskConfig.Id);

                        count++;
                    }
                }

                self.UpdateInfo(self.TaskPro.taskID);

                // 尾巴隐藏
                if (self.UISeasonTaskItemComponentList.Count > 0)
                {
                    self.UISeasonTaskItemComponentList[self.UISeasonTaskItemComponentList.Count - 1].Img_line.SetActive(false);
                }

                // 滑动到底部
                self.SeasonTaskScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 0;
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
                    if (number < self.UISeasonDayTaskItemComponentList.Count)
                    {
                        ui_1 = self.UISeasonDayTaskItemComponentList[number];
                        ui_1.GameObject.SetActive(true);
                    }
                    else
                    {
                        GameObject taskTypeItem = GameObject.Instantiate(self.UISeasonDayTaskItem);
                        taskTypeItem.SetActive(true);
                        UICommonHelper.SetParent(taskTypeItem, self.SeasonDayTaskListNode);
                        ui_1 = self.AddChild<UISeasonDayTaskItemComponent, GameObject>(taskTypeItem);
                        self.UISeasonDayTaskItemComponentList.Add(ui_1);
                    }

                    ui_1.OnUpdateData(taskPros[i]);
                    number++;
                }

                for (int k = number; k < self.UISeasonDayTaskItemComponentList.Count; k++)
                {
                    self.UISeasonDayTaskItemComponentList[k].GameObject.SetActive(false);
                }

                if (self.UISeasonDayTaskItemComponentList.Count > 0)
                {
                    self.UpdateInfo(self.UISeasonDayTaskItemComponentList[0].TaskPro);
                }
            }
        }

        /// <summary>
        /// 赛季每日任务信息
        /// </summary>
        /// <param name="self"></param>
        /// <param name="taskPro"></param>
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

        /// <summary>
        /// 赛季任务信息
        /// </summary>
        /// <param name="self"></param>
        /// <param name="taskId"></param>
        /// <param name="index"></param>
        public static void UpdateInfo(this UISeasonTaskComponent self, int taskId)
        {
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskId);
            self.TaskNameText.GetComponent<Text>().text = taskConfig.TaskName;
            if (taskId < self.TaskPro.taskID || (taskId == self.TaskPro.taskID && taskId == self.CompeletTaskId))
            {
                self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " +
                        string.Format("{0}/{1}", taskConfig.TargetValue[0], taskConfig.TargetValue[0]);
                self.AcvityedImg.SetActive(true);
                self.GetBtn.SetActive(false);
            }
            else
            {
                self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " +
                        string.Format("{0}/{1}", self.TaskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
                self.AcvityedImg.SetActive(self.TaskPro.taskStatus == (int)TaskStatuEnum.Commited);
                self.GetBtn.SetActive(self.TaskPro.taskStatus != (int)TaskStatuEnum.Commited);
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

            for (int i = 0; i < self.UISeasonTaskItemComponentList.Count; i++)
            {
                self.UISeasonTaskItemComponentList[i].Selected(taskId);
            }
        }

        public static async ETTask OnGetBtn(this UISeasonTaskComponent self)
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
                await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskPro.taskID, 0);
                self.OnClickPageButton(self.TaskType);
            }
            else
            {
                int error = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTaskCountry(self.TaskPro.taskID);
                if (error == ErrorCode.ERR_Success)
                {
                    self.AcvityedImg.SetActive(true);
                    self.GetBtn.SetActive(false);
                }
            }
        }
    }
}