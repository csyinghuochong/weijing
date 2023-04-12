using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UISpiritShowComponent : Entity, IAwake
    {
        public GameObject SpiritListNode;
        public GameObject TypeListNode;

        public List<UI> TypeItemUIList;
        public List<UI> SpiritUIList;

        public int ChengTypeId;
    }


    public class UISpiritShowComponentAwakeSystem : AwakeSystem<UISpiritShowComponent>
    {

        public override void Awake(UISpiritShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.SpiritListNode = rc.Get<GameObject>("SpiritListNode");
            self.TypeListNode = rc.Get<GameObject>("TypeListNode");

            self.TypeItemUIList = new List<UI>();
            self.SpiritUIList = new List<UI>();

            self.InitSpiritList().Coroutine();
        }
    }


    public static class UISpiritShowComponentSystem
    {

        public static async ETTask InitSpiritList(this UISpiritShowComponent self)
        {
            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/Spirit/UISpiritType");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            List<int> ids = new List<int>() { (int)SpiritTypeEnum.GuanKa, (int)SpiritTypeEnum.TanSuo, (int)SpiritTypeEnum.ShouJi };
            for (int i = 0; i < ids.Count; i++)
            {
                GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(taskTypeItem, self.TypeListNode);

                UI ui_1 = self.AddChild<UI, string, GameObject>( "taskTypeItem_" + i.ToString(), taskTypeItem);
                UISpiritTypeComponent uIItemComponent = ui_1.AddComponent<UISpiritTypeComponent>();
                uIItemComponent.OnUpdateData( ids[i] );
                uIItemComponent.SetClickSubTypeHandler((int typeid, int chapterId) => { self.OnClickTypeItem( typeid, chapterId); });
                self.TypeItemUIList.Add(ui_1);
            }

            self.TypeItemUIList[0].GetComponent<UISpiritTypeComponent>().OnClickTypeButton();
        }

        public static void OnClickTypeItem(this UISpiritShowComponent self,  int typeid, int chapterId)
        {
            self.ChengTypeId = typeid;
          
            for (int i = 0; i < self.TypeItemUIList.Count; i++)
            {
                UISpiritTypeComponent uISpiritTypeComponent = self.TypeItemUIList[i].GetComponent<UISpiritTypeComponent>();
                if (self.ChengTypeId == uISpiritTypeComponent.SpiritTypeId)
                {
                    continue;
                }
                uISpiritTypeComponent.UnSelectedAll();
            }

            self.OnUpdateChapterTask(self.ChengTypeId, chapterId).Coroutine();
        }


        public static async ETTask  OnUpdateChapterTask(this UISpiritShowComponent self, int typeid, int chapterId)
        {
            long instanceid = self.InstanceId;
            List<int> ids = self.ZoneScene().GetComponent<ChengJiuComponent>().GetTasksByChapter( typeid, chapterId);
            string path = ABPathHelper.GetUGUIPath("Main/Spirit/UISpiritShowItem");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            for (int i = 0; i < ids.Count; i++)
            {
                UI ui_1;
                if (i < self.SpiritUIList.Count)
                {
                    ui_1 = self.SpiritUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject uiSpiritShowItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(uiSpiritShowItem, self.SpiritListNode);
                    ui_1 = self.AddChild<UI, string, GameObject>( "uiSpiritShowItem_" + i.ToString(), uiSpiritShowItem);
                    ui_1.AddComponent<UISpiritShowItemComponent>();
                    self.SpiritUIList.Add(ui_1);
                }
                ui_1.GetComponent<UISpiritShowItemComponent>().OnUpdateData(ids[i]);
            }
            for (int  i = ids.Count; i < self.SpiritUIList.Count; i++)
            {
                self.SpiritUIList[i].GameObject.SetActive(false);
            }
        }
    }
}
