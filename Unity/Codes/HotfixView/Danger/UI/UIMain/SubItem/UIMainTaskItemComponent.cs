

using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMainTaskItemComponent : Entity, IAwake
    {

        public GameObject TaskTargetDes;
        public GameObject TaskName;
        public GameObject TaskTypeName;
        public GameObject ButtonTask;

        public TaskPro TaskPro;
    }


    [ObjectSystem]
    public class UITrackTaskComponentAwakeSystem : AwakeSystem<UIMainTaskItemComponent>
    {

        public override void Awake(UIMainTaskItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TaskTargetDes = rc.Get<GameObject>("TaskTargetDes");
            self.TaskName = rc.Get<GameObject>("TaskName");
            self.TaskTypeName = rc.Get<GameObject>("TaskTypeName");
            self.ButtonTask = rc.Get<GameObject>("ButtonTask");

            self.ButtonTask.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenTaskView().Coroutine(); });
        }
    }

    public static class UITrackTaskComponentSystem
    {
        public static async ETTask OnOpenTaskView(this UIMainTaskItemComponent self)
        {
            await UIHelper.Create( self.DomainScene(), UIType.UITask );
        }

        public static void OnUpdateItem(this UIMainTaskItemComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;

            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
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
