using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWorldLvComponent : Entity, IAwake
    {
        public GameObject Lab_DuiHuanTimes;
        public GameObject Lab_ExpRate;
        public GameObject Lab_ExpAddPro;
        public GameObject Lab_GanDiName;
        public GameObject Lab_MyLv2;
        public GameObject Lab_MyLv1;
        public GameObject Text_WorldLv;
        public GameObject ButtonDiHuan;
        public GameObject Btn_Close;
        public ServerInfo ServerInfo;
    }


    public class UIWorldLvComponentAwakeSystem : AwakeSystem<UIWorldLvComponent>
    {
        public override void Awake(UIWorldLvComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_ExpRate = rc.Get<GameObject>("Lab_ExpRate");
            self.Lab_ExpAddPro = rc.Get<GameObject>("Lab_ExpAddPro");
            self.Lab_GanDiName = rc.Get<GameObject>("Lab_GanDiName");
            self.Lab_MyLv2 = rc.Get<GameObject>("Lab_MyLv2");
            self.Lab_MyLv1 = rc.Get<GameObject>("Lab_MyLv1");
            self.Text_WorldLv = rc.Get<GameObject>("Text_WorldLv");
            self.Lab_DuiHuanTimes = rc.Get<GameObject>("Lab_DuiHuanTimes");

            self.ButtonDiHuan = rc.Get<GameObject>("ButtonDiHuan");
            ButtonHelp.AddListenerEx( self.ButtonDiHuan, () => { self.OnButtonDiHuan();  } );

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener( self.OnBtn_Close );

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIWorldLvComponentSystem
    {
        public static async ETTask OnInitUI(this UIWorldLvComponent self)
        {
            C2R_WorldLvRequest  request = new C2R_WorldLvRequest();
            R2C_WorldLvResponse response = (R2C_WorldLvResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.IsDisposed)
            {
                return;
            }

            RankingInfo rankingInfo = response.ServerInfo.RankingInfo;
            self.Text_WorldLv.GetComponent<Text>().text = response.ServerInfo.WorldLv.ToString();
            self.ServerInfo = response.ServerInfo;
            //self.Lab_GanDiName.SetActive(rankingInfo != null);
            if (rankingInfo != null)
            {
                self.Lab_GanDiName.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}({1}级)"), rankingInfo.PlayerName, rankingInfo.PlayerLv);
            }
            else 
            {
                self.Lab_GanDiName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("暂无上榜");
            }

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            self.Lab_MyLv1.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("你当前的等级：{0}"), userInfo.Lv);
            self.Lab_MyLv2.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("你当前的等级：{0}"), userInfo.Lv);

            float expAdd = ComHelp.GetExpAdd(userInfo.Lv, response.ServerInfo);
            self.Lab_ExpRate.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("可以获得经验加成:{0}%"), (int)(expAdd * 100));
            self.Lab_ExpAddPro.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("可以获得经验加成:{0}%"), (int)(expAdd * 100));
            self.UpdateDuiHuanTimes();
        }

        public static void OnBtn_Close(this UIWorldLvComponent self)
        {
            UIHelper.Remove( self.ZoneScene(), UIType.UIWorldLv );
        }

        public static void  OnButtonDiHuan(this UIWorldLvComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

            if (userInfo.Lv < self.ServerInfo.WorldLv)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("低于世界等级无法兑换"));
                return;
            }
          
            //低于20%经验无法兑换
            ExpConfig expCof = ExpConfigCategory.Instance.Get(userInfo.Lv);
            int costExp = (int)(expCof.UpExp * 0.2f);
            if (userInfo.Exp < costExp)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("低于20%经验无法兑换"));
                return;
            }

            int sendGold = (int)(10000 + expCof.RoseGoldPro * 10);
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), GameSettingLanguge.LoadLocalization("兑换金币"),
                string.Format(GameSettingLanguge.LoadLocalization("是否消耗{0}经验兑换{1}金币"), costExp, sendGold), () =>
            {
                self.RequestExpToGold().Coroutine();
            }, null).Coroutine();
        }

        public static void UpdateDuiHuanTimes(this UIWorldLvComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int times = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ExpToGoldTimes);
            self.Lab_DuiHuanTimes.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("今日兑换次数:{0}"), times);
        }

        public static async ETTask RequestExpToGold(this UIWorldLvComponent self)
        {
            C2M_ExpToGoldRequest request = new C2M_ExpToGoldRequest() {  OperateType = 1};
            M2C_ExpToGoldResponse response = (M2C_ExpToGoldResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.UpdateDuiHuanTimes();
        }
    }
}
