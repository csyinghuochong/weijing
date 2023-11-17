using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.BuffScaleTimer)]
    public class BuffScaleTimer : ATimer<BuffScaleComponet>
    {
        public override void Run(BuffScaleComponet self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class BuffScaleComponetDestroy : DestroySystem<BuffScaleComponet>
    {
        public override void Destroy(BuffScaleComponet self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class BuffScaleComponetSystem
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="skillBuff"></param>
        /// <param name="operateType">1缩放  2回退 </param>
        public static void OnBuffScale(this BuffScaleComponet self, SkillBuffConfig skillBuff, int operateType)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);

            Unit unit = self.GetParent<Unit>();
            GameObject gameObject = unit.GetComponent<GameObjectComponent>().GameObject;
            if (gameObject == null)
            {
                return;
            }

            self.PassTime = 0;
            self.ButtTime = skillBuff.BuffLoopTime;
            self.ToScaleValue = operateType ==1 ? (float)skillBuff.buffParameterValue : 1;
            self.InitScaleValue = gameObject.transform.localScale.x;
            self.Transform = gameObject.transform;
            self.BeginTime = TimeHelper.ServerNow();
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.BuffScaleTimer, self);
        }

        public static void OnUpdate(this BuffScaleComponet self)
        {
            self.PassTime = TimeHelper.ServerNow() - self.BeginTime;
            float passvalue = (self.PassTime * 1f/ self.ButtTime);
            if (passvalue > 1f)
            {
                passvalue = 1f;
            }

            float curValue = self.InitScaleValue +  ( self.ToScaleValue - self.InitScaleValue ) * passvalue;    
            self.Transform.localScale = Vector3.one * curValue;
        }
    }

}