using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2Popularize_PlayerHandler : AMActorRpcHandler<Scene, C2Popularize_PlayerRequest, Popularize2C_PlayerResponse>
    {
        protected override async ETTask Run(Scene scene, C2Popularize_PlayerRequest request, Popularize2C_PlayerResponse response, Action reply)
        {
            Log.Warning($"C2Popularize_PlayerRequest:{request.ActorId}");
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Popularize, request.ActorId))
            {
                DBPopularizeInfo dBPopularizeInfo = await DBHelper.GetComponentCache<DBPopularizeInfo>(scene.DomainZone(), request.ActorId);
                if (dBPopularizeInfo == null)
                {
                    Console.WriteLine($"C2Popularize_PlayerRequest  self dBPopularizeInfo == null  {request.ActorId}");
                    response.Error = ErrorCode.ERR_PopularizeNot;
                    reply();
                    return;
                }

                UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(scene.DomainZone(), request.ActorId);
                if (userInfoComponent == null)
                {
                    Console.WriteLine($"C2Popularize_PlayerRequest  self userInfoComponent == null  {request.ActorId}");
                    response.Error = ErrorCode.ERR_PopularizeNot;
                    reply();
                    return;
                }

                int oldzone = (int)request.PopularizeId / 1000000;
                int xuhao = (int)request.PopularizeId % 1000000;
                int newzone = ServerHelper.GetNewServerId(oldzone);
                if (newzone < 5)
                {
                    Console.WriteLine($"C2Popularize_PlayerRequest  ErrorCode.ERR_PopularizeNot");
                    response.Error = ErrorCode.ERR_PopularizeNot;
                    reply();
                    return;
                }
 

                List<DBPopularizeInfo> dBPopularizeInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBPopularizeInfo>(newzone, d => d.PopularizeCode == request.PopularizeId);
                if (dBPopularizeInfoList.Count == 0)
                {
                    Console.WriteLine($"C2Popularize_PlayerRequest 被推广人  dBPopularizeInfoList.Count == 0  {request.PopularizeId}");
                    response.Error = ErrorCode.ERR_PopularizeNot;
                    reply();
                    return;
                }

                long puserid = dBPopularizeInfoList[0].Id;
                UserInfoComponent userInfoComponent_2 = await DBHelper.GetComponentCache<UserInfoComponent>(newzone, puserid);
                if (userInfoComponent_2 == null)
                {
                    Console.WriteLine($"C2Popularize_PlayerRequest 被推广人  userInfoComponent_2 == null  {puserid}");
                    response.Error = ErrorCode.ERR_PopularizeNot;
                    reply();
                    return;
                }
                if (userInfoComponent.UserInfo.AccInfoID == userInfoComponent_2.UserInfo.AccInfoID)
                {
                    Console.WriteLine($"C2Popularize_PlayerRequest 被推广人  userInfoComponent.UserInfo.AccInfoID == userInfoComponent_2.UserInfo.AccInfoID");
                    response.Error = ErrorCode.ERR_PopularizeThe;
                    reply();
                    return;
                }

                if (dBPopularizeInfoList[0].MyPopularizeList.Count >= 10)
                {
                    response.Error = ErrorCode.ERR_PopularizeMax;
                    reply();
                    return;
                }


                response.Message = "SUCESS";
                dBPopularizeInfoList[0].MyPopularizeList.Add(new PopularizeInfo() { UnitId = request.ActorId });
                await DBHelper.SaveComponentCache(newzone, dBPopularizeInfoList[0].Id, dBPopularizeInfoList[0]);

                dBPopularizeInfo.BePopularizeId = request.PopularizeId;
                await DBHelper.SaveComponentCache(newzone, dBPopularizeInfo.Id, dBPopularizeInfo);
            }

            reply();
        }
    }
}
