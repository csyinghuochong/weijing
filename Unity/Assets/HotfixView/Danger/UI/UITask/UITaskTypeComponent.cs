using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UITaskTypeComponent : Entity, IAwake<GameObject>
    {
        public GameObject TaskTypeName;
        public GameObject ImageButton;
        public GameObject UIPointTaskDate;
        public GameObject ImageSelect;
        public int TaskTypeEnum;

        public List<UITaskTypeItemComponent> UITaskTypeItemList = new List<UITaskTypeItemComponent>();
        public Action<int> ClickTaskTypeHandler;
        public Action<int, int> ClickTaskTypeItemHandler;

        public bool bSelected;
        public bool bExpandState;
        public GameObject GameObject;
    }

    [ObjectSystem]
    public class UITaskTypeComponentAwakeSystem : AwakeSystem<UITaskTypeComponent, GameObject>
    {

        public override void Awake(UITaskTypeComponent self, GameObject gameObject)
        {
            self.bSelected = false;
            self.bExpandState = false;
            self.GameObject = gameObject;
            self.UITaskTypeItemList.Clear();
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TaskTypeName  = rc.Get<GameObject>("TaskTypeName");
            self.UIPointTaskDate = rc.Get<GameObject>("UIPointTaskDate");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.ImageSelect.SetActive(false);

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickTypeButton(); });
        }
    }

    public static class UIRoleTaskTypeComponentSystem
    {

        /// <summary>
        /// 收起状态
        /// </summary>
        /// <param name="self"></param>
        public static void SetTalkUp(this UITaskTypeComponent self)
        {
            self.bExpandState = false;
            for (int i = 0; i < self.UITaskTypeItemList.Count; i++)
            {
                self.UITaskTypeItemList[i].GameObject.SetActive(false);
            }
            self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(702, 90f);
            self.GameObject.transform.parent.gameObject.SetActive(false);
            self.GameObject.transform.parent.gameObject.SetActive(true);
        }

        /// <summary>
        /// 展开状态
        /// </summary>
        /// <param name="self"></param>
        public static  void SetExpand(this UITaskTypeComponent self, int taskId = 0)
        {
            self.bExpandState = true;
            int index = -1;

            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/Task/UITaskTypeItem");
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            List<TaskPro> taskPros = new List<TaskPro>();
            TaskComponent TaskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            taskPros = TaskComponent.GetTaskTypeList(self.TaskTypeEnum);
            if (self.TaskTypeEnum == TaskTypeEnum.Branch)
            {
                taskPros.AddRange(TaskComponent.GetTaskTypeList(TaskTypeEnum.Weekly));
            }
            for (int i = 0; i < taskPros.Count; i++)
            {
                UITaskTypeItemComponent ui_1 = null;
                if (i < self.UITaskTypeItemList.Count)
                {
                    ui_1 = self.UITaskTypeItemList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.UIPointTaskDate);
                    taskTypeItem.transform.localPosition = new Vector3(0f, i * -65f, 0f);
                    ui_1 = self.AddChild<UITaskTypeItemComponent, GameObject>( taskTypeItem);
                    ui_1.SetClickTypeHandler((int taskid) => { self.OnClickTaskTypeItem(taskid); });
                    self.UITaskTypeItemList.Add(ui_1);
                }
                if (taskPros[i].taskID == taskId)
                {
                    index = i;
                }
                ui_1.OnUpdateData(taskPros[i]);
            }
            for (int i = taskPros.Count; i < self.UITaskTypeItemList.Count; i++)
            {
                self.UITaskTypeItemList[i].GameObject.SetActive(false);
            }

            if (index >= 0)
            {
                self.UITaskTypeItemList[index].OnClickTaskTypeItem();
            }
            else if (taskPros.Count > 0)
            {
                self.UITaskTypeItemList[0].OnClickTaskTypeItem();
            }
            else
            {
                self.OnClickTaskTypeItem(0);
            }

            self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(702, 90f + 60 * taskPros.Count);
            self.GameObject.transform.parent.gameObject.SetActive(false);
            self.GameObject.transform.parent.gameObject.SetActive(true);
        }

        public static void SetSelected(this UITaskTypeComponent self, int typeid, int taskId = 0)
        {
            bool value = typeid == self.TaskTypeEnum;
            self.bSelected = value;
            self.bExpandState = value;
            self.ImageSelect.SetActive(value);

            if (!value)
            {
                self.SetTalkUp();
                return;
            }

            self.SetExpand(taskId);
        }

        public static void OnClickTypeButton(this UITaskTypeComponent self)
        {
            if (self.bSelected && self.bExpandState)
            {
                self.SetTalkUp();
                return;
            }
            if (self.bSelected && !self.bExpandState)
            {
                self.SetExpand();
                return;
            }

            self.ClickTaskTypeHandler(self.TaskTypeEnum);
        }

        public static void OnUpdateData(this UITaskTypeComponent self, int taskTypeEnum)
        {
            self.TaskTypeEnum = taskTypeEnum;
            switch (taskTypeEnum)
            {
                case (int)TaskTypeEnum.Main:
                    self.TaskTypeName.GetComponent<Text>().text = "主线任务";
                    break;
                case (int)TaskTypeEnum.Branch:
                    self.TaskTypeName.GetComponent<Text>().text = "支线任务";
                    break;
                case (int)TaskTypeEnum.EveryDay:
                    self.TaskTypeName.GetComponent<Text>().text = "每日任务";
                    break;
            }
        }

        public static void SetClickTypeHandler(this UITaskTypeComponent self, Action<int> action)
        {
            self.ClickTaskTypeHandler = action;
        }

        public static void SetClickTypeItemHandler(this UITaskTypeComponent self, Action<int, int> action)
        {
            self.ClickTaskTypeItemHandler = action;
        }

        public static void OnClickTaskTypeItem(this UITaskTypeComponent self, int taskId)
        {
            for (int i = 0; i < self.UITaskTypeItemList.Count; i++)
            {
                if (!self.UITaskTypeItemList[i].GameObject.activeSelf)
                {
                    continue;
                }
                self.UITaskTypeItemList[i].SetSelected(taskId);
            }

            self.ClickTaskTypeItemHandler(self.TaskTypeEnum, taskId);
        }

    }
}
