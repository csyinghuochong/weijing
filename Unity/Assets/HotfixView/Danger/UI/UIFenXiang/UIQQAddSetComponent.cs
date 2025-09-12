using System;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIQQAddSetComponent : Entity, IAwake
    {
        public GameObject ItemList;
        public GameObject Button_AddQQ;

        public GameObject BindRewardItem;
        public GameObject Button_WeChatBind;
        public GameObject Text_WechatOACode;
        public GameObject WeChatBind;
    }

    public class UIQQAddSetComponentAwake : AwakeSystem<UIQQAddSetComponent>
    {
        public override void Awake(UIQQAddSetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemList = rc.Get<GameObject>("ItemList");
            UICommonHelper.ShowItemList(ActivityConfigCategory.Instance.Get(34002).Par_3, self.ItemList, self);
   
            self.Button_AddQQ = rc.Get<GameObject>("Button_AddQQ");
            ButtonHelp.AddListenerEx(self.Button_AddQQ, () => { self.OnButton_AddQQ(); });

            if (GlobalHelp.GetPlatform() == 5 || GlobalHelp.GetPlatform() == 6)
            {
                self.Button_AddQQ.SetActive(false);
            }
            else
            {
                self.Button_AddQQ.SetActive(true);
            }


            self.BindRewardItem = rc.Get<GameObject>("BindRewardItem");
            UICommonHelper.ShowItemList(ActivityConfigCategory.Instance.Get(35001).Par_3, self.BindRewardItem, self);

            self.Button_WeChatBind = rc.Get<GameObject>("Button_WeChatBind");
            ButtonHelp.AddListenerEx(self.Button_WeChatBind, () => { self.OnButton_WeChatBind(); });

            self.Text_WechatOACode = rc.Get<GameObject>("Text_WechatOACode");
            self.UpdateText_WechatOACode();

            self.WeChatBind = rc.Get<GameObject>("WeChatBind");
            self.WeChatBind.SetActive( GMHelp.GmAccount.Contains( self.ZoneScene().GetComponent<AccountInfoComponent>().Account ) );


        }
    }

    public static class UIQQAddSetComponentSystem
    {
        public static void OnButton_AddQQ(this UIQQAddSetComponent self)
        {
            ///sync  UIFenXiangSetComponent
            Application.OpenURL("https://qm.qq.com/q/NYo62GmJSc");
        }

        public static void OnButton_WeChatBind(this UIQQAddSetComponent self)
        {
            FloatTipManager.Instance.ShowFloatTip("请先绑定！");
        }

        public static void UpdateText_WechatOACode(this UIQQAddSetComponent self)
        {
            self.Text_WechatOACode.GetComponent<Text>().text = $"关注微信公众号有奖励哦\r\n搜索危境游戏，发送{857496}";
        }
    }
}