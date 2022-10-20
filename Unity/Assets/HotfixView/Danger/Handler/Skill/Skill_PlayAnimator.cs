using System;


namespace ET
{
    public class Skill_PlayAnimator : AEventClass<EventType.PlayAnimator>
    {
        protected override void Run(object numerice)
        {
            EventType.PlayAnimator args = numerice as EventType.PlayAnimator;
            args.Unit.GetComponent<AnimatorComponent>()?.PlayAnimation(args.Animator);
        }
    }
}
