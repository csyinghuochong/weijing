using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

#if SERVER
    public class SeasonComponent : Entity, IAwake, ITransfer, IUnitCache
#else
    public class SeasonComponent : Entity, IAwake
    #endif
    { 
        


    }
}