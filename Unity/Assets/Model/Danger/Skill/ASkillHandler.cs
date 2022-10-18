using UnityEngine;

namespace ET
{

    public class SkillHandlerAttribute : BaseAttribute
    {
        
    }

    [SkillHandler]
    public abstract class ASkillHandler : Entity
    {

        public float PassTime = 0f;
        public float LiveTime = 0f;
        public long BeingTime = 0;

        public SkillState SkillState;

        public SkillConfig SkillConf;
        public EffectConfig EffectConf;
        public bool PlayMusic;

        public float OldSpeed = 0;

        public Vector3 NowPosition;

        public long EffectInstanceId;

        /// <summary>
        /// 来自哪个Unit
        /// </summary>
        public Unit TheUnitFrom;

        public SkillInfo SkillCmd;
        public Vector3 TargetPosition;

        public abstract void OnInit(SkillInfo skillcmd, Unit theUnitFrom);

        public abstract void OnExecute();

        public abstract void OnUpdate();

        public abstract void OnFinished();

    }
}