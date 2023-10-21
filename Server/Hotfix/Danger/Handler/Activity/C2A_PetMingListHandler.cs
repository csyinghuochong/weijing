using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2A_PetMingListHandler : AMActorRpcHandler<Scene, C2A_PetMingListRequest, A2C_PetMingListResponse>
    {
        protected override async ETTask Run(Scene scene, C2A_PetMingListRequest request, A2C_PetMingListResponse response, Action reply)
        {

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.PetMine, scene.DomainZone()))
            {

                List<PetMingPlayerInfo> selfMinelist = new List<PetMingPlayerInfo>();

                ActivitySceneComponent activitySceneComponent = scene.GetComponent<ActivitySceneComponent>();
                List<PetMingPlayerInfo> minglist = activitySceneComponent.DBDayActivityInfo.PetMingList;

                if (TimeHelper.ServerNow() - activitySceneComponent.PetMingLastTime < TimeHelper.Second * 10)
                {
                    response.PetMingPlayerInfos = activitySceneComponent.PetMingList;
                }
                else
                {
                    activitySceneComponent.PetMingList.Clear();
                    long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());

                    for (int i = 0; i < minglist.Count; i++)
                    {
                        long enemyId = minglist[i].UnitId;
                        UserInfoComponent userInfoComponent = null;
                        PetComponent petComponent = null;
                        D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = enemyId, Component = DBHelper.UserInfoComponent });
                        if (d2GGetUnit.Component == null)
                        {
                            continue;
                        }
                        userInfoComponent = d2GGetUnit.Component as UserInfoComponent;
                        d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = enemyId, Component = DBHelper.PetComponent });
                        if (d2GGetUnit.Component == null)
                        {
                            continue;
                        }

                        int teamid = minglist[i].TeamId;
                        petComponent = d2GGetUnit.Component as PetComponent;
                        List<int> petconfidds = new List<int>();
                        List<long> petidlist = new List<long>();
                        for (int p = teamid * 5; p < (teamid + 1) * 5; p++ )
                        {
                            RolePetInfo rolePetInfo = petComponent.GetPetInfo(petComponent.PetMingList[p]);
                            if (rolePetInfo != null)
                            {
                                petidlist.Add(rolePetInfo.Id);
                                petconfidds.Add(rolePetInfo.ConfigId);
                            }
                            else
                            {
                                petidlist.Add(0);
                                petconfidds.Add(0); 
                            }
                        }

                        activitySceneComponent.PetMingList.Add(new PetMingPlayerInfo()
                        {
                            MineType = minglist[i].MineType,
                            Postion = minglist[i].Postion,
                            TeamId = teamid,
                            PlayerName = userInfoComponent.UserInfo.Name,
                            PetConfig = petconfidds,
                            PetIdList = petidlist,
                            UnitId = minglist[i].UnitId,
                        }); ;
                    }

                    activitySceneComponent.PetMingLastTime = TimeHelper.ServerNow();
                    response.PetMingPlayerInfos = activitySceneComponent.PetMingList;
                }

                if (activitySceneComponent.DBDayActivityInfo.PetMingChanChu.ContainsKey(request.ActorId))
                {
                    response.ChanChu = activitySceneComponent.DBDayActivityInfo.PetMingChanChu[request.ActorId];
                }

                //计算自己的矿
                for (int i = 0; i < response.PetMingPlayerInfos.Count; i++)
                {
                    if (response.PetMingPlayerInfos[i].UnitId == request.ActorId)
                    {
                        selfMinelist.Add(response.PetMingPlayerInfos[i]);
                    }
                }
                A2M_PetMingLoginRequest a2M_PetMing = new A2M_PetMingLoginRequest()
                {
                    UnitID = request.ActorId,
                    PetMineList = selfMinelist,
                    PetMingExtend = activitySceneComponent.DBDayActivityInfo.PetMingExtend,
                };

                M2A_PetMingLoginResponse m2G_RechargeResponse = (M2A_PetMingLoginResponse)await ActorLocationSenderComponent.Instance.Call(request.ActorId, a2M_PetMing);
                if (m2G_RechargeResponse.Error == ErrorCode.ERR_Success)
                {
                }

                response.PetMineExtend = activitySceneComponent.DBDayActivityInfo.PetMingExtend;
                reply();
            }
            await ETTask.CompletedTask;
        }
    }
}
