using System.Collections.Generic;

namespace ET
{
    public class LRUComponent : Entity, IAwake<int>, IDestroy
    {
        public Dictionary<long, LRUCacheNode> LruCacheNodes;
        public Pool<LRUCacheNode> CacheNodePool;
        public int LRUCapacity;
        public LRUCacheNode HeadCacheNode;
        public LRUCacheNode TailCacheNode;
    }
}