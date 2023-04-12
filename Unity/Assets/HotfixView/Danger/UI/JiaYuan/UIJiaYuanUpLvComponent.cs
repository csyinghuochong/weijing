using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanUpLvComponent : Entity, IAwake
    {
        public GameObject UpdateGet;
        public GameObject Btn_UpLv;
        public GameObject Btn_ExchangeExp;
        public GameObject Btn_ExchangeZiJin;
        public GameObject Text_ZiZhiValue;
        public GameObject JiaYuanUpHint;
        public GameObject ImageExpValue;
        public GameObject JiaYuanName;
        public GameObject JiaYuanLv;
        public GameObject Lab_GengDi;
        public GameObject Lab_RenKou;
        public GameObject ZiJinDuiHuanText;
        public GameObject ExpDuiHuanText;
        public GameObject ExpDuiHuanShow;
        public GameObject ZiJinDuiHuanShow;
        public GameObject ExpDuiHuanAddShow;
        public GameObject ZiJinDuiHuanAddShow;
    }


    public class UIJiaYuanUpLvComponentAwake : AwakeSystem<UIJiaYuanUpLvComponent>
    {
        public override void Awake(UIJiaYuanUpLvComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UpdateGet = rc.Get<GameObject>("UpdateGet");
            self.Text_ZiZhiValue = rc.Get<GameObject>("Text_ZiZhiValue");
            self.JiaYuanUpHint = rc.Get<GameObject>("JiaYuanUpHint");
            self.ImageExpValue = rc.Get<GameObject>("ImageExpValue");
            self.JiaYuanName = rc.Get<GameObject>("JiaYuanName");
            self.JiaYuanLv = rc.Get<GameObject>("JiaYuanLv");

            self.Lab_GengDi = rc.Get<GameObject>("Lab_GengDi");
            self.Lab_RenKou = rc.Get<GameObject>("Lab_RenKou");

            self.ZiJinDuiHuanText = rc.Get<GameObject>("ZiJinDuiHuanText");
            self.ExpDuiHuanText = rc.Get<GameObject>("ExpDuiHuanText");

            
            self.ExpDuiHuanShow = rc.Get<GameObject>("ExpDuiHuanShow");
            self.ZiJinDuiHuanShow = rc.Get<GameObject>("ZiJinDuiHuanShow");
            self.ExpDuiHuanAddShow = rc.Get<GameObject>("ExpDuiHuanAddShow");
            self.ZiJinDuiHuanAddShow = rc.Get<GameObject>("ZiJinDuiHuanAddShow");

            self.Btn_UpLv = rc.Get<GameObject>("Btn_UpLv");
            ButtonHelp.AddListenerEx( self.Btn_UpLv, () => { self.OnBtn_UpLv().Coroutine();  });
            self.Btn_ExchangeExp = rc.Get<GameObject>("Btn_ExchangeExp");
            ButtonHelp.AddListenerEx(self.Btn_ExchangeExp, () => { self.OnBtn_ExchangeExp().Coroutine(); });
            self.Btn_ExchangeZiJin = rc.Get<GameObject>("Btn_ExchangeZiJin");
            ButtonHelp.AddListenerEx(self.Btn_ExchangeZiJin, () => { self.OnBtn_ExchangeZiJin().Coroutine(); });

            self.OnUpdateUI();
        }
    }

    public static class UIJiaYuanUpLvComponentSystem
    {

        public static async ETTask OnBtn_UpLv(this UIJiaYuanUpLvComponent self)
        {
            C2M_JiaYuanUpLvRequest  requet  = new C2M_JiaYuanUpLvRequest() { };
            M2C_JiaYuanUpLvResponse response = (M2C_JiaYuanUpLvResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(requet);

            self.OnUpdateUI();
        }

        /// <summary>
        /// 兑换经验
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static async ETTask OnBtn_ExchangeExp(this UIJiaYuanUpLvComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            
            if (numericComponent.GetAsInt(NumericType.JiaYuanExchangeExp) >= 10)
            {
                FloatTipManager.Instance.ShowFloatTip("兑换次数不足！");
                return;
            }
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfo.JiaYuanLv);
            if (userInfo.JiaYuanFund < jiaYuanConfig.ExchangeExpCostZiJin)
            {
                FloatTipManager.Instance.ShowFloatTip("家园资金不足！");
                return;
            }

            C2M_JiaYuanExchangeRequest  request = new C2M_JiaYuanExchangeRequest() { ExchangeType = 2 };
            M2C_JiaYuanExchangeResponse response = (M2C_JiaYuanExchangeResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.OnUpdateUI();
        }
        public static async ETTask OnBtn_ExchangeZiJin(this UIJiaYuanUpLvComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.JiaYuanExchangeZiJin) >= 10)
            {
                FloatTipManager.Instance.ShowFloatTip("兑换次数不足！");
                return;
            }
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfo.JiaYuanLv);
            if (userInfo.Gold < jiaYuanConfig.ExchangeZiJinCostGold)
            {
                FloatTipManager.Instance.ShowFloatTip("金币不足！");
                return;
            }

            C2M_JiaYuanExchangeRequest request = new C2M_JiaYuanExchangeRequest() { ExchangeType = 1 };
            M2C_JiaYuanExchangeResponse response = (M2C_JiaYuanExchangeResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.OnUpdateUI();
        }

        //初始化
        public static void OnUpdateUI(this UIJiaYuanUpLvComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            UserInfoComponent userInfoCom = self.ZoneScene().GetComponent<UserInfoComponent>();
            int jiayuanid = userInfoCom.UserInfo.JiaYuanLv;

            JiaYuanConfig jiayuanCof = JiaYuanConfigCategory.Instance.Get(jiayuanid);
            self.JiaYuanName.GetComponent<Text>().text = userInfoCom.UserInfo.Name + "的家园";
            self.Text_ZiZhiValue.GetComponent<Text>().text = userInfoCom.UserInfo.JiaYuanExp + "/" + jiayuanCof.Exp;
            self.ImageExpValue.GetComponent<Image>().fillAmount = (float)userInfoCom.UserInfo.JiaYuanExp / (float)jiayuanCof.Exp;

            self.Lab_GengDi.GetComponent<Text>().text = jiayuanCof.FarmNumMax.ToString();
            self.Lab_RenKou.GetComponent<Text>().text = jiayuanCof.PeopleNumMax.ToString();

            self.JiaYuanLv.GetComponent<Text>().text = "等级:" + jiayuanCof.Lv;

            //提示描述
            int hour = (int)((float)(jiayuanCof.Exp - (int)userInfoCom.UserInfo.JiaYuanExp)/ jiayuanCof.JiaYuanAddExp) + 1;
            if (hour < 0) {
                hour = 0;
            }
            self.JiaYuanUpHint.GetComponent<Text>().text = "提示:经验产出" + jiayuanCof.JiaYuanAddExp + "/小时,预计" + hour + "小时后可升级家园";

            self.ZiJinDuiHuanText.GetComponent<Text>().text = $"兑换次数:10/{numericComponent.GetAsInt(NumericType.JiaYuanExchangeZiJin)}";
            self.ExpDuiHuanText.GetComponent<Text>().text = $"兑换次数:10/{numericComponent.GetAsInt(NumericType.JiaYuanExchangeExp)}";

            string[] upgets = jiayuanCof.JiaYuanDes.Split(';');
            for (int i = 0; i < self.UpdateGet.transform.childCount; i++)
            {
                Transform item = self.UpdateGet.transform.GetChild(i);
                if ( i >= upgets.Length)
                {
                    item.gameObject.SetActive(false);
                    continue;
                }
                item.gameObject.SetActive(true);
                item.Find("Text").GetComponent<Text>().text = upgets[i];
            }

            //更新兑换显示
            self.ExpDuiHuanShow.GetComponent<Text>().text = jiayuanCof.ExchangeExpCostZiJin.ToString();
            self.ZiJinDuiHuanShow.GetComponent<Text>().text = jiayuanCof.ExchangeZiJinCostGold.ToString();

            self.ExpDuiHuanAddShow.GetComponent<Text>().text = jiayuanCof.JiaYuanAddExp.ToString();
            self.ZiJinDuiHuanAddShow.GetComponent<Text>().text = jiayuanCof.ExchangeZiJin.ToString();

        }
    }
}
