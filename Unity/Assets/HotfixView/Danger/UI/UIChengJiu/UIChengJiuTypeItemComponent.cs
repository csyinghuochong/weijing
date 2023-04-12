using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChengJiuTypeItemComponent : Entity, IAwake
    {
        public GameObject Ima_CompleteTask;
        public GameObject Ima_Progress;
        public GameObject Lab_TaskNum;
        public GameObject Lab_TaskName;
        public GameObject Ima_Di;
        public GameObject Ima_SelectStatus;

        public Action<int> ClickHandler;
        public int SubTypeId;
    }


    public class UIChengJiuTyperowAwakeSystem : AwakeSystem<UIChengJiuTypeItemComponent>
    {

        public override void Awake(UIChengJiuTypeItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>(); 

            self.Ima_CompleteTask = rc.Get<GameObject>("Ima_CompleteTask");
            self.Ima_Progress = rc.Get<GameObject>("Ima_Progress");
            self.Lab_TaskNum = rc.Get<GameObject>("Lab_TaskNum");
            self.Lab_TaskName = rc.Get<GameObject>("Lab_TaskName");
            self.Ima_Di = rc.Get<GameObject>("Ima_Di");
            self.Ima_SelectStatus = rc.Get<GameObject>("Ima_SelectStatus");
            self.Ima_Di.GetComponent<Button>().onClick.AddListener(() => { self.OnClickButtoin(); });
        }
    }

    public static class UIChengJiuTypeItemComponentSystem
    {
        public static void SetSelected(this UIChengJiuTypeItemComponent self, int subTypeid)
        {
            self.Ima_SelectStatus.SetActive(subTypeid == self.SubTypeId);
        }

        public static void OnUpdateData(this UIChengJiuTypeItemComponent self,  int typeid, int subType)
        {
            self.SubTypeId = subType;

            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            List<int> ids = chengJiuComponent.GetTasksByChapter(typeid, subType);
            int number = 0;
            for (int i = 0; i < ids.Count; i++)
            {
                number += chengJiuComponent.ChengJiuCompleteList.Contains(ids[i]) ? 1 : 0;
            }

            self.Lab_TaskNum.GetComponent<Text>().text = string.Format(" ({0}/{1})", number, ids.Count);
            self.Lab_TaskName.GetComponent<Text>().text = ChengJiuHelper.Instance.ChapterIndexText[subType];
            self.Ima_Progress.transform.localScale = new Vector3(number*1f / ids.Count,1f, 1f);
            self.Ima_CompleteTask.SetActive(number >= ids.Count);
        }

        public static void SetClickSubTypeHandler(this UIChengJiuTypeItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnClickButtoin(this UIChengJiuTypeItemComponent self)
        {
            self.ClickHandler(self.SubTypeId);
        }
    }
}
