using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_RoleAddPointHandler : AMActorLocationRpcHandler<Unit, C2M_RoleAddPointRequest, M2C_RoleAddPointResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_RoleAddPointRequest request, M2C_RoleAddPointResponse response, Action reply)
        { 
            int totalPoint = 0;
            for (int i = 0;i < request.PointList.Count; i++)
            {
                totalPoint += request.PointList[i];
            }
            int remainPoint = (unit.GetComponent<UserInfoComponent>().UserInfo.Lv - 1) * 5 - totalPoint;

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.ApplyValue( NumericType.PointLiLiang, request.PointList[0]);
            numericComponent.ApplyValue(NumericType.PointZhiLi, request.PointList[1]);
            numericComponent.ApplyValue(NumericType.PointTiZhi, request.PointList[2]);
            numericComponent.ApplyValue(NumericType.PointNaiLi, request.PointList[3]);
            numericComponent.ApplyValue(NumericType.PointMinJie, request.PointList[4]);
            numericComponent.ApplyValue(NumericType.PointRemain, remainPoint);
            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
