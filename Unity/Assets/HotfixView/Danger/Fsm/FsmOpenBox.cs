using UnityEngine;

namespace ET
{

    [FsmHandler]
    public class FsmOpenBox : AFsmHandler
    {
        public override void OnInit()
        {

        }

        public override void OnEnter(string paramss = "")
        {
            this.ClearnAnimator();
            this.PlayAnimation(paramss);

        }

        public void PlayAnimation(string paramss = "")
        {
            Unit unit = this.FsmComponent.Parent as Unit;
            unit.Rotation = Quaternion.Euler(0, int.Parse(paramss), 0);
            AnimatorComponent acomponent = unit.GetComponent<AnimatorComponent>();
            acomponent.PlayAnimation("OpenLock");
            unit.ShowWeapon(false);
        }

        public override void OnReEnter(string paramss = "")
        {

        }

        public override void OnExit()
        {
            this.OnRemoveTimer();
            this.ClearnAnimator();
            Unit unit = this.FsmComponent.Parent as Unit;
            AnimatorComponent acomponent = unit.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Idle, true);
            unit.ShowWeapon(true);
        }
    }
}
