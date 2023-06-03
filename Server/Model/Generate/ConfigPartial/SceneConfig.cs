using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public partial class SceneConfigCategory
    {

        public List<int> NpcIdList = new List<int>();

        public List<Vector3> NpcPosList = new List<Vector3>();

        public override void AfterEndInit()
        {
            foreach (SceneConfig sceneConfig in this.GetAll().Values)
            {
                if (sceneConfig.Id == 101)
                {
                    InitMainNpc(sceneConfig);
                }
            }
        }

        public void InitMainNpc(SceneConfig sceneConfig)
        {
            int[] npcids = sceneConfig.NpcList;
            for (int i = 0; i < npcids.Length; i++)
            {
                NpcIdList.Add(npcids[i]);

                NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcids[i]);
                NpcPosList.Add(new Vector3()
                {
                    x = npcConfig.Position[0] * 0.01f,
                    y = npcConfig.Position[1] * 0.01f,
                    z = npcConfig.Position[2] * 0.01f,
                });
            }
        }
    }
}