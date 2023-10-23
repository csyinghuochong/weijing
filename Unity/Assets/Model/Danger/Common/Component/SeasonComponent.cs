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

        ///赛季任务 赛季晶核


        /// <summary>
        /// 赛季主线任务
        /// </summary>
        public List<TaskPro> MainTask = new List<TaskPro>();    


        /// <summary>
        /// 赛季每次任务
        /// </summary>
        public List<TaskPro> EverydayTask =new List<TaskPro>();


        /// <summary>
        /// 开启的晶核位置。 对应的装备在bagcomponent。  类似于生肖系统
        /// </summary>
        public List<int> OpenJingHeIds = new List<int>();   


    }
}