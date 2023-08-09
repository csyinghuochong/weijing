using System;

namespace ET
{

    [ObjectSystem]
    public class SkillRangeBomb1ComponentAwake : AwakeSystem<SkillRangeBomb1Component>
    {
        public override void Awake(SkillRangeBomb1Component self)
        {

        }
    }

    [ObjectSystem]
    public class SkillRangeBomb1ComponentDestroy : DestroySystem<SkillRangeBomb1Component>
    {
        public override void Destroy(SkillRangeBomb1Component self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class SkillRangeBomb1ComponentSystem
    {

        public static void OnBaseInit(this SkillRangeBomb1Component self, SkillHandler skillHandler)
        {
            self.SkillHandler = skillHandler;
        }

        public static void OnUpdate(this SkillRangeBomb1Component self)
        {
            
           
        }
    }
}
