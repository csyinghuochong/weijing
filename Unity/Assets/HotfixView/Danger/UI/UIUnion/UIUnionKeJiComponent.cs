using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public enum UIUnionKeJiEnum: int
    {
        UnionKeJiResearch = 0,
        UnionKeJiLearn = 1,
        Number,
    }

    public class UIUnionKeJiComponent: Entity, IAwake
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public GameObject Btn_1;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIUnionKeJiComponentAwakeSystem: AwakeSystem<UIUnionKeJiComponent>
    {
        public override void Awake(UIUnionKeJiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_1 = rc.Get<GameObject>("Btn_1");
            self.Btn_1.SetActive(false);
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)UIUnionKeJiEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)UIUnionKeJiEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)UIUnionKeJiEnum.Number];

            pageViewComponent.UISubViewPath[(int)UIUnionKeJiEnum.UnionKeJiResearch] = ABPathHelper.GetUGUIPath("Main/Union/UIUnionKeJiResearch");
            pageViewComponent.UISubViewPath[(int)UIUnionKeJiEnum.UnionKeJiLearn] = ABPathHelper.GetUGUIPath("Main/Union/UIUnionKeJiLearn");

            pageViewComponent.UISubViewType[(int)UIUnionKeJiEnum.UnionKeJiResearch] = typeof (UIUnionKeJiResearchComponent);
            pageViewComponent.UISubViewType[(int)UIUnionKeJiEnum.UnionKeJiLearn] = typeof (UIUnionKeJiLearnComponent);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI ui = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageButtonComponent = ui.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            self.UIPageButton = uIPageButtonComponent;

            self.Init().Coroutine();
        }
    }

    public static class UIUnionKeJiComponentSystem
    {
        public static async ETTask Init(this UIUnionKeJiComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = unit.GetUnionId();
            C2U_UnionMyInfoRequest request = new C2U_UnionMyInfoRequest() { UnionId = unionId };
            U2C_UnionMyInfoResponse respose =
                    (U2C_UnionMyInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);

            foreach (UnionPlayerInfo unionPlayerInfo in respose.UnionMyInfo.UnionPlayerList)
            {
                if (unionPlayerInfo.UserID == unit.Id)
                {
                    if (unionPlayerInfo.Position == 0)
                    {
                        self.Btn_1.SetActive(false);
                        self.UIPageButton.OnSelectIndex(1);
                        return;
                    }
                }
            }

            self.Btn_1.SetActive(true);
            self.UIPageButton.OnSelectIndex(0);
        }

        public static void OnClickPageButton(this UIUnionKeJiComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}