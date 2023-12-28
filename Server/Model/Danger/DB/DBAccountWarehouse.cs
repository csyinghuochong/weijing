using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    [BsonIgnoreExtraElements]
    public class DBAccountWarehouse : Entity
    {
        public List<BagInfo> BagInfoList = new List<BagInfo>();

        public int HaveItemById(long bagInfoId)
        {
            for (int i = 0; i < BagInfoList.Count; i++)
            {
                if (BagInfoList[i].BagInfoID == bagInfoId)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
