using System;
using UnityEngine;

namespace ET
{
    public enum ProtectkPageEnum : int
    {
        ProtectEquip    = 0,
        ProtectPet      = 1,     
        Number,
    }

    public class UIProtectComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public UIPageViewComponent UIPageView;
    }

    public class UIProtectComponentAwake : AwakeSystem<UIProtectComponent>
    {
        public override void Awake(UIProtectComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)ProtectkPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ProtectkPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ProtectkPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)ProtectkPageEnum.ProtectEquip] = ABPathHelper.GetUGUIPath("Main/Protect/UIProtectEquip");
            pageViewComponent.UISubViewPath[(int)ProtectkPageEnum.ProtectPet] = ABPathHelper.GetUGUIPath("Main/Protect/UIProtectPet");
          
            pageViewComponent.UISubViewType[(int)ProtectkPageEnum.ProtectEquip] = typeof(UIProtectEquipComponent);
            pageViewComponent.UISubViewType[(int)ProtectkPageEnum.ProtectPet] = typeof(UIProtectPetComponent);
            self.UIPageView = pageViewComponent;

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton  = self.AddChild<UI, string, GameObject>("FunctionSetBtn", FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = pageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UIProtectComponentSystem
    {
        public static void OnClickPageButton(this UIProtectComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
