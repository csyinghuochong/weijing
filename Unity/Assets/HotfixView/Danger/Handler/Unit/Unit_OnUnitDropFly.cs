using UnityEngine;


namespace ET
{
    [Event]
    public class Unit_OnUnitDropFly : AEventClass<EventType.UnitDropFly>
    {

        protected override void Run(object cls)
        {
            EventType.UnitDropFly args = cls as EventType.UnitDropFly;
            if (args.Unit.GetComponent<DropFlyComponent>() == null)
            {
                args.Unit.AddComponent<DropFlyComponent>();
            }
        }

    }
}