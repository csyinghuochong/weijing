using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_UnionInviteHandler : AMActorLocationHandler<Unit, C2M_UnionInviteRequest>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionInviteRequest message)
        {
            Unit beinvite = unit.GetParent<UnitComponent>().Get(message.InviteId);

            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (string.IsNullOrEmpty(userInfo.UnionName))
            {
                return;
            }
            long unitid = unit.GetComponent<NumericComponent>().GetAsLong( NumericType.UnionId );
            if (unitid == 0)
            {
                return;
            }

            if (beinvite != null)
            {
                MessageHelper.SendToClient(beinvite, new M2C_UnionInviteMessage()
                { 
                    UnionId = unitid,
                    UnionName = userInfo.UnionName,
                    PlayerName = userInfo.Name,
                });
            }
            await ETTask.CompletedTask;
        }
    }
}
