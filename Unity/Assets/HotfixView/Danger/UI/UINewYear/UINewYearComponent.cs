using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum NewYearPageEnum : int
    {
        CollectionWord = 0,
        NewYearMonster = 1,
        ActivityV1Task = 2,
        ActivityV1Points = 3,
        ActivityV1Shop = 4,
        ActivityV1PointsChouKa = 5,
        ActivityV1ChouKa = 6,
        ActivityV1Guess = 7,
        ActivityV1Consume = 8,
        ActivityV1HongBao = 9,
        ActivityV1DuiHuanWord = 10,
        ActivityV1ChouKa2 = 11,
        ActivityV1LiBao = 12,
        ActivityV1Feed = 13,
        ActivityV1Order = 14,
        ActivityV1GrowthTree = 15,
        ActivityV1WeeklyTask = 16,
        ActivityV1PointsShunXu = 17,
        Number,
    }

    public class UINewYearComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public GameObject ScrollView;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }


    public class UINewYearComponentAwake : AwakeSystem<UINewYearComponent>
    {
        public override void Awake(UINewYearComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");
            self.ScrollView = rc.Get<GameObject>("ScrollView");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)NewYearPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)NewYearPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)NewYearPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.CollectionWord] = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearCollectionWord");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.NewYearMonster] = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearMonster");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1Task] = ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Task");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1Points] = ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Points");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1Shop] = ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Shop");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1PointsChouKa] = ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1PointsChouKa");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1ChouKa] =
                   ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1ChouKa");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1Guess] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Guess");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1Consume] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Consume");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1HongBao] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1HongBao");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1DuiHuanWord] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1DuiHuanWord");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1ChouKa2] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1ChouKa2");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1LiBao] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1LiBao");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1Feed] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Feed");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1Order] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Order");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1GrowthTree] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1GrowthTree");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.ActivityV1WeeklyTask] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1WeeklyTask");


            pageViewComponent.UISubViewType[(int)NewYearPageEnum.CollectionWord] = typeof(UINewYearCollectionWordComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.NewYearMonster] = typeof(UINewYearMonsterComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1Task] = typeof (UIActivityV1TaskComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1Points] = typeof(UIActivityV1PointsComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1Shop] = typeof(UIActivityV1ShopComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1PointsChouKa] = typeof(UIActivityV1PointsChouKaComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1ChouKa] = typeof(UIActivityV1ChouKaComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1Guess] = typeof(UIActivityV1GuessComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1Consume] = typeof(UIActivityV1ConsumeComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1HongBao] = typeof(UIActivityV1HongBaoComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1DuiHuanWord] = typeof(UIActivityV1DuiHuanWordComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1ChouKa2] = typeof(UIActivityV1ChouKa2Component);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1LiBao] = typeof(UIActivityV1LiBaoComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1Feed] = typeof(UIActivityV1FeedComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1Order] = typeof(UIActivityV1OrderComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1GrowthTree] = typeof(UIActivityV1GrowthTreeComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.ActivityV1WeeklyTask] = typeof(UIActivityV1WeeklyTaskComponent);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            self.FunctionSetBtn.transform.Find("Btn_Type1").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_NewYearCollectionWord));
            self.FunctionSetBtn.transform.Find("Btn_Type2").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_NewYearMonster));
            self.FunctionSetBtn.transform.Find("Btn_Type3").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Task));
            self.FunctionSetBtn.transform.Find("Btn_Type4").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Points));
            self.FunctionSetBtn.transform.Find("Btn_Type5").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Shop));
            self.FunctionSetBtn.transform.Find("Btn_Type6").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_PointsChouKa));

            self.FunctionSetBtn.transform.Find("Btn_Type7").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_ChouKa));
            self.FunctionSetBtn.transform.Find("Btn_Type8").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Guess));
            self.FunctionSetBtn.transform.Find("Btn_Type9").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Consume));
            self.FunctionSetBtn.transform.Find("Btn_Type10").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_HongBao));
            self.FunctionSetBtn.transform.Find("Btn_Type11").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_DuiHuanWord));
            self.FunctionSetBtn.transform.Find("Btn_Type12").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_ChouKa2));
            self.FunctionSetBtn.transform.Find("Btn_Type13").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_LiBao));
            self.FunctionSetBtn.transform.Find("Btn_Type14").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Feed));
            self.FunctionSetBtn.transform.Find("Btn_Type15").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_Order));
            self.FunctionSetBtn.transform.Find("Btn_Type16").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_GrowthTree));
            self.FunctionSetBtn.transform.Find("Btn_Type17").gameObject.SetActive(activityV1Info.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_WeeklyTask));

            //self.FunctionSetBtn.transform.Find("Btn_Type6").gameObject.SetActive( GMHelp.GmAccount.Contains( self.ZoneScene().GetComponent<AccountInfoComponent>().Account ) );

            int openindex = 0;
            for (int i = 1; i <= 17; i++)
            {
                if (self.FunctionSetBtn.transform.Find($"Btn_Type{i}").gameObject.activeSelf)
                {
                    openindex = i - 1;
                    break;
                }
            }


            //IOS适配
            IPHoneHelper.SetPosition(self.ScrollView, new Vector2(120f, -77f));

            UIPageButtonComponent uIPageButtonComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });
            self.UIPageButtonComponent = uIPageButtonComponent;
            self.UIPageButtonComponent.OnSelectIndex(openindex);
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);

            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.RegisterReddot(ReddotType.NewYear, self.Reddot_NewYear);
        }
    }
    
    public class UINewYearComponentDestroySystem : DestroySystem<UINewYearComponent>
    {
        public override void Destroy(UINewYearComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);

            if (self.ZoneScene() != null)
            {
                ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
                redPointComponent?.UnRegisterReddot(ReddotType.NewYear, self.Reddot_NewYear);
            }
        }
    }

    public static class UINewYearComponentAwakeSystem
    {
        public static void Reddot_NewYear(this UINewYearComponent self, int num)
        {
            self.UIPageButtonComponent.SetButtonReddot((int)NewYearPageEnum.ActivityV1Task, num > 0);
        }

        public static void OnLanguageUpdate(this UINewYearComponent self)
        {
            Transform tt = self.UIPageButtonComponent.GetParent<UI>().GameObject.transform;

            int childCount = tt.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = tt.transform.GetChild(i);

                Transform XuanZhong = transform.Find("XuanZhong");
                if (XuanZhong)
                {
                    RectTransform rt = XuanZhong.GetComponent<RectTransform>();
                    Vector2 size = rt.sizeDelta;
                    size.x = GameSettingLanguge.Language == 0? 100f : 200f;
                    rt.sizeDelta = size;
                    
                    Text text = XuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }

                Transform WeiXuanZhong = transform.Find("WeiXuanZhong");
                if (WeiXuanZhong)
                {
                    RectTransform rt = WeiXuanZhong.GetComponent<RectTransform>();
                    Vector2 size = rt.sizeDelta;
                    size.x = GameSettingLanguge.Language == 0? 100f : 200f;
                    rt.sizeDelta = size;
                    
                    Text text = WeiXuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }
            }
        }
        
        public static void OnClickPageButton(this UINewYearComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
