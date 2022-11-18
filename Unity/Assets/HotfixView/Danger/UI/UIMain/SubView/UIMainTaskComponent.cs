using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIMainTaskComponent : Entity, IAwake<GameObject>
    {
        public GameObject TaskShowList;
        public GameObject TaskShowItem;
        public GameObject GameObject;

        public List<UIMainTaskItemComponent> TrackTaskList = new List<UIMainTaskItemComponent>();
    }

    [ObjectSystem]
    public class TaskShowSetComponentAwakeSystem : AwakeSystem<UIMainTaskComponent, GameObject>
    {
        public override void Awake(UIMainTaskComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = self.GameObject.GetComponent<ReferenceCollector>();

            self.TaskShowList = rc.Get<GameObject>("TaskShowList");
            self.TaskShowItem = rc.Get<GameObject>("UIMainTaskItem");
            self.TaskShowItem.SetActive(false);

            self.TrackTaskList.Clear();
            self.OnUpdateUI();
        }
    }

    public static class TaskShowSetComponentSystem
    {

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

                UIMainTaskItemComponent ui_1 = null;
                if (number < self.TrackTaskList.Count)
                {
                    ui_1 = self.TrackTaskList[number];
                    ui_1.GameObject.SetActive(true);
                    ui_1.OnUpdateItem(taskPros[i]);
                }
                else
                {
                    GameObject item = GameObject.Instantiate(self.TaskShowItem);
                    item.SetActive(true);
                    UICommonHelper.SetParent(item, self.TaskShowList);

                    ui_1 = self.AddChild<UIMainTaskItemComponent, GameObject>( item);
                    ui_1.OnUpdateItem(taskPros[i]);

                    self.TrackTaskList.Add(ui_1);
                }
                number++;
            }
        }

    }

}
