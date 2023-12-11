using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionMyInfoHandler : AMActorRpcHandler<Scene, C2U_UnionMyInfoRequest, U2C_UnionMyInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionMyInfoRequest request, U2C_UnionMyInfoResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            DBUnionInfo dBUnionInfo =await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }

            ///1族长 2副族长  ///3长老
            long gateServerId = DBHelper.GetGateServerId(scene.DomainZone());
            for (int i = dBUnionInfo.UnionInfo.UnionPlayerList.Count - 1; i >= 0; i--)
            {
                UnionPlayerInfo unionPlayerInfo = dBUnionInfo.UnionInfo.UnionPlayerList[i];
                long userId = unionPlayerInfo.UserID;

                D2G_GetComponent  d2GSave = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userId, Component = DBHelper.UserInfoComponent });
                UserInfoComponent userInfoComponent = d2GSave.Component as UserInfoComponent;
                if (userInfoComponent == null)
                {
                    dBUnionInfo.UnionInfo.UnionPlayerList.RemoveAt(i);
                    continue;
                }

                if (unionPlayerInfo.Position == 1 && unionPlayerInfo.UserID != dBUnionInfo.UnionInfo.LeaderId)
                {
                    unionPlayerInfo.Position = 0;
                }
                if (unionPlayerInfo.UserID == dBUnionInfo.UnionInfo.LeaderId)
                {
                    unionPlayerInfo.Position = 1;
                }

                unionPlayerInfo.PlayerLevel = userInfoComponent.UserInfo.Lv;
                unionPlayerInfo.PlayerName = userInfoComponent.UserInfo.Name;
                unionPlayerInfo.Combat = userInfoComponent.UserInfo.Combat;

                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = userId
                    });
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    response.OnLinePlayer.Add(userId);
                }
                if (dBUnionInfo.UnionInfo.LeaderId == userId)
                {
                    dBUnionInfo.UnionInfo.LeaderName = userInfoComponent.UserInfo.Name;
                }
            }

            long timeNow = TimeHelper.ServerNow();

            if (dBUnionInfo.UnionInfo.Level == 0)
            {
                dBUnionInfo.UnionInfo.Level = 1;
            }

            if (dBUnionInfo.UnionInfo.UnionKeJiList.Count < UnionKeJiConfigCategory.Instance.UnionQiangHuaList.Count)
            {
                int curNumber = dBUnionInfo.UnionInfo.UnionKeJiList.Count;
                int maxNumber = UnionKeJiConfigCategory.Instance.UnionQiangHuaList.Count;
                for (int keji = curNumber; keji < maxNumber; keji++)
                {
                    dBUnionInfo.UnionInfo.UnionKeJiList.Add(UnionKeJiConfigCategory.Instance.GetFristId(keji));
                }
            }

            //检测是否有科技可以升级
            if (dBUnionInfo.UnionInfo.KeJiActiteTime > 0)
            {
                int keijiId = dBUnionInfo.UnionInfo.UnionKeJiList[dBUnionInfo.UnionInfo.KeJiActitePos];
                long passTime = (dBUnionInfo.UnionInfo.KeJiActiteTime - timeNow) / 1000;
                if (UnionKeJiConfigCategory.Instance.Contain(keijiId + 1 ) && passTime >= UnionKeJiConfigCategory.Instance.Get(keijiId + 1).NeedTime)
                {
                    dBUnionInfo.UnionInfo.UnionKeJiList[dBUnionInfo.UnionInfo.KeJiActitePos] = keijiId + 1;
                    dBUnionInfo.UnionInfo.KeJiActitePos = -1;
                    dBUnionInfo.UnionInfo.KeJiActiteTime = 0;
                }
            }

            ///判断族长离线时间
            D2G_GetComponent d2GSave_2 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = dBUnionInfo.UnionInfo.LeaderId, Component = DBHelper.NumericComponent });
            NumericComponent numericComponent = d2GSave_2.Component as NumericComponent;

            if (dBUnionInfo.UnionInfo.JingXuanEndTime == 0 && numericComponent != null && timeNow - numericComponent.GetAsLong(NumericType.LastGameTime) > TimeHelper.OneDay * 5)
            {
                dBUnionInfo.UnionInfo.JingXuanEndTime = timeNow + TimeHelper.OneDay * 3;
            }
            ///判断竞选是否结束
            if(dBUnionInfo.UnionInfo.JingXuanEndTime != 0 && timeNow >= dBUnionInfo.UnionInfo.JingXuanEndTime )
            {
                ///分配新族长
                Log.Console("分配新族长！！");
                List<UnionPlayerInfo> jingxuanPlayers = new List<UnionPlayerInfo>();    
                for (int i = dBUnionInfo.UnionInfo.UnionPlayerList.Count - 1; i >= 0; i--)
                {
                    UnionPlayerInfo unionPlayerInfo = dBUnionInfo.UnionInfo.UnionPlayerList[i];
                    long userId = unionPlayerInfo.UserID;
                    if (dBUnionInfo.UnionInfo.JingXuanList.Contains(userId))
                    {
                        jingxuanPlayers.Add(unionPlayerInfo);
                    }
                }
                jingxuanPlayers.Sort(delegate (UnionPlayerInfo a, UnionPlayerInfo b)
                {
                    int positiona = a.Position == 0 ? 10 : a.Position;
                    int positionb = b.Position == 0 ? 10 : b.Position;
                    int combata = a.Combat;
                    int combatb = b.Combat;

                    if (positiona == positionb)
                    {
                        return combatb - combata;
                    }
                    else
                    { 
                        return positiona - positionb;   
                    }
                });
                dBUnionInfo.UnionInfo.JingXuanList.Clear();
                dBUnionInfo.UnionInfo.JingXuanEndTime = 0;

                long newLeaderId = 0;
                if (jingxuanPlayers.Count > 0)
                {
                    newLeaderId = jingxuanPlayers[0].UserID;
                }
                if (newLeaderId!= 0 && newLeaderId != dBUnionInfo.UnionInfo.LeaderId)
                {
                    UnionPlayerInfo unionPlayerInfo_old = UnionHelper.GetUnionPlayerInfo(dBUnionInfo.UnionInfo.UnionPlayerList, dBUnionInfo.UnionInfo.LeaderId);
                    UnionPlayerInfo unionPlayerInfo_new = UnionHelper.GetUnionPlayerInfo(dBUnionInfo.UnionInfo.UnionPlayerList, newLeaderId);

                    if (unionPlayerInfo_old != null && unionPlayerInfo_new != null)
                    {
                        long oldLeaderid = dBUnionInfo.UnionInfo.LeaderId;
                        dBUnionInfo.UnionInfo.LeaderId = newLeaderId;
                        unionPlayerInfo_new.Position = 1;
                        unionPlayerInfo_old.Position = 0;
                        dBUnionInfo.UnionInfo.LeaderName = unionPlayerInfo_new.PlayerName;
                        UnionHelper.NoticeUnionLeader(scene.DomainZone(), newLeaderId, 1).Coroutine();

                        //通知旧族长
                        UnionHelper.NoticeUnionLeader(scene.DomainZone(), oldLeaderid, 0).Coroutine();
                    }
                }
            }
           
            response.UnionMyInfo = dBUnionInfo.UnionInfo;
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
        }
    }
}
