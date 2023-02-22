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
            Log.Debug($"Singing OnTimer {self.PassTime} {self.TotalTime}");
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
                stateComponent.SendUpdateState(2, StateTypeEnum.Singing, "0");
            }
            if (self.Type == 1 &&  self.PassTime > self.TotalTime)
            {
                //吟唱前结束，释放技能
                self.PassTime = -1;
                self.TotalTime = -1;
                Unit unit = self.GetParent<Unit>();
                StateComponent stateComponent = unit.GetComponent<StateComponent>();
                stateComponent.SendUpdateState(2, StateTypeEnum.Singing, "0");
                self.WaitUseSkill();
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

        //技能吟唱
        public static void BeforeSkillSing(this SingingComponent self, C2M_SkillCmd c2M_SkillCmd)
        {
            self.c2M_SkillCmd = c2M_SkillCmd;
           
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
            stateComponent.SendUpdateState(1, StateTypeEnum.Singing, c2M_SkillCmd.SkillID.ToString());

            Log.Debug("Singing BeforeSkillSing");
        }


        //被攻击，吟唱时间倒退0.3秒
        public static void BeAttacking(this SingingComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (!unit.MainHero)
            {
                return;
            }

            if (self.Type == 1 && self.Timer > 0)
            {
                //self.PassTime -= 300;   暂时先不倒退了,先屏蔽
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
            if (self.PassTime > 0)
            {
                self.PassTime = -1;
                self.UpdateUISinging();
            }
        }

        public static void BeginSkill(this SingingComponent self)
        {
            if (self.PassTime > 0)
            {
                self.PassTime = -1;
                self.UpdateUISinging();
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

        public static  void WaitUseSkill(this SingingComponent self)
        {
            if (self.Type!=1)
            {
                return;
            }
            Unit unit = self.GetParent<Unit>();
            unit.GetComponent<SkillManagerComponent>().ImmediateUseSkill(self.c2M_SkillCmd).Coroutine();
        }

    }
}
