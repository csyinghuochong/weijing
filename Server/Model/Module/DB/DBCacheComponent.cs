using System;
using System.Collections.Generic;

namespace ET
{
    public class UnitCache : Entity, IAwake, IDestroy
    {
        public string key;

        public Dictionary<long, Entity> CacheCompoenntsDictionary = new Dictionary<long, Entity>();     //玩家组件
    }

    /// <summary>
    /// 数据库缓存组件
    /// </summary>
    public class DBCacheComponent : Entity, IAwake, IDestroy
    {
        public long CurHourTime;                                                                         //每个小时
        public Dictionary<long, long> UnitCachesTime = new Dictionary<long, long>();                     //缓存时间
        public Dictionary<string, UnitCache> UnitCaches = new Dictionary<string, UnitCache>();           //组件字典
        public List<string> UnitCacheKeyList = new List<string>();
    }
}