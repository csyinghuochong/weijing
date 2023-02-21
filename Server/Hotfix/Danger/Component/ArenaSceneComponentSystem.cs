using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    public class ArenaSceneComponentAwake : AwakeSystem<ArenaSceneComponent>
    {
        public override void Awake(ArenaSceneComponent self)
        {
            self.BattleInfos.Clear();
        }
    }

    public class ArenaSceneComponentDestroy : DestroySystem<ArenaSceneComponent>
    {
        public override void Destroy(ArenaSceneComponent self)
        {
            self.BattleInfos.Clear();
        }
    }

    public static  class ArenaSceneComponentSystem
    {


        public static BattleInfo GetArenaInstanceId(this ArenaSceneComponent self, int sceneId)
        {
            BattleInfo battleInfo = null;
            int number = self.BattleInfos.Count;
            for (int i = 0; i < self.BattleInfos.Count; i++)
            {
                battleInfo = self.BattleInfos[i];
                if (battleInfo.SceneId != sceneId)
                {
                    continue;
                }
                if (battleInfo.PlayerNumber < ComHelp.GetPlayerLimit(sceneId))
                {
                    return battleInfo;
                }
            }

            //动态创建副本
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, self.DomainZone(), "Battle" + fubenid.ToString(), SceneType.Fuben);
            fubnescene.AddComponent<ArenaDungeonComponent>();
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.Arena, sceneId, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            fubnescene.AddComponent<YeWaiRefreshComponent>().SceneId = sceneId;
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonster);
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonsterPosi);
            battleInfo = new BattleInfo() { FubenId = fubenid, PlayerNumber = 0, FubenInstanceId = fubenInstanceId, SceneId = sceneId };
            self.BattleInfos.Add(battleInfo);
            return battleInfo;
        }

    }
}
