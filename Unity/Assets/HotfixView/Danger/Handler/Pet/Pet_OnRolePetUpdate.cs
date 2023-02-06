using UnityEngine;


namespace ET
{

    [Event]
    public class Pet_OnRolePetUpdate : AEventClass<EventType.RolePetUpdate>
    {
        protected override void Run(object cls)
        {
            EventType.RolePetUpdate args = cls as EventType.RolePetUpdate;

            Unit unit = args.ZoneScene.CurrentScene().GetComponent<UnitComponent>().Get(args.PetId);
            unit.GetComponent<HeroHeadBarComponent>()?.UpdateShow();
        }

    }
}
