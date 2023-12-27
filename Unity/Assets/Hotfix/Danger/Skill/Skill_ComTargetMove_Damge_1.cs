using UnityEngine;

namespace ET
{

    //指定目标攻击
    [SkillHandler]
    public class Skill_ComTargetMove_Damge_1 : ASkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.NowPosition = theUnitFrom.Position;
            this.NowPosition.y = theUnitFrom.Position.y + SkillHelp.GetCenterHigh(theUnitFrom.Type, theUnitFrom.ConfigId);

            this.OnExecute();
        }

        public override void OnExecute()
        {
            this.OnShowSkillIndicator(this.SkillInfo);
            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
            long serverNow = TimeHelper.ServerNow();
            float passTime = (serverNow - this.SkillInfo.SkillBeginTime) * 0.001f;
            if (passTime < this.SkillConf.SkillDelayTime)
            {
                return;
            }
            
            Unit targetUnit = TheUnitFrom.GetParent<UnitComponent>().Get(this.SkillInfo.TargetID);
            if (targetUnit != null)
            {
                this.TargetPosition = targetUnit.Position;
                this.TargetPosition.y = targetUnit.Position.y + SkillHelp.GetCenterHigh(targetUnit.Type, targetUnit.ConfigId);
            }

            Vector3 dir = (this.TargetPosition - this.NowPosition).normalized;
            float effectAngle = Mathf.Atan2(dir.x, dir.z) * 180f / 3.1415926535897931f;
            if (this.EffectInstanceId.Count == 0)
            {
                //Vector3 newestPositon = this.TheUnitFrom.Position;
                //newestPositon.y = this.TheUnitFrom.Position.y + SkillHelp.GetCenterHigh(this.TheUnitFrom.Type, this.TheUnitFrom.ConfigId);
                //float effectAngle = 0;
                //if (Vector3.Distance(newestPositon, this.NowPosition) > 0.2f)
                //{
                //    // 位置预测
                //    Vector3 dire = newestPositon - this.NowPosition;
                //    this.NowPosition += dire * 4.2f;

                //    // 角度,后面更新位置的时候也可以更新一下角度,这样看起来箭不是斜着射过去的，因为目标是移动的，箭的角度不变
                //    Vector3 dire2 = (this.TargetPosition - this.NowPosition).normalized;
                //    effectAngle = Mathf.Atan2(dire2.x, dire2.z) * 180 / 3.141592653589793f;
                //}
                //this.PlaySkillEffects(this.NowPosition, effectAngle);
                this.PlaySkillEffects(this.NowPosition, effectAngle);
            }

            float dis = PositionHelper.Distance2D(this.TargetPosition, this.NowPosition);
#if !SERVER && NOT_UNITY
            float move = (float)this.SkillConf.SkillMoveSpeed * 0.033f; 
#else
            float move = (float)this.SkillConf.SkillMoveSpeed * Time.deltaTime;
#endif

            move = Mathf.Min(dis, move);
            this.NowPosition = this.NowPosition + (move * dir);

            if (this.EffectId!=0)
            {
                EventType.SkillEffectMove.Instance.EffectInstanceId = this.EffectInstanceId[0];
                EventType.SkillEffectMove.Instance.Unit = this.TheUnitFrom;
                EventType.SkillEffectMove.Instance.Postion = this.NowPosition;
                EventType.SkillEffectMove.Instance.Angle = effectAngle;
                EventSystem.Instance.PublishClass(EventType.SkillEffectMove.Instance);
            }
          
            dis = PositionHelper.Distance2D(this.NowPosition, this.TargetPosition);
            if (dis < 0.5f || targetUnit == null)
            {
                this.SetSkillState(SkillState.Finished);
            }
        }

        public override void OnFinished()
        {
            this.EndSkillEffect();
        }

    }
}
