using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_UnionInviteReplyHandler : AMActorLocationHandler<Unit, C2M_UnionInviteReplyRequest>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionInviteReplyRequest message)
        {
            long unionid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
            if (unionid != 0)
            {
                return;
            }

            long unitonsceneid = DBHelper.GetUnionServerId( unit.DomainZone() );
            MessageHelper.SendActor(unitonsceneid, new M2U_UnionInviteReplyMessage()
            {
                UnionId = message.UnionId,
                UnitID = unit.Id,
            });
            await ETTask.CompletedTask;
        }
    }
}
