using System.Collections.Generic;
#if SERVER
using MongoDB.Bson.Serialization.Attributes;
#endif


namespace ET
{
#if SERVER
     public  class TaskComponent: Entity, IAwake, ITransfer, IDestroy, IUnitCache, IDeserialize
#else
    public class TaskComponent : Entity, IAwake
#endif
    {
        public int OnLineTime = 0;
        public List<int> ReceiveHuoYueIds = new List<int>();
        public List<TaskPro> TaskCountryList = new List<TaskPro>();
        public List<TaskPro> RoleTaskList = new List<TaskPro>();
        public List<int> RoleComoleteTaskList = new List<int>();

#if SERVER
        [BsonIgnore]
        public M2C_TaskCountryUpdate m2C_TaskCountryUpdate = new M2C_TaskCountryUpdate();
        [BsonIgnore]
        public M2C_TaskUpdate M2C_TaskUpdate = new M2C_TaskUpdate();
#endif
    }
}
