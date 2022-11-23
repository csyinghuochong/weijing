using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    [BsonIgnoreExtraElements]
    public class DBRankInfo : Entity
    {
        public List<RankPetInfo> rankingPets = new List<RankPetInfo>();     //宠物天梯
        public List<RankingInfo> rankingInfos = new List<RankingInfo>();    //战力排行
        public List<RankingInfo> rankingCamp1 = new List<RankingInfo>();    //正派
        public List<RankingInfo> rankingCamp2 = new List<RankingInfo>();    //邪派
    }
}
