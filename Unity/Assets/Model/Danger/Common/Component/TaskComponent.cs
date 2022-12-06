using System.Collections.Generic;

namespace ET
{
    public  class TaskComponent: Entity, IAwake, ITransfer, IDestroy, IUnitCache, IDeserialize
    {
        public List<int> ReceiveHuoYueIds = new List<int>();
        public List<TaskPro> TaskCountryList = new List<TaskPro>();
        public List<TaskPro> RoleTaskList = new List<TaskPro>();
        public List<TaskPro> CampTaskList = new List<TaskPro>();    //阵营狩猎
        public List<int> RoleComoleteTaskList = new List<int>();

        public M2C_TaskCountryUpdate m2C_TaskCountryUpdate = new M2C_TaskCountryUpdate();   
        public M2C_TaskUpdate M2C_TaskUpdate = new M2C_TaskUpdate();    
    }
}
