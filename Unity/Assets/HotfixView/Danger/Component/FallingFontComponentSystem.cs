using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{
    public class AddBuff_ShowFallingFont : AEventClass<EventType.AddBuff>
    {
        protected override void Run(object numerice)
        {
            EventType.AddBuff args = numerice as EventType.AddBuff;
            if (args.Unit == null || args.Unit.IsDisposed)
            {
                return;
            }


            SkillBuffConfig skillBuffConfig = SkillBuffConfigCategory.Instance.Get(args.BuffId);

            if (!SkillHelp.BuffFallingFont.ContainsKey(skillBuffConfig.buffParameterType))
            {
                return;
            }

            string showText = string.Empty;
            if (skillBuffConfig.buffParameterValue > 0)
            {
                showText = SkillHelp.BuffFallingFont[skillBuffConfig.buffParameterType].Item1;
            }
            else
            {
                showText = SkillHelp.BuffFallingFont[skillBuffConfig.buffParameterType].Item2;
            }

            if (showText == string.Empty)
            {
                return;
            }

            GameObject HpGameObject = null;

            UIUnitHpComponent heroHeadBarComponent = args.Unit.GetComponent<UIUnitHpComponent>();
            if (heroHeadBarComponent != null)
            {
                HpGameObject = heroHeadBarComponent.GameObject;

                args.ZoneScene.CurrentScene().GetComponent<FallingFontComponent>()
                        ?.Play(HpGameObject, args.Unit, showText, FallingFontType.Special, Vector3.one);
            }
        }
    }
    
    
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

    /// <summary>
    /// 飘字组件，用于处理诸如伤害飘字。治疗飘字这种效果
    /// </summary>
    public class FallingFontComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public List<FallingFontShowComponent> FallingFontShows = new List<FallingFontShowComponent>();
    }

    public class FallingFontComponentAwakeSystem : AwakeSystem<FallingFontComponent>
    {
        public override void Awake(FallingFontComponent self)
        {
            self.OnAwake();
        }
    }

    public class FallingFontComponentDestroySystem : DestroySystem<FallingFontComponent>
    {
        public override void Destroy(FallingFontComponent self)
        {
            for (int i = self.FallingFontShows.Count - 1; i >= 0; i--)
            {
                FallingFontShowComponent fallingFontShowComponent = self.FallingFontShows[i];
                self.FallingFontShows.RemoveAt(i);
                fallingFontShowComponent.Dispose();
            }
            self.FallingFontShows = null;
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class FallingFontComponentSystem
    {
        public static void OnAwake(this FallingFontComponent self)
        {
            self.FallingFontShows = new List<FallingFontShowComponent>();
        }

        private static (string, FallingFontType, Vector3) GetBattleShowText(this FallingFontComponent self, long targetValue, Unit unit, int type)
        {
            FallingFontType fallingFontType = FallingFontType.Target;
            string showText = string.Empty;

            //根据目标Unit设定飘字字体
            string selfNull = "";
            if (unit.MainHero)
            {
                fallingFontType = FallingFontType.Self;
                selfNull = " ";
            }

            //恢复血量
            if (type == 2 || type == 11 || type == 12 || targetValue > 0)
            {
                fallingFontType = FallingFontType.Add;
            }

            //恢复暴击/重击
            if (unit.MainHero == false && type == 1 || type == 3)
            {
                fallingFontType = FallingFontType.Special;
            }

            string addStr = "";

            Vector3 startScale = Vector3.one;

            if (targetValue >= 0 && type == 2)
            {
                addStr = "+";
            }

            if (type == 1)
            {
                addStr = "暴击";
                startScale = new Vector3(1.4f, 1.4f, 1.4f);
            }

            if (type != 2 && type != 11 && type != 12 && targetValue == 0)
            {
                showText = "闪避";
            }
            else if (type == 11)
            {
                showText = "抵抗";
            }
            else if (type == 12)
            {
                showText = "免疫";
            }
            else
            {
                showText = StringBuilderHelper.GetFallText(addStr + selfNull, targetValue);
            }

            return (showText, fallingFontType, startScale);
        }

        public static void PlayBattle(this FallingFontComponent self, GameObject HeadBar, Unit unit, long targetValue, int type)
        {
            FallingFontShowComponent fallingFont = self.AddChild<FallingFontShowComponent>();
            (string, FallingFontType, Vector3) showText = GetBattleShowText(self, targetValue, unit, type);
            fallingFont.OnInitData(HeadBar, unit, showText.Item1, showText.Item2, showText.Item3);
            self.FallingFontShows.Add(fallingFont);

            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.FallingFont, self);
            }
        }

        public static void Play(this FallingFontComponent self, GameObject HeadBar, Unit unit, string showText,
        FallingFontType fallingFontType, Vector3 startScale)
        {
            FallingFontShowComponent fallingFont = self.AddChild<FallingFontShowComponent>();
            fallingFont.OnInitData(HeadBar, unit, showText, fallingFontType, startScale);
            self.FallingFontShows.Add(fallingFont);

            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.FallingFont, self);
            }
        }

        public static void OnUpdate(this FallingFontComponent self)
        {
            for (int i = self.FallingFontShows.Count - 1; i >= 0; i--)
            {
                FallingFontShowComponent fallingFontShowComponent = self.FallingFontShows[i];
                bool remove = fallingFontShowComponent.LateUpdate();
                if (remove)
                {
                    self.FallingFontShows.RemoveAt(i);
                    fallingFontShowComponent.Dispose();
                }
            }

            if (self.FallingFontShows.Count == 0 && self.Timer!=0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }
    }

}