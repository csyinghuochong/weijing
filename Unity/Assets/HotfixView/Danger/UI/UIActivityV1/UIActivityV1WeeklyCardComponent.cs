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
    }

    public class UIActivityV1WeeklyCardComponentAwake : AwakeSystem<UIActivityV1WeeklyCardComponent>
    {
        public override void Awake(UIActivityV1WeeklyCardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");

            self.UIActivityV1WeeklyCardItem = rc.Get<GameObject>("UIActivityV1WeeklyCardItem");
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
            List<string> rewardlist = ActivityConfigHelper.ActivityV1WeeklyCardReward[ self.uIPageViewComponent.CurrentIndex + 1];
            foreach (string rewarditem in rewardlist)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1WeeklyCardItem);
               
                UICommonHelper.SetParent(go, self.TaskListNode);
                go.SetActive(true);
            }
        }
    }
}