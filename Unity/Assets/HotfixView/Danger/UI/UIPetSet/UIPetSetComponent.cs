using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public enum PetSetEnum : int
    {
        PetChallenge = 0,
        PetMining = 1,

        Number,
    }

    public class UIPetSetComponent : Entity, IAwake, IDestroy
    {
        public GameObject Btn_1;
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public GameObject ButtonClose;

        public UIPageButtonComponent UIPageButton;
        public UIPageViewComponent UIPageView;
    }

    public class UIPetSetComponentDestory : DestroySystem<UIPetSetComponent>
    {
        public override void Destroy(UIPetSetComponent self)
        {
            ReddotViewComponent redPointComponent = self.DomainScene().GetComponent<ReddotViewComponent>();
            redPointComponent.UnRegisterReddot(ReddotType.PetMine, self.Reddot_PetMine);
        }
    }

    public class UIPetSetComponentAwake : AwakeSystem<UIPetSetComponent>
    {
        public override void Awake(UIPetSetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");

            self.Btn_1 = rc.Get<GameObject>("Btn_1");
            self.Btn_1.SetActive( true );

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetSet );  });

            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();

            pageViewComponent.UISubViewList = new UI[(int)PetSetEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)PetSetEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)PetSetEnum.Number];

            pageViewComponent.UISubViewPath[(int)PetSetEnum.PetChallenge] = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetChallenge");
            pageViewComponent.UISubViewPath[(int)PetSetEnum.PetMining] = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetMining");
           
            pageViewComponent.UISubViewType[(int)PetSetEnum.PetChallenge] = typeof(UIPetChallengeComponent);
            pageViewComponent.UISubViewType[(int)PetSetEnum.PetMining] = typeof(UIPetMiningComponent);
          
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

            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.RegisterReddot(ReddotType.PetMine, self.Reddot_PetMine);
        }
    }

    public static class UIPetSetComponentSystem
    {

        public static void Reddot_PetMine(this UIPetSetComponent self, int num)
        {
            self.UIPageButton.SetButtonReddot( 1, num > 0 );
        }

        public static void OnClickPageButton(this UIPetSetComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}