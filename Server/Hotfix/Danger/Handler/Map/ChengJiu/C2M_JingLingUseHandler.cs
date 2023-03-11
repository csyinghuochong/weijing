using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JingLingUseHandler : AMActorLocationRpcHandler<Unit, C2M_JingLingUseRequest, M2C_JingLingUseResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JingLingUseRequest request, M2C_JingLingUseResponse response, Action reply)
        {
            ChengJiuComponent chengJiuComponent = unit.GetComponent<ChengJiuComponent>();
            chengJiuComponent.JingLingId = request.JingLingId;
            if (unit.GetParent<UnitComponent>().Get(chengJiuComponent.JingLingUnitId)!=null)
            {
                unit.GetParent<UnitComponent>().Remove(chengJiuComponent.JingLingUnitId);
            }
            chengJiuComponent.JingLingUnitId = 0;
            chengJiuComponent.JingLingUnitId = UnitFactory.CreateJingLing(unit, chengJiuComponent.JingLingId).Id;
          
            reply();
            await ETTask.CompletedTask;
        }
    }
}
