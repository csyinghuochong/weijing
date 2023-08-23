using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TurtleRecordHandler : AMActorLocationRpcHandler<Unit, C2M_TurtleRecordRequest, M2C_TurtleRecordResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TurtleRecordRequest request, M2C_TurtleRecordResponse response, Action reply)
        {
            long activtiyserverid = DBHelper.GetActivityServerId(unit.DomainZone());
            M2A_TurtleRecordRequest m2A_TurtleRecord = new M2A_TurtleRecordRequest()
            {
                AccountId = unit.GetComponent<UserInfoComponent>().UserInfo.AccInfoID
            };
            A2M_TurtleRecordResponse a2M_TurtleSupport = (A2M_TurtleRecordResponse)await ActorMessageSenderComponent.Instance.Call
                        (activtiyserverid, m2A_TurtleRecord);

            response.WinTimes = a2M_TurtleSupport.WinTimes;
            response.SupportId = a2M_TurtleSupport. SupportId;
            response.SupportTimes = a2M_TurtleSupport.SupportTimes; 

            reply();
            await ETTask.CompletedTask;
        }
    }
}
