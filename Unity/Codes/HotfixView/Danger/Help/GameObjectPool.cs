using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{

    public  class GameObjectPool : Singleton<GameObjectPool>
    {

        public Dictionary<string, List<GameObject>> ExternalReferences;

        public string UIBattleFly = "";


        protected override void InternalInit()
        {
            base.InternalInit();

            ExternalReferences = new Dictionary<string, List<GameObject>>();
            UIBattleFly = ABPathHelper.GetUGUIPath("Battle/UIBattleFly");
        }

        public async ETTask<GameObject> GetExternal(string path)
        {
            if (ExternalReferences.ContainsKey(path))
            {
                List<GameObject> gameObjects = ExternalReferences[path];
                for (int i = gameObjects.Count - 1; i >= 0; i--)
                {
                    if (gameObjects[i] == null)
                    {
                        gameObjects.RemoveAt(i);
                        ResourcesComponent.Instance.UnLoadAsset(path);
                    }
                }
            }
            GameObject gobjet;
            if (!ExternalReferences.ContainsKey(path) || ExternalReferences[path].Count == 0)
            {
                GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                gobjet = GameObject.Instantiate(prefab);
                return gobjet;
            }
            gobjet = ExternalReferences[path][0];
            ExternalReferences[path].RemoveAt(0);
            return gobjet;
        }

        public void DisposeAll()
        {
            List<string> paths = ExternalReferences.Keys.ToList();
            for (int i = paths.Count - 1; i >=0; i--)
            {
                List<GameObject> gameObjects;
                ExternalReferences.TryGetValue(paths[i], out gameObjects);
                if (gameObjects == null || gameObjects.Count == 0)
                {
                    continue;
                }
                for (int k = 0; k < gameObjects.Count; k++)
                {
                    if (gameObjects[k] != null)
                    {
                        GameObject.Destroy(gameObjects[k]);
                    }
                    ResourcesComponent.Instance.UnLoadAsset(paths[i]);
                }
                ExternalReferences.Remove(paths[i]);
            }
        }

        public void InternalPut(string path, GameObject gameObject)
        {
            if (!ExternalReferences.ContainsKey(path))
            {
                ExternalReferences[path] = new List<GameObject>();
            }
            ExternalReferences[path].Add(gameObject);
            UICommonHelper.SetParent(gameObject, GlobalComponent.Instance.Pool.gameObject);
        }

    }
}
