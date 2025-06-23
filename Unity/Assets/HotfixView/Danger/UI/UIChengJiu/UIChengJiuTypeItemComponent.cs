using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChengJiuTypeItemComponent : Entity, IAwake, IDestroy
    {
        public GameObject GameObject;
        public GameObject Ima_CompleteTask;
        public GameObject Ima_Progress;
        public GameObject Lab_TaskNum;
        public GameObject Lab_TaskName;
        public GameObject Ima_Di;
        public GameObject Ima_SelectStatus;
        public GameObject Lab_TaskTip;

        public Action<int> ClickHandler;
        public int SubTypeId;
    }


    public class UIChengJiuTyperowAwakeSystem : AwakeSystem<UIChengJiuTypeItemComponent>
    {

        public override void Awake(UIChengJiuTypeItemComponent self)
        {
            self.GameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>(); 

            self.Ima_CompleteTask = rc.Get<GameObject>("Ima_CompleteTask");
            self.Ima_Progress = rc.Get<GameObject>("Ima_Progress");
            self.Lab_TaskNum = rc.Get<GameObject>("Lab_TaskNum");
            self.Lab_TaskName = rc.Get<GameObject>("Lab_TaskName");
            self.Ima_Di = rc.Get<GameObject>("Ima_Di");
            self.Ima_SelectStatus = rc.Get<GameObject>("Ima_SelectStatus");
            self.Lab_TaskTip = rc.Get<GameObject>("Lab_TaskTip");
            self.Ima_Di.GetComponent<Button>().onClick.AddListener(() => { self.OnClickButtoin(); });
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIChengJiuTypeItemComponentDestroy: DestroySystem<UIChengJiuTypeItemComponent>
    {
        public override void Destroy(UIChengJiuTypeItemComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIChengJiuTypeItemComponentSystem
    {
        public static void OnLanguageUpdate(this UIChengJiuTypeItemComponent self)
        {
            if (self.GameObject == null)
            {
                return;
            }

            self.Lab_TaskName.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 36;
            self.Lab_TaskTip.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 28;
        }
        
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
            self.Lab_TaskName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization(ChengJiuHelper.Instance.ChapterIndexText[subType]);
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
