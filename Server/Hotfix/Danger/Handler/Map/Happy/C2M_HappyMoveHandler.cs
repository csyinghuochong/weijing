using System;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_HappyMoveHandler : AMActorLocationRpcHandler<Unit, C2M_HappyMoveRequest, M2C_HappyMoveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HappyMoveRequest request, M2C_HappyMoveResponse response, Action reply)
        {
            int newCell = RandomHelper.RandomNumber(0, HappyHelper.PositionList.Count);
            Vector3 vector3 = HappyHelper.PositionList[newCell];



            reply();
            await ETTask.CompletedTask;
        }
    }
}