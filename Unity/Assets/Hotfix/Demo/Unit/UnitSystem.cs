namespace ET
{
    [ObjectSystem]
    public class UnitSystem: AwakeSystem<Unit, int>
    {
        public override void Awake(Unit self, int configId)
        {
            self.MainHero = false;
            self.ConfigId = configId;
            self.UpdateUIType = 0;
            self.UpdateUITime = 0;
        }
    }
}