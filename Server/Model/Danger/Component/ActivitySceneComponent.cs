using System.Collections.Generic;

namespace ET
{
    /// <summary>
    /// 活动中心服
    /// </summary>
    public class ActivitySceneComponent : Entity, IAwake, IDestroy
    {
        //map进程ID，用来给进程广播消息，以后可能需要拆分出去
        public List<long> MapIdList = new List<long>();

        public DBDayActivityInfo DBDayActivityInfo;

        public long Timer;

        public bool OnBattleOpen;

        public bool OnBattleClose;
    }
}
