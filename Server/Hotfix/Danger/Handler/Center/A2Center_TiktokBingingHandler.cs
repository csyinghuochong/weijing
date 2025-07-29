using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class A2Center_TiktokBingingHandler : AMActorRpcHandler<Scene, A2Center_TiktokBinging, Center2A_TiktokBinging>
    {
        protected override async ETTask Run(Scene scene, A2Center_TiktokBinging request, Center2A_TiktokBinging response, Action reply)
        {
            Console.WriteLine($"C2Center_PhoneBinging:{request.Account}");
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Register, request.Account.Trim().GetHashCode()))
            {
                if ( string.IsNullOrEmpty(request.Account) || string.IsNullOrEmpty(request.TikTokGuanFuAccount))
                {
                    response.Error = ErrorCode.ERR_NotFindAccount;
                    reply();
                    return;
                }

                List<DBCenterAccountInfo> resultAccounts = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(),
                    _account => _account.Account.Equals(request.TikTokGuanFuAccount));
                if (resultAccounts.Count > 0)
                {
                    Console.WriteLine($"_account.Account.Equals(request.TikTokGuanFuAccount))");
                    response.Error = ErrorCode.ERR_NotFindAccount;
                    reply();
                    return;
                }

                resultAccounts = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(),
                    _account => _account.PlayerInfo != null && _account.PlayerInfo.TikTokGuanFuAccount.Equals(request.TikTokGuanFuAccount));
                if (resultAccounts.Count > 0)
                {
                    Console.WriteLine($"_account.PlayerInfo.TikTokGuanFuAccount.Equals(request.TikTokGuanFuAccount))");
                    response.Error = ErrorCode.ERR_NotFindAccount;
                    reply();
                    return;
                }
                resultAccounts = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(), _account => _account.Account == request.Account);
                if (resultAccounts.Count == 0)
                {
                    Console.WriteLine($"A2Center_TiktokBinging resultAccounts.Count == 0");
                    response.Error = ErrorCode.ERR_NotFindAccount;
                    reply();
                    return;
                }

                DBCenterAccountInfo dBCenterAccountInfo = resultAccounts[0];

                Console.WriteLine($"抖音渠道包账号绑定官包账号成功！{dBCenterAccountInfo.Account}  {dBCenterAccountInfo.PlayerInfo.TikTokGuanFuAccount}");
                dBCenterAccountInfo.PlayerInfo.TikTokGuanFuAccount = request.TikTokGuanFuAccount;
                await Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(scene.DomainZone(), dBCenterAccountInfo);
                response.AccountId = dBCenterAccountInfo.Id;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
