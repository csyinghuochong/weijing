using System;
using UnityEngine;

namespace ET
{
    public enum PetEggEnum : int
    {
        PetEggList = 0,
        PetChouKa = 1,
        PetEggDuiHuan = 2,
        PetEggChouKa = 3,

        Num,
    }

    public class UIPetEggComponent : Entity, IAwake
    {
        public UIPageViewComponent UIPageView;
    }


    public class UIPetEggComponentAwakeSystem : AwakeSystem<UIPetEggComponent>
    {
        public override void Awake(UIPetEggComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)PetEggEnum.Num];
            pageViewComponent.UISubViewPath = new string[(int)PetEggEnum.Num];
            pageViewComponent.UISubViewType = new Type[(int)PetEggEnum.Num];

            pageViewComponent.UISubViewPath[(int)PetEggEnum.PetEggList] = ABPathHelper.GetUGUIPath("Main/PetEgg/UIPetEggList");
            pageViewComponent.UISubViewPath[(int)PetEggEnum.PetChouKa] = ABPathHelper.GetUGUIPath("Main/PetEgg/UIPetChouKa");
            pageViewComponent.UISubViewPath[(int)PetEggEnum.PetEggDuiHuan] = ABPathHelper.GetUGUIPath("Main/PetEgg/UIPetEggDuiHuan");
            pageViewComponent.UISubViewPath[(int)PetEggEnum.PetEggChouKa] = ABPathHelper.GetUGUIPath("Main/PetEgg/UIPetEggChouKa");

            pageViewComponent.UISubViewType[(int)PetEggEnum.PetEggList] = typeof(UIPetEggListComponent);
            pageViewComponent.UISubViewType[(int)PetEggEnum.PetChouKa] = typeof(UIPetChouKaComponent);
            pageViewComponent.UISubViewType[(int)PetEggEnum.PetEggDuiHuan] = typeof(UIPetEggDuiHuanComponent);
            pageViewComponent.UISubViewType[(int)PetEggEnum.PetEggChouKa] = typeof(UIPetEggChouKaComponent);
            self.UIPageView = pageViewComponent;

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI PageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = PageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);
        }
    }

    public static class UIPetEggComponentSystem
    {
        public static void OnClickPageButton(this UIPetEggComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void OnRolePetEggOpen(this UIPetEggComponent self)
        {
            self.UIPageView.UISubViewList[(int)PetEggEnum.PetEggList].GetComponent<UIPetEggListComponent>().UpdatePetEggUI();
        }

        public static void UpdateChouKaTime(this UIPetEggComponent self)
        {
            UI ui = self.UIPageView.UISubViewList[(int)PetEggEnum.PetChouKa];
            ui.GetComponent<UIPetChouKaComponent>().UpdateChouKaTime();
        }
    }
}
