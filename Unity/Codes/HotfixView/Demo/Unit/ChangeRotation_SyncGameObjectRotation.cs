using UnityEngine;

namespace ET
{
    public class ChangeRotation_SyncGameObjectRotation: AEventClass<EventType.ChangeRotation>
    {
        protected override void Run(object cls)
        {
            EventType.ChangeRotation args = cls as EventType.ChangeRotation;
            GameObjectComponent gameObjectComponent = args.Unit.GetComponent<GameObjectComponent>();
            if (gameObjectComponent == null || gameObjectComponent.GameObject == null)
            {
                return;
            }
            Transform transform = gameObjectComponent.GameObject.transform;
            transform.rotation = args.Unit.Rotation;
        }
    }
}
