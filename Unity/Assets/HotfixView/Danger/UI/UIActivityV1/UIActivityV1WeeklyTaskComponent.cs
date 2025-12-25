using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1WeeklyTaskComponent : Entity, IAwake
    {

        public GameObject Text_CurWeek;
        public GameObject TaskListNode;
        public GameObject UIActivityV1WeeklyTaskItem;

        public List<UIActivityV1WeeklyTaskItemComponent> TaskList = new List<UIActivityV1WeeklyTaskItemComponent>();
    }

    public class UIActivityV1WeeklyTaskComponentAwake : AwakeSystem<UIActivityV1WeeklyTaskComponent>
    {
        public override void Awake(UIActivityV1WeeklyTaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TaskListNode = rc.Get<GameObject>("TaskListNode");
            self.UIActivityV1WeeklyTaskItem = rc.Get<GameObject>("UIActivityV1WeeklyTaskItem");
            self.UIActivityV1WeeklyTaskItem.SetActive(false);

            self.Text_CurWeek = rc.Get<GameObject>("Text_CurWeek");
            self.Text_CurWeek.GetComponent<Text>().text = UICommonHelper.GetCurrentWeekRange();

            self.UpdateTaskCountrys();
        }
    }

    public static class UIActivityV1WeeklyTaskComponentSystem
    {
        public static void UpdateTaskCountrys(this UIActivityV1WeeklyTaskComponent self)
        {
            List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().TaskCountryList;

            taskPros = taskPros.OrderBy(p => p.taskStatus == (int)TaskStatuEnum.Completed ? 0 :
                                     p.taskStatus == (int)TaskStatuEnum.Commited ? 2 : 1)
                        .ToList();

            int number = 0;
            for (int i = 0; i < taskPros.Count; i++)
            {
                TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPros[i].taskID);
                if (taskConfig.TaskType != TaskCountryType.ActivityWeekly)
                {
                    continue;
                }

                UIActivityV1WeeklyTaskItemComponent ui_1 = null;
                if (number < self.TaskList.Count)
                {
                    ui_1 = self.TaskList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(self.UIActivityV1WeeklyTaskItem);
                    UICommonHelper.SetParent(taskTypeItem, self.TaskListNode);
                    ui_1 = self.AddChild<UIActivityV1WeeklyTaskItemComponent, GameObject>(taskTypeItem);
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