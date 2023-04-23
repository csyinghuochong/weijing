using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ObjectSystem]
    public class SkillEventAwake : AwakeSystem<SkillEvent, SkillConfig>
    {
        public override void Awake(SkillEvent self, SkillConfig skillConfig)
        {
            self.EventTriggerTime = TimeHelper.ServerNow() + 1000;
        }
    }

    public static class SkillEventSystem
    {
    }
}
