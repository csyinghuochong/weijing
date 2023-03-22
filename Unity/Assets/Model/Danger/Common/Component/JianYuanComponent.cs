using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class JianYuanComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {

        public List<JianYuanPlant> JianYuanPlants = new List<JianYuanPlant>();

#if !SERVER
        public int CellIndex = 0;
#endif
    }
}
