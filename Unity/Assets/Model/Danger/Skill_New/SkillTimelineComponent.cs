using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class SkillTimelineComponent : Entity, IAwake
    {
        public Unit Unit;

        public long StartSpellTime;
        public SkillConfig SkillConfig;
    }
}
