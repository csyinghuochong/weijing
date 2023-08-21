using System.Collections.Generic;

namespace ET
{
    public class UnionSceneComponent : Entity, IAwake
    {
        public long Timer;

        public long WinUnionId;

        public long UnionRaceSceneId;
        public long UnionRaceSceneInstanceId;

        public DBUnionManager DBUnionManager = new DBUnionManager();

        public Dictionary<long, List<long>> UnionRaceUnits = new Dictionary<long, List<long>>();

        public Dictionary<long, long> UnionBossList = new Dictionary<long, long>(); 

        public Dictionary<long, long> UnionFubens = new Dictionary<long, long>();   //fubenid->fubeninstanceid
    }
}
