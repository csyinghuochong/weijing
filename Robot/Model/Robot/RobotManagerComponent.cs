using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class RobotManagerComponent: Entity, IAwake
    {
        public int ZoneIndex;
        public Dictionary<int, int> RobotList = new Dictionary<int, int>();
    }
}