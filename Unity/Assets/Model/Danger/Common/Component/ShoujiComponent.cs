using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;
namespace ET
{

    public class ShoujiComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        /// <summary>
        /// 收集大厅
        /// </summary>
        public List<ShouJiChapterInfo> ShouJiChapterInfos = new List<ShouJiChapterInfo>();

        /// <summary>
        /// 珍宝
        /// </summary>
        public List<KeyValuePairInt> TreasureInfo = new List<KeyValuePairInt>();


        [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfArrays)]
        public Dictionary<int, int> ChapterStar = new Dictionary<int, int>();
    }
}
