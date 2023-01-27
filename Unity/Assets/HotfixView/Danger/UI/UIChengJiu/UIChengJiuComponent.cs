using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum ChengJiuPageEnum : int
    { 
        Reward = 0,
        ChengJiu = 1,
        Spirit = 2,
        Number = 3,
    }

    public class UIChengJiuComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageButton;
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
    }

    [ObjectSystem]
    public class UIChengJiuComponentAwakeSystem : AwakeSystem<UIChengJiuComponent>
    {

        public override void Awake(UIChengJiuComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();

            pageViewComponent.UISubViewList = new UI[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)ChengJiuPageEnum.Reward] = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuReward");
            pageViewComponent.UISubViewPath[(int)ChengJiuPageEnum.ChengJiu] = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuShow");
            pageViewComponent.UISubViewPath[(int)ChengJiuPageEnum.Spirit] = ABPathHelper.GetUGUIPath("Main/ChengJiu/UISpiritShow");

            pageViewComponent.UISubViewType[(int)ChengJiuPageEnum.Reward] = typeof(UIChengJiuRewardComponent);
            pageViewComponent.UISubViewType[(int)ChengJiuPageEnum.ChengJiu] = typeof(UIChengJiuShowComponent);
            pageViewComponent.UISubViewType[(int)ChengJiuPageEnum.Spirit] = typeof(UISpiritShowComponent);
            self.UIPageView = pageViewComponent;

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChengJiu(); });

            self.SubViewNode = rc.Get<GameObject>("SubViewNode");
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiJoystick = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiJoystick.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);


            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));

            self.GetChengJiuList();

            DataUpdateComponent.Instance.AddListener(DataType.ChengJiuUpdate, self);
        }
    }

    [ObjectSystem]
    public class UIChengJiuComponentDestroySystem : DestroySystem<UIChengJiuComponent>
    {

        public override void Destroy(UIChengJiuComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.ChengJiuUpdate, self);
        }
    }

    public static class UIChengJiuComponentSystem
    {

        public static void  OnClickPageButton(this UIChengJiuComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static void GetChengJiuList(this UIChengJiuComponent self)
        {
            self.ZoneScene().GetComponent<ChengJiuComponent>().GetChengJiuList().Coroutine();
        }

        public static void OnChengJiuUpdate(this UIChengJiuComponent self)
        {
            if (self.UIPageView.UISubViewList[(int)ChengJiuPageEnum.Reward] != null)
            {
                self.UIPageView.UISubViewList[(int)ChengJiuPageEnum.Reward].OnUpdateUI();
            }
        }

        public static void OnCloseChengJiu(this UIChengJiuComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIChengJiu);
        }

    }
}
