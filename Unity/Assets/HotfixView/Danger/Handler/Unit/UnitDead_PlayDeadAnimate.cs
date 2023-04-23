using UnityEngine;
using System;
namespace ET
{

    [Event]
    public class UnitDead_PlayDeadAnimate : AEventClass<EventType.UnitDead>
    {
        
        protected override void Run(object cls)
        {
            try
            {
                EventType.UnitDead args = cls as EventType.UnitDead;
                Unit unit = args.Unit;
                if (unit == null || unit.InstanceId == 0 || unit.IsDisposed)
                {
                    Log.Error("unitplaydead  unit.InstanceId == 0 || unit.IsDisposed");
                    return;
                }
                if (unit.ZoneScene().CurrentScene() == null)
                {
                    Log.Error("unitplaydead  unit.ZoneScene().CurrentScene() == null");
                    return;
                }

                MapComponent mapComponent = unit.ZoneScene().GetComponent<MapComponent>();
                UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
                if (unit.Type == UnitType.Player)
                {
                    unit.GetComponent<EffectViewComponent>()?.OnDispose();
                    unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmDeathState);
                    ShowRevive(unit, mapComponent).Coroutine();
                }
                else
                {
                    unit.GetComponent<EffectViewComponent>()?.OnDispose();
                    unit.ZoneScene().GetComponent<LockTargetComponent>().OnUnitDead(unit);
                }

                if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.ReviveTime) > 0)
                {
                    OnBossDead(unit).Coroutine();
                }
                else
                {
                    unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmDeathState);
                }

                if (unit.Type == UnitType.Monster
                 && unit.GetMonsterType() == (int)MonsterTypeEnum.Boss)
                {
                    unit.GetComponent<MonsterActRangeComponent>()?.OnDead();
                }

                if (unit.Type == UnitType.Monster
                    && mapComponent.SceneTypeEnum == (int)SceneTypeEnum.TeamDungeon)
                {
                    GameObject Obstruct = GameObject.Find("Obstruct");
                    if (Obstruct == null)
                    {
                        return;
                    }
                    Obstruct.transform.Find(unit.ConfigId.ToString())?.gameObject.SetActive(false);
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        private async ETTask ShowRevive(Unit unit, MapComponent mapComponent)
        {
            if (!unit.MainHero)
            {
                return;
            }
          
            if (!SceneConfigHelper.IfCanRevive(mapComponent.SceneTypeEnum, mapComponent.SceneId))
            {
                long instanceId = unit.InstanceId;
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("该地图不支持复活"));
                await TimerComponent.Instance.WaitAsync(3000);
                if (instanceId != unit.InstanceId)
                {
                    return;
                }
                EnterFubenHelp.RequestQuitFuben(unit.ZoneScene());
                return;
            }

            unit.ZoneScene().GetComponent<SkillIndicatorComponent>().OnSelfDead();
            unit.ZoneScene().GetComponent<LockTargetComponent>().LastLockId = 0;
            UI uimain = UIHelper.GetUI(unit.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().OnStopMove();
            if (UIHelper.GetUI(unit.ZoneScene(), UIType.UICellDungeonRevive) == null)
            {
                UI uI = await UIHelper.Create(unit.ZoneScene(), UIType.UICellDungeonRevive);
                uI.GetComponent<UICellDungeonReviveComponent>().OnInitUI(mapComponent.SceneTypeEnum);
            }
        }

        private async ETTask OnBossDead(Unit unit)
        {
            long instanceId = unit.InstanceId;
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceId != unit.InstanceId)
            {
                return;
            }

            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmHui);
            unit.GetComponent<HeroHeadBarComponent>()?.OnDead();
            unit.GetComponent<GameObjectComponent>().OnHui();
        }
    }
}
