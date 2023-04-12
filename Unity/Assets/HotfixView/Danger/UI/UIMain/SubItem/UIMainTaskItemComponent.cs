

using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMainTaskItemComponent : Entity, IAwake<GameObject>
    {

        public GameObject TaskTargetDes;
        public GameObject TaskName;
        public GameObject TaskTypeName;
        public GameObject ButtonTask;
        public GameObject GameObject;

        public TaskPro TaskPro;
        public TaskConfig TaskConfig;
    }



    public class UITrackTaskComponentAwakeSystem : AwakeSystem<UIMainTaskItemComponent, GameObject>
    {

        public override void Awake(UIMainTaskItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TaskTargetDes = rc.Get<GameObject>("TaskTargetDes");
            self.TaskName = rc.Get<GameObject>("TaskName");
            self.TaskTypeName = rc.Get<GameObject>("TaskTypeName");
            self.ButtonTask = rc.Get<GameObject>("ButtonTask");

            self.ButtonTask.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenTaskView(); });
        }
    }

    public static class UITrackTaskComponentSystem
    {
        public static  void OnOpenTaskView(this UIMainTaskItemComponent self)
        {
            int target = self.TaskConfig.TargetType;

            if (self.TaskPro.taskStatus == (int)TaskStatuEnum.Completed)
            {
                if (!TaskHelper.HaveNpc(self.ZoneScene(), self.TaskConfig.CompleteNpcID))
                {
                    int fubenId = TaskViewHelp.Instance.GetFubenByNpc(self.TaskConfig.CompleteNpcID);
                    string fubenName = fubenId > 0 ? DungeonConfigCategory.Instance.Get(fubenId).ChapterName : "副本";
                    FloatTipManager.Instance.ShowFloatTip($"请前往{fubenName}");
                    return;
                }
                FloatTipManager.Instance.ShowFloatTip("正在前往任务目标点");
                TaskHelper.MoveToNpc(self.ZoneScene(), self.TaskPro).Coroutine();
                return;
            }
            if (self.TaskConfig.TargetPosition != 0)
            {
                bool excuteVAlue = TaskViewHelp.Instance.MoveToTask(self.ZoneScene(), self.TaskConfig.TargetPosition);
                if (excuteVAlue)
                {
                    FloatTipManager.Instance.ShowFloatTip("正在前往任务目标点");
                }
                return;
            }
            TaskViewHelp.Instance.TaskTypeLogic[(TaskTargetType)target].taskExcute(self.DomainScene(), self.TaskPro, self.TaskConfig);
        }

        public static void OnUpdateItem(this UIMainTaskItemComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;

            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
            self.TaskConfig = taskConfig;
            self.TaskName.GetComponent<Text>().text = taskConfig.TaskName;
            self.TaskTargetDes.GetComponent<Text>().text = TaskViewHelp.Instance.GetTaskProgessDesc(taskPro);

            if (taskPro.taskStatus == (int)TaskStatuEnum.Completed)
            {
                self.TaskTargetDes.GetComponent<Text>().color = Color.green;
                self.TaskTargetDes.GetComponent<Text>().text = self.TaskTargetDes.GetComponent<Text>().text + " (" + GameSettingLanguge.LoadLocalization("已完成") + ")";
            }
            else
            {
                self.TaskTargetDes.GetComponent<Text>().color = Color.white;
            }

            if (taskConfig.TaskType == 1)
            {
                self.TaskTypeName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("主线");
                self.TaskTypeName.GetComponent<Text>().color = new Color(1, 0.7f, 0);
            }
            else {
                self.TaskTypeName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("支线");
            }

            
        }
    }
}
