using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [FsmHandler]
    public class FsmHui : AFsmHandler
    {
        public override void OnInit()
        {

        }

        public override void OnEnter(string paramss = "")
        {
            AnimatorComponent acomponent = this.FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Idle, false);
            acomponent.PlayAnimation(MotionType.Hui);
        }

        public override void OnReEnter(string paramss = "")
        {

        }

        public override void OnExit()
        {
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            
        }

    }
}
