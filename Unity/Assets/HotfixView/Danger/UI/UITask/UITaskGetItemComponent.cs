using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UITaskGetItemComponent : Entity, IAwake
    {

        public GameObject ImageNotRecv;
        public GameObject ImageComplete;
        public GameObject TextTaskName;
        public GameObject ImageSelect;
        public GameObject ImageButton;
        public GameObject ImageDi;

        public int TaskId;
        public Action<int> ClickHandler;
    }

    [ObjectSystem]
    public class UINpcTaskItemComponentAwakeSystem : AwakeSystem<UITaskGetItemComponent>
    {

        public override void Awake(UITaskGetItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
          
            self.ImageNotRecv = rc.Get<GameObject>("ImageNotRecv");
            self.ImageComplete = rc.Get<GameObject>("ImageComplete");
            self.TextTaskName = rc.Get<GameObject>("TextTaskName");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.ImageDi = rc.Get<GameObject>("ImageDi");
            self.ImageSelect.SetActive(false);

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickSelectTask(); });
        }
    }

    public static class UINpcTaskItemComponentSystem
    {

        public static void InitData(this UITaskGetItemComponent self,  int taskid)
        {
            self.TaskId = taskid;
            TaskPro taskPro = self.ZoneScene().GetComponent<TaskComponent>().GetTaskById(taskid);
            bool isCompleted = taskPro != null && taskPro.taskStatus == (int)TaskStatuEnum.Completed;
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskid);
            if (!isCompleted)
            {
                self.TextTaskName.GetComponent<Text>().text = taskConfig.TaskName;
            }
            else {
                self.TextTaskName.GetComponent<Text>().text = taskConfig.TaskName+"(已完成)";
                self.TextTaskName.GetComponent<Text>().color = new Color(131f/255f,255f/255f,83f/255f);
            }


            self.ImageNotRecv.SetActive(!isCompleted);
            self.ImageComplete.SetActive(isCompleted);
        }

        public static void SetSelected(this UITaskGetItemComponent self, int taskId)
        {
            self.ImageDi.SetActive(self.TaskId != taskId);
            self.ImageSelect.SetActive(self.TaskId == taskId);
        }

        public static void SetClickHandler(this UITaskGetItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnClickSelectTask(this UITaskGetItemComponent self)
        {
            self.ClickHandler(self.TaskId);
        }
    }
}
