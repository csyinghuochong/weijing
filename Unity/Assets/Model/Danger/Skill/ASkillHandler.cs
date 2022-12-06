using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class SkillHandlerAttribute : BaseAttribute
    {
        
    }

    [SkillHandler]
    public abstract class ASkillHandler : Entity
    {
        public Vector3 NowPosition;
        public SkillState SkillState;

        public SkillConfig SkillConf;
        public EffectConfig EffectConf;

        public bool SkillExcuteHurtTime;

        public List<long> EffectInstanceId = new List<long>();

        /// <summary>
        /// 来自哪个Unit
        /// </summary>
        public Unit TheUnitFrom;

        public SkillInfo SkillInfo;
        public Vector3 TargetPosition;

        public abstract void OnInit(SkillInfo skillcmd, Unit theUnitFrom);

        public abstract void OnExecute();

        public abstract void OnUpdate();

        public abstract void OnFinished();

    }
}