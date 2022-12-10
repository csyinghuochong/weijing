using System.Collections.Generic;

namespace ET
{

    //所有属性都会进来这个事件
    //发送客户端数值更新消息   EventType.NumericApplyChangeValue
    public static class SendNumbericChange 
    {
        public static  void Broadcast(EventType.NumericChangeEvent args)
        {
            if (args.Parent == null || args.Parent.IsDisposed)
            {
                return;
            }
            MessageHelper.Broadcast(args.Parent, new M2C_UnitNumericUpdate()
            {
                UnitId = args.Parent.Id,
                NumericType = args.NumericType,
                NewValue = args.NewValue,
                OldValue = args.OldValue,
                SkillId = args.SkillId,
                DamgeType = args.DamgeType
            });
        }

        public static void SendToClient(EventType.NumericChangeEvent args)
        {
            if (args.Parent == null)
            {
                Log.Debug("NumericChangeEvent args.Parent == null");
                return;
            }
            if (args.Parent.IsDisposed)
            {
                Log.Debug($"NumericChangeEvent args.Parent.IsDisposed {args.Parent.Id}");
            }
            if (args.Parent.GetComponent<UnitGateComponent>() == null)
            {
                return;
            }
            MessageHelper.SendToClient(args.Parent, new M2C_UnitNumericUpdate()
            {
                UnitId = args.Parent.Id,
                NumericType = (int)args.NumericType,
                NewValue = args.NewValue,
                OldValue = args.OldValue,
                SkillId = args.SkillId,
                DamgeType = args.DamgeType
            });
        }
    }

    //击杀事件
    [Event]
    public class KillEvent_NotifyUnit : AEvent<EventType.KillEvent>
    {

        private async ETTask OnUnitDead(EventType.KillEvent args)
        {
            Unit unitDefend = args.UnitDefend;
            await TimerComponent.Instance.WaitFrameAsync();
            if (unitDefend.IsDisposed)
            {
                return;
            }

            if (unitDefend.Type == UnitType.Player)
            {
                int playerNumber = FubenHelp.GetAliveUnitNumber(unitDefend.DomainScene(), UnitType.Player);
                if (playerNumber > 0)
                {
                    return;
                }
                List<Unit> units = FubenHelp.GetUnitList(unitDefend.DomainScene(), UnitType.Monster);
                for (int i = 0; i < units.Count; i++)
                {
                    AIComponent aIComponent = units[i].GetComponent<AIComponent>();
                    if (aIComponent!= null && aIComponent.TargetID == unitDefend.Id)
                    {
                        aIComponent.ChangeTarget(0);
                    }
                    if (units[i].IsBoss())
                    {
                        units[i].GetComponent<SkillManagerComponent>().OnFinish(true);
                    }
                }
            }
          
            if (unitDefend.Type != UnitType.Player && args.WaitRevive == 0)
            {
                unitDefend.GetParent<UnitComponent>().Remove(unitDefend.Id);
            }
        }

        protected override void Run(EventType.KillEvent args)
        {
            Unit defendUnit = args.UnitDefend;
            defendUnit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Dead, 1);
            if (args.UnitAttack != null && !args.UnitAttack.IsDisposed)
            {
                Unit player = null;
                MapComponent mapComponent = args.UnitAttack.DomainScene().GetComponent<MapComponent>();
                int sceneTypeEnum = mapComponent.SceneTypeEnum;
                int sceneId = mapComponent.SceneId;
                if (args.UnitAttack.Type == UnitType.Player)
                {
                    player = args.UnitAttack;
                }
                if (args.UnitAttack.Type == UnitType.Pet || args.UnitAttack.Type == UnitType.Monster)
                {
                    long master = args.UnitAttack.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
                    player = args.UnitAttack.GetParent<UnitComponent>().Get(master);
                }
                if (player != null)
                {
                    player.GetComponent<TaskComponent>().OnKillUnit(defendUnit, sceneTypeEnum);
                    player.GetComponent<ChengJiuComponent>().OnKillUnit(defendUnit);
                    player.GetComponent<PetComponent>().OnKillUnit(defendUnit);
                }
                if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
                {
                    List<Unit> units = FubenHelp.GetUnitList(args.UnitAttack.DomainScene(), UnitType.Player);
                    for (int k = 0; k < units.Count; k++)
                    {
                        units[k].GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum, sceneId);
                    }
                    UnitFactory.CreateDropItems(defendUnit, player, sceneTypeEnum, units.Count);
                }
                else if(player != null)
                {
                    player.GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum, sceneId);
                    UnitFactory.CreateDropItems(defendUnit, player, sceneTypeEnum, 1);
                }
                switch (sceneTypeEnum)
                {
                    case SceneTypeEnum.PetDungeon:
                        args.UnitAttack.DomainScene().GetComponent<PetFubenSceneComponent>().OnKillEvent();
                        break;
                    case SceneTypeEnum.CellDungeon:
                        args.UnitAttack.DomainScene().GetComponent<CellDungeonComponent>().OnKillEvent();
                        break;
                    case SceneTypeEnum.PetTianTi:
                        args.UnitAttack.DomainScene().GetComponent<PetTianTiComponent>().OnKillEvent();
                        break;
                    case SceneTypeEnum.TeamDungeon:
                        args.UnitAttack.DomainScene().GetComponent<TeamDungeonComponent>().OnKillEvent(args.UnitDefend);
                        break;
                    case SceneTypeEnum.YeWaiScene:
                        args.UnitAttack.DomainScene().GetComponent<YeWaiRefreshComponent>().OnKillEvent(args.UnitDefend);
                        break;
                    case SceneTypeEnum.Tower:
                        args.UnitAttack.DomainScene().GetComponent<TowerComponent>().OnKillEvent(args.UnitDefend);
                        break;
                    case SceneTypeEnum.RandomTower:
                        args.UnitAttack.DomainScene().GetComponent<RandomTowerComponent>().OnKillEvent(args.UnitDefend);
                        break;
                    case SceneTypeEnum.LocalDungeon:
                        args.UnitAttack.DomainScene().GetComponent<LocalDungeonComponent>().OnKillEvent(args.UnitDefend);
                        break;
                    case SceneTypeEnum.Battle:
                        args.UnitAttack.DomainScene().GetComponent<BattleDungeonComponent>().OnKillEvent(args.UnitDefend, args.UnitAttack);
                        break;
                    case SceneTypeEnum.TrialDungeon:
                        args.UnitAttack.DomainScene().GetComponent<TrialDungeonComponent>().OnKillEvent(args.UnitDefend);
                        break;
                }
            }

            OnUnitDead(args).Coroutine();
        }
    }
}