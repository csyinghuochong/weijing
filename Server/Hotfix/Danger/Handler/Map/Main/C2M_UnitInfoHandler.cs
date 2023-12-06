using System;
using System.Collections.Generic;

namespace ET
{
    /// <summary>
    /// 获取玩家数值
    /// </summary>
    [ActorMessageHandler]
    public class C2M_UnitInfoHandler : AMActorLocationRpcHandler<Unit, C2M_UnitInfoRequest, M2C_UnitInfoResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnitInfoRequest request, M2C_UnitInfoResponse response, Action reply)
        {

            Unit watchUnit = unit;
            if (request.UnitID != 0)
            {
                watchUnit = unit.GetParent<UnitComponent>().Get( request.UnitID );
            }

            if (watchUnit != null)
            {
                Dictionary<int, long> numericlist = watchUnit.GetComponent<NumericComponent>().NumericDic;
                foreach ((int key, long value) in numericlist )
                {
                    if (key >= (int)NumericType.Max)
                    {
                        continue;
                    }
                    response.Ks.Add(key);
                    response.Vs.Add(value);
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
