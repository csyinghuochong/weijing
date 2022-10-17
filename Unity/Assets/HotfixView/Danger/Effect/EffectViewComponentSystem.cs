using System;
using System.Collections.Generic;

namespace ET
{
    [Timer(TimerType.Effectimer)]
    public class EffectViewTimer : ATimer<EffectViewComponent>
    {
        public override void Run(EffectViewComponent self)
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

    [ObjectSystem]
    public class EffectViewCompoenntAwakeSystem : AwakeSystem<EffectViewComponent>
    {
        public override void Awake(EffectViewComponent self)
        {
            self.Effects.Clear();
            self.InitEffect();
        }
    }

    [ObjectSystem]
    public class EffectViewCompoenntDestroySystem : DestroySystem<EffectViewComponent>
    {
        public override void Destroy(EffectViewComponent self)
        {
            self.OnDispose();
        }
    }

    public static class EffectViewComponentSystem
    {

        public static void OnDispose(this EffectViewComponent self)
        {
            for (int i = self.Effects.Count - 1; i >= 0; i--)
            {
                AEffectHandler aEffectHandler = self.Effects[i];
                aEffectHandler.Clear();
                aEffectHandler.OnFinished();
                aEffectHandler.Dispose();
                self.Effects.RemoveAt(i);
            }
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void RemoveEffect(this EffectViewComponent self, int effectTypeEnum)
        {
            for (int i = self.Effects.Count - 1; i >= 0; i--)
            {
                if (self.Effects[i].EffectData.EffectTypeEnum == effectTypeEnum)
                {
                    self.Effects[i].EffectState = BuffState.Finished;
                }
            }
        }

        public static AEffectHandler GetEffect(this EffectViewComponent self, long instanceId)
        {
            for (int i = self.Effects.Count - 1; i >= 0; i--)
            {
                if (self.Effects[i].EffectData == null)
                {
                    continue;
                }
                if (self.Effects[i].EffectData.InstanceId == instanceId)
                {
                    return self.Effects[i];
                }
            }
            return null;
        }

        public static void UpdatePositon(this EffectViewComponent self)
        {
            for (int i = self.Effects.Count - 1; i >= 0; i--)
            {
                AEffectHandler aEffectHandler = self.Effects[i];
                if (aEffectHandler.EffectData == null)
                {
                    Log.ILog.Debug($"aEffectHandler.EffectData == nul");
                    continue;
                }
                if (!aEffectHandler.EffectData.FollowUnitMove)
                {
                    continue;
                }
                if (aEffectHandler.EffectData.EffectConfig.SkillParent!=2)
                {
                    continue;
                }
                aEffectHandler.UpdateEffectPosition(self.GetParent<Unit>().Position);
            }
        }

        public static void OnUpdate(this EffectViewComponent self)
        {
            for (int i = self.Effects.Count - 1; i >= 0; i--)
            {
                AEffectHandler aEffectHandler = self.Effects[i];
                if (aEffectHandler.EffectState == BuffState.Finished)
                {
                    aEffectHandler.Clear();
                    aEffectHandler.OnFinished();
                    aEffectHandler.Dispose();
                    self.Effects.RemoveAt(i);
                    continue;
                }
                self.Effects[i].OnUpdate();
            }

            if (self.Effects.Count == 0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }

        public static void InitEffect(this EffectViewComponent self)
        {
            BuffManagerComponent buffManager = self.GetParent<Unit>().GetComponent<BuffManagerComponent>();
            if (buffManager == null)
            {
                return;
            }
            List<ABuffHandler> buffList =  buffManager.m_Buffs;
            for (int i = 0; i < buffList.Count; i++)
            {
                ABuffHandler aBuffHandler = buffList[i];
                if (self.GetEffect(aBuffHandler.EffectInstanceId)!=null)
                {
                    continue;
                }
                if (aBuffHandler.EffectData != null)
                {
                    self.EffectFactory(aBuffHandler.EffectData);
                }
            }
        }

        public static AEffectHandler EffectFactory(this EffectViewComponent self, EffectData effectData)
        {
            AEffectHandler resultEffect = self.AddChild<RoleSkillEffect>();
            resultEffect.OnInit(effectData, self.GetParent<Unit>());
            self.AddEffect(resultEffect);       //给buff目标添加buff管理器
            return resultEffect;
        }

        /// <summary>
        /// 添加effect到真实链表，禁止外部调用
        /// </summary>
        /// <param name="aBuff"></param>
        public static void AddEffect(this EffectViewComponent self, AEffectHandler aBuff)
        {
            self.Effects.Add(aBuff);

            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.Effectimer, self);
            }
        }
    }
}