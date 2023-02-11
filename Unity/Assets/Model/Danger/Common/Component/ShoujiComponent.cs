using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;
namespace ET
{

    public class ShoujiComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        public List<ShouJiChapterInfo> ShouJiChapterInfos = new List<ShouJiChapterInfo>();

        

        [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfArrays)]
        public Dictionary<int, int> ChapterStar = new Dictionary<int, int>();
    }
}
