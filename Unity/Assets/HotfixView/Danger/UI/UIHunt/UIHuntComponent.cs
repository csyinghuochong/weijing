using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum HuntPageEnum: int
    {
        Ranking = 0,
        Task = 1,

        Number,
    }

    public class UIHuntComponent: Entity, IAwake, IDestroy
    {
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIHuntComponentAwakesystem: AwakeSystem<UIHuntComponent>
    {
        public override void Awake(UIHuntComponent self)
        {
            self.Awake();
        }
    }

    public class UIHuntComponentDestroySystem : DestroySystem<UIHuntComponent>
    {
        public override void Destroy(UIHuntComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    
    public static class UIHuntComponentSystem
    {
        public static void Awake(this UIHuntComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)HuntPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)HuntPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)HuntPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)HuntPageEnum.Ranking] = ABPathHelper.GetUGUIPath("Hunt/UIHuntRanking");
            pageViewComponent.UISubViewPath[(int)HuntPageEnum.Task] = ABPathHelper.GetUGUIPath("Hunt/UIHuntTask");

            pageViewComponent.UISubViewType[(int)HuntPageEnum.Ranking] = typeof (UIHuntRankingComponent);
            pageViewComponent.UISubViewType[(int)HuntPageEnum.Task] = typeof (UIHuntTaskComponent);

            self.UIPageView = pageViewComponent;

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageViewComponent;
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }

        public static void OnLanguageUpdate(this UIHuntComponent self)
        {
            Transform tt = self.UIPageButton.GetParent<UI>().GameObject.transform;

            int childCount = tt.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = tt.transform.GetChild(i);

                Transform XuanZhong = transform.Find("XuanZhong");
                if (XuanZhong)
                {
                    Text text = XuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }

                Transform WeiXuanZhong = transform.Find("WeiXuanZhong");
                if (WeiXuanZhong)
                {
                    Text text = WeiXuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }
            }
        }
        
        public static void OnClickPageButton(this UIHuntComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}