using UnityEngine;

namespace ET
{

    [FsmHandler]
    public class FsmShiQuItem : AFsmHandler
    {
        public override void OnInit()
        {

        }

        public override void OnEnter(string paramss = "")
        {
            this.ClearnAnimator();
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.PlayAnimation("ShiQu");
        }

        public override void OnReEnter(string paramss = "")
        {
        }

        public override void OnExit()
        {

        }
    }
}
