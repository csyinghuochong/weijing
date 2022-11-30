using System;

namespace ET
{
    [ActorMessageHandler]
    public class T2M_TeamUpdateHandler : AMActorLocationHandler<Unit, T2M_TeamUpdateRequest>
    {
        protected override async ETTask Run(Unit unit, T2M_TeamUpdateRequest message)
        {
            Log.Debug($"T2M_TeamUpdate  {unit.Id}  {message.TeamId}");
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.TeamId, message.TeamId);

            long rolePetId = unit.GetComponent<PetComponent>().GetFightPetId();
            Unit unitpet = unit.GetParent<UnitComponent>().Get(rolePetId);
            if (unitpet != null)
            {
                unitpet.GetComponent<NumericComponent>().ApplyValue(NumericType.TeamId, message.TeamId);
            }

            await ETTask.CompletedTask;
        }
    }
}
