using System;
using System.Collections.Generic;

namespace ET
{
    public class DBCacheComponentAwakeSystem : AwakeSystem<DBCacheComponent>
    {
        public override void Awake(DBCacheComponent self)
        {
            self.UnitCacheKeyList.Clear();
            foreach (Type type in Game.EventSystem.GetTypes().Values)
            {
                if (type != typeof(IUnitCache) && typeof(IUnitCache).IsAssignableFrom(type))
                {
                    self.UnitCacheKeyList.Add(type.Name);
                }
            }

            foreach (string key in self.UnitCacheKeyList)
            {
                UnitCache unitCache = self.AddChild<UnitCache>();
                unitCache.key = key;
                self.UnitCaches.Add(key, unitCache);
            }
        }
    }

    public static class DBCacheComponentSystem
    {
        public static async ETTask<Entity> Get(this DBCacheComponent self, long unitId, string key)
        {
            if (!self.UnitCaches.TryGetValue(key, out UnitCache unitCache))
            {
                unitCache = self.AddChild<UnitCache>();
                unitCache.key = key;
                self.UnitCaches.Add(key, unitCache);
            }
            return await unitCache.Get(unitId);
        }

        public static async ETTask<T> Get<T>(this DBCacheComponent self, long unitId) where T : Entity
        {
            string key = typeof(T).Name;

            if (!self.UnitCaches.TryGetValue(key, out UnitCache unitCache))
            {
                unitCache = self.AddChild<UnitCache>();
                unitCache.key = key;
                self.UnitCaches.Add(key, unitCache);
            }
            return await unitCache.Get(unitId) as T;
        }

        public static void Delete(this DBCacheComponent self, long unitId)
        {
            foreach (UnitCache cache in self.UnitCaches.Values)
            {
                cache.Delete(unitId);
            }
        }

        public static async ETTask AddOrUpdate(this DBCacheComponent self, long id, Entity entity)
        {
            string key = entity.GetType().Name;
            if (!self.UnitCaches.TryGetValue(key, out UnitCache unitCache))
            {
                unitCache = self.AddChild<UnitCache>();
                unitCache.key = key;
                self.UnitCaches.Add(key, unitCache);
            }
            unitCache.AddOrUpdate(entity);
            await Game.Scene.GetComponent<DBComponent>().Save(self.DomainZone(), id, entity);
        }

        public static async ETTask AddOrUpdate(this DBCacheComponent self, long id, ListComponent<Entity> entityList)
        {
            using (ListComponent<Entity> list = ListComponent<Entity>.Create())
            {
                foreach (Entity entity in entityList)
                {
                    string key = entity.GetType().Name;
                    if (!self.UnitCaches.TryGetValue(key, out UnitCache unitCache))
                    {
                        unitCache = self.AddChild<UnitCache>();
                        unitCache.key = key;
                        self.UnitCaches.Add(key, unitCache);
                    }
                    unitCache.AddOrUpdate(entity);
                    list.Add(entity);
                }
                if (list.Count > 0)
                {
                    await Game.Scene.GetComponent<DBComponent>().Save(self.DomainZone(), id, list);
                }
            }
        }
    }
}