using System;
using System.Collections.Generic;


namespace ET
{

    [MessageHandler]
    public class C2Center_PhoneBingingHandler : AMRpcHandler<C2Center_PhoneBinging, Center2C_PhoneBinging>
    {
        protected override async ETTask Run(Session session, C2Center_PhoneBinging request, Center2C_PhoneBinging response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Register, request.Account.Trim().GetHashCode()))
            {
                List<DBCenterAccountInfo> resultAccounts = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(session.DomainZone(), 
                    _account => _account.PlayerInfo!=null && _account.PlayerInfo.PhoneNumber.Equals(request.PhoneNumber));
                if (resultAccounts.Count > 0)
                {
                    response.Error = ErrorCore.ERR_BingPhoneError_1;
                    reply();
                    return;
                }

                resultAccounts = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(session.DomainZone(), _account => _account.Id == request.AccountId);
                if (resultAccounts.Count == 0)
                {
                    Log.Error($"PhoneBinging: resultAccounts.Count");
                    reply();
                    return;
                }
                DBCenterAccountInfo dBCenterAccountInfo = resultAccounts[0];
                if (dBCenterAccountInfo.PlayerInfo.PhoneNumber.Equals(request.PhoneNumber))
                {
                    Log.Error($"PhoneBinging: resultAccounts.Count");
                    reply();
                    return;
                }

                dBCenterAccountInfo.PlayerInfo.PhoneNumber = request.PhoneNumber;
                await Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(session.DomainZone(), dBCenterAccountInfo);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
