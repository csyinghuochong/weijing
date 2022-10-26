using System;
using UnityEngine;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_TeamDungeonPickHandler : AMActorLocationRpcHandler<Unit, C2M_TeamPickRequest, M2C_TeamPickResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TeamPickRequest request, M2C_TeamPickResponse response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
