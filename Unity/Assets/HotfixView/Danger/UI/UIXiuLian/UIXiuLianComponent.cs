using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.UIXiuLianTimer)]
    public class UIXiuLianTimer : ATimer<UIXiuLianComponent>
    {
        public override void Run(UIXiuLianComponent self)
        {
            try
            {
                self.OnUpdateUI();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIXiuLianComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_ExpCD;
        public GameObject Text_CoinCD;
        public GameObject Text_CoinTime;
        public GameObject Text_ExpTime;
        public GameObject Text_GetCoin;
        public GameObject Text_GetExp;
        public GameObject ButtonCoin;
        public GameObject ButtonExp;

        public long Timer;
    }


    public class UIXiuLianComponentDestroySystem : DestroySystem<UIXiuLianComponent>
    {
        public override void Destroy(UIXiuLianComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }


    public class UIXiuLianComponentAwakeSystem : AwakeSystem<UIXiuLianComponent>
    {
        public override void Awake(UIXiuLianComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_CoinTime = rc.Get<GameObject>("Text_CoinTime");
            self.Text_ExpTime = rc.Get<GameObject>("Text_ExpTime");
            self.Text_GetCoin = rc.Get<GameObject>("Text_GetCoin");
            self.Text_GetExp = rc.Get<GameObject>("Text_GetExp");
            self.ButtonCoin = rc.Get<GameObject>("ButtonCoin");
            self.ButtonExp = rc.Get<GameObject>("ButtonExp");
            self.Text_ExpCD = rc.Get<GameObject>("Text_ExpCD");
            self.Text_CoinCD = rc.Get<GameObject>("Text_CoinCD");

            ButtonHelp.AddListenerEx(self.ButtonCoin, () => { self.ReqestCoinXiuLian().Coroutine(); });
            ButtonHelp.AddListenerEx(self.ButtonExp, () => { self.ReqestExpXiuLian().Coroutine(); });

            self.OnUpdateUI();
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.UIXiuLianTimer, self);
        }
    }

    public static class UIXiuLianComponentSystem
    {

        public static void OnUpdateUI(this UIXiuLianComponent self)
        {
            int level = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int xiulianExpNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.XiuLian_ExpNumber);
            int xiulianCoinNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.XiuLian_CoinNumber);

            self.Text_CoinTime.GetComponent<Text>().text = $"剩余领取次数 {3- xiulianCoinNumber}/3";
            self.Text_ExpTime.GetComponent<Text>().text = $"剩余领取次数 {3 - xiulianExpNumber}/3";

            float coefficient = float.Parse(GlobalValueConfigCategory.Instance.Get(29).Value);
            int addValue = Mathf.CeilToInt(coefficient * level);
            self.Text_GetExp.GetComponent<Text>().text = $"当前可提取修炼经验：{addValue}";

            coefficient = float.Parse(GlobalValueConfigCategory.Instance.Get(30).Value);
            addValue = Mathf.CeilToInt(coefficient * level);
            self.Text_GetCoin.GetComponent<Text>().text = $"当前可提取修炼金币：{addValue}";

            long xiulianExpTime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.XiuLian_ExpTime);
            long xiulianCoinTime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.XiuLian_CoinTime);
            long leftExpCD = 60 * 60 * 1000 - (TimeHelper.ServerNow() - xiulianExpTime);
            if (leftExpCD > 0)
            {
                self.Text_ExpCD.GetComponent<Text>().text = "修炼时间倒计时:" + TimeHelper.ShowLeftTime(leftExpCD);
            }
            else
            {
                self.Text_ExpCD.GetComponent<Text>().text = "可领取！";
            }
            long leftCoinCD = 60 * 60 * 1000 - (TimeHelper.ServerNow() - xiulianCoinTime);
            if (leftCoinCD > 0)
            {
                self.Text_CoinCD.GetComponent<Text>().text = "修炼时间倒计时:" + TimeHelper.ShowLeftTime(leftCoinCD);
            } 
            else
            {
                self.Text_CoinCD.GetComponent<Text>().text = "可领取！";
            }
        }
        
        public static async ETTask ReqestCoinXiuLian(this UIXiuLianComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long xiulianCoinTime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.XiuLian_CoinTime);
            long leftCoinCD = 60 * 60 * 1000 - (TimeHelper.ServerNow() - xiulianCoinTime);
            if (leftCoinCD > 0)
            {
                FloatTipManager.Instance.ShowFloatTip("还未到领取时间！");
                return;
            }

            int xiulianNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.XiuLian_CoinNumber);
            if (xiulianNumber >= 3)
            {
                FloatTipManager.Instance.ShowFloatTip("已达到最大修炼次数！");
                return;
            }

            C2M_XiuLianCenterRequest c2M_XiuLianCenterRequest = new C2M_XiuLianCenterRequest() {  XiuLianType = 2};
            M2C_XiuLianCenterResponse m2C_XiuLianCenterResponse =   (M2C_XiuLianCenterResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_XiuLianCenterRequest);
            self.OnUpdateUI();
        }

        public static async ETTask ReqestExpXiuLian(this UIXiuLianComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long xiulianExpTime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.XiuLian_ExpTime);
            long leftExpCD = 60 * 60 * 1000 - (TimeHelper.ServerNow() - xiulianExpTime);
            if (leftExpCD > 0)
            {
                FloatTipManager.Instance.ShowFloatTip("还未到领取时间！");
                return;
            }
           
            int xiulianNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.XiuLian_ExpNumber);
            if (xiulianNumber >= 3)
            {
                FloatTipManager.Instance.ShowFloatTip("已达到最大修炼次数！");
                return;
            }

            C2M_XiuLianCenterRequest c2M_XiuLianCenterRequest = new C2M_XiuLianCenterRequest() { XiuLianType = 1 };
            M2C_XiuLianCenterResponse m2C_XiuLianCenterResponse = (M2C_XiuLianCenterResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_XiuLianCenterRequest);
            self.OnUpdateUI();
        }

    }
}
