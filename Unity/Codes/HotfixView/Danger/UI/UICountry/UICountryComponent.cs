using UnityEngine;
using UnityEngine.UI;
using System;


namespace ET
{

    public enum CountryPageEnum : int
    {
        CountryTask = 0,
        SingIn = 1,

        Number ,
    }

    public class UICountryComponent : Entity, IAwake, IDestroy
    {
        public GameObject Btn_Close;

        public UI UIPageButton;
        public UIPageViewComponent UIPageView;
    }

    [ObjectSystem]
    public class UIDayTaskComponentAwakeSystem : AwakeSystem<UICountryComponent>
    {

        public override void Awake(UICountryComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("SubViewNode", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            self.UIPageView = pageViewComponent;
            pageViewComponent.UISubViewList = new UI[(int)CountryPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)CountryPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)CountryPageEnum.Number];
            //增加每日活跃
            pageViewComponent.UISubViewPath[(int)CountryPageEnum.CountryTask] = ABPathHelper.GetUGUIPath("Main/Country/UICountryTask");
            pageViewComponent.UISubViewType[(int)CountryPageEnum.CountryTask] = typeof(UICountryTaskComponent);

            //增加活动列表
            //pageViewComponent.UISubViewPath[(int)CountryPageEnum.CountryHuoDong] = ABPathHelper.GetUGUIPath("Main/Country/UICountryHuoDong");
            //pageViewComponent.UISubViewType[(int)CountryPageEnum.CountryHuoDong] = typeof(UICountryHuoDongComponent);

            //增加宝箱活动
            //pageViewComponent.UISubViewPath[(int)CountryPageEnum.CountryChest] = ABPathHelper.GetUGUIPath("Main/Country/UICountryChest");
            //pageViewComponent.UISubViewType[(int)CountryPageEnum.CountryChest] = typeof(UICountryChestComponent);

            pageViewComponent.UISubViewPath[(int)CountryPageEnum.SingIn] = ABPathHelper.GetUGUIPath("Main/Activity/UIActivitySingIn");
            pageViewComponent.UISubViewType[(int)CountryPageEnum.SingIn] = typeof(UIActivitySingInComponent);

            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPageButton = self.AddChild<UI, string, GameObject>("FunctionBtnSet", BtnItemTypeSet);
            self.UIPageButton = uiPageButton;
            UIPageButtonComponent uIPageViewComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);

            self.Btn_Close = rc.Get<GameObject>("ImageButton");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });

            DataUpdateComponent.Instance.AddListener(DataType.UpdateRoleData, self);
        }
    }

    [ObjectSystem]
    public class UICountryComponentDestroySystem : DestroySystem<UICountryComponent>
    {
        public override void Destroy(UICountryComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.UpdateRoleData, self);
        }
    }

    public static class UICountryComponentSystem
    {

        public static void OnUpdateRoleData(this UICountryComponent self, string updateType)
        {
            UserDataType userDataType = (UserDataType)int.Parse(updateType.Split('_')[0]);
            if (userDataType == UserDataType.HuoYue && self.UIPageView.UISubViewList[(int)CountryPageEnum.CountryTask]!=null)
            {
                self.UIPageView.UISubViewList[(int)CountryPageEnum.CountryTask].GetComponent<UICountryTaskComponent>().OnTaskCountryUpdate();
            }
        }

        public static void OnTaskCountryUpdate(this UICountryComponent self)
        {
            if (self.UIPageView.UISubViewList[(int)CountryPageEnum.CountryTask] != null)
            {
                self.UIPageView.UISubViewList[(int)CountryPageEnum.CountryTask].GetComponent<UICountryTaskComponent>().OnTaskCountryUpdate();
            }
        }

        public static void OnClickPageButton(this UICountryComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void OnBtn_Close(this UICountryComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UICountry); 
        }
    }

}
