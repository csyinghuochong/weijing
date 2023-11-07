using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetMingOccupyHandler : AMActorLocationRpcHandler<Unit, C2M_PetMingOccupyRequest, M2C_PetMingOccupyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetMingOccupyRequest request, M2C_PetMingOccupyResponse response, Action reply)
        {
            if (request.Operate == 0)
            {
                reply();
                return;
            }
            PetMingDungeonComponent petMingDungeon  = unit.DomainScene().GetComponent<PetMingDungeonComponent>();
            if (petMingDungeon == null )
            {
                reply();
                return;
            }
            //petMingDungeon.OnPetMingOccupy().Coroutine();

            reply();
            await ETTask.CompletedTask;
        }
    }
}
