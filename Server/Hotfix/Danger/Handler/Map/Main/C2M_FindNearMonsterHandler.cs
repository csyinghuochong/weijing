using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_FindNearMonsterHandler : AMActorLocationRpcHandler<Unit, C2M_FindNearMonsterRequest, M2C_FindNearMonsterResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_FindNearMonsterRequest request, M2C_FindNearMonsterResponse response, Action reply)
        {
            List<Unit> listUnit = AIHelp.GetNearestMonsters(unit,50);
            if (listUnit.Count > 0)
            {
                response.IfFindStatus = true;
                response.x = listUnit[0].Position.x;
                response.y = listUnit[0].Position.y;
                response.z = listUnit[0].Position.z;
            }
            else {
                response.IfFindStatus = false;
            }

            reply();
            await ETTask.CompletedTask;

        }
    }
}
