using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum ZuoQiPageEnum : int
    { 
        ZuoQi = 0,
        Number,
    }

    public class UIZuoQiComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public UIPageButtonComponent UIPageButton;
        public UIPageViewComponent UIPageView;
    }


    public class UIZuoQiComponentAwake : AwakeSystem<UIZuoQiComponent>
    {
        public override void Awake(UIZuoQiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)ZuoQiPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ZuoQiPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ZuoQiPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)ZuoQiPageEnum.ZuoQi] = ABPathHelper.GetUGUIPath("ZuoQi/UIZuoQiShow");
            pageViewComponent.UISubViewType[(int)ZuoQiPageEnum.ZuoQi] = typeof(UIZuoQiShowComponent);
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
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIZuoQiComponentDestroySystem : DestroySystem<UIZuoQiComponent>
    {
        public override void Destroy(UIZuoQiComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    
    public static class UIZuoQiComponentSystem
    {
        public static void OnLanguageUpdate(this UIZuoQiComponent self)
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

        public static void OnClickPageButton(this UIZuoQiComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
