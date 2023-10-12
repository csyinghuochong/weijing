

using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public enum TrialEnum : int
    { 
        Dungeon = 0,
        Rank = 1,

        Number,
    }

    public class UITrialComponent : Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageButtonComponent UIPageButton;
        public UIPageViewComponent UIPageView;

    }

    public class UITrialComponentAwake : AwakeSystem<UITrialComponent>
    {
        public override void Awake(UITrialComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");

            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)TrialEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)TrialEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)TrialEnum.Number];
            pageViewComponent.UISubViewPath[(int)TrialEnum.Dungeon] = ABPathHelper.GetUGUIPath("TrialDungeon/UITrialDungeon");
            pageViewComponent.UISubViewPath[(int)TrialEnum.Rank] = ABPathHelper.GetUGUIPath("TrialDungeon/UITrialDungeon");
           
            pageViewComponent.UISubViewType[(int)TrialEnum.Dungeon] = typeof(UITrialDungeonComponent);
            pageViewComponent.UISubViewType[(int)TrialEnum.Rank] = typeof(UITrialDungeonComponent);
           
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


    public static class UITrialComponentSystem
    {

        public static void OnClickPageButton(this UITrialComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

    }
}