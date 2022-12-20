using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class UnitLockRange
    {
        public long Id;
        public int Range;
    }

    public class SkillIndicatorItem
    {
        public int SkillZhishiType;
        public string EffectPath;
        public int TargetAngle;
        public float AttackDistance;
        public float LiveTime = -1;
        public float PassTime;
        public long InstanceId;
        public SkillInfo SkillInfo;
        public GameObject GameObject;
    }

    public class SkillIndicatorComponent : Entity , IAwake, IDestroy
    {
        public long Timer;
        public float SkillRangeSize;
        public Camera MainCamera;
        public SkillConfig mSkillConfig;
        public SkillIndicatorItem SkillIndicator;
        public Vector2 StartIndicator;
    }
}
