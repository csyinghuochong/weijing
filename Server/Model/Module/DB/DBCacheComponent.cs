using System;
using System.Collections.Generic;

namespace ET
{
    public class UnitCache : Entity, IAwake, IDestroy
    {
        public string key;

        public Dictionary<long, Entity> CacheCompoenntsDictionary = new Dictionary<long, Entity>();
    }

    /// <summary>
    /// 数据库缓存组件
    /// </summary>
    public class DBCacheComponent : Entity, IAwake, IDestroy
    {
        public Dictionary<string, UnitCache> UnitCaches = new Dictionary<string, UnitCache>();
        public List<string> UnitCacheKeyList = new List<string>();
    }
}