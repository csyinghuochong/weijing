using ET;
using UnityEngine;

namespace ET
{

    [FsmHandler]
    public class FsmRunState : AFsmHandler
    {

        public override void OnInit()
        {

        }

        public override void OnEnter(string paramss = "")
        {
            //this.ClearnAnimator();
            if (TimeHelper.ClientNow() > this.FsmComponent.SkillMoveTime)
            {
                SetRunState();
            }
            else
            {
                WaitSkillMove(this.FsmComponent.SkillMoveTime - TimeHelper.ClientNow()).Coroutine();
            }
        }

        public void SetRunState()
        {
            AnimatorComponent acomponent = this.FsmComponent.Parent.GetComponent<AnimatorComponent>();
            this.FsmComponent.SkillMoveTime = 0;
            acomponent.SetBoolValue(MotionType.Idle, false);
            acomponent.SetBoolValue(MotionType.Run, true);
            acomponent.PlayAnimation(MotionType.Run);
        }

        public async ETTask WaitSkillMove(long addTime)
        {
            this.OnRemoveTimer();
            
            bool ret= await TimerComponent.Instance.WaitAsync(addTime, this.CancellationToken);
            if (!ret)
            {
                return;
            }
            SetRunState();
        }

        public override void OnReEnter(string paramss = "")
        {

        }

        public override void OnExit()
        {
            this.OnRemoveTimer();
        }

    }
}