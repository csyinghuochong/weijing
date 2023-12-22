namespace ET
{
    public class PetMingDungeonComponent : Entity, IAwake, IDestroy
    {

        public int MineType;
        public int Position;

        /// <summary>
        /// 挑战者的队伍
        /// </summary>
        public int TeamId;

        public Unit MainUnit;
        public long Timer;

        public int CombatResultEnum;

        public long EnemyId;
    }
}