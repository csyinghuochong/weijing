using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class JianYuanComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {



#if !SERVER
        public int SelectIndex = 0;
#endif
    }
}
