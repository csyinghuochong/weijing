using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanPetOperateHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPetOperateRequest, M2C_JiaYuanPetOperateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPetOperateRequest request, M2C_JiaYuanPetOperateResponse response, Action reply)
        {
            Unit pet = unit.GetParent<UnitComponent>().Get(request.PetInfoId);
            if (pet == null)
            {
                reply();
                return;
            }

            //0 停止AI  1启动AI 
            if (request.Operate == 0)
            {
                pet.Stop(0);
                pet.GetComponent<AIComponent>().Stop_2();
            }
            if (request.Operate == 1)
            {
                pet.GetComponent<AIComponent>().Begin();
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
