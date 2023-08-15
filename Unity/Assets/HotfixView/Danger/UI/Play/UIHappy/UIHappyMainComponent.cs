using System;
using System.Collections.Generic;
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

        public Text TextTip_3;
        public Text TextTip_2;
        public Text TextTip_1;

        public GameObject ButtonMove_3;
        public GameObject ButtonMove_2;
        public GameObject ButtonMove_1;

        public GameObject ButtonPick;

        public long NextFefreshTime;

        public long NextMoveTime;

        public long Timer;

        public string DefaultTime = "0;0";
    }

    public class UIHappyMainComponentAwake : AwakeSystem<UIHappyMainComponent>
    {
        public override void Awake(UIHappyMainComponent self)
        {
            self.NextFefreshTime = 0;

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextCoundown = rc.Get<GameObject>("TextCoundown").GetComponent<Text>();

            self.TextTip_3 = rc.Get<GameObject>("TextTip_3").GetComponent<Text>();
            self.TextTip_2 = rc.Get<GameObject>("TextTip_2").GetComponent<Text>();
            self.TextTip_1 = rc.Get<GameObject>("TextTip_1").GetComponent<Text>();

            self.ButtonMove_3 = rc.Get<GameObject>("ButtonMove_3");
            self.ButtonMove_2 = rc.Get<GameObject>("ButtonMove_2");
            self.ButtonMove_1 = rc.Get<GameObject>("ButtonMove_1");
            ButtonHelp.AddListenerEx(self.ButtonMove_3, () => { self.OnButtonMove(3).Coroutine(); } );
            ButtonHelp.AddListenerEx(self.ButtonMove_2, () => { self.OnButtonMove(2).Coroutine(); });
            ButtonHelp.AddListenerEx(self.ButtonMove_1, () => { self.OnButtonMove(1).Coroutine(); });

            self.ButtonPick = rc.Get<GameObject>("ButtonPick");
            ButtonHelp.AddListenerEx(self.ButtonPick, () => { self.OnButtonPick(); });

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

            long leftTime = self.NextFefreshTime - TimeHelper.ServerNow();
            if (leftTime >= 0)
            {
                leftTime /= 1000;
                int minute = (int)(leftTime / 60);
                int second = (int)(leftTime % 60);
                self.TextCoundown.text = $"{minute}:{second}";
            }
            else
            {
                self.TextCoundown.text = self.DefaultTime;
            }

            long moveTime = self.NextMoveTime - TimeHelper.ServerNow();
            if (moveTime >= 0)
            {
                moveTime /= 1000;
                int minute = (int)(moveTime / 60);
                int second = (int)(moveTime % 60);
                self.TextTip_1.text = $"{minute}:{second}";
            }
            else
            {
                self.TextTip_1.text = self.DefaultTime;
            }
        }

        public static void OnUpdateMoney(this UIHappyMainComponent self)
        {
            long mianfeicd = GlobalValueConfigCategory.Instance.Get(93).Value2 * 1000;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long lastmovetime = unit.GetComponent<NumericComponent>().GetAsLong( NumericType.HappyMoveTime );
            self.NextMoveTime = lastmovetime += mianfeicd;

            //金币消耗
            GlobalValueConfig globalValueConfig1 = GlobalValueConfigCategory.Instance.Get(94);
            self.TextTip_2.text = $"金币消耗:{globalValueConfig1.Value2}";

            //钻石消耗
            GlobalValueConfig globalValueConfig2 = GlobalValueConfigCategory.Instance.Get(95);
            self.TextTip_3.text = $"钻石消耗:{globalValueConfig2.Value2}";
        }

        public static void  OnButtonPick(this UIHappyMainComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() <= 0)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_BagIsFull);
                return;
            }

            List<DropInfo> ids = MapHelper.GetCanShiQu(self.ZoneScene(), 0.5f);
            if (ids.Count > 0)
            {
                UI uimain = UIHelper.GetUI( self.ZoneScene(), UIType.UIMain );
                uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.RequestShiQu(ids).Coroutine();

                //播放音效
                UIHelper.PlayUIMusic("10004");
                return;
            }
        }

        public static async ETTask OnButtonMove(this UIHappyMainComponent self, int moveType)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            if (moveType == 1)
            {
                //非免费时间则返回
                if (self.NextMoveTime > 0)
                {
                    return;
                }
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

            self.OnUpdateMoney();
        }
    }
}