using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public enum UnionXiuLianEnum: int
    {
        UnionRoleXiuLian = 0,
        UnionPetXiuLian = 1,
        Number,
    }

    public class UIUnionXiuLianComponent: Entity, IAwake
    {

        public GameObject Btn_2;

        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIUnionXiuLianComponentAwakeSystem: AwakeSystem<UIUnionXiuLianComponent>
    {
        public override void Awake(UIUnionXiuLianComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)PaiMaiPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)PaiMaiPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)PaiMaiPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)UnionXiuLianEnum.UnionRoleXiuLian] = ABPathHelper.GetUGUIPath("Main/Union/UIUnionRoleXiuLian");
            pageViewComponent.UISubViewPath[(int)UnionXiuLianEnum.UnionPetXiuLian] = ABPathHelper.GetUGUIPath("Main/Union/UIUnionPetXiuLian");

            pageViewComponent.UISubViewType[(int)UnionXiuLianEnum.UnionRoleXiuLian] = typeof (UIUnionRoleXiuLianComponent);
            pageViewComponent.UISubViewType[(int)UnionXiuLianEnum.UnionPetXiuLian] = typeof (UIUnionPetXiuLianComponent);
            self.UIPageView = pageViewComponent;

            self.Btn_2 = rc.Get<GameObject>("Btn_2");
            self.Btn_2.SetActive(GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account));

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI ui = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageButtonComponent = ui.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageButtonComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageButtonComponent;
        }
    }

    public static class UIUnionXiuLianComponentSystem
    {
        public static void OnClickPageButton(this UIUnionXiuLianComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}