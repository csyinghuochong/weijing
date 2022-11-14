using System;

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
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(60000, TimerType.UnionTimer, self);
        }
    }

    public static class UnionSceneComponentSystem
    {

        public static bool IsSameNameUnion(this UnionSceneComponent self, string name)
        {
            foreach (DBUnionInfo item in self.UnionList.Values)
            {
                if (item.UnionInfo.UnionName.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        public static async ETTask<DBUnionInfo> GetDBUnionInfo(this UnionSceneComponent self, long unionId)
        {
            DBUnionInfo unionInfo = null;
            self.UnionList.TryGetValue(unionId, out unionInfo);
            if (unionInfo != null)
            {
                return unionInfo;
            }

            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GSave = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unionId, Component = DBHelper.DBUnionInfo });
            unionInfo = d2GSave.Component as DBUnionInfo;
            if (unionInfo == null)
            {
                return null;
            }
            self.UnionList.Add(unionId, unionInfo);
            return unionInfo;
        }

        public static async ETTask SaveDB(this UnionSceneComponent self)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            foreach (var item in self.UnionList)
            {
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = self.DomainZone(), Component = item.Value, ComponentType = DBHelper.DBUnionInfo });
            }
        }
    }
}
