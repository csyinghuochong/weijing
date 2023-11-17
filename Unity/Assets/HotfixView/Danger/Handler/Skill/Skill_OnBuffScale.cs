namespace ET
{
    public class Skill_OnBuffScale : AEventClass<EventType.BuffScale>
    {
        protected override void Run(object numerice)
        {
            EventType.BuffScale args = numerice as EventType.BuffScale;
            if (args.Unit == null || args.Unit.IsDisposed)
            {
                return;
            }

            BuffScaleComponet buffScaleComponet = args.Unit.GetComponent<BuffScaleComponet>();
            if (buffScaleComponet == null)
            {
                buffScaleComponet = args.Unit.AddComponent<BuffScaleComponet>();
            }

            buffScaleComponet.OnBuffScale(args.ABuffHandler.mSkillBuffConf, args.OperateType);
        }
    }
}