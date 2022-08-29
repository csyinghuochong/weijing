using UnityEngine;

namespace ET
{

    [Event]
    public class UnitDead_PlayDeadAnimate : AEventClass<EventType.UnitDead>
    {
        
        protected override void Run(object cls)
        {
            EventType.UnitDead args = cls as EventType.UnitDead;
            Unit unit = args.Unit;
            MapComponent mapComponent = unit.ZoneScene().GetComponent<MapComponent>();
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.Type == UnitType.Player)
            {
                unit.GetComponent<EffectViewComponent>()?.OnDispose();
                args.Unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmDeathState);
                ShowRevive(args.Unit, mapComponent).Coroutine();
            }
            else
            {
                args.Unit.GetComponent<EffectViewComponent>()?.OnDispose();
                args.Unit.ZoneScene().CurrentScene().GetComponent<LockTargetComponent>().OnUnitDead(args.Unit);
            }

            if (args.Unit.GetComponent<NumericComponent>().GetAsLong(NumericType.ReviveTime) > 0)
            {
                RunAsync(args.Unit).Coroutine();
            }
            else
            {
                args.Unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmDeathState);
            }

            if (unitInfoComponent.Type == UnitType.Monster 
                && mapComponent.SceneTypeEnum == (int)SceneTypeEnum.TeamDungeon)
            {
                GameObject Obstruct = GameObject.Find("Obstruct");
                if (Obstruct == null)
                {
                    return;
                }
                Obstruct.transform.Find(unitInfoComponent.UnitCondigID.ToString())?.gameObject.SetActive(false);
            }
        }

        private async ETTask ShowRevive(Unit unit, MapComponent mapComponent)
        {
            if (!unit.MainHero)
            {
                return;
            }
          
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.YeWaiScene
                || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.Tower
                 || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.RandomTower)
            {
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);
                if (sceneConfig.IfUseRes == 1)
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
            }

            unit.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().OnSelfDead();
            UIHelper.Create(unit.ZoneScene(), UIType.UICellDungeonRevive).Coroutine();
        }

        private async ETTask RunAsync(Unit unit)
        {
            long instanceId = unit.InstanceId;
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceId != unit.InstanceId)
            {
                return;
            }
            NumericComponent  numericComponent = unit.GetComponent<NumericComponent>();
            unit.Position = new Vector3(numericComponent.GetAsFloat(NumericType.Born_X),
                numericComponent.GetAsFloat(NumericType.Born_Y),
                numericComponent.GetAsFloat(NumericType.Born_Z));
            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmHui);
            unit.GetComponent<HeroHeadBarComponent>()?.OnDead();
            unit.GetComponent<GameObjectComponent>().OnHui();
        }
    }
}
