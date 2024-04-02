using System.Collections.Generic;

namespace ET
{

    public class ChatInfoUnit : Entity, IAwake, IDestroy
    {
        public long LastSendChat;

        public long GateSessionActorId; //player.InstanceId

        public long UnionId;

        public string Name;

        public int Level;
    }

    public class BeReportedInfo
    {
        public long JinYanTime;
        public List<long> ReportedList = new List<long>();
    }

    public class ChatSceneComponent : Entity, IAwake, IDestroy
    {
        public long Timer;

        public List<WorldSayConfig> WordSayList = new List<WorldSayConfig> ();

        //全服玩家GateSessionActorId
        public Dictionary<long, ChatInfoUnit> ChatInfoUnitsDict = new Dictionary<long, ChatInfoUnit>();

        //世界列表记录
        public List<ChatInfo> WordChatInfos = new List<ChatInfo> ();    

        public Dictionary<long, BeReportedInfo> BeReportedNumber = new Dictionary<long, BeReportedInfo> ();   
    }
}
