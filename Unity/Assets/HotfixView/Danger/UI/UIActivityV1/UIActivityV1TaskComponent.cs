using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1TaskComponent: Entity, IAwake
    {
        public GameObject TaskListNode;
        public GameObject UIActivityV1TaskItem;

        public List<UIActivityV1TaskItemComponent> TaskList = new List<UIActivityV1TaskItemComponent>();
    }

    public class UIActivityV1TaskComponentAwake: AwakeSystem<UIActivityV1TaskComponent>
    {
        public override void Awake(UIActivityV1TaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TaskListNode = rc.Get<GameObject>("TaskListNode");
            self.UIActivityV1TaskItem = rc.Get<GameObject>("UIActivityV1TaskItem");

            self.UIActivityV1TaskItem.SetActive(false);

            self.UpdateTaskCountrys();
        }
    }

    public static class UIActivityV1TaskComponentSystem
    {
        public static void UpdateTaskCountrys(this UIActivityV1TaskComponent self)
        {
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
                if (taskConfig.TaskType != TaskCountryType.ActivityV1)
                {
                    continue;
                }

                UIActivityV1TaskItemComponent ui_1 = null;
                if (number < self.TaskList.Count)
                {
                    ui_1 = self.TaskList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(self.UIActivityV1TaskItem);
                    UICommonHelper.SetParent(taskTypeItem, self.TaskListNode);
                    ui_1 = self.AddChild<UIActivityV1TaskItemComponent, GameObject>(taskTypeItem);
                    self.TaskList.Add(ui_1);
                    ui_1.GameObject.SetActive(true);
                }

                ui_1.OnUpdateData(taskPros[i]);
                number++;
            }

            for (int k = number; k < self.TaskList.Count; k++)
            {
                self.TaskList[k].GameObject.SetActive(false);
            }
        }
    }
}