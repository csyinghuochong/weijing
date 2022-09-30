namespace ET
{
    public static class TokenComponentSystem
    {
        public static void Add(this TokenComponent self, long key, string token, bool queue = false)
        {
            self.TokenDictionary.Add(key, token);
            self.TimeOutRemoveKey(key, token, queue).Coroutine();
        }

        public static string Get(this TokenComponent self, long key)
        {
            string value = null;
            self.TokenDictionary.TryGetValue(key, out value);
            return value;
        }

        /// <summary>
        /// G2AExitGame
        /// </summary>
        /// <param name="self"></param>
        /// <param name="key"></param>
        public static void Remove(this TokenComponent self, long key)
        {
            if (self.TokenDictionary.ContainsKey(key))
            {
                self.TokenDictionary.Remove(key);
            }
        }

        private static async ETTask TimeOutRemoveKey(this TokenComponent self, long key, string tokenKey, bool queue = false)
        {
            await TimerComponent.Instance.WaitAsync(queue ? 6000000 : 600000);

            string onlineToken = self.Get(key);

            if (!string.IsNullOrEmpty(onlineToken) && onlineToken == tokenKey)
            {
                self.Remove(key);
            }
        }
    }
}