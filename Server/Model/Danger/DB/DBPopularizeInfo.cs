using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBPopularizeInfo : Entity, IAwake
    {

        /// <summary>
        /// 我的推广码  前两位为区服 后六位为序号
        /// </summary>
        public long PopularizeCode;

        /// <summary>
        /// 我推广的人
        /// </summary>
        public long BePopularizeId;

        /// <summary>
        /// 我的推广人
        /// </summary>
        public List<PopularizeInfo> MyPopularizeList = new List<PopularizeInfo> { };
    }
}
