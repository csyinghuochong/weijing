using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{

    [Timer(TimerType.FallingFont)]
    public class FallingFontTimer : ATimer<FallingFontComponent>
    {
        public override void Run(FallingFontComponent self)
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
    public class FallingFontComponentAwakeSystem : AwakeSystem<FallingFontComponent>
    {
        public override void Awake(FallingFontComponent self)
        {
            self.OnAwake();
        }
    }

    [ObjectSystem]
    public class FallingFontComponentDestroySystem : DestroySystem<FallingFontComponent>
    {
        public override void Destroy(FallingFontComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class FallingFontComponentSystem
    {
        public static void OnAwake(this FallingFontComponent self)
        {
            self.UiCamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
        }

        /// <summary>
        /// 播放飘字特效
        /// </summary>
        /// <param name="targetValue">目标值</param>
        public static void  Play(this FallingFontComponent self, float targetValue, Unit unit, int type)
        {
            //判断目标是否已经死亡
            if (unit.GetComponent<HeroHeadBarComponent>()== null
                || unit.GetComponent<HeroHeadBarComponent>().HeadBar == null)
                return;

            self.AddChild<FallingFontShowComponent>(true).OnInitData(targetValue, unit, type).Coroutine();

            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.FallingFont, self);
            }
        }

        public static void OnUpdate(this FallingFontComponent self)
        {
            List<Entity> entities = self.Children.Values.ToList();
            for (int i = entities.Count - 1; i >= 0; i--)
            {
                FallingFontShowComponent fallingFontShowComponent = entities[i] as FallingFontShowComponent;
                bool remove = fallingFontShowComponent.LateUpdate();
                if (remove)
                {
                    fallingFontShowComponent.Dispose();
                }
            }

            if (self.Children.Count == 0 && self.Timer!=0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }
    }

}