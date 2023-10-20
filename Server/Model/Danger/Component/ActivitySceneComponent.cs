using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 活动中心服
    /// </summary>
    public class ActivitySceneComponent : Entity, IAwake, IDestroy
    {
        public long ActivityTimer;
        public List<ActivityTimer> ActivityTimerList = new List<ActivityTimer>();

        //map进程ID，用来给进程广播消息，以后可能需要拆分出去
        public List<long> MapIdList = new List<long>();

        public DBDayActivityInfo DBDayActivityInfo;

        public Dictionary<int, List<KeyValuePair<long, long>>> TurtleSupportList = new Dictionary<int, List<KeyValuePair<long, long>>>();

        public long Timer;

        public List<PetMingPlayerInfo> PetMingList = new List<PetMingPlayerInfo>();
        public long PetMingLastTime = 0;

        public int CheckIndex = 0;
    }
}
