using UnityEngine;


namespace ET
{

    [FsmHandler]
    public class FsmNpcSpeak : AFsmHandler
    {
        public override void OnInit()
        {
        }

        public override void OnEnter(string paramss = "")
        {
            this.ClearnAnimator();
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.PlayAnimation("Speak");
        }

        public override void OnReEnter(string paramss = "")
        {

        }

        public override void OnExit()
        {
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Idle, true);
        }
    }
}
