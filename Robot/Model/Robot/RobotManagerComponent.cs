using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class RobotManagerComponent: Entity, IAwake
    {
        public int ZoneIndex;

        public Dictionary<int, int> RobotNumber = new Dictionary<int, int>();

        public Dictionary<long, long> TeamRobot = new Dictionary<long, long>(); 
    }
}