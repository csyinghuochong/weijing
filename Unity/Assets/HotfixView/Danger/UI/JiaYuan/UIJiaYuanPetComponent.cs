using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum JiaYuanPetEnum : int
    {
        Walk = 0,

        Number,
    }

    public class UIJiaYuanPetComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }

    public class UIJiaYuanPetComponentAwake : AwakeSystem<UIJiaYuanPetComponent>
    {
        public override void Awake(UIJiaYuanPetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionSetBtn", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)JiaYuanPetEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)JiaYuanPetEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)JiaYuanPetEnum.Number];

            pageViewComponent.UISubViewPath[(int)JiaYuanPetEnum.Walk] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPetWalk");
           
            pageViewComponent.UISubViewType[(int)JiaYuanPetEnum.Walk] = typeof(UIJiaYuanPetWalkComponent);
          
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });

            self.UIPageButtonComponent = uIPageButtonComponent;
            self.UIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UIJiaYuanPetComponentSystem
    {
        public static void OnClickPageButton(this UIJiaYuanPetComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
