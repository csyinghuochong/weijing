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
        public static BattleInfo GetBattleInstanceId(this BattleSceneComponent self, int sceneId)
        {
            int number = self.BattleInfos.Count;
            if (number > 0 && self.BattleInfos[number - 1].PlayerNumber < 40)
            {
                return self.BattleInfos[number - 1];
            }
            //动态创建副本
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, self.DomainZone(), "Battle" + fubenid.ToString(), SceneType.Fuben);
            BattleDungeonComponent teamDungeonComponent = fubnescene.AddComponent<BattleDungeonComponent>();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.Battle, sceneId, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            BattleInfo battleInfo = new BattleInfo() { PlayerNumber = 0, FubenInstanceId = fubenInstanceId };
            self.BattleInfos.Add(battleInfo);
            return battleInfo;
        }
    }
}
