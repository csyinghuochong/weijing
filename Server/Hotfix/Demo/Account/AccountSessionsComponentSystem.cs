using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class AccountSessionsComponentDestroySystem : DestroySystem<AccountSessionsComponent>
    {
        public override void Destroy(AccountSessionsComponent self)
        {
           self.AccountSessionsDictionary.Clear();
        }
    }

    public static class AccountSessionsComponentSystem
    {
        public static long Get(this AccountSessionsComponent self, long accountId)
        {
            if (!self.AccountSessionsDictionary.TryGetValue(accountId, out long instanceId))
            {
                return 0;
            }
            return instanceId;
        }

        public static Dictionary<long,long> GetAll(this AccountSessionsComponent self)
        { 
            return self.AccountSessionsDictionary;
        }

        public static void Add(this AccountSessionsComponent self, long accountId, long instanceId)
        {
            if (self.AccountSessionsDictionary.ContainsKey(accountId))
            {
                self.AccountSessionsDictionary[accountId] = instanceId;
                return;
            }
            self.AccountSessionsDictionary.Add(accountId, instanceId);
        }

        public static void Remove(this AccountSessionsComponent self, long accountId)
        {
            if (self.AccountSessionsDictionary.ContainsKey(accountId))
            {
                self.AccountSessionsDictionary.Remove(accountId);
            }
        }
    }
}
