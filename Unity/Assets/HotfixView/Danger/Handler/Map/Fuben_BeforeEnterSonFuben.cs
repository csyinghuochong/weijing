#if !NOT_UNITY
using UnityEngine;
#endif


namespace ET
{

    [Event]
    public class Fuben_BeforeEnterSonFuben : AEventClass<EventType.BeforeEnterSonFuben>
    {
        protected override void Run(object cls)
        {
            EventType.BeforeEnterSonFuben args = cls as EventType.BeforeEnterSonFuben;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( args.ZoneScene );
            unit.GetComponent<SkillManagerComponent>().OnFinish();
            unit.GetComponent<EffectViewComponent>().RemoveEffect(EffectTypeEnum.SkillEffect);

            //播放传送特效
            FunctionEffect.GetInstance().PlaySelfEffect(unit, 60000001);
        }
    }
}
