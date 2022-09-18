using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum PetSetEnum : int
    {
        PetChallenge = 0,
        PetFormation = 1,
       
        Num,
    }

    public class UIPetSetComponent : Entity, IAwake
    {
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;

        public GameObject CloseButton;
    }

    [ObjectSystem]
    public class UIPetSetComponentAwakeSystem : AwakeSystem<UIPetSetComponent>
    {
        public override void Awake(UIPetSetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetSet );  });

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)PetSetEnum.Num];
            pageViewComponent.UISubViewPath = new string[(int)PetSetEnum.Num];
            pageViewComponent.UISubViewType = new Type[(int)PetSetEnum.Num];

            pageViewComponent.UISubViewPath[(int)PetSetEnum.PetFormation] = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormation");
            pageViewComponent.UISubViewPath[(int)PetSetEnum.PetChallenge] = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetChallenge");

            pageViewComponent.UISubViewType[(int)PetSetEnum.PetFormation] = typeof(UIPetFormationComponent);
            pageViewComponent.UISubViewType[(int)PetSetEnum.PetChallenge] = typeof(UIPetChallengeComponent);
            self.UIPageView = pageViewComponent;

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI PageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = PageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageButtonComponent;
        }
    }

    public static class UIPetSetComponentSystem
    {
        public static void OnClickPageButton(this UIPetSetComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void RequestFormationSet(this UIPetSetComponent self, long rolePetInfoId, int index, int operateType)
        {
            UI ui = self.UIPageView.UISubViewList[(int)PetSetEnum.PetFormation];
            ui?.GetComponent<UIPetFormationComponent>().RequestFormationSet(rolePetInfoId, index, operateType).Coroutine();
        }
    }
}
