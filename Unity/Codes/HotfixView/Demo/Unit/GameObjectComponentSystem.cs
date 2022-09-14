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
                if (self.BaiTan != null)
                {
                    GameObjectPool.Instance.InternalPut(ABPathHelper.GetUnitPath("Player/BaiTan"), self.GameObject);
                }
                self.BaiTan = null;
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

        public static async ETTask OnUnitStallUpdate(this GameObjectComponent self,int stallType)
        {
            if (stallType == 0)
            {
                if (self.BaiTan != null)
                {
                    GameObjectPool.Instance.InternalPut(ABPathHelper.GetUnitPath("Player/BaiTan"), self.BaiTan);
                    self.BaiTan = null;
                }
                self.GameObject.transform.Find("BaseModel").gameObject.SetActive(true);
                return;
            }

            if (stallType == 1)
            {
                long instancid = self.InstanceId;
                if (self.BaiTan == null)
                {
                    self.BaiTan = await GameObjectPool.Instance.GetExternal(ABPathHelper.GetUnitPath("Player/BaiTan"));
                }
                self.BaiTan.SetActive(true);
                self.BaiTan.transform.position = self.GameObject.transform.position;
                self.GameObject.transform.Find("BaseModel").gameObject.SetActive(false);
            }
        }
    }
}