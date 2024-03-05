using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2Popularize_ListHandler : AMActorRpcHandler<Scene, C2Popularize_ListRequest, Popularize2C_ListResponse>
    {
        protected override async ETTask Run(Scene scene, C2Popularize_ListRequest request, Popularize2C_ListResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Popularize, scene.DomainZone()))
            {
                //UserInfoComponent userInfoComponent_self = await DBHelper.GetComponentCache<UserInfoComponent>(scene.DomainZone(), request.ActorId);
                //if (userInfoComponent_self == null)
                //{
                //    response.Error = ErrorCode.ERR_ModifyData;
                //    reply();
                //    return;
                //}
                
                //List<DBCenterAccountInfo> resulets = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id == userInfoComponent_self.UserInfo.AccInfoID);
                //if (resulets == null || resulets.Count == 0)
                //{
                //    response.Error = ErrorCode.ERR_ModifyData;
                //    reply();
                //    return;
                //}

                //int createDay = userInfoComponent_self.GetCrateDay();
                //int needLv = ComHelp.IsCanPaiMai(createDay, userInfoComponent_self.UserInfo.Lv);
                //if (!ComHelp.IsRecharge(resulets[0].PlayerInfo) && ComHelp.IsCanPaiMai(createDay, userInfoComponent_self.UserInfo.Lv) > 0)
                //{
                //    response.Error = ErrorCode.ERR_ModifyData;
                //    reply();
                //    return;
                //}

                DBPopularizeInfo dBPopularizeInfo = await DBHelper.GetComponentCache<DBPopularizeInfo>(scene.DomainZone(), request.ActorId);
                if (dBPopularizeInfo == null)
                {
                    if (scene.GetChild<DBPopularizeInfo>(request.ActorId) != null)
                    {
                        reply();
                        return;
                    }

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
                    int newZone = ServerHelper.GetNewServerId(oldZone);
                    if (newZone < 5)
                    {
                        continue;
                    }

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
                response.BePopularizeId = dBPopularizeInfo.BePopularizeId;
                response.MyPopularizeList = dBPopularizeInfo.MyPopularizeList;

            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
