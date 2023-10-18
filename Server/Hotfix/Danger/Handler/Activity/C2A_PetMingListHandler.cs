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
                ActivitySceneComponent activitySceneComponent = scene.GetComponent<ActivitySceneComponent>();
                List<PetMingPlayerInfo> minglist = activitySceneComponent.DBDayActivityInfo.PetMingList;

                if (TimeHelper.ServerNow() - activitySceneComponent.PetMingLastTime < TimeHelper.Minute)
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
                        for (int p = teamid * 5; p < (teamid + 1) * 5; p++ )
                        {
                            RolePetInfo rolePetInfo = petComponent.GetPetInfo(petComponent.PetMingList[p]);
                            if (rolePetInfo != null)
                            {
                                petconfidds.Add(rolePetInfo.ConfigId);
                            }
                            else
                            {
                                petconfidds.Add(0);
                            }
                        }

                        activitySceneComponent.PetMingList.Add(new PetMingPlayerInfo()
                        {
                            MineType = minglist[i].MineType,
                            Postion = minglist[i].Postion,
                            TeamId = teamid,
                            PlayerName = userInfoComponent.UserInfo.Name,
                            PetConfig = petconfidds
                        }); ;
                    }

                    activitySceneComponent.PetMingLastTime = TimeHelper.ServerNow();
                    response.PetMingPlayerInfos = activitySceneComponent.PetMingList;
                }
                reply();
            }
            await ETTask.CompletedTask;
        }
    }
}
