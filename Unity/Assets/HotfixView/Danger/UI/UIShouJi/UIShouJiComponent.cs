using System;
using UnityEngine;


namespace ET
{

    public enum ShouJiPageEnum : int
    {
        ShouJiList = 0,
        ShouJiTreasure = 1,
      
        Number ,
    }

    public class UIShouJiComponent : Entity, IAwake
    {
        public GameObject FunctionSetBtn;
        public GameObject SubViewNode;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }

    [ObjectSystem]
    public class UIShouJiComponentAwakeSystem : AwakeSystem<UIShouJiComponent>
    {
        public override void Awake(UIShouJiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            UI uiPageView = self.AddChild<UI, string, GameObject>("SubViewNode", self.SubViewNode);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)ShouJiPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ShouJiPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ShouJiPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)ShouJiPageEnum.ShouJiList] = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiList");
            pageViewComponent.UISubViewPath[(int)ShouJiPageEnum.ShouJiTreasure] = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiTreasure");
          
            pageViewComponent.UISubViewType[(int)ShouJiPageEnum.ShouJiList] = typeof(UIShouJiListComponent);
            pageViewComponent.UISubViewType[(int)ShouJiPageEnum.ShouJiTreasure] = typeof(UIShouJiTreasureComponent);
            self.UIPageView = pageViewComponent;

            UI uiPageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });
            self.UIPageButtonComponent = uIPageButtonComponent;
            self.UIPageButtonComponent.OnSelectIndex(0);

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIShouJiComponentSystem
    {

        public static void OnShouJiTreasure(this UIShouJiComponent self)
        {
            self.UIPageView.UISubViewList[(int)ShouJiPageEnum.ShouJiTreasure].GetComponent<UIShouJiTreasureComponent>().OnShouJiTreasure();  
        }

        public static void OnClickPageButton(this UIShouJiComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static async ETTask OnUpdateUI(this UIShouJiComponent self)
        {
            await ETTask.CompletedTask;
        }
    }
}
