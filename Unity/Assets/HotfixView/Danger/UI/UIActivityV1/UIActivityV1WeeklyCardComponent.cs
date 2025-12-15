using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1WeeklyCardComponent : Entity, IAwake
    {
        public GameObject Text_Number;
        public GameObject ButtonOpen;
        public GameObject UIActivityV1WeeklyCardItem;
        public GameObject TaskListNode;
        public GameObject BtnItemTypeSet;
        public UIPageButtonComponent uIPageViewComponent;

        public List<UIActivityV1WeeklyCardItemComponent> WeeklyCardItemList = new List<UIActivityV1WeeklyCardItemComponent>();    
    }

    public class UIActivityV1WeeklyCardComponentAwake : AwakeSystem<UIActivityV1WeeklyCardComponent>
    {
        public override void Awake(UIActivityV1WeeklyCardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            self.WeeklyCardItemList.Clear();

            self.UIActivityV1WeeklyCardItem = rc.Get<GameObject>("UIActivityV1WeeklyCardItem");
            self.UIActivityV1WeeklyCardItem.SetActive(false);
            self.TaskListNode = rc.Get<GameObject>("TaskListNode");

            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            self.uIPageViewComponent = uIPageViewComponent;
            uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);
        }
    }

    public static class UIActivityV1WeeklyCardComponentSystem
    {
        public static void OnClickPageButton(this UIActivityV1WeeklyCardComponent self, int page)
        {
            self.UpdateInfo();
        }


        public static void UpdateInfo(this UIActivityV1WeeklyCardComponent self)
        {
            int dtype = self.uIPageViewComponent.CurrentIndex ;
            List<string> rewardlist = ActivityConfigHelper.ActivityV1WeeklyCardReward[dtype + 1];

            for (int i = 0; i < rewardlist.Count; i++)
            {
                string rewarditem = rewardlist[i];
                UIActivityV1WeeklyCardItemComponent component = null;

                if (i < self.WeeklyCardItemList.Count)
                {
                    component = self.WeeklyCardItemList[i];
                }
                else
                {
                    GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1WeeklyCardItem);
                    component = self.AddChild<UIActivityV1WeeklyCardItemComponent, GameObject>(go);
                    UICommonHelper.SetParent(go, self.TaskListNode);
                    go.SetActive(true);
                    self.WeeklyCardItemList.Add(component);
                }

                component.OnUpdateData(dtype + ActivityConfigHelper.ActivityV1_GoldWeeklyCard, i);
            }

            for (int i = 0; i < self.WeeklyCardItemList.Count; i++)
            {
                

            }
        }
    }
}