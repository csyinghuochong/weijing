using ET;

namespace ET
{

    [FsmHandler]
    public class FsmDeathState : AFsmHandler
    {

        public override void OnInit()
        {
            
        }
        public override void OnEnter(string paramss = "")
        {
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Idle, false);
            acomponent.SetBoolValue(MotionType.Death, true);

            acomponent.PlayAnimation(MotionType.Death);
        }

        public override void OnReEnter(string paramss = "")
        {

        }

        public override void OnExit()
        {
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Death, false);
        }
    }
}
