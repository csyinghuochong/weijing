using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionDonationComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_Tip_1;
        public GameObject Text_Tip_2;
        public GameObject Text_Tip_4;
        public GameObject Text_Tip_3;
        public GameObject Button_Donation;
        public GameObject Text_Tip_6;
        public GameObject Text_Tip_5;
        public GameObject Button_DiamondDonation;
        public GameObject Button_Record;
        public long LastDonationTime;
        public int UnionLevel;
    }

    public class UIUnionDonationComponentAwake : AwakeSystem<UIUnionDonationComponent>
    {
        public override void Awake(UIUnionDonationComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Tip_1 = rc.Get<GameObject>("Text_Tip_1");
            self.Text_Tip_2 = rc.Get<GameObject>("Text_Tip_2");
            self.Text_Tip_4 = rc.Get<GameObject>("Text_Tip_4");
            self.Text_Tip_3 = rc.Get<GameObject>("Text_Tip_3");
            self.Text_Tip_6 = rc.Get<GameObject>("Text_Tip_6");
            self.Text_Tip_5 = rc.Get<GameObject>("Text_Tip_5");

            self.Button_DiamondDonation = rc.Get<GameObject>("Button_DiamondDonation");
            ButtonHelp.AddListenerEx(self.Button_DiamondDonation, () => { self.OnButton_DiamondDonation().Coroutine(); });

            self.Button_Donation = rc.Get<GameObject>("Button_Donation");
            ButtonHelp.AddListenerEx(self.Button_Donation, () => { self.OnButton_Donation().Coroutine(); });

            self.Button_Record = rc.Get<GameObject>("Button_Record");
            ButtonHelp.AddListenerEx(self.Button_Record, () => { self.OnButton_Record(); });

            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
            
            self.OnUpdateUI();
        }
    }

    public class UIUnionDonationComponentDestroySystem : DestroySystem<UIUnionDonationComponent>
    {
        public override void Destroy(UIUnionDonationComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIUnionDonationComponentSystem
    {
        public static void OnLanguageUpdate(this UIUnionDonationComponent self)
        {
            self.Text_Tip_1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 36;
            self.Text_Tip_2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 36;
            self.Text_Tip_3.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 36;
            self.Text_Tip_4.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 36;
            self.Text_Tip_5.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 36;
            self.Text_Tip_6.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 36;
            self.Button_Record.GetComponentInChildren<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Button_Record.GetComponentInChildren<Text>().lineSpacing = GameSettingLanguge.Language == 0? 1f : 0.6f;
        }

        public static async void OnUpdateUI(this UIUnionDonationComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.Text_Tip_4.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("捐献次数： {0}/{1}次"), unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDonationNumber), 5);
            self.Text_Tip_6.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("捐献次数： {0}/{1}次"), unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDiamondDonationNumber), 10);

            //客户端获取家族等级
            long unionId = (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0));
            C2U_UnionMyInfoRequest request = new C2U_UnionMyInfoRequest()
            {
                UnionId = unionId
            };
            U2C_UnionMyInfoResponse respose = (U2C_UnionMyInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);
            if (respose.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            UnionConfig unionCof = UnionConfigCategory.Instance.Get((int)respose.UnionMyInfo.Level);

            self.UnionLevel = respose.UnionMyInfo.Level;
            self.Text_Tip_3.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("消耗:{0}金币"), unionCof.DonateGold);
            self.Text_Tip_5.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("消耗:{0}钻石"), unionCof.DonateDiamond);
        }

        public static void OnButton_Record(this UIUnionDonationComponent self)
        {
            UIHelper.Create( self.ZoneScene(), UIType.UIUnionDonationRecord ).Coroutine();
        }

        public static async ETTask OnButton_DiamondDonation(this UIUnionDonationComponent self)
        {
            UnionConfig unionConfig = UnionConfigCategory.Instance.Get(self.UnionLevel);
            long selfDiamond = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Diamond;
            if (selfDiamond < unionConfig.DonateDiamond)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("钻石数量不足！"));
                return;
            }

            if (TimeHelper.ServerNow() - self.LastDonationTime < 500)
            {
                return;
            }
            self.LastDonationTime = TimeHelper.ServerNow();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDiamondDonationNumber)>= 10)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("捐献次数已达上限！"));
                return;
            }

            C2M_UnionDonationRequest request = new C2M_UnionDonationRequest() { Type = 1 };
            M2C_UnionDonationResponse response = (M2C_UnionDonationResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.OnUpdateUI();
        }
        
        public static async ETTask OnButton_Donation(this UIUnionDonationComponent self)
        {
            UnionConfig unionConfig = UnionConfigCategory.Instance.Get(self.UnionLevel);
            long selfgold = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Gold;
            if (selfgold < unionConfig.DonateGold)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("金币数量不足！"));
                return;
            }
            
            if (TimeHelper.ServerNow() - self.LastDonationTime < 500)
            {
                return;
            }
            self.LastDonationTime = TimeHelper.ServerNow();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDonationNumber)>= 5)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("捐献次数已达上限！"));
                return;
            }

            C2M_UnionDonationRequest request = new C2M_UnionDonationRequest() { Type = 0 };
            M2C_UnionDonationResponse response = (M2C_UnionDonationResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.OnUpdateUI();
        }
    }
}
