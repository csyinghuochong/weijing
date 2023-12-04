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

            // 已经完成
            if (taskPro.taskStatus == (int)TaskStatuEnum.Commited)
            {
                if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10 ||
                    taskConfig.TargetType == (int)TaskTargetType.GivePet_25 ||
                    taskConfig.TargetType == (int)TaskTargetType.TeamDungeonHurt_136 ||
                    taskConfig.TargetType == (int)TaskTargetType.JianDingAttrNumber_43 ||
                    taskConfig.TargetType == (int)TaskTargetType.MakeQulityNumber_29)
                {
                    self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度") + ":" + "1/1";
                }
                else
                {
                    self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度") + ":" +
                            $"{taskPro.taskTargetNum_1}/{taskConfig.TargetValue[0]}";
                }
            }
            else
            {
                // 进行中
                if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10 || taskConfig.TargetType == (int)TaskTargetType.GivePet_25)
                {
                    self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度") + ":" + "0/1";
                }
                else if (taskConfig.TargetType == (int)TaskTargetType.JianDingAttrNumber_43 ||
                         taskConfig.TargetType == (int)TaskTargetType.TeamDungeonHurt_136 ||
                         taskConfig.TargetType == (int)TaskTargetType.MakeQulityNumber_29)
                {
                    if (self.TaskPro.taskStatus == (int)TaskStatuEnum.Completed)
                    {
                        self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度") + ":" + "1/1";
                    }
                    else
                    {
                        self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度") + ":" + "0/1";
                    }
                }
                else
                {
                    self.ProgressText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度") + ":" +
                            $"{self.TaskPro.taskTargetNum_1}/{taskConfig.TargetValue[0]}";
                }
            }
        }
    }
}