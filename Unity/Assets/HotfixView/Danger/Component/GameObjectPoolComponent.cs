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
            self.LoadGameObject(load).Coroutine();
        }

        public static async ETTask LoadGameObject(this GameObjectPoolComponent self, GameObjectLoad load)
        {
            string path = load.Path;
            GameObject gobjet = null;
            List<GameObject> poolGameObjects = null;
            self.ExternalReferences.TryGetValue(path, out poolGameObjects);
            if (poolGameObjects !=null )
            {
                for (int i = poolGameObjects.Count - 1; i >= 0; i--)
                {
                    if (poolGameObjects[i] == null)
                    {
                        poolGameObjects.RemoveAt(i);
                    }
                }
            }
            if (poolGameObjects == null || poolGameObjects.Count == 0)
            {
                GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                if (prefab == null)
                {
                    Log.Error($"GameObjectPool1 : prefab == null {path}");
                    return;
                }
                gobjet = GameObject.Instantiate(prefab);
            }
            else
            {
                gobjet = poolGameObjects[0];
                poolGameObjects.RemoveAt(0);
            }
            load.LoadHandler(gobjet, load.FormId);
            load.Dispose();
        }

        public static void AddLoadQueue(this GameObjectPoolComponent self,  string path, long formId, Action<GameObject, long> action)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            List<GameObject> poolGameObjects = null;
            self.ExternalReferences.TryGetValue(path, out poolGameObjects);
            if (poolGameObjects != null)
            {
                for (int i = poolGameObjects.Count - 1; i >= 0; i--)
                {
                    if (poolGameObjects[i] == null)
                    {
                        poolGameObjects.RemoveAt(i);
                    }
                }
                if ( poolGameObjects.Count > 0)
                {
                    action(poolGameObjects[0], formId);
                    poolGameObjects.RemoveAt(0);
                    return;
                }
            }
 
            GameObjectLoad load = self.AddChild<GameObjectLoad>();
            load.Path = path;
            load.FormId = formId;
            load.LoadHandler = action;
            self.LoadingList.Add(load);
            self.AddTimer();
        }

        public static void RecoverGameObject(this GameObjectPoolComponent self, string path, GameObject gameObject, bool active = false)
        {
            if (string.IsNullOrEmpty(path) || gameObject == null)
            {
                return;
            }
            if (!self.ExternalReferences.ContainsKey(path))
            {
                self.ExternalReferences[path] = new List<GameObject>();
            }
            self.ExternalReferences[path].Add(gameObject);
            gameObject.SetActive(active);
            UICommonHelper.SetParent(gameObject, GlobalComponent.Instance.Pool.gameObject);
        }

        public static void AddTimer(this GameObjectPoolComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.GameObjectPoolTimer, self);
            }
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

    }
}
