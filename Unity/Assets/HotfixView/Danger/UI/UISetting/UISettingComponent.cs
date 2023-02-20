using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{

    public enum SettingEnum : int
    { 
        Game = 0,
        Title = 1,  

        Number,
    }

    public class UISettingComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    [ObjectSystem]
    public class UISettingComponentAwakeSystem : AwakeSystem<UISettingComponent>
    {
        public override void Awake(UISettingComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            //IOS适配
            IPHoneHelper.SetPosition(rc.Get<GameObject>("FunctionSetBtn"), new Vector2(300f, 316f));

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)SettingEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)SettingEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)SettingEnum.Number];
            pageViewComponent.UISubViewPath[(int)SettingEnum.Game] = ABPathHelper.GetUGUIPath("Main/Setting/UISettingGame");
            pageViewComponent.UISubViewPath[(int)SettingEnum.Title] = ABPathHelper.GetUGUIPath("Main/Setting/UISettingTitle");
           
            pageViewComponent.UISubViewType[(int)SettingEnum.Game] = typeof(UISettingGameComponent);
            pageViewComponent.UISubViewType[(int)SettingEnum.Title] = typeof(UISettingTitleComponent);
            
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            self.UIPageButton = pageButton.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton.OnSelectIndex(0);
        }
    }

    public static class UISettingComponentSystem
    {

        public static void OnBeforeClose(this UISettingComponent self)
        {
            UI uI = self.UIPageView.UISubViewList[(int)SettingEnum.Game];
            if (uI != null)
            { 
                uI.GetComponent<UISettingGameComponent>().OnBeforeClose();  
            }
        }

        public static void OnTitleUse(this UISettingComponent self)
        {
            UI uI = self.UIPageView.UISubViewList[(int)SettingEnum.Title];
            if (uI != null)
            {
                uI.GetComponent<UISettingTitleComponent>().OnUpdateUI();
            }
        }

        public static void OnClickPageButton(this UISettingComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
