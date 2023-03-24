using UnityEngine;

namespace ET
{

    /// <summary>
    /// 位置类型
    /// </summary>
    public enum PosType
    {
        Name,
        Hp,
        MiddleBuff,

        Di,
        Center,
        Head,
        Hand,

        Weapon_R,
    }

    public class EffectHandlerAttribute : BaseAttribute
    {

    }

    [EffectHandler]
    public abstract class AEffectHandler : Entity, IAwake
    {

        /// <summary>
        /// Buff当前状态
        /// </summary>
        public BuffState EffectState;

        public EffectConfig EffectConfig;

        /// <summary>
        /// Buff数据
        /// </summary>
        public EffectData EffectData;

        /// <summary>
        /// 寄生于哪个Unit，并不代表当前Buff实际寄居者，需要通过GetBuffTarget来获取，因为它赋值于Buff链起源的地方，具体值取决于那个起源Buff
        /// </summary>
        public Unit TheUnitBelongto;

        /// <summary>
        /// 最多持续到什么时候
        /// </summary>
        public float EffectEndTime;

        public float EffectDelayTime;

        /// <summary>
        /// 执行的时间
        /// </summary>
        public float PassTime;

        public float HideObjTime;          //隐藏物体间隔时间    

        public GameObject EffectObj;
        public string EffectPath;

        /// <summary>
        /// 初始化buff数据
        /// </summary>
        /// <param name="buffData">Buff数据</param>
        /// <param name="theUnitFrom">来自哪个Unit</param>
        /// <param name="theUnitBelongto">寄生于哪个Unit</param>
        public abstract void OnInit(EffectData buffData, Unit theUnitBelongto);


        /// <summary>
        /// Buff持续
        /// </summary>
        public virtual void OnUpdate()
        {
            PassTime += Time.deltaTime;
        }

        /// <summary>
        /// 重置Buff用
        /// </summary>
        public abstract void OnFinished();
        
    }

}