using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum UnionMysteryEnum: int
    {
        UnionMystery_A = 0,
        UnionMystery_B = 1,
        Number
    }

    public class UIUnionMysteryComponent: Entity, IAwake, IDestroy
    {
        public UI UIPageButton;
        public UIPageViewComponent UIPageView;
        public GameObject FunctionSetBtn;

        public GameObject closeButton;
    }

    public class UIUnionMysteryComponentAwake: AwakeSystem<UIUnionMysteryComponent>
    {
        public override void Awake(UIUnionMysteryComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)UnionMysteryEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)UnionMysteryEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)UnionMysteryEnum.Number];

            pageViewComponent.UISubViewPath[(int)UnionMysteryEnum.UnionMystery_A] = ABPathHelper.GetUGUIPath("Main/Union/UIUnionMystery_A");
            pageViewComponent.UISubViewType[(int)UnionMysteryEnum.UnionMystery_A] = typeof (UIUnionMystery_AComponent);

            pageViewComponent.UISubViewPath[(int)UnionMysteryEnum.UnionMystery_B] = ABPathHelper.GetUGUIPath("Main/Union/UIUnionMystery_B");
            pageViewComponent.UISubViewType[(int)UnionMysteryEnum.UnionMystery_B] = typeof (UIUnionMystery_BComponent);

            self.UIPageView = pageViewComponent;

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uiPage;

            //IOS适配
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseStore(); });
        }
    }

    public static class UIUnionMysteryComponentSystem
    {
        public static void OnClickPageButton(this UIUnionMysteryComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void OnCloseStore(this UIUnionMysteryComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIUnionMystery);
        }
    }
}