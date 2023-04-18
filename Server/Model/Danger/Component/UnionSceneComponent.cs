using System.Collections.Generic;

namespace ET
{
    public class UnionSceneComponent : Entity, IAwake
    {
        public long Timer;
        public Dictionary<long, DBUnionInfo> UnionList = new Dictionary<long, DBUnionInfo>();
    }
}
