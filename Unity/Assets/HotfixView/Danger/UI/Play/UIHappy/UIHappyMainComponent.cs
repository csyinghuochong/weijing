using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.UIHappyMainTimer)]
    public class UIHappyMainTimer : ATimer<UIHappyMainComponent>
    {
        public override void Run(UIHappyMainComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIHappyMainComponent : Entity, IAwake, IDestroy
    {

        public Text TextCoundown;

        public GameObject TextTip_3;
        public GameObject TextTip_2;
        public GameObject TextTip_1;

        public GameObject ButtonMove_3;
        public GameObject ButtonMove_2;
        public GameObject ButtonMove_1;

        public GameObject ButtonPick;

        public long NextFefreshTime;

        public long Timer;
    }

    public class UIHappyMainComponentAwake : AwakeSystem<UIHappyMainComponent>
    {
        public override void Awake(UIHappyMainComponent self)
        {
            self.NextFefreshTime = 0;

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextCoundown = rc.Get<GameObject>("TextCoundown").GetComponent<Text>();

            self.TextTip_3 = rc.Get<GameObject>("TextTip_3");
            self.TextTip_2 = rc.Get<GameObject>("TextTip_2");
            self.TextTip_1 = rc.Get<GameObject>("TextTip_1");

            self.ButtonMove_3 = rc.Get<GameObject>("ButtonMove_3");
            self.ButtonMove_2 = rc.Get<GameObject>("ButtonMove_2");
            self.ButtonMove_1 = rc.Get<GameObject>("ButtonMove_1");

            self.ButtonPick = rc.Get<GameObject>("ButtonPick");

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Second, TimerType.UIHappyMainTimer, self );
            self.OnInitUI();
        }
    }

    public class UIHappyMainComponentDestroe : DestroySystem<UIHappyMainComponent>
    {
        public override void Destroy(UIHappyMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIHappyMainComponentSystem
    {

        public static void OnInitUI(this UIHappyMainComponent self)
        {
            M2C_HappyInfoResult m2C_Happy = self.ZoneScene().GetComponent<BattleMessageComponent>().M2C_HappyInfoResult;
            if (m2C_Happy != null)
            {
                self.OnUpdateUI(m2C_Happy);
            }
        }

        public static void OnUpdateUI(this UIHappyMainComponent self, M2C_HappyInfoResult m2C_Happy)
        {
            self.NextFefreshTime = m2C_Happy.NextRefreshTime;
        }

        public static void OnUpdate(this UIHappyMainComponent self)
        {
            if (self.NextFefreshTime == 0)
            {
                return;
            }
            long leftTime = self.NextFefreshTime - TimeHelper.ServerNow();
            if (leftTime < 0)
            {
                return;
            }
            leftTime /= 1000;
            int minute = (int)(leftTime / 60);
            int second = (int)(leftTime % 60);
            self.TextCoundown.text = $"{minute}:{second}";
        }

        public static async ETTask OnButtonMove(this UIHappyMainComponent self, int moveType)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            if (moveType == 1)
            {
                //非免费时间则返回
                ;
            }
            if (moveType == 2)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(94);
                if (userInfoComponent.UserInfo.Gold < globalValueConfig.Value2)
                {
                    FloatTipManager.Instance.ShowFloatTip(ErrorHelp.Instance.GetHint(ErrorCore.ERR_GoldNotEnoughError));
                    return;
                }
            }
            if (moveType == 3)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(95);
                if (userInfoComponent.UserInfo.Diamond < globalValueConfig.Value2)
                {
                    FloatTipManager.Instance.ShowFloatTip(ErrorHelp.Instance.GetHint(ErrorCore.ERR_DiamondNotEnoughError));
                    return;
                }
            }

            long instanceId = self.InstanceId;
            C2M_HappyMoveRequest request = new C2M_HappyMoveRequest() { OperatateType = 1 };
            M2C_HappyMoveResponse response = (M2C_HappyMoveResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (instanceId != self.InstanceId || response.Error == ErrorCore.ERR_Success)
            {
                return;
            }


        }
    }
}