using System;
using UnityEngine;

namespace ET
{
    public enum WatchPageEnum : int
    { 
        Equip = 0,
        Pet = 1,

        Number
    }

    public class UIWatchComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageButtonComponent UIPageButton;
        public UIPageViewComponent UIPageView;

        public F2C_WatchPlayerResponse F2C_WatchPlayerResponse;
    }

    [ObjectSystem]
    public class UIWatchComponentAwakeSystem : AwakeSystem<UIWatchComponent>
    {
        public override void Awake(UIWatchComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
          
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();

            pageViewComponent.UISubViewList = new UI[(int)WatchPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)WatchPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)WatchPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)WatchPageEnum.Equip] = ABPathHelper.GetUGUIPath("Main/Watch/UIWatchEquip");
            pageViewComponent.UISubViewPath[(int)WatchPageEnum.Pet] = ABPathHelper.GetUGUIPath("Main/Pet/UIPetList");
            pageViewComponent.UISubViewType[(int)WatchPageEnum.Equip] = typeof(UIWatchEquipComponent);
            pageViewComponent.UISubViewType[(int)WatchPageEnum.Pet] = typeof(UIWatchPetComponent);

            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);
            self.UIPageButton = pageButton.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton.ClickEnabled = false;
        }
    }

    public static class UIWatchComponentSystem
    {
        public static void OnClickPageButton(this UIWatchComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void OnClickImageBg(this UIWatchComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIWatch);
        }

        public static void OnUpdateUI(this UIWatchComponent self, F2C_WatchPlayerResponse m2C_WatchPlayerResponse)
        {
            self.F2C_WatchPlayerResponse = m2C_WatchPlayerResponse;
            self.UIPageButton.ClickEnabled = true;
            self.UIPageButton.OnSelectIndex(0);
        }
    }
}
