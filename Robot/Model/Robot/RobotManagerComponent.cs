using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class RobotManagerComponent: Entity, IAwake
    {
        public int ZoneIndex;

        public Dictionary<int, int> RobotNumber = new Dictionary<int, int>();

        public Dictionary<long, long> TeamRobot = new Dictionary<long, long>();

        /// <summary>已拉过机器人的区+战场图：key = zone*10000000L + sceneId</summary>
        public HashSet<long> BattleOpenRunningScenes = new HashSet<long>();
    }
}