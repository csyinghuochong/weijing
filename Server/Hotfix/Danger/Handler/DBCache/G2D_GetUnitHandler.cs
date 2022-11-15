using System;
using System.Collections.Generic;

namespace ET
{
    public class G2D_GetUnitHandler : AMActorRpcHandler<Scene, G2D_GetUnit,D2G_GetUnit>
    {
        protected override async ETTask Run(Scene scene, G2D_GetUnit request, D2G_GetUnit response, Action reply)
        {
            DBCacheComponent unitCacheComponent = scene.GetComponent<DBCacheComponent>();
            Dictionary<string, Entity> dictionary = MonoPool.Instance.Fetch(typeof(Dictionary<string, Entity>)) as Dictionary<string, Entity>;
            try
            {
                //dictionary.Add(nameof(Unit), null);
                foreach (string s in unitCacheComponent.UnitCacheKeyList)
                {
                    dictionary.Add(s, null);
                }

                foreach (var key in dictionary.Keys)
                {
                    Entity entity = await unitCacheComponent.Get(request.UnitId, key);
                    dictionary[key] = entity;
                }

                response.ComponentNameList.AddRange(dictionary.Keys);
                response.EntityList.AddRange(dictionary.Values);
            }
            finally
            {
                dictionary.Clear();
                MonoPool.Instance.Recycle(dictionary);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}