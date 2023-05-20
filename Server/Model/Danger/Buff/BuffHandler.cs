
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class BuffHandlerAttribute : BaseAttribute
    {
    }

    [BuffHandler]
    public abstract class BuffHandler : Entity
    {
        /// <summary>
        /// Buff当前状态
        /// </summary>
        public BuffState BuffState;

        /// <summary>
        /// 最多持续到什么时候
        /// </summary>
        public long BuffEndTime;

        /// <summary>
        /// Buff数据
        /// </summary>
        public BuffData BuffData;

        public SkillBuffConfig mBuffConfig;
        public SkillConfig mSkillConf;
        public SkillHandler mSkillHandler;

        /// <summary>
        /// 来自哪个Unit
        /// </summary>
        public Unit TheUnitFrom;

        /// <summary>
        /// 寄生于哪个Unit，并不代表当前Buff实际寄居者，需要通过GetBuffTarget来获取，因为它赋值于Buff链起源的地方，具体值取决于那个起源Buff
        /// </summary>
        public Unit TheUnitBelongto;

        //当前buff参数
        public int BaseBuffType;

        public bool IsTrigger;

        public long DelayTime;
        public long BeginTime;
        public long PassTime;

        public Vector3 StartPosition;
        public Vector3 TargetPosition;

        public float DamageRange;
        public float Angle;
        public float StartAngle;
        public float Radius;

        public long InterValTime;

        public long InterValTimeSumBegin;
        public long InterValTimeSum;

        public int NowBuffParameterType;
        public int NowBuffParameterValueType;
        public double NowBuffParameterValue;
        public double NowBuffValue;

        public List<long> HurtIds = new List<long>();
        /// <summary>
        /// 初始化buff数据
        /// </summary>
        /// <param name="buffData">Buff数据</param>
        /// <param name="theUnitFrom">来自哪个Unit</param>
        /// <param name="theUnitBelongto">寄生于哪个Unit</param>
        public abstract void OnInit(BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto, SkillHandler skillHandler=null);

        /// <summary>
        /// Buff持续
        /// </summary>
        public abstract void OnUpdate();

        /// <summary>
        /// 重置Buff用
        /// </summary>
        public abstract void OnFinished();

    }
}
