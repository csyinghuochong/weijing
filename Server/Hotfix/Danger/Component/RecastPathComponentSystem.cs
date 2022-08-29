using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public class RecastPathAwakeSystem : AwakeSystem<RecastPathComponent>
    {
        public override void Awake(RecastPathComponent self)
        {
            self.Awake();
        }
    }

    public class RecastPathLoadSystem : LoadSystem<RecastPathComponent>
    {
        public override void Load(RecastPathComponent self)
        {
            self.OnLoad();
        }
    }

    public  static class RecastPathComponentSystem
    {
        public static void OnLoad(this RecastPathComponent self)
        {
            List<int> maps = self.m_RecastPathProcessorDic.Keys.ToList();

            //卸载旧场景
            for (int i = 0; i < maps.Count; i++)
            {
                self.UnLoadMapNavData( maps[i] );
            }

            //加载新场景
            for (int i = 0; i < maps.Count; i++)
            {
                self.Update(maps[i]);
            }
        }

        public static void OnLoadSingle(this RecastPathComponent self, int mapId)
        {
            if (!self.m_RecastPathProcessorDic.ContainsKey(mapId))
            {
                return;
            }
            self.UnLoadMapNavData(mapId);
            self.Update(mapId);
        }
    }
}
