using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetOpenCangKuHandler : AMActorLocationRpcHandler<Unit, C2M_PetOpenCangKu, M2C_PetOpenCangKu>
    {
        protected override async ETTask Run(Unit unit, C2M_PetOpenCangKu request, M2C_PetOpenCangKu response, Action reply)
        {
            PetComponent petinfo = unit.GetComponent<PetComponent>();
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}
