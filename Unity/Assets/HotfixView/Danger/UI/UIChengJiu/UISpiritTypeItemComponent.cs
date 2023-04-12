using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISpiritTypeItemComponent : Entity, IAwake
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


    public class UISpiritTyperowAwakeSystem : AwakeSystem<UISpiritTypeItemComponent>
    {

        public override void Awake(UISpiritTypeItemComponent self)
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

    public static class UISpiritTypeItemComponentSystem
    {
        public static void SetSelected(this UISpiritTypeItemComponent self, int subTypeid)
        {
            self.Ima_SelectStatus.SetActive(subTypeid == self.SubTypeId);
        }

        public static void OnUpdateData(this UISpiritTypeItemComponent self,  int typeid, int subType)
        {
            self.SubTypeId = subType;
            /*
            UIChengJiuComponent SpiritComponent = self.ZoneScene().GetComponent<UIChengJiuComponent>();
            List<int> ids = ChengJiuComponent.GetTasksByChapter(typeid, subType);
            int number = 0;
            for (int i = 0; i < ids.Count; i++)
            {
                number += SpiritComponent.SpiritCompleteList.Contains(ids[i]) ? 1 : 0;
            }
            
            self.Lab_TaskNum.GetComponent<Text>().text = string.Format(" ({0}/{1})", number, ids.Count);
            self.Lab_TaskName.GetComponent<Text>().text = SpiritHelper.Instance.ChapterIndexText[subType];
            self.Ima_Progress.transform.localScale = new Vector3(number*1f / ids.Count,1f, 1f);
            self.Ima_CompleteTask.SetActive(number >= ids.Count);
            */
        }

        public static void SetClickSubTypeHandler(this UISpiritTypeItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnClickButtoin(this UISpiritTypeItemComponent self)
        {
            self.ClickHandler(self.SubTypeId);
        }
    }
}
