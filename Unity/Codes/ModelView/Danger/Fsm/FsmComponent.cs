
using UnityEngine;

namespace ET
{
    //动画状态机组件

    public class FsmComponent : Entity, IAwake, IDestroy
    {

        public FsmStateUI FsmStateUI;

        public long SkillMoveTime;  //1旋风斩之类的技能

        public AFsmHandler CurrentFsm;

        public Animator Animator;
    }
}
