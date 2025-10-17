

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

        public static void UpdateItemHeight(this UIMainTaskItemComponent self)
        {
            self.GameObject.gameObject.SetActive(false);
            self.GameObject.gameObject.SetActive(true);
            Text textDesc = self.TaskTargetDes.GetComponent<Text>();
            textDesc.GetComponent<ContentSizeFitter>().SetLayoutVertical();

            if (textDesc.preferredHeight > 50f)
            {
                self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(300f, textDesc.preferredHeight + 50f);
            }
            else
            {
                self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(300f, 80f);
            }
        }

        public static void OnUpdateItem(this UIMainTaskItemComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;

            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
            self.TaskConfig = taskConfig;
            self.TaskName.GetComponent<Text>().text = taskConfig.GetTaskName();

            Text textDesc = self.TaskTargetDes.GetComponent<Text>();
            string text = TaskViewHelp.Instance.GetTaskProgessDesc(taskPro);
            if (taskPro.taskStatus == (int)TaskStatuEnum.Completed)
            {
                textDesc.color = Color.green;
                text = text + " (" + GameSettingLanguge.LoadLocalization("已完成") + ")";
                //text = text.Replace(" ", "\u00A0");

                textDesc.text = text;
            }
            else
            {
                textDesc.color = Color.white;
                //text = text.Replace(" ", "\u00A0");
                textDesc.text = text;
            }

            textDesc.horizontalOverflow = GameSettingLanguge.Language == 0 ? HorizontalWrapMode.Overflow : HorizontalWrapMode.Wrap;
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
