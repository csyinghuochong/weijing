using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanVisitListHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanVisitListRequest, M2C_JiaYuanVisitListResponse>
    {

        private async ETTask<JiaYuanVisit> GetJiaYuanVisit(int zone, long id)
        {
            List<JiaYuanComponent> resultJiaYuan = await Game.Scene.GetComponent<DBComponent>().Query<JiaYuanComponent>(zone, _account => _account.Id == id);
            if (resultJiaYuan == null || resultJiaYuan.Count == 0)
            {
                return null;
            }

            List<UserInfoComponent> resultUser = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(zone, _account => _account.Id == id);
            if (resultUser[0].UserInfo.Lv < 10)
            {
                return null;
            }
            JiaYuanVisit jiaYuanVisit = new JiaYuanVisit() ;
            jiaYuanVisit.Occ = resultUser[0].UserInfo.Occ;
            jiaYuanVisit.OccTwo = resultUser[0].UserInfo.OccTwo;
            jiaYuanVisit.PlayerName = resultUser[0].UserInfo.Name;
            jiaYuanVisit.UnitId = resultJiaYuan[0].Id;
            jiaYuanVisit.Rubbish = resultJiaYuan[0].GetRubbishNumber();
            jiaYuanVisit.Gather = resultJiaYuan[0].GetCanGatherNumber();
            return jiaYuanVisit;
        }

        protected override async ETTask Run(Unit unit, C2M_JiaYuanVisitListRequest request, M2C_JiaYuanVisitListResponse response, Action reply)
        {
            Log.Warning($"C2M_JiaYuanVisitListRequest:{request.ActorId}");
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.JiaYuan, unit.Id))
            {
                JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
                if (request.OperateType == 1)
                {
                    if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.JiaYuanVisitRefresh) >= 3)
                    {
                        return;
                    }
                    unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.JiaYuanVisitRefresh, 1, 0);
                    jiaYuanComponent.JiaYuanFuJinTime_3 = 0;
                }

                long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unit.Id, Component = DBHelper.DBFriendInfo });
                DBFriendInfo dBFriendInfo = d2GGetUnit.Component as DBFriendInfo;
                if (dBFriendInfo != null)
                {
                    List<long> friendList = dBFriendInfo.FriendList;
                    for (int i = 0; i < friendList.Count; i++)
                    {
                        if (friendList[i] == unit.Id)
                        {
                            continue;
                        }
                        JiaYuanVisit jiaYuanVisit = await GetJiaYuanVisit(unit.DomainZone(), friendList[i]);
                        if (jiaYuanVisit != null)
                        {
                            response.JiaYuanVisit_1.Add(jiaYuanVisit);
                        }
                    }
                }

                if (TimeHelper.ServerNow() - jiaYuanComponent.JiaYuanFuJinTime_3 > TimeHelper.Hour * 4)
                {
                    jiaYuanComponent.JiaYuanFuJins_3.Clear();

                    long mapInstanceId = DBHelper.GetMainCityServerId(unit.DomainZone());
                    M2M_AllPlayerListResponse reqEnter = (M2M_AllPlayerListResponse)await ActorMessageSenderComponent.Instance.Call(mapInstanceId, new M2M_AllPlayerListRequest()
                    {
                    });
                    List<long> allPlayers = new List<long>();
                    if (reqEnter.Error == ErrorCode.ERR_Success)
                    {
                        allPlayers = reqEnter.AllPlayers;
                    }

                    for (int i = allPlayers.Count - 1; i >= 0; i--)
                    {
                        if (allPlayers[i] == unit.Id || allPlayers[i] == request.MasterId)
                        {
                            allPlayers.RemoveAt(i);
                            continue;
                        }
                        if (friendList.Contains(allPlayers[i]))
                        {
                            allPlayers.RemoveAt(i);
                            continue;
                        }
                    }

                    List<long> destUserinfos = new List<long>();
                    RandomHelper.GetRandListByCount(allPlayers, destUserinfos, Math.Min(allPlayers.Count, 3));
                    jiaYuanComponent.JiaYuanFuJinTime_3 = TimeHelper.ServerNow();
                    jiaYuanComponent.JiaYuanFuJins_3 = destUserinfos;
                }

                for (int i = 0; i < jiaYuanComponent.JiaYuanFuJins_3.Count; i++)
                {
                    JiaYuanVisit jiaYuanVisit = await GetJiaYuanVisit(unit.DomainZone(), jiaYuanComponent.JiaYuanFuJins_3[i]);
                    if (jiaYuanVisit != null)
                    {
                        response.JiaYuanVisit_2.Add(jiaYuanVisit);
                    }
                }
            }    
            reply();
            await ETTask.CompletedTask;
        }
    }
}
