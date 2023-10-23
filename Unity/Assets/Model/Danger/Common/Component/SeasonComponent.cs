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


        ////赛季主线任务. 在TaskComponent.RoleTaskList  

        /// 赛季每次任务. 在TaskComponent.TaskCountryList

        /// 开启的晶核位置，在userfo。 对应的装备在bagcomponent 类似于生肖系统

    }
}