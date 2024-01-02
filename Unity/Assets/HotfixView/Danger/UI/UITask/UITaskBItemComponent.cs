using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITaskBItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;

        public GameObject Item;
        public GameObject Img_line;
        public GameObject Img_lineDi;
        public GameObject Text;
        public GameObject SeasonIcon;
        public GameObject ScelectImg;
        public int TaskId;
    }

    public class UITaskBItemComponentAwake: AwakeSystem<UITaskBItemComponent, GameObject>
    {
        public override void Awake(UITaskBItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Item = rc.Get<GameObject>("Item");
            self.Img_line = rc.Get<GameObject>("Img_line");
            self.Img_lineDi = rc.Get<GameObject>("Img_lineDi");
            self.Text = rc.Get<GameObject>("Text");
            self.SeasonIcon = rc.Get<GameObject>("SeasonIcon");
            self.ScelectImg = rc.Get<GameObject>("ScelectImg");
        }
    }

    public static class UITaskBItemComponentSystem
    {
        public static void OnUpdateData(this UITaskBItemComponent self, int taskId)
        {
            self.TaskId = taskId;

            self.SeasonIcon.GetComponent<Button>().onClick.RemoveAllListeners();
            self.SeasonIcon.GetComponent<Button>().onClick.AddListener(() => { self.GetParent<UITaskBComponent>().UpdateInfo(self.TaskId); });
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskId);
            self.Text.GetComponent<Text>().text = taskConfig.TaskName;
            self.Img_line.SetActive(true);
        }

        public static void Selected(this UITaskBItemComponent self, int taskId)
        {
            self.ScelectImg.SetActive(self.TaskId == taskId);
        }
    }
}