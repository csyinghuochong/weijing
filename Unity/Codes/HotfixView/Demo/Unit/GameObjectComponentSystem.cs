using System;
using UnityEngine;

namespace ET
{
    public static class GameObjectComponentSystem
    {
        [ObjectSystem]
        public class GameObjectAwakeSystem : AwakeSystem<GameObjectComponent>
        {
            public override void Awake(GameObjectComponent self)
            {
                self.AssetsPath = "";
                self.Material = null;
            }
        }

        [ObjectSystem]
        public class GameObjectDestroySystem : DestroySystem<GameObjectComponent>
        {
            public override void Destroy(GameObjectComponent self)
            {
                self.GameObject.SetActive(false);
                if (string.IsNullOrEmpty(self.AssetsPath))
                {
                    UnityEngine.Object.Destroy(self.GameObject);
                }
                else
                {
                    GameObjectPool.Instance.InternalPut(self.AssetsPath, self.GameObject);
                }
            }
        }

        public static void OnHui(this GameObjectComponent self)
        {
            //self.Material = self.GameObject.GetComponentInChildren<SkinnedMeshRenderer>().materials[0];
            //self.Material.shader = Shader.Find("Custom/UI_Hui");
            Transform transform = self.GameObject.transform;
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).name == "RoleBoneSet")
                {
                    continue;
                }
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }


        public static void OnRevive(this GameObjectComponent self)
        {
            //if (self.Material != null)
            //{
            //    self.Material.shader = Shader.Find("Toon/BasicOutline");
            //}
            Transform transform = self.GameObject.transform;
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).name == "RoleBoneSet")
                {
                    continue;
                }
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}