using System.Collections.Generic;

namespace ET
{
    public class SoloSceneComponent : Entity, IAwake
    {
        public long SoloTimer;      

        public List<SoloPlayerInfo> MatchList = new List<SoloPlayerInfo>();         //竞技场匹配列表

        public Dictionary<long, SoloMatchInfo> MatchResult = new Dictionary<long, SoloMatchInfo>();

        public M2C_SoloMatchResult m2C_SoloMatchResult = new M2C_SoloMatchResult();
    }
}
