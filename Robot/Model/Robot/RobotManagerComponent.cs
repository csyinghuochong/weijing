using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class RobotManagerComponent: Entity, IAwake
    {
        public int ZoneIndex;

        public Dictionary<int, int> RobotNumber = new Dictionary<int, int>();

        public Dictionary<long, long> TeamRobot = new Dictionary<long, long>();

        /// <summary>正在拉机器人的区（区内串行，区间并行）</summary>
        public HashSet<int> BattleOpenRunningZones = new HashSet<int>();
    }
}