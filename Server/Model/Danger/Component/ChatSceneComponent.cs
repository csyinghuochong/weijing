using System.Collections.Generic;

namespace ET
{


    public class ChatSceneComponent : Entity, IAwake
    {
        //全服玩家GateSessionActorId
        public List<ChatUnitInfo> WordActorList = new List<ChatUnitInfo>();
    }
}
