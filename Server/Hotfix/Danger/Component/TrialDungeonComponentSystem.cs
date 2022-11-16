namespace ET
{
    public static class TrialDungeonComponentSystem
    {

        public static void GenerateFuben(this TrialDungeonComponent self)
        {
            int towerId = self.DomainScene().GetComponent<MapComponent>().SonSceneId;
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(towerId);
            FubenHelp.CreateMonsterList(self.DomainScene(), towerConfig.MonsterSet);
        }

    }
}
