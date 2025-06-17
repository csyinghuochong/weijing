using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public enum RankPageEnum : int
    { 
        RankShow = 0,
        RankReward = 1,
        RankPet = 2,
        PetReward = 3,
        RankNum,
    }

    public class UIRankComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public UI UIPageButton;
        public UIPageViewComponent UIPageView;
    }

    public class UIRankComponentAwakeSystem : AwakeSystem<UIRankComponent>
    {
        public override void Awake(UIRankComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)RankPageEnum.RankNum];
            pageViewComponent.UISubViewPath = new string[(int)RankPageEnum.RankNum];
            pageViewComponent.UISubViewType = new Type[(int)RankPageEnum.RankNum];
            pageViewComponent.UISubViewPath[(int)RankPageEnum.RankShow] = ABPathHelper.GetUGUIPath("Main/Rank/UIRankShow");
            pageViewComponent.UISubViewPath[(int)RankPageEnum.RankReward] = ABPathHelper.GetUGUIPath("Main/Rank/UIRankReward");
            pageViewComponent.UISubViewPath[(int)RankPageEnum.RankPet] = ABPathHelper.GetUGUIPath("Main/Rank/UIRankPet");
            pageViewComponent.UISubViewPath[(int)RankPageEnum.PetReward] = ABPathHelper.GetUGUIPath("Main/Rank/UIRankPetReward");

            pageViewComponent.UISubViewType[(int)RankPageEnum.RankShow] = typeof(UIRankShowComponent);
            pageViewComponent.UISubViewType[(int)RankPageEnum.RankReward] = typeof(UIRankRewardComponent);
            pageViewComponent.UISubViewType[(int)RankPageEnum.RankPet] = typeof(UIRankPetComponent);
            pageViewComponent.UISubViewType[(int)RankPageEnum.PetReward] = typeof(UIRankPetRewardComponent);
            self.UIPageView = pageViewComponent;

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            self.UIPageButton = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", FunctionSetBtn);

            //IOS适配
            IPHoneHelper.SetPosition(FunctionSetBtn, new Vector2(300f, 316f));

            UIPageButtonComponent uIPageButtonComponent = self.UIPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UIRankComponentDestroySystem : DestroySystem<UIRankComponent>
    {
        public override void Destroy(UIRankComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UIRankComponentSystem
    {
        public static void OnLanguageUpdate(this UIRankComponent self)
        {
            Transform tt = self.UIPageButton.GameObject.transform;

            int childCount = tt.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = tt.transform.GetChild(i);

                Transform XuanZhong = transform.Find("XuanZhong");
                if (XuanZhong)
                {
                    // RectTransform rt = XuanZhong.GetComponent<RectTransform>();
                    // Vector2 size = rt.sizeDelta;
                    // size.x = GameSettingLanguge.Language == 0? 100f : 200f;
                    // rt.sizeDelta = size;
                    
                    Text text = XuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        RectTransform rt = text.GetComponent<RectTransform>();
                        Vector2 size = rt.sizeDelta;
                        size.x = GameSettingLanguge.Language == 0? 180f : 200f;
                        rt.sizeDelta = size;
                        
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }

                Transform WeiXuanZhong = transform.Find("WeiXuanZhong");
                if (WeiXuanZhong)
                {
                    // RectTransform rt = WeiXuanZhong.GetComponent<RectTransform>();
                    // Vector2 size = rt.sizeDelta;
                    // size.x = GameSettingLanguge.Language == 0? 100f : 200f;
                    // rt.sizeDelta = size;
                    
                    Text text = WeiXuanZhong.GetComponentInChildren<Text>();
                    if (text)
                    {
                        RectTransform rt = text.GetComponent<RectTransform>();
                        Vector2 size = rt.sizeDelta;
                        size.x = GameSettingLanguge.Language == 0? 180f : 200f;
                        rt.sizeDelta = size;
                        
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                    }
                }
            }
        }
        
        public static void OnClickPageButton(this UIRankComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
