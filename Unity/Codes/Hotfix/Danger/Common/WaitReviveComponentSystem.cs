namespace ET
{

    [ObjectSystem]
    public class WaitReviveComponentAwakeSystem : AwakeSystem<WaitReviveComponent>
    {
        public override void Awake(WaitReviveComponent self)
        {
            self.WaitReviveIds.Clear();
        }
    }

    [ObjectSystem]
    public class WaitReviveComponentDestroySystem : DestroySystem<WaitReviveComponent>
    {
        public override void Destroy(WaitReviveComponent self)
        {
        }
    }

    public static class WaitReviveComponentSystem
    {

#if SERVER
        public static void Add(this WaitReviveComponent self, long unitId, long reviviTime)
        {
            self.WaitReviveIds.Add(unitId,TimeHelper.ServerNow() + reviviTime);
            self.TimeOutRemoveKey(unitId, reviviTime).Coroutine();
        }

        public static long Get(this WaitReviveComponent self, long unitId)
        { 
            long reviviTime = 0;
            self.WaitReviveIds.TryGetValue(unitId, out reviviTime);
            return reviviTime;
        }

        public static void Remove(this WaitReviveComponent self, long unitId)
        {
            if (self.WaitReviveIds.ContainsKey(unitId))
            { 
                self.WaitReviveIds.Remove(unitId);
            }
        }
        private static async ETTask TimeOutRemoveKey(this WaitReviveComponent self, long unitId, long reviviTime)
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
