using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum TaskPageEnum
    {
        TaskA,
        TaskB,

        Number
    }

    public class UITaskComponent: Entity, IAwake, IDestroy
    {
        public GameObject Btn_2;
        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UITaskComponentAwake: AwakeSystem<UITaskComponent>
    {
        public override void Awake(UITaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)TaskPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)TaskPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)TaskPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)TaskPageEnum.TaskA] = ABPathHelper.GetUGUIPath("Main/Task/UITaskA");
            pageViewComponent.UISubViewPath[(int)TaskPageEnum.TaskB] = ABPathHelper.GetUGUIPath("Main/Task/UITaskB");

            pageViewComponent.UISubViewType[(int)TaskPageEnum.TaskA] = typeof (UITaskAComponent);
            pageViewComponent.UISubViewType[(int)TaskPageEnum.TaskB] = typeof (UITaskBComponent);

            self.UIPageView = pageViewComponent;

            self.Btn_2 = rc.Get<GameObject>("Btn_2");
            // self.Btn_2.SetActive(GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account));

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((page) => { self.OnClickPageButton(page); });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageViewComponent;
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UITaskComponentDestroySystem : DestroySystem<UITaskComponent>
    {
        public override void Destroy(UITaskComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UITaskComponentSystem
    {
        public static void OnLanguageUpdate(this UITaskComponent self)
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
                        RectTransform rt = text.GetComponent<RectTransform>();
                        Vector2 size = rt.sizeDelta;
                        size.x = GameSettingLanguge.Language == 0? 150f : 200f;
                        rt.sizeDelta = size;
                        
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }

                Transform WeiXuanZhong = transform.Find("WeiXuanZhong");
                if (WeiXuanZhong)
                {
                    Text text = WeiXuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        RectTransform rt = text.GetComponent<RectTransform>();
                        Vector2 size = rt.sizeDelta;
                        size.x = GameSettingLanguge.Language == 0? 150f : 200f;
                        rt.sizeDelta = size;
                        
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }
            }
        }
        
        public static void OnClickPageButton(this UITaskComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}