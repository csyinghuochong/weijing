using System;

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
            foreach ((int key, long value) in unit.GetComponent<NumericComponent>().NumericDic)
            {
                if (key >= (int)NumericType.Max)
                {
                    continue;
                }
                response.Ks.Add(key);
                response.Vs.Add(value);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
