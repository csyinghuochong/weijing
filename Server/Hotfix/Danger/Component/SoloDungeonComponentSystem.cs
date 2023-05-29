namespace ET
{
    public static class SoloDungeonComponentSystem
    {

        public static void OnKillEvent(this SoloDungeonComponent self, Unit defend)
        {
            Log.Debug($"solo场击杀事件 {defend.Type}");
        }
    }
}
