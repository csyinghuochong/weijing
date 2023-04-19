
using System.Collections.Generic;

namespace ET
{

    public static class GuideTriggerType
    {
        public const int OpenUI = 1;
        public const int EnterFuben = 2;
        public const int AcceptTask = 3;
        public const int CommitTask = 4;
        public const int DropItem   = 5;
    }
    
    public static class GuideActionType
    {
        public const int Button = 1;
        public const int NpcTalk = 2;
    }

    public class GuideInfo : Entity, IAwake<int>
    {
        public int Step = 0;
        public int GuideId;
        public List<int> Ids = new List<int>();
        public GuideConfig GuideConfig { get { return GuideConfigCategory.Instance.Get(this.GuideId); } }
    }
}
