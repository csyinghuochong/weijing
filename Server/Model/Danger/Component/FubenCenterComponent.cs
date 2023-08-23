using System.Collections.Generic;

namespace ET
{


    public class FubenCenterComponent : Entity, IAwake
    {
        /// <summary>
        /// 
        /// </summary>
        //public List<BattleInfo> RunRaceSeneList = new List<BattleInfo>();

        public List<long> FubenInstanceList = new List<long>();
        public Dictionary<int, long> YeWaiFubenList = new Dictionary<int, long>();
        public ServerInfo ServerInfo;
    }
}
