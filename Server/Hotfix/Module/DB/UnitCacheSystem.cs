using System;
using System.Collections.Generic;

namespace ET
{
    [ObjectSystem]
    public class UnitCacheDestroySystem : DestroySystem<UnitCache>
    {
        public override void Destroy(UnitCache self)
        {
            foreach (Entity entity in self.CacheCompoenntsDictionary.Values)
            {
                entity.Dispose();
            }
            self.CacheCompoenntsDictionary.Clear();
            self.key = null;
        }
    }

    public static class UnitCacheSystem
    {
        public static void AddOrUpdate(this UnitCache self, Entity entity)
        {
            if (entity == null)
            {
                return;
            }

            if (self.CacheCompoenntsDictionary.TryGetValue(entity.Id, out Entity oldEntity))
            {
                if (entity != oldEntity)
                {
                    oldEntity.Dispose();
                }

                self.CacheCompoenntsDictionary.Remove(entity.Id);
            }

            if (entity.Id == 1853710032957407232)
            {
                Log.Warning($"{entity.Id}: {self.CacheCompoenntsDictionary.ContainsKey(entity.Id)} DBHelper SaveDB4444");
            }

            self.CacheCompoenntsDictionary.Add(entity.Id, entity);
        }

        public static async ETTask<Entity> Get(this UnitCache self, long unitId)
        {
            Entity entity = null;
            if (!self.CacheCompoenntsDictionary.TryGetValue(unitId, out entity))
            {
                entity = await Game.Scene.GetComponent<DBComponent>().Query<Entity>(self.DomainZone(), unitId, self.key);
                if (entity != null)
                {
                    self.AddOrUpdate(entity);
                }
            }

            if (entity.Id == 1853710032957407232)
            {
                Log.Warning($"{entity.Id}: {self.CacheCompoenntsDictionary.ContainsKey(entity.Id)} DBHelper GetDB");
            }

            return entity;
        }

        public static void Delete(this UnitCache self, long id)
        {
            if (self.CacheCompoenntsDictionary.TryGetValue(id, out Entity entity))
            {
                entity.Dispose();
                self.CacheCompoenntsDictionary.Remove(id);
            }
        }
    }
}