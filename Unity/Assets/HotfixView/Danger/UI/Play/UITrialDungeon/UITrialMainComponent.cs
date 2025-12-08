using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.TrialMainTimer)]
    public class TrialMainTimer : ATimer<UITrialMainComponent>
    {
        public override void Run(UITrialMainComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UITrialHurtData
    {
        public int UnitType; //1宠物 2召唤物 3技能
        public long UnitId;
        public int ConfigId;
        public int SkillId;
        public string UnitName; //1宠物名字 2召唤物名字 3技能名字
        public int UseNumber;   //释放次数
        public long TotalHurt; //总伤害
    }

    public class UITrialMainComponent : Entity, IAwake, IDestroy
    {
        public GameObject TextCoundown;
        public GameObject ButtonTiaozhan;
        public GameObject ButtonDetails;
        public Text TextHurt;

        public long Countdown;
        public long Timer;
        public long LastTiaoZhan;
        public long HurtValue;
        public long FightTime;

        public List<UITrialHurtData> iTrialHurtDatas = new List<UITrialHurtData>();
    }


    public class UITrialMainComponentDestroy : DestroySystem<UITrialMainComponent>
    {
        public override void Destroy(UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public class UITrialMainComponentAwake : AwakeSystem<UITrialMainComponent>
    {
        public override void Awake(UITrialMainComponent self)
        {
            self.HurtValue = 0;
            self.LastTiaoZhan = 0;
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextCoundown = rc.Get<GameObject>("TextCoundown");
            self.ButtonTiaozhan = rc.Get<GameObject>("ButtonTiaozhan");
            self.ButtonDetails = rc.Get<GameObject>("ButtonDetails");
            self.TextHurt = rc.Get<GameObject>("TextHurt").GetComponent<Text>();
            self.OnUpdateHurt(0);
            self.iTrialHurtDatas.Clear();

            ButtonHelp.AddListenerEx(self.ButtonTiaozhan, self.OnButtonTiaozhan);
            ButtonHelp.AddListenerEx(self.ButtonDetails, () => { self.OnButtonDetails().Coroutine(); });
            self.BeginTimer();
        }
    }

    public static class UITrialMainComponentSystem
    {
        public static void StopTimer(this UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void OnUpdateHurt_2(this UITrialMainComponent self, EventType.UnitHpUpdate args)
        {
            if (args.ChangeHpValue > 0)
            {
                return;
            }
            Unit attack = args.Attack;
          
            // public int UnitType; //1宠物 2召唤物 3技能
            //public long UnitId;
            //public string UnitName; //1宠物名字 2召唤物名字 3技能名字
            //public int UseNumber;   //释放次数
            //public long TotalHurt; //总伤害
            int unitType = attack.Type;
            int configId = attack.ConfigId;
            string unitName = string.Empty;


            for (int i = 0; i < self.iTrialHurtDatas.Count; i++)
            {
                if (self.iTrialHurtDatas[i].UnitType != unitType)
                {
                    continue;
                }
                if (self.iTrialHurtDatas[i].ConfigId != configId)
                {
                    continue;
                }

                if (unitType == UnitType.Player)
                {
                    if ( self.iTrialHurtDatas[i].SkillId == args.SkillID)
                    {
                        self.iTrialHurtDatas[i].TotalHurt += args.ChangeHpValue * -1;
                        self.iTrialHurtDatas[i].UseNumber += 1;
                        return;
                    }
                }
                else
                {
                    self.iTrialHurtDatas[i].TotalHurt += args.ChangeHpValue * -1;
                    self.iTrialHurtDatas[i].UseNumber += 1;
                    return;
                }
            }

            UITrialHurtData uITrialHurtData = new UITrialHurtData();
            uITrialHurtData.UnitType = unitType;
            uITrialHurtData.UnitName = unitName;
            uITrialHurtData.UnitId = attack.Id;
            uITrialHurtData.ConfigId = attack.ConfigId;
            uITrialHurtData.SkillId = args.SkillID;
            uITrialHurtData.TotalHurt = args.ChangeHpValue * -1;
            uITrialHurtData.UseNumber = 1;
            self.iTrialHurtDatas.Add(uITrialHurtData);
        }

        public static void OnUpdateHurt(this UITrialMainComponent self, long hurt)
        {
            if (hurt > 0)
            {
                return;
            }
            hurt *= -1;
            self.HurtValue += hurt;

            if (self.FightTime <= 0)
            {
                self.FightTime = 1;
            }
            self.TextHurt.text = string.Format(GameSettingLanguge.LoadLocalization("伤害总值:{0}\n伤害秒值:{1}"), self.HurtValue, (int)((float)self.HurtValue / self.FightTime));
        }

        public static void BeginTimer(this UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Countdown = TimeHelper.ServerNow() + TimeHelper.Minute;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.TrialMainTimer, self);
        }

        public static async ETTask OnButtonDetails(this UITrialMainComponent self)
        {
            UI ui = await UIHelper.Create( self.ZoneScene(), UIType.UITrialHurtData );
            ui.GetComponent<UITrialHurtDataComponent>().OnUpdateUI( self.iTrialHurtDatas, self.HurtValue, self.FightTime );
            await ETTask.CompletedTask;
        }

        public static void OnButtonTiaozhan(this UITrialMainComponent self)
        {
            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            //if (numericComponent.GetAsInt(NumericType.TrialDungeonId) >= mapComponent.SonSceneId)
            //{
            //    FloatTipManager.Instance.ShowFloatTip("已经通关了该关卡！");
            //    return;
            //}

            if (TimeHelper.ServerNow() - self.LastTiaoZhan < 1000)
            {
                return;
            }
            self.LastTiaoZhan = TimeHelper.ServerNow();

            PopupTipHelp.OpenPopupTip(self.ZoneScene(), GameSettingLanguge.LoadLocalization("系统提示"), GameSettingLanguge.LoadLocalization("是否重新开始挑战,开始后倒计时和怪物生命将自动初始化"), () => 
            {
                self.RequestTiaozhan().Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask RequestTiaozhan(this UITrialMainComponent self)
        {
            C2M_TrialDungeonBeginRequest request = new C2M_TrialDungeonBeginRequest();
            M2C_TrialDungeonBeginResponse response = (M2C_TrialDungeonBeginResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            self.BeginTimer();
            self.HurtValue = 0;
            self.OnUpdateHurt(0);
            self.iTrialHurtDatas.Clear();
            self.FightTime = 0;
            self.ResetBossHP().Coroutine();
        }

        public static async ETTask ResetBossHP(this UITrialMainComponent self)
        {
            await TimerComponent.Instance.WaitAsync(500);
            UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            ui.GetComponent<UIMainComponent>().UIMainHpBar.BossNode.SetActive(false);
            ui.GetComponent<UIMainComponent>().UIMainHpBar.Img_BossHp.fillAmount = 1f;
            ui.GetComponent<UIMainComponent>().LockTargetComponent.OnMainHeroMove();
        }

        public static void OnTimer(this UITrialMainComponent self)
        {
            int leftTime = Mathf.CeilToInt(( self.Countdown - TimeHelper.ServerNow() ) * 0.001f);
            if (leftTime <= 0)
            {
                self.ZoneScene().GetComponent<SessionComponent>().Session.Call(new C2M_TrialDungeonFinishRequest()).Coroutine();
                TimerComponent.Instance?.Remove(ref self.Timer);

                self.TextCoundown.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("未能在60秒内击败怪物,请点击重新挑战");

                return;
            }

            self.TextCoundown.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("倒计时 {0}"), leftTime - 1);
            self.FightTime++;
        }
    }
}