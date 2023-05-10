using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class GuideComponent : Entity, IAwake
    {
        public Dictionary<int, int> GuideInfoList = new Dictionary<int, int>();
        public Dictionary<int, GuideInfo> GuideInfoDict = new Dictionary<int, GuideInfo>();
    }
}
