using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIMainTaskComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Btn_RoseTask;
        public GameObject TaskShowList;
        public GameObject TaskShowItem;
        public GameObject GameObject;

        public List<UIMainTaskItemComponent> TrackTaskList = new List<UIMainTaskItemComponent>();
    }
    
    public class TaskShowSetComponentAwakeSystem : AwakeSystem<UIMainTaskComponent, GameObject>
    {
        public override void Awake(UIMainTaskComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = self.GameObject.GetComponent<ReferenceCollector>();

            self.Btn_RoseTask = rc.Get<GameObject>("Btn_RoseTask");
            self.TaskShowList = rc.Get<GameObject>("TaskShowList");
            self.TaskShowItem = rc.Get<GameObject>("UIMainTaskItem");
            ButtonHelp.AddListenerEx(self.Btn_RoseTask, self.OnOpenTask);
            self.TaskShowItem.SetActive(false);

            self.TrackTaskList.Clear();
            self.OnUpdateUI();
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIMainTaskComponentDestroySystem : DestroySystem<UIMainTaskComponent>
    {
        public override void Destroy(UIMainTaskComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class TaskShowSetComponentSystem
    {
        public static void OnLanguageUpdate(this UIMainTaskComponent self)
        {
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
                
                UIMainTaskItemComponent ui_1 = null;
                if (number < self.TrackTaskList.Count)
                {
                    ui_1 = self.TrackTaskList[number];
                    ui_1.GameObject.SetActive(true);
                 
                }
                else
                {
                    GameObject item = GameObject.Instantiate(self.TaskShowItem);
                    item.SetActive(true);
                    UICommonHelper.SetParent(item, self.TaskShowList);
                    ui_1 = self.AddChild<UIMainTaskItemComponent, GameObject>( item);
                    self.TrackTaskList.Add(ui_1);
                }
                ui_1.OnUpdateItem(taskPros[i]);
                number++;
            }

            self.Btn_RoseTask.SetActive(number == 0);
        }

        public static void OnOpenTask(this UIMainTaskComponent self)
        {
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            //if (taskComponent.GetTaskTypeList(TaskTypeEnum.Main).Count > 0)
            //{
            //    UIHelper.Create(self.DomainScene(), UIType.UITask).Coroutine();
            //    return;
            //}
            int nextTask = taskComponent.GetNextMainTask();
            if (nextTask == 0)
            {
                UIHelper.Create(self.DomainScene(), UIType.UITask).Coroutine();
                return;
            }

            int getNpc = TaskConfigCategory.Instance.Get(nextTask).GetNpcID;
            int fubenId = TaskViewHelp.Instance.GetFubenByNpc(getNpc);
            if (fubenId == 0)
            {
                return;
            }

            string fubenName = string.Format(GameSettingLanguge.LoadLocalization("请前往{0} {1} 出接取任务"), DungeonConfigCategory.Instance.Get(fubenId).GetChapterName(), NpcConfigCategory.Instance.Get(getNpc).GetName());
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.LocalDungeon)
            {
                FloatTipManager.Instance.ShowFloatTip(fubenName);
                return;
            }
            int curdungeonid = mapComponent.SceneId;
            if (curdungeonid == fubenId)
            {
                TaskViewHelp.Instance.MoveToNpc(self.ZoneScene(), getNpc).Coroutine();
                return;
            }
            if (TaskViewHelp.Instance.GeToOtherFuben(self.ZoneScene(), fubenId, mapComponent.SceneId))
            {
                return;
            }

            FloatTipManager.Instance.ShowFloatTip(fubenName);
        }


    }

}
