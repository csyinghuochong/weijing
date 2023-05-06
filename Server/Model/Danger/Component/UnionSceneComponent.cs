using System.Collections.Generic;

namespace ET
{
    public class UnionSceneComponent : Entity, IAwake
    {
        public long Timer;

        public long BossTimer;

        public long RaceTimer;

        public long WinUnionId;

        public Scene UnionRaceScene;

        public DBUnionManager DBUnionManager = new DBUnionManager();

        public Dictionary<long, long> UnionBossList = new Dictionary<long, long>(); 

        public Dictionary<long, long> UnionFubens = new Dictionary<long, long>();   //fubenid->fubeninstanceid
    }
}
