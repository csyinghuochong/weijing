using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIBattleTaskComponent : Entity, IAwake
    {
        public GameObject TaskListNode;
        public List<UIBattleTaskItemComponent> TaskList = new List<UIBattleTaskItemComponent>();
    }

    [ObjectSystem]
    public class UIBattleTaskComponentAwakeSystem : AwakeSystem<UIBattleTaskComponent>
    {

        public override void Awake(UIBattleTaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TaskListNode  = rc.Get<GameObject>("TaskListNode");
            self.TaskList.Clear();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
        }
    }

    public static class UIBattleTaskComponentSystem
    {
        public static void OnUpdateUI(this UIBattleTaskComponent self)
        {
            self.UpdateTaskCountrys();
        }

        public static void UpdateTaskCountrys(this UIBattleTaskComponent self)
        {
            List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().TaskCountryList;
            string path = ABPathHelper.GetUGUIPath("BattleDungeon/UIBattleTaskItem");
            GameObject bundleObj =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            taskPros.Sort(delegate (TaskPro a, TaskPro b)
            {
                int commita = a.taskStatus == (int)TaskStatuEnum.Commited ? 1 : 0;
                int commitb = b.taskStatus == (int)TaskStatuEnum.Commited ? 1 : 0;
                int completea = a.taskStatus == (int)TaskStatuEnum.Completed ? 1 : 0;
                int completeb = b.taskStatus == (int)TaskStatuEnum.Completed ? 1 : 0;

                if (commita == commitb)
                    return completeb - completea;       //可以领取的在前
                else
                    return commitb - commita;           //已经完成的在前
            });

            int number = 0;
            for (int i = 0; i < taskPros.Count; i++)
            {
                TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPros[i].taskID);
                if (taskConfig.TaskType != TaskCountryType.Battle)
                {
                    continue;
                }

                UIBattleTaskItemComponent ui_1 = null;
                if (number < self.TaskList.Count)
                {
                    ui_1 = self.TaskList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.TaskListNode);
                    ui_1 = self.AddChild<UIBattleTaskItemComponent, GameObject>(taskTypeItem);
                    self.TaskList.Add(ui_1);
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