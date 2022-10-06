using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIChengJiuShowComponent : Entity, IAwake
    {
        public GameObject ChengJiuListNode;
        public GameObject TypeListNode;

        public List<UI> TypeItemUIList;
        public List<UI> ChengJiuUIList;

        public int ChengTypeId;
    }

    [ObjectSystem]
    public class UIChengJiuShowComponentAwakeSystem : AwakeSystem<UIChengJiuShowComponent>
    {

        public override void Awake(UIChengJiuShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.ChengJiuListNode = rc.Get<GameObject>("ChengJiuListNode");
            self.TypeListNode = rc.Get<GameObject>("TypeListNode");

            self.TypeItemUIList = new List<UI>();
            self.ChengJiuUIList = new List<UI>();

            self.InitChengJiuList().Coroutine();
        }
    }


    public static class UIChengJiuShowComponentSystem
    {

        public static async ETTask InitChengJiuList(this UIChengJiuShowComponent self)
        {
            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuType");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            List<int> ids = new List<int>() { (int)ChengJiuTypeEnum.GuanKa, (int)ChengJiuTypeEnum.TanSuo, (int)ChengJiuTypeEnum.ShouJi };
            for (int i = 0; i < ids.Count; i++)
            {
                GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(taskTypeItem, self.TypeListNode);

                UI ui_1 = self.AddChild<UI, string, GameObject>( "taskTypeItem_" + i.ToString(), taskTypeItem);
                UIChengJiuTypeComponent uIItemComponent = ui_1.AddComponent<UIChengJiuTypeComponent>();
                uIItemComponent.OnUpdateData( ids[i] );
                uIItemComponent.SetClickSubTypeHandler((int typeid, int chapterId) => { self.OnClickTypeItem( typeid, chapterId); });
                self.TypeItemUIList.Add(ui_1);
            }

            self.TypeItemUIList[0].GetComponent<UIChengJiuTypeComponent>().OnClickTypeButton();
        }

        public static void OnClickTypeItem(this UIChengJiuShowComponent self,  int typeid, int chapterId)
        {
            self.ChengTypeId = typeid;
          
            for (int i = 0; i < self.TypeItemUIList.Count; i++)
            {
                UIChengJiuTypeComponent uIChengJiuTypeComponent = self.TypeItemUIList[i].GetComponent<UIChengJiuTypeComponent>();
                if (self.ChengTypeId == uIChengJiuTypeComponent.ChengJiuTypeId)
                {
                    continue;
                }
                uIChengJiuTypeComponent.UnSelectedAll();
            }

            self.OnUpdateChapterTask(self.ChengTypeId, chapterId).Coroutine();
        }


        public static async ETTask  OnUpdateChapterTask(this UIChengJiuShowComponent self, int typeid, int chapterId)
        {
            long instanceid = self.InstanceId;
            List<int> ids = self.ZoneScene().GetComponent<ChengJiuComponent>().GetTasksByChapter( typeid, chapterId);
            string path = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuShowItem");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            for (int i = 0; i < ids.Count; i++)
            {
                UI ui_1;
                if (i < self.ChengJiuUIList.Count)
                {
                    ui_1 = self.ChengJiuUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject uiChengJiuShowItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(uiChengJiuShowItem, self.ChengJiuListNode);
                    ui_1 = self.AddChild<UI, string, GameObject>( "uiChengJiuShowItem_" + i.ToString(), uiChengJiuShowItem);
                    ui_1.AddComponent<UIChengJiuShowItemComponent>();
                    self.ChengJiuUIList.Add(ui_1);
                }
                ui_1.GetComponent<UIChengJiuShowItemComponent>().OnUpdateData(ids[i]);
            }
            for (int  i = ids.Count; i < self.ChengJiuUIList.Count; i++)
            {
                self.ChengJiuUIList[i].GameObject.SetActive(false);
            }
        }
    }
}
