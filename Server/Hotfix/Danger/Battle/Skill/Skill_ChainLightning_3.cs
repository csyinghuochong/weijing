using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    /// <summary>
    /// 闪电链3,传递电下去，每次只电一下(当前目标死了也能传递下去，能否传递只跟两者间的距离、技能存在时间有关)
    /// https://www.bilibili.com/video/BV13F411d7XL/?spm_id_from=333.337.search-card.all.click&amp;vd_source=df9f0a2e3f52f77e8636fbb4dc7e8532
    /// </summary>
    public class Skill_ChainLightning_3: SkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.NowPosition = theUnitFrom.Position;
            this.NowPosition.y = theUnitFrom.Position.y + SkillHelp.GetCenterHigh(theUnitFrom.Type, theUnitFrom.ConfigId);
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.OnUpdate();
        }

        public void BroadcastSkill(long unitid, long targetId, float x, float y, float z)
        {
            MessageHelper.Broadcast(this.TheUnitFrom,
                new M2C_ChainLightning()
                {
                    UnitId = unitid,
                    TargetID = targetId,
                    SkillID = this.SkillInfo.WeaponSkillID,
                    PosX = x,
                    PosY = y,
                    PosZ = z,
                    Type = 3,
                    InstanceId = this.InstanceId
                });
        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();

            if (serverNow > this.SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
            }

            if (this.HurtIds.Count == 0)
            {
                this.TheUnitTarget = AIHelp.GetNearestEnemy(this.TheUnitFrom, (float)this.SkillConf.DamgeRange[0], true);
                if (this.TheUnitTarget == null || this.TheUnitTarget.IsDisposed)
                {
                    this.SetSkillState(SkillState.Finished);
                    return;
                }

                this.HurtIds.Add(this.TheUnitTarget.Id);
                this.BroadcastSkill(this.TheUnitFrom.Id, this.TheUnitTarget.Id, 0f, 0f, 0f);
                this.TargetPosition = this.TheUnitTarget.Position;
                this.TargetPosition.y = this.TheUnitTarget.Position.y + SkillHelp.GetCenterHigh(this.TheUnitTarget.Type, this.TheUnitTarget.ConfigId);
            }

            if (this.TheUnitTarget == null || this.TheUnitTarget.IsDisposed)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }

            // Vector3 dir = (this.TargetPosition - this.NowPosition).normalized;
            // float dis = PositionHelper.Distance2D(this.NowPosition, this.TargetPosition);
            // float move = (float)this.SkillConf.SkillMoveSpeed * 0.1f; //服务器0.1秒一帧
            // move = Mathf.Min(dis, move);
            // this.NowPosition = this.NowPosition + move * dir;
            //
            // dis = PositionHelper.Distance2D(this.NowPosition, this.TargetPosition);
            // if (dis > 0.5f)
            // {
            //     return;
            // }
            
            float passTime = (serverNow - this.SkillInfo.SkillBeginTime) * 0.001f;
            if (passTime < this.SkillConf.SkillDelayTime)
            {
                return;
            }
            this.SkillInfo.SkillBeginTime = serverNow;

            Unit lastTarget = null;
            lastTarget = this.TheUnitFrom.GetParent<UnitComponent>().Get(this.HurtIds[^1]);
            // this.OnCollisionUnit(lastTarget);

            this.TheUnitTarget = AIHelp.GetNearestUnit(this.TheUnitFrom, lastTarget.Position, (float)this.SkillConf.DamgeRange[0], this.HurtIds);
            if (this.TheUnitTarget == null)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }

            this.TargetPosition = this.TheUnitTarget.Position;
            this.TargetPosition.y = this.TheUnitTarget.Position.y + SkillHelp.GetCenterHigh(this.TheUnitTarget.Type, this.TheUnitTarget.ConfigId);

            this.HurtIds.Add(this.TheUnitTarget.Id);
            this.BroadcastSkill(lastTarget.Id, this.TheUnitTarget.Id, 0f, 0f, 0f);
            this.OnCollisionUnit(lastTarget);
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}