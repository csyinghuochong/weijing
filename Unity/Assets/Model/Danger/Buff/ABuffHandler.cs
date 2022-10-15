using UnityEngine;

namespace ET
{

    public class BuffHandlerAttribute : BaseAttribute
    { 
    
    }

    [BuffHandler]
    public abstract class ABuffHandler : Entity
    {

        /// <summary>
        /// Buff当前状态
        /// </summary>
        public BuffState BuffState;

        /// <summary>
        /// 最多持续到什么时候
        /// </summary>
        public long BuffEndTime;

        public long BuffBeginTime;

        /// <summary>
        /// Buff数据
        /// </summary>
        public BuffData BuffData;

        public EffectData EffectData;

        /// <summary>
        /// 寄生于哪个Unit，并不代表当前Buff实际寄居者，需要通过GetBuffTarget来获取，因为它赋值于Buff链起源的地方，具体值取决于那个起源Buff
        /// </summary>
        public Unit TheUnitBelongto;

        /// <summary>
        /// 执行的时间
        /// </summary>
        public float PassTime;
        public Vector3 StartPosition;

        public SkillConfig mSkillConf;
        public EffectConfig mEffectConf;
        public SkillBuffConfig mSkillBuffConf;

        public abstract void OnInit(BuffData buffData, Unit theUnitBelongto);

        public abstract void OnReset();

        public abstract void OnExecute();

        public abstract void OnUpdate();

        public abstract void OnFinished();

        public float mDelayTime;
        public bool IsDelayPlay;
        public long EffectInstanceId;

        public float mAngle;
        public float startAngle;
        public float mRadius;
    }
}