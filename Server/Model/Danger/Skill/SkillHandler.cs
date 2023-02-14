using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class SkillHandlerAttribute : BaseAttribute
    {

    }

    [SkillHandler]
    public abstract class SkillHandler : Entity
    {
        public List<long> HurtIds = new List<long>();
        public Dictionary<long, long> LastHurtTimes = new Dictionary<long, long>();
        public Dictionary<int, float> TianfuProAdd;

        //1 正在执行   2完成使命
        public SkillState SkillState;

        public SkillConfig SkillConf;

        public long SkillBeginTime;    
        public long SkillEndTime;
        /// <summary>
        /// 记录是否触发过技能伤害
        /// </summary>
        public bool IsExcuteHurt;
        public long SkillExcuteHurtTime;
        public long SkillTriggerInvelTime;      //技能伤害触发间隔时间
        public long SkillTriggerLastTime;

        public int SkillExcuteNum;

        public Vector3 NowPosition;             //当前技能的坐标点
        public Vector3 TargetPosition;

        public List<SkillParValue_HpUpAct> SkillParValueHpUpAct = new List<SkillParValue_HpUpAct>();        //目标血量处理高或者低 提升自身伤害

        //攻击目标临时增加/降低伤害
        public float ActTargetTemporaryAddPro;
        //自身增加/降低伤害
        public float ActTargetAddPro;

        /// <summary>
        /// 来自哪个Unit
        /// </summary>
        public Unit TheUnitFrom;

        public List<Shape> ICheckShape;

        public SkillInfo SkillInfo;

        public abstract void OnInit(SkillInfo skillId, Unit theUnitFrom);

        public abstract void OnExecute();

        public abstract void OnUpdate();

        public abstract void OnFinished();
    }

    //技能通用处理 (当己方血量低于某个百分比,伤害提升X百分比)
    public struct SkillParValue_HpUpAct
    {
        public int type;            // 1 低于  2 高于
        public float hpNeedPro;     // 血量要求百分比
        public float actAddPro;     // 攻击要求百分比
    }
}
