using System;
using System.Collections.Generic;

namespace ET
{
    [MessageHandler]
    public class C2A_DeleteAccountHandler : AMRpcHandler<C2A_DeleteAccountRequest, A2C_DeleteAccountResponse>
    {
        protected override async ETTask Run(Session session, C2A_DeleteAccountRequest request, A2C_DeleteAccountResponse response, Action reply)
        {
            //存储账号信息
            List<DBAccountInfo> accountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(session.DomainZone(), d => d.Account == request.Account && d.Password == request.Password);
            DBAccountInfo account = accountInfoList != null && accountInfoList.Count > 0 ? accountInfoList[0] : null;

            long accountZone = DBHelper.GetAccountCenter();
            Center2A_DeleteAccount centerAccount = (Center2A_DeleteAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_DeleteAccount() { AccountName = request.Account, Password = request.Password });

            reply();
            await ETTask.CompletedTask;
        }
    }
}
