
using System;
using System.Collections.Generic;

namespace ET
{
    public class SkillDispatcherComponent : Entity, IAwake, IDestroy, ILoad
    {
        public static SkillDispatcherComponent Instance;
        public Dictionary<string, Type> SkillTypes = new Dictionary<string, Type>();
    }
}
