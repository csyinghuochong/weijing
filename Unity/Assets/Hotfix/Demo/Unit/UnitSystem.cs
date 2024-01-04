namespace ET
{
    [ObjectSystem]
    public class UnitSystem: AwakeSystem<Unit, int>
    {
        public override void Awake(Unit self, int configId)
        {
            self.MainHero = false;
            self.ConfigId = configId;
            self.UpdateUITime = 0;
        }
    }
}