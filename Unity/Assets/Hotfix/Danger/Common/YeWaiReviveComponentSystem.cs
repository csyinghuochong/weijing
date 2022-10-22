namespace ET
{

    [ObjectSystem]
    public class YeWaiReviveComponentAwakeSystem : AwakeSystem<YeWaiReviveComponent>
    {
        public override void Awake(YeWaiReviveComponent self)
        {
            self.WaitReviveIds.Clear();
        }
    }

    [ObjectSystem]
    public class YeWaiReviveComponentDestroySystem : DestroySystem<YeWaiReviveComponent>
    {
        public override void Destroy(YeWaiReviveComponent self)
        {
        }
    }

    public static class YeWaiReviveComponentSystem
    {

#if SERVER
        public static void Add(this YeWaiReviveComponent self, long unitId, long reviviTime)
        {
            self.WaitReviveIds.Add(unitId,TimeHelper.ServerNow() + reviviTime);
            self.TimeOutRemoveKey(unitId, reviviTime).Coroutine();
        }

        public static long Get(this YeWaiReviveComponent self, long unitId)
        { 
            long reviviTime = 0;
            self.WaitReviveIds.TryGetValue(unitId, out reviviTime);
            return reviviTime;
        }

        public static void Remove(this YeWaiReviveComponent self, long unitId)
        {
            if (self.WaitReviveIds.ContainsKey(unitId))
            { 
                self.WaitReviveIds.Remove(unitId);
            }
        }
        private static async ETTask TimeOutRemoveKey(this YeWaiReviveComponent self, long unitId, long reviviTime)
        {
            await TimerComponent.Instance.WaitAsync(reviviTime);

            if (!self.WaitReviveIds.ContainsKey(unitId))
            {
                return;
            }
            Unit unit = self.DomainScene().GetComponent<UnitComponent>().Get(unitId);
            if (unit != null && !unit.IsDisposed)
            {
                unit.GetComponent<HeroDataComponent>().OnRevive();
            }
            self.WaitReviveIds.Remove(unitId);
        }
#endif
    }
}
