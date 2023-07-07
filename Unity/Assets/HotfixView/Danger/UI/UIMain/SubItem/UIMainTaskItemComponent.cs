

using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMainTaskItemComponent : Entity, IAwake<GameObject>
    {

        public GameObject TaskTargetDes;
        public GameObject TaskName;
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
            self.ButtonTask = rc.Get<GameObject>("ButtonTask");

            self.ButtonTask.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenTaskView(); });
        }
    }

    public static class UITrackTaskComponentSystem
    {
        public static  void OnOpenTaskView(this UIMainTaskItemComponent self)
        {
            TaskViewHelp.Instance.ExcuteTask( self.ZoneScene(), self.TaskPro );
        }

        public static void OnUpdateItem(this UIMainTaskItemComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;

            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
            self.TaskConfig = taskConfig;
            self.TaskName.GetComponent<Text>().text = taskConfig.TaskName;

            Text textDesc = self.TaskTargetDes.GetComponent<Text>();
            textDesc.text = TaskViewHelp.Instance.GetTaskProgessDesc(taskPro);

            if (taskPro.taskStatus == (int)TaskStatuEnum.Completed)
            {
                textDesc.color = Color.green;
                textDesc.text = textDesc.text + " (" + GameSettingLanguge.LoadLocalization("已完成") + ")";
            }
            else
            {
                textDesc.color = Color.white;
            }
            //self.ButtonTask.GetComponent<RectTransform>().sizeDelta = new Vector2(textDesc.preferredWidth, 90f);

            if (taskConfig.TaskType == 1)
            {
                //self.TaskTypeName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("主线");
                //self.TaskTypeName.GetComponent<Text>().color = new Color(1, 0.7f, 0);
            }
            else {
                //self.TaskTypeName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("支线");
            }

            
        }
    }
}
