using System.Collections.Generic;

namespace ET
{

    //[BsonIgnore]该标签用来禁止字段序列化，不保存数据库也不查询，即忽略。
    //[BsonElement] 字段加上该标签，即使是private字段也会序列化(默认只序列化public字段)，该标签还可以带一个string参数，给字段序列化指定别名。
    public class TitleComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {
#if SERVER
        [BsonIgnore]
#endif

        public List<KeyValuePairInt> TitleList = new List<KeyValuePairInt>();   
    }
}
