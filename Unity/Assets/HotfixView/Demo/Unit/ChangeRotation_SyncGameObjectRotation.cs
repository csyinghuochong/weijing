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
            StateComponent stateComponent = unit.GetComponent<StateComponent>();
            if (stateComponent.StateTypeGet(StateTypeEnum.BePulled)
               || stateComponent.StateTypeGet(StateTypeEnum.JiTui))
            {
                gameObjectComponent?.UpdateRotation(Quaternion.AngleAxis(180, Vector3.up) * args.Unit.Rotation);
            }
            else
            {
                gameObjectComponent?.UpdateRotation(args.Unit.Rotation);
            }
        }
    }
}
