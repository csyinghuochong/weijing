using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_PetMingBattleWinHandler : AMActorRpcHandler<Scene, M2A_PetMingBattleWinRequest, A2M_PetMingBattleWinResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_PetMingBattleWinRequest request, A2M_PetMingBattleWinResponse response, Action reply)
        {
            Log.Console($"M2A_PetMingBattleWinRequest: {request}");

            long oldUnitid = 0;
            long serverTime = TimeHelper.ServerNow();

            List<PetMingPlayerInfo> petMingPlayerInfos = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.PetMingList;

            //移除改队伍之前占领
            for (int i = petMingPlayerInfos.Count - 1; i >= 0; i--)
            {
                if (petMingPlayerInfos[i].UnitId == request.UnitID
                 && petMingPlayerInfos[i].TeamId == request.TeamId)
                {
                    petMingPlayerInfos.RemoveAt(i);
                    break;
                }
            }

            for (int i = petMingPlayerInfos.Count - 1; i >= 0; i--)
            {
                if (petMingPlayerInfos[i].MineType == request.MingType
                 && petMingPlayerInfos[i].Postion == request.Postion)
                {
                    oldUnitid = petMingPlayerInfos[i].UnitId;
                    petMingPlayerInfos.RemoveAt(i);
                    break;
                }
            }
            if (request.UnitID != 0)
            {
                petMingPlayerInfos.Add(new PetMingPlayerInfo()
                {
                    MineType = request.MingType,
                    Postion = request.Postion,
                    UnitId = request.UnitID,
                    TeamId = request.TeamId,
                    OccupyTime = serverTime
                });
            }

            if (oldUnitid != 0)
            {
                PetMingRecord petMingRecord = new PetMingRecord();
                petMingRecord.UnitID = request.UnitID;
                petMingRecord.Position = request.Postion;
                petMingRecord.MineType = request.MingType;
                petMingRecord.Time = serverTime;
                petMingRecord.WinPlayer = request.WinPlayer;    

                //通知玩家
                long gateServerId = DBHelper.GetGateServerId(scene.DomainZone());
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                   (gateServerId, new T2G_GateUnitInfoRequest()
                   {
                       UserID = oldUnitid
                   });
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    A2M_PetMingRecordRequest a2M_PetMing = new A2M_PetMingRecordRequest()
                    {
                        UnitID = oldUnitid,
                        PetMingRecord =  petMingRecord
                    };

                    M2A_PetMingRecordResponse m2G_RechargeResponse = (M2A_PetMingRecordResponse)await ActorLocationSenderComponent.Instance.Call(oldUnitid, a2M_PetMing);
                    if (m2G_RechargeResponse.Error == ErrorCode.ERR_Success)
                    {
                    }
                }
                else
                {
                    long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                    D2G_GetComponent d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = oldUnitid, Component = DBHelper.PetComponent });
                    PetComponent petComponent = d2GGet.Component as PetComponent;
                    petComponent.OnPetMingRecord(petMingRecord);
                    D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = oldUnitid, EntityByte = MongoHelper.ToBson(petComponent), ComponentType = DBHelper.PetComponent });

                    D2G_GetComponent d2GGet_2 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = oldUnitid, Component = DBHelper.ReddotComponent });
                    ReddotComponent redComponent = d2GGet_2.Component as ReddotComponent;
                    redComponent.AddReddont(601);
                    D2M_SaveComponent d2GSave_2 = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = oldUnitid, EntityByte = MongoHelper.ToBson(redComponent), ComponentType = DBHelper.ReddotComponent });
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
