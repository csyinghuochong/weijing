using UnityEngine;

namespace ET
{
    public class ChangeRotation_SyncGameObjectRotation: AEventClass<EventType.ChangeRotation>
    {
        protected override void Run(object cls)
        {
            EventType.ChangeRotation args = cls as EventType.ChangeRotation;
            Unit unit = args.Unit;
            GameObjectComponent gameObjectComponent = unit.GetComponent<GameObjectComponent>();
            if (unit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.BePulled))
            {
                //gameObjectComponent?.UpdateRotation(args.Unit.Rotation * new Vector3(0,0,180));
            }
            else
            {
                gameObjectComponent?.UpdateRotation(args.Unit.Rotation);
            }
        }
    }
}
