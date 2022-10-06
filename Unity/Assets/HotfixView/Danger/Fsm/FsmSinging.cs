namespace ET
{
    [FsmHandler]
    public class FsmSinging : AFsmHandler
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
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(paramss));
            AnimatorComponent acomponent = this.FsmComponent.Parent.GetComponent<AnimatorComponent>();

            if (skillConfig.SkillFrontSingTime > 0)
            {
                acomponent.PlayAnimation("YinChang");
            }
        }

        public override void OnReEnter(string paramss = "")
        {

        }

        public override void OnExit()
        {
            this.OnRemoveTimer();
            this.ClearnAnimator();
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Idle, true);
        }
    }
}
