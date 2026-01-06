using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public enum ActivityV1PageEnum: int
    {
        ActivityV1ChouKa = 0,
        ActivityV1Guess = 1,
        ActivityV1Consume = 2,
        ActivityV1HongBao = 3,
        ActivityV1DuiHuanWord = 4,
        ActivityV1ChouKa2 = 5,
        ActivityV1LiBao = 6,
        ActivityV1Feed = 7,
        ActivityV1Order = 8,
        ActivityV1GrowthTree = 9,
        ActivityV1WeeklyTask = 10,
        Number,
    }

    public class UIActivityV1Component: Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIActivityV1ComponentAwakeSystem: AwakeSystem<UIActivityV1Component>
    {
        public override void Awake(UIActivityV1Component self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)ActivityV1PageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ActivityV1PageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ActivityV1PageEnum.Number];

            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1ChouKa] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1ChouKa");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1Guess] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Guess");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1Consume] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Consume");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1HongBao] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1HongBao");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1DuiHuanWord] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1DuiHuanWord");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1ChouKa2] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1ChouKa2");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1LiBao] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1LiBao");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1Feed] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Feed");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1Order] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Order");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1GrowthTree] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1GrowthTree");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1WeeklyTask] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1WeeklyTask");

            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1ChouKa] = typeof (UIActivityV1ChouKaComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1Guess] = typeof (UIActivityV1GuessComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1Consume] = typeof (UIActivityV1ConsumeComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1HongBao] = typeof (UIActivityV1HongBaoComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1DuiHuanWord] = typeof (UIActivityV1DuiHuanWordComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1ChouKa2] = typeof (UIActivityV1ChouKa2Component);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1LiBao] = typeof (UIActivityV1LiBaoComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1Feed] = typeof (UIActivityV1FeedComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1Order] = typeof(UIActivityV1OrderComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1GrowthTree] = typeof(UIActivityV1GrowthTreeComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1WeeklyTask] = typeof(UIActivityV1WeeklyTaskComponent);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            self.FunctionSetBtn.transform.Find("Btn_1").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_ChouKa));
            self.FunctionSetBtn.transform.Find("Btn_2").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Guess));
            self.FunctionSetBtn.transform.Find("Btn_3").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Consume));
            self.FunctionSetBtn.transform.Find("Btn_4").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_HongBao));
            self.FunctionSetBtn.transform.Find("Btn_5").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_DuiHuanWord));
            self.FunctionSetBtn.transform.Find("Btn_6").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_ChouKa2));
            self.FunctionSetBtn.transform.Find("Btn_7").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_LiBao));
            self.FunctionSetBtn.transform.Find("Btn_8").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Feed));
            self.FunctionSetBtn.transform.Find("Btn_9").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Order));
            self.FunctionSetBtn.transform.Find("Btn_10").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_GrowthTree));
            self.FunctionSetBtn.transform.Find("Btn_11").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_WeeklyTask));


            int openindex = 0;
            for (int i = 1; i <= 11; i++)
            { 
                if(self.FunctionSetBtn.transform.Find($"Btn_{i}").gameObject.activeSelf)
                {
                    openindex = i - 1;  
                    break;
                }
            }


            UI ui = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);
            //IOS适配
            IPHoneHelper.SetPosition(rc.Get<GameObject>("ScrollView"), new Vector2(300f, -30f));

            UIPageButtonComponent uIPageButtonComponent = ui.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });

            uIPageButtonComponent.OnSelectIndex(openindex);
            self.UIPageButton = uIPageButtonComponent;
        }
    }

    public static class UIActivityV1ComponentSystem
    {
        public static void OnClickPageButton(this UIActivityV1Component self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}