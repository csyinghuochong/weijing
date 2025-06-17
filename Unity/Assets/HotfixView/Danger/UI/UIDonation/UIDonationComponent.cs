using UnityEngine;
using System;
using UnityEngine.UI;

namespace ET
{

    public enum DonationEnum : int
    {
        Show = 0,
        Union = 1,
        RankUnion = 2,
        Number,
    }

    public class UIDonationComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;

        public UIPageViewComponent UIPageView;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIDonationComponentAwake :AwakeSystem<UIDonationComponent>
    {
        public override void Awake(UIDonationComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject pageView = rc.Get<GameObject>("SubViewNode");

            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)DonationEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)DonationEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)DonationEnum.Number];
            pageViewComponent.UISubViewPath[(int)DonationEnum.Show] = ABPathHelper.GetUGUIPath("Main/Donation/UIDonationShow");
            pageViewComponent.UISubViewPath[(int)DonationEnum.Union] = ABPathHelper.GetUGUIPath("Main/Donation/UIDonationUnion");
            pageViewComponent.UISubViewPath[(int)DonationEnum.RankUnion] = ABPathHelper.GetUGUIPath("Main/Union/UIRankUnion");
          
            pageViewComponent.UISubViewType[(int)DonationEnum.Show] = typeof(UIDonationShowComponent);
            pageViewComponent.UISubViewType[(int)DonationEnum.Union] = typeof(UIDonationUnionComponent);
            pageViewComponent.UISubViewType[(int)DonationEnum.RankUnion] = typeof(UIRankUnionComponent);
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

    public class UIDonationComponentDestroySystem : DestroySystem<UIDonationComponent>
    {
        public override void Destroy(UIDonationComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIDonationComponentSystem
    {
        public static void OnLanguageUpdate(this UIDonationComponent self)
        {
            Transform tt = self.UIPageButton.GetParent<UI>().GameObject.transform;

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
        
        public static void OnClickPageButton(this UIDonationComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
