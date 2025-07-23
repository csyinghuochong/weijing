using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanUpLvComponent : Entity, IAwake, IDestroy
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
        public GameObject Text_GengDiTip;
        public GameObject Image_GengDi;
        public GameObject Lab_GengDi;
        public GameObject Text_RenKouTip;
        public GameObject Image_RenKou;
        public GameObject Lab_RenKou;
        public GameObject ZiJinDuiHuanText;
        public GameObject ExpDuiHuanText;
        public GameObject ExpDuiHuanShow;
        public GameObject ZiJinDuiHuanShow;
        public GameObject ExpDuiHuanAddShow;
        public GameObject ZiJinDuiHuanAddShow;
        public GameObject ImgGengDiIcon;
        
        public List<string> AssetPath = new List<string>();
        
        public List<Vector2> UIOldPositionList = new List<Vector2>();
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
            self.Text_GengDiTip = rc.Get<GameObject>("Text_GengDiTip");
            self.Image_GengDi = rc.Get<GameObject>("Image_GengDi");
            self.Lab_GengDi = rc.Get<GameObject>("Lab_GengDi");
            self.Text_RenKouTip = rc.Get<GameObject>("Text_RenKouTip");
            self.Image_RenKou = rc.Get<GameObject>("Image_RenKou");
            self.Lab_RenKou = rc.Get<GameObject>("Lab_RenKou");

            self.ZiJinDuiHuanText = rc.Get<GameObject>("ZiJinDuiHuanText");
            self.ExpDuiHuanText = rc.Get<GameObject>("ExpDuiHuanText");

            
            self.ExpDuiHuanShow = rc.Get<GameObject>("ExpDuiHuanShow");
            self.ZiJinDuiHuanShow = rc.Get<GameObject>("ZiJinDuiHuanShow");
            self.ExpDuiHuanAddShow = rc.Get<GameObject>("ExpDuiHuanAddShow");
            self.ZiJinDuiHuanAddShow = rc.Get<GameObject>("ZiJinDuiHuanAddShow");
            self.ImgGengDiIcon = rc.Get<GameObject>("ImgGengDiIcon");

            self.Btn_UpLv = rc.Get<GameObject>("Btn_UpLv");
            ButtonHelp.AddListenerEx( self.Btn_UpLv, () => { self.OnBtn_UpLv().Coroutine();  });
            self.Btn_ExchangeExp = rc.Get<GameObject>("Btn_ExchangeExp");
            ButtonHelp.AddListenerEx(self.Btn_ExchangeExp, () => { self.OnBtn_ExchangeExp().Coroutine(); });
            self.Btn_ExchangeZiJin = rc.Get<GameObject>("Btn_ExchangeZiJin");
            ButtonHelp.AddListenerEx(self.Btn_ExchangeZiJin, () => { self.OnBtn_ExchangeZiJin().Coroutine(); });

            //放止图标丢失
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, "444");
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ImgGengDiIcon.GetComponent<Image>().sprite = sp;

            self.StoreUIdData();
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
            
            self.OnUpdateUI();
        }
    }
    public class UIJiaYuanUpLvComponentDestroy : DestroySystem<UIJiaYuanUpLvComponent>
    {
        public override void Destroy(UIJiaYuanUpLvComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
            
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    public static class UIJiaYuanUpLvComponentSystem
    {
        public static void StoreUIdData(this UIJiaYuanUpLvComponent self)
        {
            self.UIOldPositionList.Add(self.Text_GengDiTip.GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(self.Image_GengDi.GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(self.Lab_GengDi.GetComponent<RectTransform>().localPosition);
            
            self.UIOldPositionList.Add(self.Text_RenKouTip.GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(self.Image_RenKou.GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(self.Lab_RenKou.GetComponent<RectTransform>().localPosition);
        }

        public static void OnLanguageUpdate(this UIJiaYuanUpLvComponent self)
        {
            self.JiaYuanUpHint.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 32 : 28;
            
            self.Text_GengDiTip.GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[0] : new Vector2(-219, 0);
            self.Image_GengDi.GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[1] : new Vector2(-206, 0);
            self.Lab_GengDi.GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[2] : new Vector2(34, 0);
            
            self.Text_RenKouTip.GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[3] : new Vector2(-83, 0);
            self.Image_RenKou.GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[4] : new Vector2(-201, 0);
            self.Lab_RenKou.GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[5] : new Vector2(116, 0);
        }

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
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("兑换次数不足！"));
                return;
            }
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfo.JiaYuanLv);
            if (userInfo.JiaYuanFund < jiaYuanConfig.ExchangeExpCostZiJin)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("家园资金不足！"));
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
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("兑换次数不足！"));
                return;
            }
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfo.JiaYuanLv);
            if (userInfo.Gold < jiaYuanConfig.ExchangeZiJinCostGold)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("金币不足！"));
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
            self.JiaYuanName.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}的家园"), userInfoCom.UserInfo.Name);
            self.Text_ZiZhiValue.GetComponent<Text>().text = userInfoCom.UserInfo.JiaYuanExp + "/" + jiayuanCof.Exp;
            self.ImageExpValue.GetComponent<Image>().fillAmount = (float)userInfoCom.UserInfo.JiaYuanExp / (float)jiayuanCof.Exp;

            self.Lab_GengDi.GetComponent<Text>().text = jiayuanCof.FarmNumMax.ToString();
            self.Lab_RenKou.GetComponent<Text>().text = jiayuanCof.PeopleNumMax.ToString();

            self.JiaYuanLv.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("等级：{0}"), + jiayuanCof.Lv);

            //提示描述
            int hour = (int)((float)(jiayuanCof.Exp - (int)userInfoCom.UserInfo.JiaYuanExp)/ jiayuanCof.JiaYuanAddExp) + 1;
            if (hour < 0) {
                hour = 0;
            }

            self.JiaYuanUpHint.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("提示:经验产出{0}/小时,预计{1}小时后可升级家园"), jiayuanCof.JiaYuanAddExp, hour);

            self.ZiJinDuiHuanText.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("兑换次数:10/{0}"), numericComponent.GetAsInt(NumericType.JiaYuanExchangeZiJin));
            self.ExpDuiHuanText.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("兑换次数:10/{0}"), numericComponent.GetAsInt(NumericType.JiaYuanExchangeExp));

            string[] upgets = jiayuanCof.GetJiaYuanDes().Split(';');
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
