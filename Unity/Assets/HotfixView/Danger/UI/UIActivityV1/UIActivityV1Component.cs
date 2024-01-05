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
        ActivityV1Shop = 4,
        ActivityV1DuiHuanWord = 5,
        ActivityV1ChouKa2 = 6,
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

            Vector2 startPosition = new Vector2(-20, -38);
            for (int i = 1; i <= 5; i++)
            {
                GameObject go = rc.Get<GameObject>($"Btn_{i}");
                if (ActivityConfigHelper.ActivityV1OpenList.Contains(i))
                {
                    go.SetActive(true);
                    go.GetComponent<RectTransform>().localPosition = startPosition;
                    startPosition.y -= 150;
                }
                else
                {
                    go.SetActive(false);
                }
            }

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
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1Shop] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1Shop");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1DuiHuanWord] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1DuiHuanWord");
            pageViewComponent.UISubViewPath[(int)ActivityV1PageEnum.ActivityV1ChouKa2] =
                    ABPathHelper.GetUGUIPath("Main/ActivityV1/UIActivityV1ChouKa2");

            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1ChouKa] = typeof (UIActivityV1ChouKaComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1Guess] = typeof (UIActivityV1GuessComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1Consume] = typeof (UIActivityV1ConsumeComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1HongBao] = typeof (UIActivityV1HongBaoComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1Shop] = typeof (UIActivityV1ShopComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1DuiHuanWord] = typeof (UIActivityV1DuiHuanWordComponent);
            pageViewComponent.UISubViewType[(int)ActivityV1PageEnum.ActivityV1ChouKa2] = typeof (UIActivityV1ChouKa2Component);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI ui = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(rc.Get<GameObject>("ScrollView"), new Vector2(300f, 316f));

            UIPageButtonComponent uIPageButtonComponent = ui.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageButtonComponent.OnSelectIndex(0);
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