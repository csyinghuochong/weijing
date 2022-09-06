using libx;
using System;
using UnityEngine;

namespace ET
{
    [ObjectSystem]
    public class ResourcesComponentAwakeSystem : AwakeSystem<ResourcesComponent>
    {
        public override void Awake(ResourcesComponent self)
        {
            self.Awake();
        }
    }

    public class LoadHandler
    {
        public Action<GameObject> LoadHandle;
        public string Path;
    }

    public class ResourcesComponent : Entity, IAwake
    {

        public static ResourcesComponent Instance { get; set; }
      
        public void Awake()
        {
            Instance = this;

        }
        #region Assets

        /// <summary>
        /// 加载资源，path需要是全路径
        /// </summary>
        /// <param name="path"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T LoadAsset<T>(string path) where T : UnityEngine.Object
        {
            AssetRequest assetRequest = libx.Assets.LoadAsset(path, typeof(T));
            return (T)assetRequest.asset;
        }

        /// <summary>
        /// 异步加载资源，path需要是全路径
        /// </summary>
        /// <param name="path"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async ETTask<T> LoadAssetAsync<T>(string path) where T : UnityEngine.Object
        {
            var tcs = ETTask<T>.Create();
            AssetRequest assetRequest = libx.Assets.LoadAssetAsync(path, typeof(T));

            //如果已经加载完成则直接返回结果（适用于编辑器模式下的异步写法和重复加载）,下面的API如果有需求可按照此格式添加相关代码
            if (assetRequest.isDone)
            {
                tcs.SetResult((T)assetRequest.asset);
                return await tcs;
            }

            //+=委托链，否则会导致前面完成委托被覆盖
            assetRequest.completed += (arq) => { tcs.SetResult((T)arq.asset); };
            return await tcs;
        }

        /// <summary>
        /// 卸载资源，path需要是全路径
        /// </summary>
        /// <param name="path"></param>
        public void UnLoadAsset(string path)
        {
            libx.Assets.UnloadAsset(path);
        }

        #endregion

        #region Scenes

        /// <summary>
        /// 预先加载场景
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ETTask<SceneAssetRequest> LoadSceneAdditive(string path)
        {
            ETTask<SceneAssetRequest> tcs = ETTask<SceneAssetRequest>.Create();

            SceneAssetRequest sceneAssetRequest = libx.Assets.LoadSceneAsync(path, true);
            sceneAssetRequest.completed = (arq) =>
            {
                tcs.SetResult(sceneAssetRequest);
            };
            return tcs;
        }

        /// <summary>
        /// 加载场景，path需要是全路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public  ETTask<SceneAssetRequest> LoadSceneAsync(string path)
        {
            ETTask<SceneAssetRequest> tcs = ETTask<SceneAssetRequest>.Create();

            SceneAssetRequest sceneAssetRequest = libx.Assets.LoadSceneAsync(path, false);

            Game.Scene.GetComponent<SceneManagerComponent>().SceneAssetRequest = sceneAssetRequest;

            sceneAssetRequest.completed = (arq) =>
            {
                tcs.SetResult(sceneAssetRequest);
            };
            return tcs;
        }

        /// <summary>
        /// 卸载场景，path需要是全路径
        /// </summary>
        /// <param name="path"></param>
        public void UnLoadScene(string path)
        {
            libx.Assets.UnloadScene(path);
        }

        public void RemoveUnUseScene()
        {
            libx.Assets.RemoveUnUseScene();
        }
        #endregion
    }
}