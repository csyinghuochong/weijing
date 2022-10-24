
using UnityEngine;

namespace ET
{
    //动画状态机组件

    public class FsmComponent : Entity, IAwake, IDestroy
    {

        public int CurrentFsm;

        public Animator Animator;

        public long SkillMoveTime;  //1旋风斩之类的技能. 可以移动但是需要保持技能动作

        public long SkillSingTime;  //吟唱， 移动会打断施法动作

        public long Timer;
    }
}
