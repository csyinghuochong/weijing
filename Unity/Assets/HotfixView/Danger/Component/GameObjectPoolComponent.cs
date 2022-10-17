using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace ET
{

    public class GameObjectLoad : Entity, IAwake
    {
        public string Path;
        public long FormId;
        public Action<GameObject, long> LoadHandler;
    }

    [Timer(TimerType.GameObjectPoolTimer)]
    public class GameObjectPoolTimer : ATimer<GameObjectPoolComponent>
    {
        public override void Run(GameObjectPoolComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public  class GameObjectPoolComponent : Entity, IAwake, IDestroy
    {
        public long LoadingLimit;
        public static GameObjectPoolComponent Instance;
        public List<GameObjectLoad> LoadingList = new List<GameObjectLoad> ();
        public Dictionary<string, List<GameObject>> ExternalReferences = new Dictionary<string, List<GameObject>>();

        public long Timer;
    }

    [ObjectSystem]
    public class GameObjectPoolComponentAwakeSystem : AwakeSystem<GameObjectPoolComponent>
    {
        public override void Awake(GameObjectPoolComponent self)
        {
            self.LoadingList.Clear (); 
            self.ExternalReferences.Clear();
            GameObjectPoolComponent.Instance = self;
            self.LoadingLimit = GlobalHelp.IsEditorMode ? 200 : 100;
        }
    }

    [ObjectSystem]
    public class GameObjectPoolComponentDestroySystem : DestroySystem<GameObjectPoolComponent>
    {
        public override void Destroy(GameObjectPoolComponent self)
        {
            self.ExternalReferences.Clear();
            TimerComponent.Instance?.Remove(ref  self.Timer);
        }
    }

    public static class GameObjectPoolComponentSystem
    {
        public static void OnUpdate(this GameObjectPoolComponent self)
        {
            if (self.LoadingList.Count == 0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }
            GameObjectLoad load = self.LoadingList[0];
            self.LoadingList.RemoveAt (0);
            self.GetExternal_2(load).Coroutine();
        }

        public static async ETTask GetExternal_2(this GameObjectPoolComponent self, GameObjectLoad load)
        {
            string path = load.Path;
            if (self.ExternalReferences.ContainsKey(path))
            {
                List<GameObject> gameObjects = self.ExternalReferences[path];
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
            if (!self.ExternalReferences.ContainsKey(path) || self.ExternalReferences[path].Count == 0)
            {
                GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                gobjet = GameObject.Instantiate(prefab);
            }
            else
            {
                gobjet = self.ExternalReferences[path][0];
                self.ExternalReferences[path].RemoveAt(0);
            }
            load.LoadHandler(gobjet, load.FormId);
            load.Dispose();
        }

        public static void AddLoadQueue(this GameObjectPoolComponent self,  string path, long formId, Action<GameObject, long> action)
        {
            GameObjectLoad load = self.AddChild<GameObjectLoad>();
            load.Path = path;
            load.FormId = formId;
            load.LoadHandler = action;
            self.LoadingList.Add(load);
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.GameObjectPoolTimer, self);
            }
        }

        public static async ETTask<GameObject> GetExternalAsync(this GameObjectPoolComponent self, string path)
        {
            if (self.ExternalReferences.ContainsKey(path))
            {
                List<GameObject> gameObjects = self.ExternalReferences[path];
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
            if (!self.ExternalReferences.ContainsKey(path) || self.ExternalReferences[path].Count == 0)
            {
                GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                gobjet = GameObject.Instantiate(prefab);
                return gobjet;
            }
            gobjet = self.ExternalReferences[path][0];
            self.ExternalReferences[path].RemoveAt(0);
            return gobjet;
        }

        public static  GameObject GetExternal(this GameObjectPoolComponent self, string path)
        {
            if (self.ExternalReferences.ContainsKey(path))
            {
                List<GameObject> gameObjects = self.ExternalReferences[path];
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
            if (!self.ExternalReferences.ContainsKey(path) || self.ExternalReferences[path].Count == 0)
            {
                GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                gobjet = GameObject.Instantiate(prefab);
                return gobjet;
            }
            gobjet = self.ExternalReferences[path][0];
            self.ExternalReferences[path].RemoveAt(0);
            return gobjet;
        }

        public static void DisposeAll(this GameObjectPoolComponent self)
        {
            List<string> paths = self.ExternalReferences.Keys.ToList();
            for (int i = paths.Count - 1; i >= 0; i--)
            {
                List<GameObject> gameObjects;
                self.ExternalReferences.TryGetValue(paths[i], out gameObjects);
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
                self.ExternalReferences.Remove(paths[i]);
            }
        }

        public static void InternalPut(this GameObjectPoolComponent self, string path, GameObject gameObject)
        {
            if (!self.ExternalReferences.ContainsKey(path))
            {
                self.ExternalReferences[path] = new List<GameObject>();
            }
            self.ExternalReferences[path].Add(gameObject);
            UICommonHelper.SetParent(gameObject, GlobalComponent.Instance.Pool.gameObject);
        }
    }
}
