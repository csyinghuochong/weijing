using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIMainTaskComponent : Entity, IAwake
    {
        public GameObject TaskShowList;
        public GameObject TaskShowItem;

        public List<UI> TrackTaskList = new List<UI>();
    }

    [ObjectSystem]
    public class TaskShowSetComponentAwakeSystem : AwakeSystem<UIMainTaskComponent>
    {
        public override void Awake(UIMainTaskComponent self)
        {
            self.Awake();
        }
    }

    public static class TaskShowSetComponentSystem
    {

        public static void Awake(this UIMainTaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
           
            self.TaskShowList = rc.Get<GameObject>("TaskShowList");
            self.TaskShowItem = rc.Get<GameObject>("UIMainTaskItem");
            self.TaskShowItem.SetActive(false);

            self.TrackTaskList.Clear();
            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIMainTaskComponent self)
        {
            for (int i = 0; i < self.TrackTaskList.Count; i++)
            {
                self.TrackTaskList[i].GameObject.SetActive(false);
            }

            List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().RoleTaskList;
           
            int number = 0;
            for (int i = 0; i < taskPros.Count; i++)
            {
                if (taskPros[i].TrackStatus == 0)
                {
                    continue;
                }

                UI ui_1 = null;
                if (number < self.TrackTaskList.Count)
                {
                    ui_1 = self.TrackTaskList[number];
                    ui_1.GameObject.SetActive(true);
                    ui_1.GetComponent<UIMainTaskItemComponent>().OnUpdateItem(taskPros[i]);
                }
                else
                {
                    GameObject item = GameObject.Instantiate(self.TaskShowItem);
                    item.SetActive(true);
                    UICommonHelper.SetParent(item, self.TaskShowList);

                    ui_1 = self.AddChild<UI, string, GameObject>( "TaskShowItem_" + i.ToString(), item);
                    UIMainTaskItemComponent uIItemComponent = ui_1.AddComponent<UIMainTaskItemComponent>();
                    uIItemComponent.OnUpdateItem(taskPros[i]);

                    self.TrackTaskList.Add(ui_1);
                }
                number++;
            }
        }

    }

}
