using System.Collections.Generic;

namespace ET
{
    public class FubenCenterComponent : Entity, IAwake
    {
        public List<long> FubenInstanceList = new List<long>();
        public ServerInfo ServerInfo;
    }
}
