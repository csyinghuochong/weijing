using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    
    public class RecastPathComponent : Entity, IAwake, ILoad
    {
        public const string Map1NavDataPath = "../Config/RecastNavData/1.bin";

        /// <summary>
        /// 寻路处理者（可用于拓展多线程，参考A*插件）
        /// key为地图id，value为具体处理者
        /// </summary>
        public Dictionary<int, RecastPathProcessor> m_RecastPathProcessorDic = new Dictionary<int, RecastPathProcessor>();

        /// <summary>
        /// 初始化寻路引擎
        /// </summary>
        public void Awake( )
        {
            RecastInterface.Init();

            Dictionary<int, SceneConfig> sceneConfigs = SceneConfigCategory.Instance.GetAll();
            foreach (var sceneConfig in sceneConfigs)
            {
                if (sceneConfig.Value.MapType != (int)SceneTypeEnum.MainCityScene
                    && sceneConfig.Value.MapType != (int)SceneTypeEnum.YeWaiScene)
                {
                    continue;
                }
                Update(sceneConfig.Value.MapID);
            }
        }

        /// <summary>
        /// 寻路
        /// </summary>
        public void SearchPath(int mapId, Vector3 from, Vector3 to, List<Vector3> result)
        {
            GetRecastPathProcessor(mapId).CalculatePath(from, to, result);
        }

        public RecastPathProcessor GetRecastPathProcessor(int mapId)
        {
            if (this.m_RecastPathProcessorDic.TryGetValue(mapId, out var recastPathProcessor))
            {
                return recastPathProcessor;
            }
            else
            {
                Log.Error($"未找到地图id为{mapId}的recastPathProcessor");
                return null;
            }
        }

        /// <summary>
        /// 加载一个Map的数据
        /// </summary>
        public void LoadMapNavData(int mapId, char[] navDataPath)
        {
            if (m_RecastPathProcessorDic.ContainsKey(mapId))
            {
                //Log.Warning($"已存在Id为{mapId}的地图Nav数据，请勿重复加载！");
                return;
            }

            if (RecastInterface.LoadMap(mapId, navDataPath))
            {
                RecastPathProcessor recastPathProcessor = this.domain.AddChild<RecastPathProcessor>();
                recastPathProcessor.MapId = mapId;
                m_RecastPathProcessorDic[mapId] = recastPathProcessor;
                Log.Info($"加载Id为{mapId}的地图Nav数据成功！");
            }
        }

        /// <summary>
        /// 卸载地图数据
        /// </summary>
        /// <param name="mapId">地图Id</param>
        public void UnLoadMapNavData(int mapId)
        {
            if (!m_RecastPathProcessorDic.ContainsKey(mapId))
            {
                //Log.Warning($"不存在Id为{mapId}的地图Nav数据，无法进行卸载！");
                return;
            }

            m_RecastPathProcessorDic[mapId].Dispose();
            m_RecastPathProcessorDic.Remove(mapId);
            if (RecastInterface.FreeMap(mapId))
            {
                Log.Info($"地图： {mapId}  释放成功");
            }
            else
            {
                Log.Info($"地图： {mapId}  释放失败");
            }
        }

        public override void Dispose()
        {
            m_RecastPathProcessorDic = new Dictionary<int, RecastPathProcessor>();
            if (this.IsDisposed)
            {
                return;
            }

            base.Dispose();
            //RecastInterface.Fini();
        }

        public void Update(int mapId)
        {
            string path = $"../Config/RecastNavData/{mapId}.bin";
            LoadMapNavData(mapId, path.ToCharArray());
        }
    }
}