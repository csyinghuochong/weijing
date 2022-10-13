
using UnityEngine;

namespace ET
{
    //动画状态机组件

    public class FsmComponent : Entity, IAwake, IDestroy
    {

        public int CurrentFsm;

        public Animator Animator;

        public long SkillMoveTime;  //1旋风斩之类的技能

        public long SkillRigibTime;

        public long SkillSingTime;

        public long Timer;
    }
}
