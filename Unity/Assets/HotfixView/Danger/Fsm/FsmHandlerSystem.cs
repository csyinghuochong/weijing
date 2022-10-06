

namespace ET
{
    public static class FsmHandlerSystem
    {

        public static void ClearnAnimator(this AFsmHandler self)
        {
            FsmComponent fsmComponent = self.FsmComponent;
            //重置参数
            AnimatorComponent acomponent = fsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Idle, false);
            acomponent.SetBoolValue(MotionType.Run, false);
            acomponent.SetBoolValue(MotionType.Death, false);
            acomponent.SetBoolValue(MotionType.CriAct, false);
            acomponent.SetBoolValue(MotionType.Act_1, false);
            acomponent.SetBoolValue(MotionType.Act_2, false);
            acomponent.SetBoolValue(MotionType.Act_3, false);
        }

        public static void OnRemoveTimer(this AFsmHandler self)
        {
            self.CancellationToken?.Cancel();
            self.CancellationToken = null;
            ETCancellationToken cancellationToken = new ETCancellationToken();
            self.CancellationToken = cancellationToken;
        }

        public static void OnDestory(this AFsmHandler self)
        {
            self.CancellationToken?.Cancel();
            self.CancellationToken = null;
        }
    }
}
