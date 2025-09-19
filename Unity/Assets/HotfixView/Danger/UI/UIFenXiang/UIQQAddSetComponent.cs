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
        public GameObject Img_Received;
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
            ButtonHelp.AddListenerEx(self.Button_WeChatBind, () => { self.OnButton_WeChatBind().Coroutine(); });

            self.WeChatBind = rc.Get<GameObject>("WeChatBind");
            self.WeChatBind.SetActive( true );

            self.Img_Received = rc.Get<GameObject>("Img_Received");
            self.Img_Received.SetActive(false);

            self.Text_WechatOACode = rc.Get<GameObject>("Text_WechatOACode");
            self.UpdateText_WechatOACode().Coroutine();
        }
    }

    public static class UIQQAddSetComponentSystem
    {
        public static void OnButton_AddQQ(this UIQQAddSetComponent self)
        {
            ///sync  UIFenXiangSetComponent
            Application.OpenURL("https://qm.qq.com/q/NYo62GmJSc");
        }

        public static async ETTask OnButton_WeChatBind(this UIQQAddSetComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (activityComponent.ActivityReceiveIds.Contains(35001))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过奖励！");
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene() );
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.WeChatOABind) == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请先绑定！");
                return;
            }

            C2M_ActivityReceiveRequest c2M_ItemHuiShouRequest = new C2M_ActivityReceiveRequest() { ActivityType = 35, ActivityId = 35001 };
            M2C_ActivityReceiveResponse r2c_roleEquip = (M2C_ActivityReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            if (r2c_roleEquip.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            activityComponent.ActivityReceiveIds.Add(35001);
            self.Img_Received.SetActive(true);
        }

        public static void OnWeChatOABind(this UIQQAddSetComponent self)
        {
            Log.Warning($"OnWeChatOABindOnWeChatOABind");
            self.Text_WechatOACode.GetComponent<Text>().text = "绑定成功！";
        }

        public static async ETTask UpdateText_WechatOACode(this UIQQAddSetComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            self.Img_Received.SetActive(activityComponent.ActivityReceiveIds.Contains(35001));
            Log.ILog.Debug($"35001:  {activityComponent.ActivityReceiveIds.Contains(35001)}");

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.WeChatOABind) == 1)
            {
                self.OnWeChatOABind();
                return;
            }


            M2C_GetWeChatOACode m2C_GetWe = await NetHelper.RequestWeChatOACode( self.ZoneScene() );
            if (m2C_GetWe != null && m2C_GetWe.Error == ErrorCode.ERR_Success)
            {
                self.Text_WechatOACode.GetComponent<Text>().text = $"{m2C_GetWe.Code}";
            }
            else
            {
                self.Text_WechatOACode.GetComponent<Text>().text = string.Empty;
            }
        }
    }
}