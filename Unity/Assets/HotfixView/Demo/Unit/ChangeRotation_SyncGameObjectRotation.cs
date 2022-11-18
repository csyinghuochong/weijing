using UnityEngine;

namespace ET
{
    public class ChangeRotation_SyncGameObjectRotation: AEventClass<EventType.ChangeRotation>
    {
        protected override void Run(object cls)
        {
            EventType.ChangeRotation args = cls as EventType.ChangeRotation;
            GameObjectComponent gameObjectComponent = args.Unit.GetComponent<GameObjectComponent>();
            gameObjectComponent?.UpdateRotation(args.Unit.Rotation);
        }
    }
}
