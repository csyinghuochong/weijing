using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_RoleAddPointHandler : AMActorLocationRpcHandler<Unit, C2M_RoleAddPointRequest, M2C_RoleAddPointResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_RoleAddPointRequest request, M2C_RoleAddPointResponse response, Action reply)
        {
            try
            {
                int totalPoint = 0;
                for (int i = 0; i < request.PointList.Count; i++)
                {
                    if (request.PointList[i] < 0 || request.PointList[i] > 2000)
                    {
                        Log.Error($"C2M_RoleAddPointRequest: {unit.DomainZone()}  {unit.Id}  {request.PointList[i]}");
                        response.Error = ErrorCode.ERR_ModifyData;
                        reply();
                        return;
                    }

                    totalPoint += request.PointList[i];
                }
                int remainPoint = (unit.GetComponent<UserInfoComponent>().UserInfo.Lv - 1) * 10 - totalPoint;
                if (remainPoint < 0)
                {
                    Log.Error($"C2M_RoleAddPointRequest 2");
                    response.Error = ErrorCode.ERR_ModifyData;
                    reply();
                    return;
                }

                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                numericComponent.ApplyValue(NumericType.PointLiLiang, request.PointList[0]);
                numericComponent.ApplyValue(NumericType.PointZhiLi, request.PointList[1]);
                numericComponent.ApplyValue(NumericType.PointTiZhi, request.PointList[2]);
                numericComponent.ApplyValue(NumericType.PointNaiLi, request.PointList[3]);
                numericComponent.ApplyValue(NumericType.PointMinJie, request.PointList[4]);
                numericComponent.ApplyValue(NumericType.PointRemain, remainPoint);
                //unit.GetComponent<HeroDataComponent>().CheckNumeric();
                Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);

                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception ex)
            {
                Log.Error("C2M_RoleAddPointError: " + ex.ToString());
            }
        }
    }
}
