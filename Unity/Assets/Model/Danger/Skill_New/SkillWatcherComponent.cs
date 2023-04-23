using System;
using System.Collections.Generic;

namespace ET
{
    public interface ISkillWatcher
    {
        void Run(SkillEvent skillEvent, EventType.SkillEventType args);
    }

    public class SkillWatcherAttribute : BaseAttribute
    {

        public ESkillEventType SkillEventType { get; }

        public SkillWatcherAttribute(ESkillEventType eventType)
        {
            this.SkillEventType = eventType;
        }
    }

    public class SkillWatcherComponent : Entity, IAwake, ILoad
    {
        public static SkillWatcherComponent Instance { get; set; }

        public Dictionary<ESkillEventType, List<ISkillWatcher>> allWatchers;
    }
}
