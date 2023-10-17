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
        public List<RankingInfo> rankSoloInfo = new List<RankingInfo>();    //solo
        public List<RankShouLieInfo> rankShowLie = new List<RankShouLieInfo>(); //狩猎
        public List<RankShouLieInfo> rankUnionRace = new List<RankShouLieInfo>();//家族战
        public List<RankingInfo> rankRunRace = new List<RankingInfo>();     //奔跑大赛
        public List<RankingInfo> rankingDemon = new List<RankingInfo>();     //恶魔活动
        public List<KeyValuePairLong> rankingTrial = new List<KeyValuePairLong>();   //试炼副本伤害排行
    }
}
