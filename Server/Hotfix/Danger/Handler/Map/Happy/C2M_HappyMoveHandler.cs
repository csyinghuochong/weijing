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
            unit.GetComponent<NumericComponent>().ApplyValue( NumericType.HappyCellIndex, newCell );
            Vector3 vector3 = HappyHelper.PositionList[newCell];

            unit.Position = vector3;

            unit.Stop(-2);
            reply();
            await ETTask.CompletedTask;
        }
    }
}