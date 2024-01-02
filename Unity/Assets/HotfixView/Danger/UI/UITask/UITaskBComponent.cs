using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITaskBComponent: Entity, IAwake
    {
        public GameObject UITaskBItemListNode;
        public GameObject UITaskBItem;
        public GameObject TaskNameText;
        public GameObject ProgressText;
        public GameObject TaskDescText;
        public GameObject RewardListNode;
        public GameObject GetBtn;
        public GameObject GiveBtn;
        public GameObject AcvityedImg;

        public TaskPro TaskPro; // 进行中的赛季任务 或 选中的每日任务
        public int CompeletTaskId;
        public UIPageButtonComponent UIPageButtonComponent;
        public List<UITaskBItemComponent> UITaskBItemComponentList = new List<UITaskBItemComponent>();
    }

    public class UITaskBComponentAwakeSystem: AwakeSystem<UITaskBComponent>
    {
        public override void Awake(UITaskBComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UITaskBItemListNode = rc.Get<GameObject>("UITaskBItemListNode");
            self.UITaskBItem = rc.Get<GameObject>("UITaskBItem");
            self.TaskNameText = rc.Get<GameObject>("TaskNameText");
            self.ProgressText = rc.Get<GameObject>("ProgressText");
            self.TaskDescText = rc.Get<GameObject>("TaskDescText");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.GetBtn = rc.Get<GameObject>("GetBtn");
            self.GiveBtn = rc.Get<GameObject>("GiveBtn");
            self.AcvityedImg = rc.Get<GameObject>("AcvityedImg");

            self.UITaskBItem.SetActive(false);
            self.GetBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnGetBtn().Coroutine(); });
            self.GiveBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnGiveBtn().Coroutine(); });

            self.UpdateTask();
        }
    }

    public static class UITaskBComponentSystem
    {
        public static void UpdateTask(this UITaskBComponent self)
        {
            self.CompeletTaskId =
                    (int)UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>()[NumericType.SystemTask];
            List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().RoleTaskList;
            for (int i = 0; i < taskPros.Count; i++)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPros[i].taskID);
                if (taskConfig.TaskType == TaskTypeEnum.System)
                {
                    self.TaskPro = taskPros[i];
                    break;
                }
            }

            if (self.TaskPro == null && self.CompeletTaskId > 0)
            {
                self.TaskPro = new TaskPro() { taskID = self.CompeletTaskId };
            }

            int count = 0;
            Vector3 lastPosition = new Vector3(-250, 0, 0);
            int dre = 1;
            Material mat = ResourcesComponent.Instance.LoadAsset<Material>(ABPathHelper.GetMaterialPath("UI_Hui"));
            int index = 0;
            foreach (TaskConfig taskConfig in TaskConfigCategory.Instance.GetAll().Values)
            {
                if (taskConfig.TaskType == TaskTypeEnum.System)
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

                    if (count >= self.UITaskBItemComponentList.Count)
                    {
                        GameObject go = UnityEngine.Object.Instantiate(self.UITaskBItem);
                        UITaskBItemComponent ui = self.AddChild<UITaskBItemComponent, GameObject>(go);
                        self.UITaskBItemComponentList.Add(ui);
                        go.SetActive(true);
                        UICommonHelper.SetParent(go, self.UITaskBItemListNode);

                        ui.Item.GetComponent<RectTransform>().localPosition = lastPosition;
                        if (dre == 1)
                        {
                            ui.Img_line.GetComponent<RectTransform>().localPosition = new Vector3(87, -42, 0);
                            ui.Img_line.GetComponent<RectTransform>().transform.Rotate(0, 0, 150);
                            ui.Img_lineDi.GetComponent<RectTransform>().localPosition = new Vector3(87, -42, 0);
                            ui.Img_lineDi.GetComponent<RectTransform>().transform.Rotate(0, 0, 150);
                        }
                        else
                        {
                            ui.Img_line.GetComponent<RectTransform>().localPosition = new Vector3(-124, -64, 0);
                            ui.Img_line.GetComponent<RectTransform>().transform.Rotate(0, 0, -150);
                            ui.Img_lineDi.GetComponent<RectTransform>().localPosition = new Vector3(-124, -64, 0);
                            ui.Img_lineDi.GetComponent<RectTransform>().transform.Rotate(0, 0, -150);
                        }
                    }

                    self.UITaskBItemComponentList[count].OnUpdateData(taskConfig.Id);
                    self.UITaskBItemComponentList[count].SeasonIcon.GetComponent<Image>().material = null;
                    self.UITaskBItemComponentList[count].Img_line.SetActive(true);
                    self.UITaskBItemComponentList[count].Img_lineDi.SetActive(true);

                    if (taskConfig.Id > self.TaskPro.taskID)
                    {
                        // self.UISeasonTaskItemComponentList[count].SeasonIcon.GetComponent<Button>().onClick.RemoveAllListeners();
                        self.UITaskBItemComponentList[count].SeasonIcon.GetComponent<Image>().material = mat;
                        self.UITaskBItemComponentList[count].Img_line.SetActive(false);
                    }

                    if (taskConfig.Id == self.TaskPro.taskID)
                    {
                        index = count;
                        self.UITaskBItemComponentList[count].Img_line.SetActive(false);
                    }

                    count++;
                }
            }

            self.UpdateInfo(self.TaskPro.taskID);

            // 尾巴隐藏
            if (self.UITaskBItemComponentList.Count > 0)
            {
                self.UITaskBItemComponentList[self.UITaskBItemComponentList.Count - 1].Img_line.SetActive(false);
                self.UITaskBItemComponentList[self.UITaskBItemComponentList.Count - 1].Img_lineDi.SetActive(false);
            }

            // 滑动到底部
            // self.SeasonTaskScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 0;
            // 滑动到对应位置
            Vector3 vector3 = self.UITaskBItemListNode.GetComponent<RectTransform>().localPosition;
            vector3.y = index * 160;
            self.UITaskBItemListNode.GetComponent<RectTransform>().localPosition = vector3;
        }

        public static void UpdateInfo(this UITaskBComponent self, int taskId)
        {
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskId);
            self.TaskNameText.GetComponent<Text>().text = taskConfig.TaskName;
            if (taskId < self.TaskPro.taskID || (taskId == self.TaskPro.taskID && taskId == self.CompeletTaskId))
            {
                // 已经完成
                if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10 ||
                    taskConfig.TargetType == (int)TaskTargetType.GivePet_25 ||
                    taskConfig.TargetType == (int)TaskTargetType.TeamDungeonHurt_136 ||
                    taskConfig.TargetType == (int)TaskTargetType.JianDingAttrNumber_43 ||
                    taskConfig.TargetType == (int)TaskTargetType.MakeQulityNumber_29)
                {
                    self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " + "1/1";
                }
                else
                {
                    self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " +
                            $"{taskConfig.TargetValue[0]}/{taskConfig.TargetValue[0]}";
                }

                self.AcvityedImg.SetActive(true);
                self.GetBtn.SetActive(false);
                self.GiveBtn.SetActive(false);
            }
            else
            {
                // 进行中
                if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10 || taskConfig.TargetType == (int)TaskTargetType.GivePet_25)
                {
                    self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " + "0/1";
                    self.GetBtn.SetActive(false);
                    self.GiveBtn.SetActive(true);
                }
                else if (taskConfig.TargetType == (int)TaskTargetType.JianDingAttrNumber_43 ||
                         taskConfig.TargetType == (int)TaskTargetType.TeamDungeonHurt_136 ||
                         taskConfig.TargetType == (int)TaskTargetType.MakeQulityNumber_29)
                {
                    if (self.TaskPro.taskStatus == (int)TaskStatuEnum.Completed)
                    {
                        self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " + "1/1";
                        self.GetBtn.SetActive(true);
                        self.GiveBtn.SetActive(false);
                    }
                    else
                    {
                        self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " + "0/1";
                        self.GetBtn.SetActive(true);
                        self.GiveBtn.SetActive(false);
                    }
                }
                else
                {
                    self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("当前进度值") + ": " +
                            $"{self.TaskPro.taskTargetNum_1}/{taskConfig.TargetValue[0]}";
                    self.GetBtn.SetActive(true);
                    self.GiveBtn.SetActive(false);
                }

                if (taskId > self.TaskPro.taskID)
                {
                    self.GetBtn.SetActive(false);
                    self.GiveBtn.SetActive(false);
                }

                self.AcvityedImg.SetActive(false);
            }

            self.TaskDescText.GetComponent<Text>().text = taskConfig.TaskDes;
            if (!ComHelp.IfNull(taskConfig.ItemID))
            {
                UICommonHelper.DestoryChild(self.RewardListNode);
                List<RewardItem> rewardItems = new List<RewardItem>();
                if (taskConfig.TaskCoin != 0)
                {
                    rewardItems.Add(new RewardItem() { ItemID = 1, ItemNum = taskConfig.TaskCoin });
                }

                if (taskConfig.TaskExp != 0)
                {
                    rewardItems.Add(new RewardItem() { ItemID = 2, ItemNum = taskConfig.TaskExp });
                }

                rewardItems.AddRange(TaskHelper.GetTaskRewards(taskId));
                UICommonHelper.ShowItemList(rewardItems, self.RewardListNode, self, 0.8f);
            }

            for (int i = 0; i < self.UITaskBItemComponentList.Count; i++)
            {
                self.UITaskBItemComponentList[i].Selected(taskId);
            }
        }

        public static async ETTask OnGetBtn(this UITaskBComponent self)
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

            await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskPro.taskID, 0);
            self.UpdateTask();
        }

        public static async ETTask OnGiveBtn(this UITaskBComponent self)
        {
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.TaskPro.taskID);
            if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10)
            {
                UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIGiveTask);
                ui.GetComponent<UIGiveTaskComponent>().InitTask(self.TaskPro.taskID, 1);
                ui.GetComponent<UIGiveTaskComponent>().OnGiveAction = self.UpdateTaskB;
            }
            else if (taskConfig.TargetType == (int)TaskTargetType.GivePet_25)
            {
                UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIGivePet);
                ui.GetComponent<UIGivePetComponent>().InitTask(self.TaskPro.taskID, 1);
                ui.GetComponent<UIGivePetComponent>().OnUpdateUI();
                ui.GetComponent<UIGivePetComponent>().OnGiveAction = self.UpdateTaskB;
            }
        }

        public static void UpdateTaskB(this UITaskBComponent self)
        {
            self.UpdateTask();
        }
    }
}