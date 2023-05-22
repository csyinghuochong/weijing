
using UnityEngine;

namespace ET
{
    //动画状态机组件

    public class FsmComponent : Entity, IAwake, IDestroy
    {
        public int CurrentFsm;


        public long Timer;

        public long WaitIdleTime;

        public AnimatorComponent Animator;

        public string LastAnimator; 
    }
}
