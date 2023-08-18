using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using System.Text;

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

    public  class GameObjectPoolComponent : Entity, IAwake, IDestroy
    {
        public static GameObjectPoolComponent Instance;
        public List<GameObjectLoad> LoadingList = new List<GameObjectLoad> ();

        public Dictionary<int, GameObject> PlayerObjects = new Dictionary<int, GameObject> ();
        public Dictionary<string, List<GameObject>> ExternalReferences = new Dictionary<string, List<GameObject>>();

        public long Timer;
    }

    public class GameObjectPoolComponentAwakeSystem : AwakeSystem<GameObjectPoolComponent>
    {
        public override void Awake(GameObjectPoolComponent self)
        {
            self.LoadingList.Clear (); 
            self.ExternalReferences.Clear();
            GameObjectPoolComponent.Instance = self;
        }
    }

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

            int number = Math.Max(self.LoadingList.Count - 4, 0);
            for (int i = self.LoadingList.Count - 1; i>= number; i-- )
            {
                GameObjectLoad load = self.LoadingList[i];
                self.LoadingList.RemoveAt(i);
                self.LoadGameObject(load).Coroutine();
            }
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

        public static void AddPlayerGameObject(this GameObjectPoolComponent self, int occ, GameObject gameObject)
        {
            if (!self.PlayerObjects.ContainsKey(occ))
            {
                self.PlayerObjects.Add(occ, gameObject);
            }
        }

        public static void AddPlayerLoad(this GameObjectPoolComponent self, int occ, string path, long formId, Action<GameObject, long> action)
        {
            if (self.CheckHaveCache(path, formId, action))
            {
                return;
            }

            GameObject gameObject = null;
            self.PlayerObjects.TryGetValue(occ, out gameObject);
            if (gameObject != null)
            {
                action(GameObject.Instantiate(gameObject), formId);
                return;
            }
            self.AddLoadQueue(path, formId, action);
        }

        public static bool CheckHaveCache(this GameObjectPoolComponent self, string path, long formId, Action<GameObject, long> action)
        {
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
                if (poolGameObjects.Count > 0)
                {
                    action(poolGameObjects[0], formId);
                    poolGameObjects.RemoveAt(0);
                    return true;
                }
            }

            return false;
        }

        public static void AddLoadQueue(this GameObjectPoolComponent self,  string path, long formId, Action<GameObject, long> action)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            if (self.CheckHaveCache(path, formId, action))
            {
                return;
            }
 
            GameObjectLoad load = self.AddChild<GameObjectLoad>();
            load.Path = path;
            load.FormId = formId;
            load.LoadHandler = action;
            self.LoadingList.Insert(0, load);
            self.AddTimer();
        }

        public static void RecoverGameObject(this GameObjectPoolComponent self, string path, GameObject gameObject, bool active = false)
        {
            if (string.IsNullOrEmpty(path) || gameObject == null)
            {
                return;
            }
            if (SettingHelper.UsePool)
            {
                if (!self.ExternalReferences.ContainsKey(path))
                {
                    self.ExternalReferences[path] = new List<GameObject>();
                }
                self.ExternalReferences[path].Add(gameObject);
                gameObject.SetActive(active);
                gameObject.transform.SetParent(GlobalComponent.Instance.Pool);
                if (self.ExternalReferences[path].Count > 300)
                {
                    Log.Error($"GameObjectPoolError: {path}:  count:{self.ExternalReferences[path].Count}");
                }
            }
            else
            {
                GameObject.Destroy(gameObject);
            }
        }

        public static void AddTimer(this GameObjectPoolComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.GameObjectPoolTimer, self);
            }
        }

        public static  string ToString2(this GameObjectPoolComponent self)
        {
            StringBuilder sb = new StringBuilder();

            List<string> paths = self.ExternalReferences.Keys.ToList();
            for (int i = paths.Count - 1; i >= 0; i--)
            {
                List<GameObject> gameObjects;
                self.ExternalReferences.TryGetValue(paths[i], out gameObjects);
                if (gameObjects == null)
                {
                    continue;
                }

                sb.Append($"{paths[i]}:{gameObjects.Count}");
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public static void DisposeAll(this GameObjectPoolComponent self)
        {
            List<int> texttures =  self.PlayerObjects.Keys.ToList();
            for (int i = texttures.Count - 1; i >= 0; i--)
            {
                GameObject.Destroy(self.PlayerObjects[texttures[i]]);
            }
            self.PlayerObjects.Clear();

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

            Resources.UnloadUnusedAssets();
            GC.Collect();
        }

    }
}
