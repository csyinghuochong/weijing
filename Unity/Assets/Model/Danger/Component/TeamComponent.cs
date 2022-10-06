using System.Collections.Generic;

namespace ET
{
    public class TeamComponent : Entity, IAwake
    {
        public bool FubenOpen = false;

        public List<TeamInfo> TeamList = new List<TeamInfo>();

        public List<TeamPlayerInfo> ApplyList = new List<TeamPlayerInfo>();
    }
}
