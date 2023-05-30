using System;
using UnityEngine;

namespace ET
{
    public enum FriendPageEnum : int
    {
        FriendList = 0,
        FriendApply = 1,
        Blacklist = 2,
        UnionShow = 3,
        UnionMy = 4,

        Number,
    }

    public class UIFriendComponent : Entity, IAwake, IDestroy
    {

        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }


    public class UIFriendComponentAwakeSystem : AwakeSystem<UIFriendComponent>
    {
        public override void Awake(UIFriendComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)FriendPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)FriendPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)FriendPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)FriendPageEnum.FriendList] = ABPathHelper.GetUGUIPath("Main/Friend/UIFriendList");
            pageViewComponent.UISubViewPath[(int)FriendPageEnum.FriendApply] = ABPathHelper.GetUGUIPath("Main/Friend/UIFriendApply");
            pageViewComponent.UISubViewPath[(int)FriendPageEnum.Blacklist] = ABPathHelper.GetUGUIPath("Main/Friend/UIFriendBlack");
            pageViewComponent.UISubViewPath[(int)FriendPageEnum.UnionShow] = ABPathHelper.GetUGUIPath("Main/Union/UIUnionShow");
            pageViewComponent.UISubViewPath[(int)FriendPageEnum.UnionMy] = ABPathHelper.GetUGUIPath("Main/Union/UIUnionMy");

            pageViewComponent.UISubViewType[(int)FriendPageEnum.FriendList] = typeof(UIFriendListComponent);
            pageViewComponent.UISubViewType[(int)FriendPageEnum.FriendApply] = typeof(UIFriendApplyComponent);
            pageViewComponent.UISubViewType[(int)FriendPageEnum.Blacklist] = typeof(UIFriendBlackComponent);
            pageViewComponent.UISubViewType[(int)FriendPageEnum.UnionShow] = typeof(UIUnionShowComponent);
            pageViewComponent.UISubViewType[(int)FriendPageEnum.UnionMy] = typeof(UIUnionMyComponent);
            self.UIPageView = pageViewComponent;
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPageButton = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageButtonComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.CheckHandler = (int page) => { return self.CheckPageButton_1(page); };
            self.UIPageButtonComponent = uIPageButtonComponent;
            self.UIPageButtonComponent.ClickEnabled = false;
            self.RequestFriendInfo().Coroutine();

            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.RegisterReddot(ReddotType.FriendApply, self.Reddot_FriendApply);
            //redPointComponent.RegisterReddot(RedPointType.UnionMy, self.Reddot_UnionApply);

            //UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            //self.UIPageButtonComponent.SetButtonActive((int)FriendPageEnum.UnionCreate, userInfoComponent.UserInfo.UnionId == 0);

            DataUpdateComponent.Instance.AddListener(DataType.FriendUpdate, self);
        }
    }


    public class UIFriendComponentDestroySystem : DestroySystem<UIFriendComponent>
    {
        public override void Destroy(UIFriendComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.FriendUpdate, self);

            ReddotViewComponent redPointComponent = self.DomainScene().GetComponent<ReddotViewComponent>();
            redPointComponent.UnRegisterReddot(ReddotType.FriendApply, self.Reddot_FriendApply);
            redPointComponent.UnRegisterReddot(ReddotType.UnionMy, self.Reddot_UnionApply);
        }
    }

    public static class UIFriendComponentSystem
    {

        public static async ETTask RequestFriendInfo(this UIFriendComponent self)
        {
            await NetHelper.RequestFriendInfo(self.ZoneScene());
            if (self.IsDisposed)
            {
                return;
            }
            self.UIPageButtonComponent.ClickEnabled = true;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0));
            self.UIPageButtonComponent.OnSelectIndex(unionId > 0 ? 4 : 3);
        }

        public static bool CheckPageButton_1(this UIFriendComponent self, int page)
        {
            if (page == (int)FriendPageEnum.UnionMy)
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                long unionId = (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0));
                if (unionId == 0)
                {
                    FloatTipManager.Instance.ShowFloatTip("请先创建或者加入一个家族");
                    return false;
                }
            }
            return true;
        }

        public static void Reddot_FriendApply(this UIFriendComponent self, int num)
        {
            self.UIPageButtonComponent.SetButtonReddot((int)FriendPageEnum.FriendApply, num > 0);
        }

        public static void Reddot_UnionApply(this UIFriendComponent self, int num)
        {
            self.UIPageButtonComponent.SetButtonReddot((int)FriendPageEnum.UnionMy, num > 0);
        }

        public static void OnClickPageButton(this UIFriendComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();

            if (page == (int)FriendPageEnum.FriendApply)
            {
                ReddotComponent redPointComponent = self.ZoneScene().GetComponent<ReddotComponent>();
                redPointComponent.RemoveReddont(ReddotType.FriendApply);
            }
        }

        public static void OnFriendUpdate(this UIFriendComponent self)
        {
            UI uI_1 = self.UIPageView.UISubViewList[(int)FriendPageEnum.FriendList];
            if (uI_1 != null)
            {
                uI_1.GetComponent<UIFriendListComponent>().OnUpdateFriendList().Coroutine();
            }
            UI uI_2 = self.UIPageView.UISubViewList[(int)FriendPageEnum.FriendApply];
            if (uI_2 != null)
            {
                uI_2.GetComponent<UIFriendApplyComponent>().OnUpdateApplyList().Coroutine();
            }
        }

        public static void OnRemoveBlack(this UIFriendComponent self)
        {
            UI uI = self.UIPageView.UISubViewList[(int)FriendPageEnum.Blacklist];
            if (uI != null)
            {
                uI.GetComponent<UIFriendBlackComponent>().OnUpdateFriendList().Coroutine();
            }
        }

        public static void OnCreateUnion(this UIFriendComponent self)
        {
            UI uI = self.UIPageView.UISubViewList[(int)FriendPageEnum.UnionShow];
            if (uI!= null)
            {
                uI.GetComponent<UIUnionShowComponent>().OnCreateUnion();
            }
        }

        public static void OnLeaveUnion(this UIFriendComponent self)
        {
            self.UIPageButtonComponent.OnSelectIndex(0);
        }

        public static void OnUpdateMyUnion(this UIFriendComponent self)
        {
            UI uI = self.UIPageView.UISubViewList[(int)FriendPageEnum.UnionMy];
            if (uI != null)
            {
                uI.GetComponent<UIUnionMyComponent>().OnUpdateUI().Coroutine();
            }
        }
    }

}
