using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_StopResultHandler : AMActorLocationHandler<Unit, C2M_StopResult>
    {
        protected override async ETTask Run(Unit unit, C2M_StopResult message)
        {
            unit.StopResult(new Vector3(message.X, message.Y, message.Z), 0);
            await ETTask.CompletedTask;
        }
    }
}