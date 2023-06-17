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
            if (args.Unit.IsDisposed)
            {
                Log.ILog.Debug("args.Unit.IsDisposed: " + args.Unit.Id);
                return;
            }
            
            args.Unit.AddComponent<GameObjectComponent>();
        }
    }
}
