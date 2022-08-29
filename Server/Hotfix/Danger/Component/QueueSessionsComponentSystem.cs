using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ObjectSystem]
    public class QueueSessionsComponenDestroySystem : DestroySystem<QueueSessionsComponent>
    {
        public override void Destroy(QueueSessionsComponent self)
        {
            self.QueueSessionsDictionary.Clear();
        }
    }

    public static class QueueSessionsComponentSystem
    {

        public static void AddToken(this QueueSessionsComponent self, long accountId, string token)
        {
            if (self.QueueTokenDictionary.ContainsKey(accountId))
            {
                self.QueueTokenDictionary[accountId] = token;
                return;
            }
            self.QueueTokenDictionary.Add(accountId, token);
        }

        public static string GetToken(this QueueSessionsComponent self, long accountId)
        {
            string token = null;
            self.QueueTokenDictionary.TryGetValue(accountId, out token);
            return token;
        }

        public static void RemoveToken(this QueueSessionsComponent self, long accountId)
        {
            if (self.QueueTokenDictionary.ContainsKey(accountId))
            {
                self.QueueTokenDictionary.Remove(accountId);
            }
        }

        public static void Add(this QueueSessionsComponent self, long accountId, long instanceId)
        {
            if (self.QueueSessionsDictionary.ContainsKey(accountId))
            {
                self.QueueSessionsDictionary[accountId] = instanceId;
                return;
            }
            self.QueueSessionsDictionary.Add(accountId, instanceId);
        }

        public static long GetFirst(this QueueSessionsComponent self)
        {
            List<long> ids = self.QueueSessionsDictionary.Keys.ToList();
            return ids.Count > 0 ?  ids.First() : 0;
        }

        public static long Get(this QueueSessionsComponent self, long accountId)
        {
            if (!self.QueueSessionsDictionary.TryGetValue(accountId, out long instanceId))
            {
                return 0;
            }
            return instanceId;
        }

        public static void Remove(this QueueSessionsComponent self, long accountId)
        {
            if (self.QueueSessionsDictionary.ContainsKey(accountId))
            {
                self.QueueSessionsDictionary.Remove(accountId);
            }
        }


    }

}
