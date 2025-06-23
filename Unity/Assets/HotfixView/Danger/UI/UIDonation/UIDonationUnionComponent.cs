using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDonationUnionComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_Bonus;
        public GameObject Text_Open_Time;
        public GameObject Button_Signup;
        public GameObject Text_Tip_1;
        public GameObject Text_Tip_2;
        public GameObject Text_Tip_3;
        public GameObject Text_Tip_4;
        public GameObject Text_Tip_5;
        public GameObject Button_Race;
        public List<UnionListItem> UnionListItems = new List<UnionListItem>();
    }

    public class UIDonationUnionComponentAwake : AwakeSystem<UIDonationUnionComponent>
    {
        public override void Awake(UIDonationUnionComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Bonus = rc.Get<GameObject>("Text_Bonus");
            self.Text_Open_Time = rc.Get<GameObject>("Text_Open_Time");
            
            self.Text_Tip_1 = rc.Get<GameObject>("Text_Tip_1");
            self.Text_Tip_2 = rc.Get<GameObject>("Text_Tip_2");
            self.Text_Tip_3 = rc.Get<GameObject>("Text_Tip_3");
            self.Text_Tip_4 = rc.Get<GameObject>("Text_Tip_4");
            self.Text_Tip_5 = rc.Get<GameObject>("Text_Tip_5");

            self.Button_Signup = rc.Get<GameObject>("Button_Signup");
            ButtonHelp.AddListenerEx(self.Button_Signup, () => { self.OnButton_Signup().Coroutine();  });

            self.Button_Race = rc.Get<GameObject>("Button_Race");
            ButtonHelp.AddListenerEx(self.Button_Race, () => { self.OnButton_Race(); });
            self.Button_Race.SetActive(false);
            self.OnUpdateUI().Coroutine();
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIDonationUnionComponentDestroySystem : DestroySystem<UIDonationUnionComponent>
    {
        public override void Destroy(UIDonationUnionComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIDonationUnionComponentSystem
    {
        public static void OnLanguageUpdate(this UIDonationUnionComponent self)
        {
            self.Text_Open_Time.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 38;
            self.Text_Bonus.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 50 : 38;
            
            self.Text_Tip_1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 33 : 28;
            self.Text_Tip_2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 33 : 28;
            self.Text_Tip_3.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 33 : 28;
            self.Text_Tip_4.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 33 : 28;
        }

        public static void ShowOpenTime(this UIDonationUnionComponent self)
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
           
            long opentime = FunctionHelp.GetOpenTime(1044);
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
            bool raceopen = FunctionHelp.IsFunctionDayOpen((int)dateTime.DayOfWeek, 1044);

            if (raceopen && curTime < opentime)
            {
                self.Text_Open_Time.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}月{1}日 21点30开启"), dateTime.Month, dateTime.Day);
            }
            else
            {
                long addTime = (7 - (int)dateTime.DayOfWeek) * TimeHelper.OneDay + (opentime  - curTime )* TimeHelper.Second;
                serverTime += addTime;
                dateTime = TimeInfo.Instance.ToDateTime(serverTime);
                self.Text_Open_Time.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}月{1}日 21点30开启"), dateTime.Month, dateTime.Day);
            }
        }

        public static void OnButton_Race(this UIDonationUnionComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            bool signup = false;
            for (int i = 0; i < self.UnionListItems.Count; i++)
            {
                if (self.UnionListItems[i].UnionId == numericComponent.GetAsLong(NumericType.UnionId_0))
                {
                    signup = true;
                    break;
                }
            }
            if (signup)
            {
                EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.UnionRace, 2000008).Coroutine();
                UIHelper.Remove( self.ZoneScene(), UIType.UIDonation );
            }
            else
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("未报名！"));
            }
        }

        public static async ETTask OnButton_Signup(this UIDonationUnionComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            if (numericComponent.GetAsLong(NumericType.UnionId_0) == 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("没有家族！"));
                return;
            }

            for (int i = 0; i < self.UnionListItems.Count; i++)
            {
                if (self.UnionListItems[i].UnionId == numericComponent.GetAsLong(NumericType.UnionId_0))
                {
                    FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已报名！"));
                    return;
                }
            }

            C2U_UnionMyInfoRequest  unionrequest = new C2U_UnionMyInfoRequest() { UnionId = numericComponent.GetAsLong(NumericType.UnionId_0) };
            U2C_UnionMyInfoResponse unionrespose = (U2C_UnionMyInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(unionrequest);
            UnionPlayerInfo unionPlayerInfo = UnionHelper.GetUnionPlayerInfo(unionrespose.UnionMyInfo.UnionPlayerList, unit.Id);
            if (unionPlayerInfo.Position == 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("没有权限！"));
                return;
            }

            C2U_UnionSignUpRequest  request = new C2U_UnionSignUpRequest() { UnionId = numericComponent.GetAsLong(NumericType.UnionId_0) };
            U2C_UnionSignUpResponse response = (U2C_UnionSignUpResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.OnUpdateUI().Coroutine();
        }

        public static async ETTask OnUpdateUI(this UIDonationUnionComponent self)
        {
            C2U_UnionRaceInfoRequest  request = new C2U_UnionRaceInfoRequest();
            U2C_UnionRaceInfoResponse response = (U2C_UnionRaceInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.UnionListItems = response.UnionInfoList;
            self.Text_Bonus.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("累计总奖金： {0}"), response.TotalDonation);

            string unionnamelist = GameSettingLanguge.LoadLocalization("已报名家族：");
            for (int i = 0; i < self.UnionListItems.Count; i++)
            {
                unionnamelist = unionnamelist + self.UnionListItems[i].UnionName + "   ";
            }

            self.Text_Tip_5.GetComponent<Text>().text = unionnamelist;

            self.Button_Race.SetActive(FunctionHelp.IsInUnionRaceTime());
            self.Button_Signup.SetActive(!FunctionHelp.IsInUnionRaceTime());

            self.ShowOpenTime();
        }
    }
}
