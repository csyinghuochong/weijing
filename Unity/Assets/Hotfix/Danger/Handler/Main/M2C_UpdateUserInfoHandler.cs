using System;


namespace ET
{

    [MessageHandler]
    public class M2C_UpdateUserInfoHandler : AMHandler<M2C_UpdateUserInfoMessage>
    {
        protected override void Run(Session session, M2C_UpdateUserInfoMessage message)
        {
            session.ZoneScene().GetComponent<UserInfoComponent>().UserInfo = message.UserInfo;
        }
    }
}