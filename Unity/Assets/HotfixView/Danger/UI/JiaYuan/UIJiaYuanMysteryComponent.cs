using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum JiaYuanMysteryEnum: int
    {
        JiaYuanMystery_A = 0,
        JiaYuanMystery_B = 1,
        Number
    }

    public class UIJiaYuanMysteryComponent: Entity, IAwake, IDestroy
    {
        public UI UIPageButton;
        public UIPageViewComponent UIPageView;
        public GameObject FunctionSetBtn;

        public GameObject closeButton;
        public GameObject RawImage;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
    }

    public class UIJiaYuanMysteryComponentAwake: AwakeSystem<UIJiaYuanMysteryComponent>
    {
        public override void Awake(UIJiaYuanMysteryComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)JiaYuanMysteryEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)JiaYuanMysteryEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)JiaYuanMysteryEnum.Number];

            pageViewComponent.UISubViewPath[(int)JiaYuanMysteryEnum.JiaYuanMystery_A] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanMystery_A");
            pageViewComponent.UISubViewType[(int)JiaYuanMysteryEnum.JiaYuanMystery_A] = typeof (UIJiaYuanMystery_AComponent);

            pageViewComponent.UISubViewPath[(int)JiaYuanMysteryEnum.JiaYuanMystery_B] = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanMystery_B");
            pageViewComponent.UISubViewType[(int)JiaYuanMysteryEnum.JiaYuanMystery_B] = typeof (UIJiaYuanMystery_BComponent);

            self.UIPageView = pageViewComponent;

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uiPage;

            //IOS适配
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            
            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseStore(); });

            self.RawImage = rc.Get<GameObject>("RawImage");

            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.InitModelShowView().Coroutine();
        }
    }

    public static class UIJiaYuanMysteryComponentSystem
    {
        public static void OnClickPageButton(this UIJiaYuanMysteryComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static async ETTask InitModelShowView(this UIJiaYuanMysteryComponent self)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(UIHelper.CurrentNpcId);
            self.uIModelShowComponent.ShowOtherModel("Npc/" + npcConfig.Asset.ToString()).Coroutine();
        }

        public static void OnCloseStore(this UIJiaYuanMysteryComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIJiaYuanMystery);
        }
    }
}