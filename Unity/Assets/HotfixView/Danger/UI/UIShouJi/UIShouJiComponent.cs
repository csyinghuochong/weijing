using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public enum ShouJiPageEnum : int
    {
        ShouJiList = 0,
        ShouJiTreasure = 1,
      
        Number ,
    }

    public class UIShouJiComponent : Entity, IAwake, IDestroy
    {
        public GameObject FunctionSetBtn;
        public GameObject SubViewNode;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButtonComponent;
    }


    public class UIShouJiComponentAwakeSystem : AwakeSystem<UIShouJiComponent>
    {
        public override void Awake(UIShouJiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            self.SubViewNode = rc.Get<GameObject>("SubViewNode");

            UI uiPageView = self.AddChild<UI, string, GameObject>("SubViewNode", self.SubViewNode);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)ShouJiPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ShouJiPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ShouJiPageEnum.Number];

            pageViewComponent.UISubViewPath[(int)ShouJiPageEnum.ShouJiList] = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiList");
            pageViewComponent.UISubViewPath[(int)ShouJiPageEnum.ShouJiTreasure] = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiTreasure");
          
            pageViewComponent.UISubViewType[(int)ShouJiPageEnum.ShouJiList] = typeof(UIShouJiListComponent);
            pageViewComponent.UISubViewType[(int)ShouJiPageEnum.ShouJiTreasure] = typeof(UIShouJiTreasureComponent);
            self.UIPageView = pageViewComponent;

            UI uiPageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = uiPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) =>
            {
                self.OnClickPageButton(page);
            });
            self.UIPageButtonComponent = uIPageButtonComponent;
            self.UIPageButtonComponent.OnSelectIndex(0);

            self.OnUpdateUI().Coroutine();

            //IOS适配
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIShouJiComponentDestroySystem : DestroySystem<UIShouJiComponent>
    {
        public override void Destroy(UIShouJiComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIShouJiComponentSystem
    {
        public static void OnLanguageUpdate(this UIShouJiComponent self)
        {
            Transform tt = self.UIPageButtonComponent.GetParent<UI>().GameObject.transform;

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

        public static void OnShouJiTreasure(this UIShouJiComponent self)
        {
            self.UIPageView.UISubViewList[(int)ShouJiPageEnum.ShouJiTreasure].GetComponent<UIShouJiTreasureComponent>().OnShouJiTreasure();  
        }

        public static void OnClickPageButton(this UIShouJiComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }

        public static async ETTask OnUpdateUI(this UIShouJiComponent self)
        {
            await ETTask.CompletedTask;
        }
    }
}
