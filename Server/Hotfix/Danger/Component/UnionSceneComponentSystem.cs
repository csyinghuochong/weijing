using System;
using System.Collections.Generic;

namespace ET
{
    [Timer(TimerType.UnionTimer)]
    public class UnionTimer : ATimer<UnionSceneComponent>
    {
        public override void Run(UnionSceneComponent self)
        {
            try
            {
                self.SaveDB().Coroutine();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    /// <summary>
    /// 定时刷新的暂时都作为活动来处理
    /// </summary>
    [ObjectSystem]
    public class UnionSceneComponentAwakeSystem : AwakeSystem<UnionSceneComponent>
    {
        public override void Awake(UnionSceneComponent self)
        {
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Minute * 5 + self.DomainZone() * 1200, TimerType.UnionTimer, self);
        }
    }

    public static class UnionSceneComponentSystem
    {

        public static async ETTask<DBUnionInfo> GetDBUnionInfo(this UnionSceneComponent self, long unionId)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GSave = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unionId, Component = DBHelper.DBUnionInfo });
            DBUnionInfo unionInfo = d2GSave.Component as DBUnionInfo;
            if (unionInfo == null)
            {
                return null;
            }
            return unionInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unionid"></param>
        /// <param name="unitid"></param>
        /// <param name="replyCode">0拒绝  1同意</param>
        /// <returns></returns>
        public static async ETTask<int> OnJoinUinon(this UnionSceneComponent self, long unionid, long unitid, int replyCode)
        {
            DBUnionInfo dBUnionInfo = await self.GetDBUnionInfo(unionid);
            if (dBUnionInfo == null)
            {
                return ErrorCore.ERR_Union_Not_Exist;
            }
            if (dBUnionInfo.UnionInfo.ApplyList.Contains(unitid))
            {
                dBUnionInfo.UnionInfo.ApplyList.Remove(unitid);
            }
            bool exist = false;
            for (int i = 0; i < dBUnionInfo.UnionInfo.UnionPlayerList.Count; i++)
            {
                if (dBUnionInfo.UnionInfo.UnionPlayerList[i].UserID == unitid)
                {
                    exist = true;
                }
            }
            if (!exist && replyCode == 1)
            {
                dBUnionInfo.UnionInfo.UnionPlayerList.Add(new UnionPlayerInfo()
                {
                    UserID = unitid,
                });

                //通知玩家
                long gateServerId = DBHelper.GetGateServerId(self.DomainZone());
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                   (gateServerId, new T2G_GateUnitInfoRequest()
                   {
                       UserID = unitid
                   });
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    U2M_UnionApplyRequest r2M_RechargeRequest = new U2M_UnionApplyRequest() { UnionId = unitid, UnionName = dBUnionInfo.UnionInfo.UnionName };
                    M2U_UnionApplyResponse m2G_RechargeResponse = (M2U_UnionApplyResponse)await ActorLocationSenderComponent.Instance.Call(g2M_UpdateUnitResponse.UnitId, r2M_RechargeRequest);
                }
                else
                {
                    long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
                    D2G_GetComponent d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unitid, Component = DBHelper.NumericComponent });
                    NumericComponent numericComponent = d2GGet.Component as NumericComponent;
                    numericComponent.Set(NumericType.UnionId, unitid, false);
                    D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = unitid, EntityByte = MongoHelper.ToBson(numericComponent), ComponentType = DBHelper.NumericComponent });
                }
            }

            DBHelper.SaveComponent(self.DomainZone(), unionid, dBUnionInfo).Coroutine();
            return ErrorCore.ERR_Success;
        }

        public static async ETTask SaveDB(this UnionSceneComponent self)
        {
            await ETTask.CompletedTask;
        }
    }
}
