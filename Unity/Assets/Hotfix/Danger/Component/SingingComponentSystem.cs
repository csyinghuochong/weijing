using System;

namespace ET
{

    [Timer(TimerType.UISingingTimer)]
    public class SingingTimer : ATimer<SingingComponent>
    {
        public override void Run(SingingComponent self)
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

    [ObjectSystem]
    public class SingingComponentAwake : AwakeSystem<SingingComponent>
    {
        public override void Awake(SingingComponent self)
        {
            
        }
    }

    [ObjectSystem]
    public class SingingComponentDestroy : DestroySystem<SingingComponent>
    {
        public override void Destroy(SingingComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class SingingComponentSystem
    {
        public static void OnTimer(this SingingComponent self)
        {
            self.PassTime = TimeHelper.ServerNow() - self.BeginTime ;
            self.UpdateUISinging();
        }

        public static void UpdateUISinging(this SingingComponent self)
        {
            EventType.SingingUpdate.Instance.Type = self.Type;
            EventType.SingingUpdate.Instance.PassTime = self.PassTime;
            EventType.SingingUpdate.Instance.TotalTime = self.TotalTime;
            EventType.SingingUpdate.Instance.ZoneScene = self.ZoneScene();
            Game.EventSystem.PublishClass(EventType.SingingUpdate.Instance);

            if (self.Type == 1 && self.PassTime < 0)
            {
                //打断吟唱前
                StateComponent stateComponent = self.GetParent<Unit>().GetComponent<StateComponent>();
                stateComponent.SendUpdateState(2, StateTypeEnum.Singing, "0_0");
            }
            if (self.Type == 1 &&  self.PassTime > self.TotalTime)
            {
                //吟唱前结束，释放技能
                self.PassTime = -1;
                self.TotalTime = -1;
                Unit unit = self.GetParent<Unit>();
                StateComponent stateComponent = unit.GetComponent<StateComponent>();
                stateComponent.SendUpdateState(2, StateTypeEnum.Singing, "0_0");
                self.ImmediateUseSkill();
            }
            if (self.Type == 2 && self.PassTime > self.TotalTime)
            {
                //吟唱后结束，释放技能
                self.PassTime = -1;
                self.TotalTime = -1;
            }
            if (self.PassTime < 0)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }
        }

        public static void AfterSkillSing(this SingingComponent self, SkillConfig skillConfig)
        {
            if (skillConfig.ComboSkillID == 0 && skillConfig.SkillSingTime > 0f)
            {
                self.Type = 2;
                self.PassTime = 0;
                self.TotalTime = (long)(1000 * skillConfig.SkillSingTime);
                TimerComponent.Instance?.Remove(ref self.Timer);
                self.BeginTime = TimeHelper.ServerNow();
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.UISingingTimer, self);
            }
        }

        //被攻击，吟唱时间倒退0.3秒
        public static void StateTypeAdd(this SingingComponent self, long nowStateType)
        {
            if (self.Type == 1 && self.Timer > 0)
            {
                bool daduan = nowStateType == StateTypeEnum.Silence || nowStateType == StateTypeEnum.Dizziness;
                self.PassTime = daduan ? -1 : self.PassTime;   
                self.UpdateUISinging();
            }
        }

        /// <summary>
        /// 施法中吟唱由服务器打断
        /// </summary>
        /// <param name="self"></param>
        public static void OnInterrupt(this SingingComponent self)
        {
            self.PassTime = -1;
            self.UpdateUISinging();
            HintHelp.GetInstance().ShowHint("施法中断！");
        }

        public static void BeginMove(this SingingComponent self)
        {
            long passTime = self.PassTime;
            if (passTime <= 0)
            {
                return;
            }

            self.PassTime = -1;
            self.UpdateUISinging();

            //立即释放技能
            if (self.c2M_SkillCmd == null || self.c2M_SkillCmd.SkillID == 0)
            {
                return;
            }
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get( self.c2M_SkillCmd.SkillID );
            if (self.c2M_SkillCmd == null || self.c2M_SkillCmd.SkillID == 0)
            {
                return;
            }
            if (skillConfig.SkillFrontSingTime > 0f && SkillHelp.havePassiveSkillType(skillConfig.PassiveSkillType, 2))
            {
                float sinValue = (float)((0.001f * passTime) / (float)skillConfig.SkillFrontSingTime);
                sinValue = Math.Min(sinValue, 1f);
                self.c2M_SkillCmd.SingValue = sinValue;
                self.ImmediateUseSkill();
            }
        }

        public static void PlayerXuLiEffect(this SingingComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            EffectData playEffectBuffData = new EffectData();
            playEffectBuffData.EffectId = 21202031;                  //特效相关配置
            playEffectBuffData.EffectPosition = unit.Position;
            playEffectBuffData.TargetAngle = 0;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;
            playEffectBuffData.InstanceId = IdGenerater.Instance.GenerateInstanceId();
            self.EffectInstanceId = playEffectBuffData.InstanceId;
            EventType.SkillEffect.Instance.EffectData = playEffectBuffData;
            EventType.SkillEffect.Instance.Unit = unit;
            EventSystem.Instance.PublishClass(EventType.SkillEffect.Instance);
        }

        //技能吟唱
        public static void BeforeSkillSing(this SingingComponent self, C2M_SkillCmd c2M_SkillCmd)
        {
            self.c2M_SkillCmd.SkillID = c2M_SkillCmd.SkillID;
            self.c2M_SkillCmd.TargetID = c2M_SkillCmd.TargetID;
            self.c2M_SkillCmd.TargetAngle = c2M_SkillCmd.TargetAngle;
            self.c2M_SkillCmd.TargetDistance = c2M_SkillCmd.TargetDistance;
            self.c2M_SkillCmd.WeaponSkillID = c2M_SkillCmd.WeaponSkillID;
            self.c2M_SkillCmd.ItemId = c2M_SkillCmd.ItemId;
            self.c2M_SkillCmd.SingValue = 1f;

            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(c2M_SkillCmd.SkillID);
            self.Type = 1;
            self.PassTime = 0;
            self.TotalTime = (long)(skillConfig.SkillFrontSingTime * 1000);
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.BeginTime = TimeHelper.ServerNow();
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.UISingingTimer, self);

            Unit unit = self.GetParent<Unit>();
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
            StateComponent stateComponent = unit.GetComponent<StateComponent>();
            stateComponent.SendUpdateState(1, StateTypeEnum.Singing, $"{c2M_SkillCmd.SkillID}_0");

            if (skillConfig.SkillFrontSingTime > 0f && SkillHelp.havePassiveSkillType(skillConfig.PassiveSkillType, 2))
            {
                self.PlayerXuLiEffect();

                //镜头拉远
                EventType.ChangeCameraMoveType.Instance.CameraType = 4;
                EventType.ChangeCameraMoveType.Instance.ZoneScene = self.ZoneScene();
                EventSystem.Instance.PublishClass(EventType.ChangeCameraMoveType.Instance);
            }
        }


        public static void BeginSkill(this SingingComponent self)
        {
            if (self.PassTime > 0)
            {
                self.PassTime = -1;
                self.UpdateUISinging();
            }
            if (self.EffectInstanceId > 0)
            {
                self.ResetEffect();
            }
        }

        public static bool IsSkillSinging(this SingingComponent self, int skillid)
        {
            Unit unit = self.GetParent<Unit>();
            if (self.c2M_SkillCmd != null && self.c2M_SkillCmd.SkillID == skillid
             && unit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.Singing))
            {
                return true;
            }
            return false;
        }

        public static void ResetEffect(this SingingComponent self)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(self.c2M_SkillCmd.SkillID);
            if (self.EffectInstanceId != 0 && skillConfig.SkillFrontSingTime > 0f && SkillHelp.havePassiveSkillType(skillConfig.PassiveSkillType, 2))
            {
                //镜头回位
                EventType.ChangeCameraMoveType.Instance.CameraType = 5;
                EventType.ChangeCameraMoveType.Instance.ZoneScene = self.ZoneScene();
                EventSystem.Instance.PublishClass(EventType.ChangeCameraMoveType.Instance);

                EventType.SkillEffectFinish.Instance.EffectInstanceId = self.EffectInstanceId;
                EventType.SkillEffectFinish.Instance.Unit = self.GetParent<Unit>();
                EventSystem.Instance.PublishClass(EventType.SkillEffectFinish.Instance);
                self.EffectInstanceId = 0;
            }
        }

        public static  void ImmediateUseSkill(this SingingComponent self)
        {
            self.ResetEffect();

            if (self.Type!=1)
            {
                return;
            }
            Unit unit = self.GetParent<Unit>();
            unit.GetComponent<SkillManagerComponent>().ImmediateUseSkill(self.c2M_SkillCmd).Coroutine();
        }

    }
}
