using System.Collections.Generic;

namespace ET
{

    public class ChatInfoUnit : Entity, IAwake, IDestroy
    {
        public long GateSessionActorId; //player.InstanceId

        public string Name;
    }

    public class ChatSceneComponent : Entity, IAwake, IDestroy
    {
        public long Timer;

        public List<WorldSayConfig> WordSayList = new List<WorldSayConfig> ();

        //全服玩家GateSessionActorId
        public Dictionary<long, ChatInfoUnit> ChatInfoUnitsDict = new Dictionary<long, ChatInfoUnit>();
    }
}
