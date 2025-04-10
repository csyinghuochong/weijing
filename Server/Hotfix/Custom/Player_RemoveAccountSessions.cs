

namespace ET
{

    public static class AccountSessionsComponentSystem2
    {
        /// <summary>
        /// AccountCheckOutTimeComponent 十分钟后
        /// DisconnectHelper.KickPlayer
        /// G2A_ExitGame
        /// </summary>
        /// <param name="self"></param>
        /// <param name="accountId"></param>
        public static void Remove(this AccountSessionsComponent self, long accountId)
        {
            if (self.AccountSessionsDictionary.ContainsKey(accountId))
            {
                self.AccountSessionsDictionary.Remove(accountId);
            }
        }
    }

    
    public class Player_RemoveAccountSessions : AEvent<EventType.RemoveAccountSessions>
    {
        protected override void Run(EventType.RemoveAccountSessions args)
        {
            Scene scene = args.DomainScene;
            scene.GetComponent<AccountSessionsComponent>().Remove(args.AccountId);
        }
    }
}
