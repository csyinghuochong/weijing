using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBUnionManager : Entity, IAwake
    {
        /// <summary>
        /// 捐献榜
        /// </summary>
        public List<RankingInfo> rankingDonation = new List<RankingInfo>();   

        /// <summary>
        /// 报名家族
        /// </summary>
        public List<long> SignupUnions = new List<long> { };

        /// <summary>
        /// 总捐献
        /// </summary>
        public long TotalDonation = 0;

        /// <summary>
        /// 上周捐献
        /// </summary>
        public long LastWeakDonation = 0;

        /// <summary>
        /// 家族争霸赛次数
        /// </summary>
        public int UnionRaceTime = 0;

        /// <summary>
        /// 胜利家族
        /// </summary>
        public long WinUnionId;
    }
}
