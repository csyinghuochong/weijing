using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1TaskComponent: Entity, IAwake
    {

        public GameObject Text_CurWeek;
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

            self.Text_CurWeek = rc.Get<GameObject>("Text_CurWeek");
            self.Text_CurWeek.GetComponent<Text>().text = UICommonHelper.GetCurrentWeekRange();

            self.UpdateTaskCountrys();
        }
    }

    public static class UIActivityV1TaskComponentSystem
    {
        public static void UpdateTaskCountrys(this UIActivityV1TaskComponent self)
        {
            List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().TaskCountryList;

            taskPros = taskPros.OrderBy(p => p.taskStatus == (int)TaskStatuEnum.Completed ? 0 :
                                     p.taskStatus == (int)TaskStatuEnum.Commited ? 2 : 1)
                        .ToList();

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