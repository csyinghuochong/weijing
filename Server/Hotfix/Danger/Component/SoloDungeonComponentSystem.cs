namespace ET
{
    public static class SoloDungeonComponentSystem
    {

        public static void OnKillEvent(this SoloDungeonComponent self, Unit defend)
        {
            Log.Debug($"SoloDungeonComponent {defend.Type}");
        }
    }
}
