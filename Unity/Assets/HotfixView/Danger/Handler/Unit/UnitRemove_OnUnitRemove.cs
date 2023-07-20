using UnityEngine;


namespace ET
{
    [Event]
    public class UnitRemove_OnUnitRemove : AEventClass<EventType.UnitRemove>
    {

        protected override void Run(object cls)
        {
            EventType.UnitRemove args = cls as EventType.UnitRemove;
            args.ZoneScene.GetComponent<LockTargetComponent>().OnUnitRemove(args.RemoveIds);
        }

    }
}