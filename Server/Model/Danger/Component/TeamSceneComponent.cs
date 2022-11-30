using System.Collections.Generic;

namespace ET
{
    public class TeamSceneComponent : Entity, IAwake
    {

        public List<TeamInfo> TeamList = new List<TeamInfo>();

        public M2C_TeamUpdateResult m2C_TeamUpdateResult = new M2C_TeamUpdateResult();  

        public T2M_TeamUpdateRequest t2M_TeamUpdateRequest = new T2M_TeamUpdateRequest();

    }
}
