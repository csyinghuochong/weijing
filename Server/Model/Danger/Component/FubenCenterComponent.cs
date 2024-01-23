using System.Collections.Generic;

namespace ET
{


    public class FubenCenterComponent : Entity, IAwake
    {

        public List<long> FubenInstanceList = new List<long>();
        public Dictionary<int, long> YeWaiFubenList = new Dictionary<int, long>();
        public ServerInfo ServerInfo;

        /// <summary>
        /// 奔跑大赛
        /// </summary>
        public bool RunRaceOpen = false;    
        public Dictionary<long, List<long>> RunRacePlayerList = new Dictionary<long, List<long>>();

        /// <summary>
        /// 恶魔大赛
        /// </summary>
        public bool DemonOpen = false;
        public Dictionary<long, List<long>> DemonPlayerList = new Dictionary<long, List<long>>();
    }
}
