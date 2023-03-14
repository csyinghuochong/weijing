using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class JiaYuanComponentSystem
    {

        public static void CreateNpc(this JiaYuanComponent self, int sceneId)
        {
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
            int[] npcs = sceneConfig.NpcList;
            if (npcs == null)
            {
                return;
            }
            for (int i = 0; i < npcs.Length; i++)
            {
                if (npcs[i] == 0)
                {
                    continue;
                }
                UnitFactory.CreateNpc(self.DomainScene(), npcs[i]);
            }
        }
    }
}
