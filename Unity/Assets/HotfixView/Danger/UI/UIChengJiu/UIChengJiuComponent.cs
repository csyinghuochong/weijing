using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum ChengJiuPageEnum : int
    { 
        Reward = 0,
        ChengJiu = 1,
        JingLing = 2,
        PetTuJian = 3,
        MagickaSlot = 4,

        Number,
    }

    public class UIChengJiuComponent : Entity, IAwake, IDestroy
    {

        public GameObject Btn_Magic;
        public GameObject Btn_JingLing;
        public GameObject ImageButton;
        public GameObject SubViewNode;
        public GameObject FunctionSetBtn;
        public UIPageButtonComponent UIPageButton;

        public UIPageViewComponent UIPageView;
    }


    public class UIChengJiuComponentAwakeSystem : AwakeSystem<UIChengJiuComponent>
    {

        public override void Awake(UIChengJiuComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject pageView = rc.Get<GameObject>("SubViewNode");
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            UI uiPageView = self.AddChild<UI, string, GameObject>("FunctionBtnSet", pageView);
            UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();

            pageViewComponent.UISubViewList = new UI[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewPath = new string[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewType = new Type[(int)ChengJiuPageEnum.Number];
            pageViewComponent.UISubViewPath[(int)ChengJiuPageEnum.Reward] = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuReward");
            pageViewComponent.UISubViewPath[(int)ChengJiuPageEnum.ChengJiu] = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuShow");
            pageViewComponent.UISubViewPath[(int)ChengJiuPageEnum.JingLing] = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuJingling");
            pageViewComponent.UISubViewPath[(int)ChengJiuPageEnum.PetTuJian] = ABPathHelper.GetUGUIPath("Main/Pet/UIPetTuJian");
            pageViewComponent.UISubViewPath[(int)ChengJiuPageEnum.MagickaSlot] = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIMagickaSlot");

            pageViewComponent.UISubViewType[(int)ChengJiuPageEnum.Reward] = typeof(UIChengJiuRewardComponent);
            pageViewComponent.UISubViewType[(int)ChengJiuPageEnum.ChengJiu] = typeof(UIChengJiuShowComponent);
            pageViewComponent.UISubViewType[(int)ChengJiuPageEnum.JingLing] = typeof(UIChengJiuJingLingComponent);
            pageViewComponent.UISubViewType[(int)ChengJiuPageEnum.PetTuJian] = typeof(UIPetTuJianComponent);
            pageViewComponent.UISubViewType[(int)ChengJiuPageEnum.MagickaSlot] = typeof(UIMagickaSlotComponent);
            self.UIPageView = pageViewComponent;

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChengJiu(); });

            self.Btn_Magic = rc.Get<GameObject>("Btn_Magic");
            self.Btn_Magic.SetActive( GMHelp.GmAccount.Contains( self.ZoneScene().GetComponent<AccountInfoComponent>().Account ) );

            self.SubViewNode = rc.Get<GameObject>("SubViewNode");
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiJoystick = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", BtnItemTypeSet);
            self.UIPageButton = uiJoystick.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton.OnSelectIndex(0);


            //IOS适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));

            self.GetChengJiuList();

            DataUpdateComponent.Instance.AddListener(DataType.ChengJiuUpdate, self);
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }


    public class UIChengJiuComponentDestroySystem : DestroySystem<UIChengJiuComponent>
    {
        public override void Destroy(UIChengJiuComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.ChengJiuUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UIChengJiuComponentSystem
    {
        public static void OnLanguageUpdate(this UIChengJiuComponent self)
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
