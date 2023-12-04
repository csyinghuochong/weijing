using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIGiveTaskComponent: Entity, IAwake
    {
        public GameObject BagListNode;
        public GameObject UICommonItem;
        public GameObject TaskDesText;
        public GameObject GiveBtn;
        public GameObject CloseBtn;

        public int TaskId;

        public int TaskType = 1; //1 taskconfig  2taskcountryconfig

        public BagInfo BagInfo;
        public BagComponent BagComponent;
        public UIItemComponent CheckedItem;
        public List<UIItemComponent> BagList = new List<UIItemComponent>();

        public Action OnGiveAction;
    }

    public class UIGiveTaskComponentAwakeSystem: AwakeSystem<UIGiveTaskComponent>
    {
        public override void Awake(UIGiveTaskComponent self)
        {
            self.Awake();
        }
    }

    public static class UIGiveTaskComponentSystem
    {
        public static void Awake(this UIGiveTaskComponent self)
        {
            self.BagList.Clear();
            self.BagInfo = null;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BagListNode = rc.Get<GameObject>("BagListNode");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.TaskDesText = rc.Get<GameObject>("TaskDesText");
            self.GiveBtn = rc.Get<GameObject>("GiveBtn");
            self.CloseBtn = rc.Get<GameObject>("CloseBtn");

            self.CloseBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseBtn(); });
            self.GiveBtn.GetComponent<Button>().onClick.AddListener(() => self.OnGiveBtn().Coroutine());

            self.CheckedItem = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.OnBagListUpdate().Coroutine();
        }

        public static void InitTask(this UIGiveTaskComponent self, int taskId, int taskType = 1)
        {
            self.TaskId = taskId;
            self.TaskType = taskType;
            if (taskType == 1)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskId);
                self.TaskDesText.GetComponent<Text>().text = taskConfig.TaskDes;
            }
            else
            {
                TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get(taskId);
                self.TaskDesText.GetComponent<Text>().text = taskCountryConfig.TaskDes;
            }
        }

        public static void OnCloseBtn(this UIGiveTaskComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIGiveTask);
        }

        public static async ETTask OnBagListUpdate(this UIGiveTaskComponent self)
        {
            int number = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            List<BagInfo> bagInfos = self.BagComponent.GetItemsByType(ItemTypeEnum.Equipment);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                UIItemComponent uI = null;
                if (number < self.BagList.Count)
                {
                    uI = self.BagList[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BagListNode);
                    uI = self.AddChild<UIItemComponent, GameObject>(go);
                    uI.SetClickHandler((BagInfo bagInfo) => { self.OnSelect(bagInfo); });
                    self.BagList.Add(uI);
                }

                number++;
                uI.UpdateItem(bagInfos[i], ItemOperateEnum.SkillSet);
            }

            for (int i = number; i < self.BagList.Count; i++)
            {
                self.BagList[i].GameObject.SetActive(false);
            }
        }

        public static void OnSelect(this UIGiveTaskComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            self.CheckedItem.UpdateItem(bagInfo, ItemOperateEnum.None);
            for (int i = 0; i < self.BagList.Count; i++)
            {
                self.BagList[i].SetSelected(bagInfo);
            }
        }

        public static async ETTask OnGiveBtn(this UIGiveTaskComponent self)
        {
            if (self.TaskType == 1)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.TaskId);
                if (TaskHelper.IsTaskGiveItem(taskConfig.TargetType, taskConfig.Target, taskConfig.TargetValue, self.BagInfo))
                {
                    TaskPro taskPro = self.ZoneScene().GetComponent<TaskComponent>().GetTaskById(self.TaskId);
                    taskPro.taskStatus = (int)TaskStatuEnum.Completed;
                    int errorCode = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskId, self.BagInfo.BagInfoID);
                    if (errorCode == ErrorCode.ERR_Success)
                    {
                        FloatTipManager.Instance.ShowFloatTip("完成任务");
                        self.OnGiveAction?.Invoke();
                        UIHelper.Remove(self.ZoneScene(), UIType.UIGiveTask);
                    }
                }
                else
                {
                    FloatTipManager.Instance.ShowFloatTip("道具类型不符合任务要求");
                    return;
                }
            }
            else
            {
                TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(self.TaskId);
                if (TaskHelper.IsTaskGiveItem(taskConfig.TargetType, taskConfig.Target, taskConfig.TargetValue, self.BagInfo))
                {
                    TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
                    TaskPro taskPro = null;
                    for (int i = 0; i < taskComponent.TaskCountryList.Count; i++)
                    {
                        if (taskComponent.TaskCountryList[i].taskID == self.TaskId)
                        {
                            taskPro = taskComponent.TaskCountryList[i];
                            break;
                        }
                    }
                    taskPro.taskStatus = (int)TaskStatuEnum.Completed;
                    int errorCode = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTaskCountry(self.TaskId, self.BagInfo.BagInfoID);
                    if (errorCode == ErrorCode.ERR_Success)
                    {
                        FloatTipManager.Instance.ShowFloatTip("完成任务");
                        self.OnGiveAction?.Invoke();
                        UIHelper.Remove(self.ZoneScene(), UIType.UIGiveTask);
                    }
                }
                else
                {
                    FloatTipManager.Instance.ShowFloatTip("道具类型不符合任务要求");
                    return;
                }
            }

            await ETTask.CompletedTask;
        }
    }
}