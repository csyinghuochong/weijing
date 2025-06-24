using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum ProtectkPageEnum : int
    {
        ProtectEquip    = 0,
        ProtectPet      = 1,     
        Number,
    }

    public class UIProtectComponent : Entity, IAwake, IDestroy
    {
        public GameObject SubViewNode;
        public UIPageViewComponent UIPageView;
        public GameObject FunctionSetBtn;
        public UIPageButtonComponent UIPageButton;
    }

    public class UIProtectComponentAwake : AwakeSystem<UIProtectComponent>
    {
        public override void Awake(UIProtectComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
            pageViewComponent.UISubViewList = new UI[(int)ProtectkPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ProtectkPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ProtectkPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)ProtectkPageEnum.ProtectEquip] = ABPathHelper.GetUGUIPath("Main/Protect/UIProtectEquip");
            pageViewComponent.UISubViewPath[(int)ProtectkPageEnum.ProtectPet] = ABPathHelper.GetUGUIPath("Main/Protect/UIProtectPet");
          
            pageViewComponent.UISubViewType[(int)ProtectkPageEnum.ProtectEquip] = typeof(UIProtectEquipComponent);
            pageViewComponent.UISubViewType[(int)ProtectkPageEnum.ProtectPet] = typeof(UIProtectPetComponent);
            self.UIPageView = pageViewComponent;

            GameObject FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton  = self.AddChild<UI, string, GameObject>("FunctionSetBtn", FunctionSetBtn);
            UIPageButtonComponent uIPageButtonComponent = pageButton.AddComponent<UIPageButtonComponent>();
            self.UIPageButton = uIPageButtonComponent;
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);

            //IOS适配
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            IPHoneHelper.SetPosition(self.FunctionSetBtn, new Vector2(300f, 316f));
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIProtectComponentDestroySystem : DestroySystem<UIProtectComponent>
    {
        public override void Destroy(UIProtectComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIProtectComponentSystem
    {
        public static void OnLanguageUpdate(this UIProtectComponent self)
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

        public static void OnClickPageButton(this UIProtectComponent self, int page)
        {
            self.UIPageView.OnSelectIndex(page).Coroutine();
        }
    }
}
