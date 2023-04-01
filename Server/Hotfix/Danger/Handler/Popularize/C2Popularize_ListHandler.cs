using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2Popularize_ListHandler : AMActorRpcHandler<Scene, C2Popularize_ListRequest, Popularize2C_ListResponse>
    {
        protected override async ETTask Run(Scene scene, C2Popularize_ListRequest request, Popularize2C_ListResponse response, Action reply)
        {
            DBPopularizeInfo dBPopularizeInfo = await DBHelper.GetComponentCache<DBPopularizeInfo>(scene.DomainZone(), request.ActorId);
            if (dBPopularizeInfo == null)
            {
                dBPopularizeInfo = scene.AddChildWithId<DBPopularizeInfo>(request.ActorId);

                int newzone = scene.DomainZone();
                List<DBPopularizeInfo> dBPopularizeInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBPopularizeInfo>(newzone, d => d.Id > 0);
                int xuindex = dBPopularizeInfoList.Count + 1;

                //推广码生成规则
                dBPopularizeInfo.PopularizeCode = newzone * 1000000 + xuindex;

                await DBHelper.SaveComponent(scene.DomainZone(), request.ActorId, dBPopularizeInfo);
                dBPopularizeInfo.Dispose();
            }

            for (int i = 0; i < dBPopularizeInfo.MyPopularizeList.Count; i++)
            {
                long unitid = dBPopularizeInfo.MyPopularizeList[i].UnitId;
                int oldZone = UnitIdStruct.GetUnitZone(unitid);
                int newZone = ServerHelper.GetNewServerId(false, oldZone);
                UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(newZone, unitid);
                if (userInfoComponent == null)
                {
                    continue;
                }

                dBPopularizeInfo.MyPopularizeList[i].Nmae = userInfoComponent.UserInfo.Name;
                dBPopularizeInfo.MyPopularizeList[i].Level = userInfoComponent.UserInfo.Lv;
                dBPopularizeInfo.MyPopularizeList[i].Occ = userInfoComponent.UserInfo.Occ;
                dBPopularizeInfo.MyPopularizeList[i].OccTwo = userInfoComponent.UserInfo.OccTwo;
            }

            response.PopularizeCode = dBPopularizeInfo.PopularizeCode;
            response.BePopularizeId = dBPopularizeInfo. BePopularizeId;
            response.MyPopularizeList = dBPopularizeInfo.MyPopularizeList;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
