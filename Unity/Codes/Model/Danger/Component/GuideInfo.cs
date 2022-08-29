
using System.Collections.Generic;

namespace ET
{

    public static class GuideTriggerType
    {
        public const int GuideTriggerLevel = 1;
    }

    public class GuideInfo : Entity, IAwake<int>
    {
        public int Step = 0;
        public int GuideId;
        public List<int> Ids = new List<int>();
        public GuideConfig GuideConfig { get { return GuideConfigCategory.Instance.Get(this.GuideId); } }
    }
}
