using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    public static class SkillTimelineComponentSystem
    {

        private static void Remove(this SkillTimelineComponent self, long id)
        {
            if (!self.Children.TryGetValue(id, out Entity skillEvent))
            {
                return;
            }

            skillEvent.Dispose();
        }

        public static void InitEvents(this SkillTimelineComponent self)
        {
            //初始化技能事件列表
            //for (int i = 0; i < self.SkillConfig.BuffID.Length; i++)
            {
                self.AddChild<SkillEvent, SkillConfig>(self.SkillConfig);
            }
        }

        /// <summary>
        /// 固定帧驱动，创建技能事件
        /// </summary>
        /// <param name="self"></param>
        public static void FixedUpdate(this SkillTimelineComponent self)
        {
            using (ListComponent<long> list = ListComponent<long>.Create())
            {
                long timeNow = TimeHelper.ServerNow();
                foreach (var item in self.Children)
                {
                    long key = item.Key;
                    Entity value = item.Value;

                    SkillEvent skillEvent = (SkillEvent)value;

                    if (timeNow > skillEvent.EventTriggerTime)
                    {
                        //SkillWatcherComponent.Instance.Run(skillEvent, new SkillEventType() { skillEventType = skillEvent.SkillEventType, owner = skillEvent.Unit });
                        list.Add(key);
                    }
                }

                foreach (long id in list)
                {
                    self.Remove(id);
                }
            }
        }
    }
}
