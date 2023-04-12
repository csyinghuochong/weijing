using System;
using UnityEngine;

namespace ET
{
    public enum EnergyPageEnum : int
    {
        Earlyup = 0,
        Earlysleep = 1,
        Answer = 2,
        Number = 3,
    }

    public class UIEnergyComponent : Entity, IAwake
    {

        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UI UIPageButton;
        public UIPageViewComponent UIPageView;

        public EnergyComponent EnergyComponent;

        public bool RecvEnergyInfo = false;
    }


    public class UIEnergyComponentAwakeSystem : AwakeSystem<UIEnergyComponent>
    {
        public override void Awake(UIEnergyComponent self)
        {
            self.RecvEnergyInfo = false;

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)EnergyPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)EnergyPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)EnergyPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)EnergyPageEnum.Earlyup] = ABPathHelper.GetUGUIPath("Main/Energy/UIEnergyEarlyup");
            pageViewComponent.UISubViewPath[(int)EnergyPageEnum.Earlysleep] = ABPathHelper.GetUGUIPath("Main/Energy/UIEnergyEarlysleep");
            pageViewComponent.UISubViewPath[(int)EnergyPageEnum.Answer] = ABPathHelper.GetUGUIPath("Main/Energy/UIEnergyAnswer");

            pageViewComponent.UISubViewType[(int)EnergyPageEnum.Earlyup] = typeof(UIEnergyEarlyupComponent);
            pageViewComponent.UISubViewType[(int)EnergyPageEnum.Earlysleep] = typeof(UIEnergyEarlysleepComponent);
            pageViewComponent.UISubViewType[(int)EnergyPageEnum.Answer] = typeof(UIEnergyAnswerComponent);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            self.UIPageButton = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", self.FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = self.UIPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });

            self.EnergyComponent = self.ZoneScene().GetComponent<EnergyComponent>();

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIEnergyComponentSystem
    {

        public static async ETTask OnUpdateUI(this UIEnergyComponent self)
        {
            if (self.EnergyComponent.QuestionList.Count == 0)
            {
                await self.EnergyComponent.RequestEnergyInfo();
            }
            self.UIPageButton.GetComponent<UIPageButtonComponent>().OnSelectIndex(0);
        }

        public static void OnClickPageButton(this UIEnergyComponent self, int page)
        {
            if (self.EnergyComponent.QuestionList.Count == 0)
            {
                return;
            }
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }

}