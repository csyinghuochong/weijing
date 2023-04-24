using UnityEngine;
using System;

namespace ET
{

    public enum DonationEnum : int
    {
        Show = 0,
        Union = 1,
        Number,
    }

    public class UIDonationComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIDonationComponentAwake :AwakeSystem<UIDonationComponent>
    {
        public override void Awake(UIDonationComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");

            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)DonationEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)DonationEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)DonationEnum.Number];
            pageViewComponent.UISubViewPath[(int)DonationEnum.Show] = ABPathHelper.GetUGUIPath("Main/Donation/UIDonationShow");
            pageViewComponent.UISubViewPath[(int)DonationEnum.Union] = ABPathHelper.GetUGUIPath("Main/Donation/UIDonationUnion");
          
            pageViewComponent.UISubViewType[(int)DonationEnum.Show] = typeof(UIDonationShowComponent);
            pageViewComponent.UISubViewType[(int)DonationEnum.Union] = typeof(UIDonationUnionComponent);
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

    public static class UIDonationComponentSystem
    {
        public static void OnClickPageButton(this UIDonationComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
