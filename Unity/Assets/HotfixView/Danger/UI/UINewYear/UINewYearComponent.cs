using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum NewYearPageEnum : int
    {
        CollectionWord = 0,
        Monster = 1,
        Number,
    }

    public class UINewYearComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }


    public class UINewYearComponentAwake : AwakeSystem<UINewYearComponent>
    {
        public override void Awake(UINewYearComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)NewYearPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)NewYearPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)NewYearPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.CollectionWord] = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearCollectionWord");
            pageViewComponent.UISubViewPath[(int)NewYearPageEnum.Monster] = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearMonster");

            pageViewComponent.UISubViewType[(int)NewYearPageEnum.CollectionWord] = typeof(UINewYearCollectionWordComponent);
            pageViewComponent.UISubViewType[(int)NewYearPageEnum.Monster] = typeof(UINewYearMonsterComponent);
            self.UIPageView = pageViewComponent;

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageButtonComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });
            self.UIPageButtonComponent = uIPageButtonComponent;
            self.UIPageButtonComponent.OnSelectIndex(0);
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UINewYearComponentDestroySystem : DestroySystem<UINewYearComponent>
    {
        public override void Destroy(UINewYearComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UINewYearComponentAwakeSystem
    {
        public static void OnLanguageUpdate(this UINewYearComponent self)
        {
            Transform tt = self.UIPageButtonComponent.GetParent<UI>().GameObject.transform;

            int childCount = tt.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = tt.transform.GetChild(i);

                Transform XuanZhong = transform.Find("XuanZhong");
                if (XuanZhong)
                {
                    RectTransform rt = XuanZhong.GetComponent<RectTransform>();
                    Vector2 size = rt.sizeDelta;
                    size.x = GameSettingLanguge.Language == 0? 100f : 200f;
                    rt.sizeDelta = size;
                    
                    Text text = XuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }

                Transform WeiXuanZhong = transform.Find("WeiXuanZhong");
                if (WeiXuanZhong)
                {
                    RectTransform rt = WeiXuanZhong.GetComponent<RectTransform>();
                    Vector2 size = rt.sizeDelta;
                    size.x = GameSettingLanguge.Language == 0? 100f : 200f;
                    rt.sizeDelta = size;
                    
                    Text text = WeiXuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }
            }
        }
        
        public static void OnClickPageButton(this UINewYearComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
