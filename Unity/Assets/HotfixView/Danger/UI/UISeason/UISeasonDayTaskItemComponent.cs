using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonDayTaskItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject TaskNameText;
        public GameObject TaskDescText;
        public GameObject ProgressText;
        public GameObject ClickBtn;

        public TaskPro TaskPro;
    }

    public class UISeasonDayTaskItemComponentAwake: AwakeSystem<UISeasonDayTaskItemComponent, GameObject>
    {
        public override void Awake(UISeasonDayTaskItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TaskNameText = rc.Get<GameObject>("TaskNameText");
            self.TaskDescText = rc.Get<GameObject>("TaskDescText");
            self.ProgressText = rc.Get<GameObject>("ProgressText");
            self.ClickBtn = rc.Get<GameObject>("ClickBtn");
        }
    }

    public static class UISeasonDayTaskItemComponentSystem
    {
        public static void OnUpdateData(this UISeasonDayTaskItemComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;
            self.ClickBtn.GetComponent<Button>().onClick.RemoveAllListeners();
            self.ClickBtn.GetComponent<Button>().onClick.AddListener(() => { self.GetParent<UISeasonTaskComponent>().UpdateInfo(self.TaskPro); });
            TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPro.taskID);

            self.TaskNameText.GetComponent<Text>().text = taskConfig.TaskName;
            self.TaskDescText.GetComponent<Text>().text = taskConfig.TaskDes;

            taskPro.taskTargetNum_1 = taskPro.taskTargetNum_1 > taskConfig.TargetValue? taskConfig.TargetValue : taskPro.taskTargetNum_1;
            self.ProgressText.GetComponent<Text>().text = $"进度:{taskPro.taskTargetNum_1}/{taskConfig.TargetValue}";
        }
    }
}