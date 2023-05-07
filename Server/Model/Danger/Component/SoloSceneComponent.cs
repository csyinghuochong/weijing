using System.Collections.Generic;

namespace ET
{
    public class SoloSceneComponent : Entity, IAwake
    {
        public long SoloTimer;      

        public List<SoloPlayerInfo> MatchList = new List<SoloPlayerInfo>();

        public Dictionary<long, SoloResultInfo> SoloResult = new Dictionary<long, SoloResultInfo>();

        public M2C_SoloMatchResult m2C_SoloMatchResult = new M2C_SoloMatchResult();
    }
}
