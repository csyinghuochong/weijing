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
        public SkillZhishiType SkillZhishiType;
        public GameObject GameObject;
        public string EffectPath;
        public int TargetAngle;
        public float AttackDistance;
        public float LiveTime = -1;
        public float PassTime;
    }

    public class SkillIndicatorComponent : Entity , IAwake, IDestroy
    {
        public long Timer;
        public float SkillRangeSize;
        public SkillConfig mSkillConfig;
        public SkillIndicatorItem SkillIndicator;
        public bool ShowEffect;
        public Camera MainCamera;
    }
}
