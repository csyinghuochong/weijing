namespace ET
{
    public static class PlayerSystem
    {

        [ObjectSystem]
        public class PlayerAwakeSystem : AwakeSystem<Player, long, long>
        {
            public override void Awake(Player self, long a, long roleId)
            {
                self.AccountId = a;
                self.UnitId = roleId;
                self.ChatInfoInstanceId = 0;
                self.PlayerState = PlayerState.Disconnect;
                self.ClientSession?.Dispose();
            }
        }
    }
}