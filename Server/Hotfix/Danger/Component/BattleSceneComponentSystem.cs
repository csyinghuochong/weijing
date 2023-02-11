namespace ET
{
    public class BattleSceneComponentAwakeSystem : AwakeSystem<BattleSceneComponent>
    {
        public override void Awake(BattleSceneComponent self)
        {
              self.BattleInfos.Clear();
        }
    }

    public class BattleSceneComponentDestroySystem : DestroySystem<BattleSceneComponent>
    {
        public override void Destroy(BattleSceneComponent self)
        {
            self.BattleInfos.Clear();
        }
    }

    public static class BattleSceneComponentSystem
    {
        public static async ETTask OnBattleOver(this BattleSceneComponent self)
        {
            await TimerComponent.Instance.WaitAsync(60000);
            for (int i = 0; i < self.BattleInfos.Count;i++)
            {
                Scene scene = Game.Scene.Get(self.BattleInfos[i].FubenId);
                scene.GetComponent<BattleDungeonComponent>().OnBattleOver();
                await TimerComponent.Instance.WaitAsync(2000);
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
            self.BattleInfos.Clear();
        }

        public static BattleInfo GetBattleInstanceId(this BattleSceneComponent self, int sceneId)
        {
            BattleInfo battleInfo = null;
            int number = self.BattleInfos.Count;
            for(int i = 0; i < self.BattleInfos.Count; i++)
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
            fubnescene.AddComponent<BattleDungeonComponent>();
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.Battle, sceneId, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            fubnescene.AddComponent<YeWaiRefreshComponent>().SceneId = sceneId;
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonster);
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonsterPosi);
            battleInfo = new BattleInfo() { FubenId = fubenid, PlayerNumber = 0, FubenInstanceId = fubenInstanceId,SceneId = sceneId };
            self.BattleInfos.Add(battleInfo);
            return battleInfo;
        }
    }
}
