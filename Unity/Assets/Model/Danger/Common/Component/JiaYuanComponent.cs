using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class JiaYuanComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {

        public List<JiaYuanPlant> JianYuanPlants = new List<JiaYuanPlant>();

#if !SERVER
        public int CellIndex = 0;
#endif
    }
}
