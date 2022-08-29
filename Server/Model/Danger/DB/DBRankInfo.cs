using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    [BsonIgnoreExtraElements]
    public class DBRankInfo : Entity
    {
        public int RankType = 1;
        public List<RankPetInfo> rankingPets = new List<RankPetInfo>();
        public List<RankingInfo> rankingInfos = new List<RankingInfo>();
        public List<RankingInfo> rankingCamp1 = new List<RankingInfo>();    //正派
        public List<RankingInfo> rankingCamp2 = new List<RankingInfo>();    //正派
    }
}
