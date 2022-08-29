using ET;

namespace ET
{

    [FsmHandler]
    public class FsmIdleState: AFsmHandler
    {

        public override void OnInit()
        {
            
        }

        public override void OnEnter(string paramss = "")
        {
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Run, false);
            acomponent.SetBoolValue(MotionType.Idle, true);
        }

        public override void OnReEnter(string paramss = "")
        {

        }

        public override void OnExit()
        {
           
        }

    }
}