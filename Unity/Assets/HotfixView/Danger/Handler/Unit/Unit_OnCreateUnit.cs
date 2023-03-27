using System;
using UnityEngine;

namespace ET
{
    [Event]
    public class Unit_OnCreateUnit : AEventClass<EventType.AfterUnitCreate>
    {
        protected override void Run(object cls)
        {
            EventType.AfterUnitCreate args = cls as EventType.AfterUnitCreate;
            switch (args.Unit.Type)
            {
                case UnitType.Plant:
                    args.Unit.AddComponent<GameObjectPlantComponent>();
                    break;
                default:
                    args.Unit.AddComponent<GameObjectComponent>();
                    break;
            }
        }
    }
}
