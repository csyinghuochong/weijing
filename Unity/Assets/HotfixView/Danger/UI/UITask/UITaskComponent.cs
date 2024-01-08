using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum TaskPageEnum
    {
        TaskA,
        TaskB,

        Number
    }

    public class UITaskComponent: Entity, IAwake
    {
        public GameObject Btn_2;
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UITaskComponentAwake: AwakeSystem<UITaskComponent>
    {
        public override void Awake(UITaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)TaskPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)TaskPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)TaskPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)TaskPageEnum.TaskA] = ABPathHelper.GetUGUIPath("Main/Task/UITaskA");
            pageViewComponent.UISubViewPath[(int)TaskPageEnum.TaskB] = ABPathHelper.GetUGUIPath("Main/Task/UITaskB");

            pageViewComponent.UISubViewType[(int)TaskPageEnum.TaskA] = typeof (UITaskAComponent);
            pageViewComponent.UISubViewType[(int)TaskPageEnum.TaskB] = typeof (UITaskBComponent);

            self.UIPageView = pageViewComponent;

            self.Btn_2 = rc.Get<GameObject>("Btn_2");
            // self.Btn_2.SetActive(GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account));

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageViewComponent;
        }
    }

    public static class UITaskComponentSystem
    {
        public static void OnClickPageButton(this UITaskComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}