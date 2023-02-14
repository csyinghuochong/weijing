using ET;

namespace ET
{

    //闪现
    public class Skill_ShanXian_1 : SkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        public override void OnExecute()
        {
            if (this.SkillConf.GameObjectParameter == "0")
            {
                //先跳过去再触发伤害
                this.SyncPostion();
                this.InitSelfBuff();
                this.BaseOnUpdate();
            }
            else
            {
                //先触发伤害再跳过去
                this.UpdateCheckPoint();
                this.InitSelfBuff();
                this.BaseOnUpdate();
            }
        }

        public void SyncPostion()
        {
            if (this.TheUnitFrom.GetComponent<StateComponent>().CanMove() == ErrorCore.ERR_Success)
            {
                TheUnitFrom.Position = this.TargetPosition;
                TheUnitFrom.Stop(-2);
            }
            else
            {
                Log.Debug($"FsmStateEnum.ShanXian被定[S]  {TargetPosition}");
            }
        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();
            //根据技能效果延迟触发伤害
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }

            this.BaseOnUpdate();
            if (this.SkillConf.GameObjectParameter == "1"  && serverNow > this.SkillExcuteHurtTime)
            {
                this.SyncPostion();
                this.SetSkillState( SkillState.Finished);
            }
        }

        public override void OnFinished()
        {

        }
    }
}
