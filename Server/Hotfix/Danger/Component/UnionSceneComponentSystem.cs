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
            DBUnionInfo unionInfo = null;
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GSave = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unionId, Component = DBHelper.DBUnionInfo });
            unionInfo = d2GSave.Component as DBUnionInfo;
            if (unionInfo == null)
            {
                return null;
            }
            return unionInfo;
        }

        public static async ETTask SaveDB(this UnionSceneComponent self)
        {
            await ETTask.CompletedTask;
        }
    }
}
