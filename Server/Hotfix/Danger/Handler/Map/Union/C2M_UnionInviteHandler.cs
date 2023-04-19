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
            long unionid = unit.GetComponent<NumericComponent>().GetAsLong( NumericType.UnionId_0 );
            if (unionid == 0)
            {
                return;
            }

            if (beinvite != null)
            {
                if (beinvite.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0) != 0)
                {
                    return;
                }

                MessageHelper.SendToClient(beinvite, new M2C_UnionInviteMessage()
                { 
                    UnionId = unionid,
                    UnionName = userInfo.UnionName,
                    PlayerName = userInfo.Name,
                });
            }
            await ETTask.CompletedTask;
        }
    }
}
