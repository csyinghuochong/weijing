using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum SeasonPageEnum
    {
        Home = 0,
        Task = 1,
        JingHe = 2,
        Store = 3,
        Tower = 4,
        Number,
    }

    public class UISeasonComponent: Entity, IAwake, IDestroy
    {
        public GameObject Btn_Tower;
        public GameObject ImageButton;
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UISeasonComponentAwakeSystem: AwakeSystem<UISeasonComponent>
    {
        public override void Awake(UISeasonComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();

            pageViewComponent.UISubViewList = new UI[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.Home] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonHome");
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.Task] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonTask");
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.JingHe] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonJingHe");
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.Store] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonStore");
            pageViewComponent.UISubViewPath[(int)SeasonPageEnum.Tower] = ABPathHelper.GetUGUIPath("Main/Season/UISeasonTower");

            pageViewComponent.UISubViewType[(int)SeasonPageEnum.Home] = typeof (UISeasonHomeComponent);
            pageViewComponent.UISubViewType[(int)SeasonPageEnum.Task] = typeof (UISeasonTaskComponent);
            pageViewComponent.UISubViewType[(int)SeasonPageEnum.JingHe] = typeof (UISeasonJingHeComponent);
            pageViewComponent.UISubViewType[(int)SeasonPageEnum.Store] = typeof (UISeasonStoreComponent);
            pageViewComponent.UISubViewType[(int)SeasonPageEnum.Tower] = typeof (UISeasonTowerComponent);
            self.UIPageView = pageViewComponent;

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(self.OnCloseChengJiu);

            self.Btn_Tower = rc.Get<GameObject>("Btn_Tower");
            self.Btn_Tower.SetActive( true );

            self.SubViewNode = rc.Get<GameObject>("SubViewNode");
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiJoystick = self.AddChild<UI, string, GameObject>("FunctionBtnSet", BtnItemTypeSet);
            self.UIPageButton = uiJoystick.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((page) => { self.OnClickPageButton(page); });
            self.UIPageButton.OnSelectIndex(0);

            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UISeasonComponentDestroySystem : DestroySystem<UISeasonComponent>
    {
        public override void Destroy(UISeasonComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UISeasonComponentSystem
    {
        public static void OnLanguageUpdate(this UISeasonComponent self)
        {
            Transform tt = self.UIPageButton.GetParent<UI>().GameObject.transform;

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
        
        public static void OnClickPageButton(this UISeasonComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void OnCloseChengJiu(this UISeasonComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UISeason);
        }
    }
}