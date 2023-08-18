using System;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_HappyMoveHandler : AMActorLocationRpcHandler<Unit, C2M_HappyMoveRequest, M2C_HappyMoveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HappyMoveRequest request, M2C_HappyMoveResponse response, Action reply)
        {

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();

            if (request.OperatateType == 1)
            {
                //非免费时间则返回
                long mianfeicd = GlobalValueConfigCategory.Instance.Get(93).Value2 * 1000;
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.HappyMoveTime, TimeHelper.ServerNow() + mianfeicd);
            }
            if (request.OperatateType == 2)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(94);
                if (userInfoComponent.UserInfo.Gold < globalValueConfig.Value2)
                {
                    response.Error = ErrorCore.ERR_GoldNotEnoughError;
                    reply();
                    return;
                }
                userInfoComponent.UpdateRoleMoneySub( UserDataType.Gold, (globalValueConfig.Value2 * -1).ToString(), true, ItemGetWay.HappyMove);
            }
            if (request.OperatateType  == 3)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(95);
                if (userInfoComponent.UserInfo.Diamond < globalValueConfig.Value2)
                {
                    response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                    reply();
                    return;
                }
                userInfoComponent.UpdateRoleMoneySub(UserDataType.Diamond, (globalValueConfig.Value2 * -1).ToString(), true, ItemGetWay.HappyMove);
            }

            int newCell = RandomHelper.RandomNumber(0, HappyHelper.PositionList.Count);
            unit.GetComponent<NumericComponent>().ApplyValue( NumericType.HappyCellIndex, newCell + 1 );
            Vector3 vector3 = HappyHelper.PositionList[newCell];
            unit.Position = vector3;
            unit.Stop(-2);

            reply();
            await ETTask.CompletedTask;
        }
    }
}