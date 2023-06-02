using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetPutCangKuHandler : AMActorLocationRpcHandler<Unit, C2M_PetPutCangKu, M2C_PetPutCangKu>
    {
        protected override async ETTask Run(Unit unit, C2M_PetPutCangKu request, M2C_PetPutCangKu response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
