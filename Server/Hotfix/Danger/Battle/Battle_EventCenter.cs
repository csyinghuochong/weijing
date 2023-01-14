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
           
            //玩家全部死亡，怪物技能清空
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
            //怪物死亡， 清除玩家BUFF
            if (unitDefend.Type == UnitType.Monster)  
            {
                List<Unit> units = FubenHelp.GetUnitList(unitDefend.DomainScene(), UnitType.Player);
                for(int i = 0; i < units.Count; i++)
                {
                    units[i].GetComponent<BuffManagerComponent>().OnRemoveBuffByUnit(unitDefend.Id);
                }
            }

            await TimerComponent.Instance.WaitFrameAsync();
            if (unitDefend.IsDisposed)
            {
                return;
            }
            if (unitDefend.Type != UnitType.Player && args.WaitRevive == 0)
            {
                unitDefend.GetParent<UnitComponent>().Remove(unitDefend.Id);
            }
        }

        protected override void Run(EventType.KillEvent args)
        {
            Unit defendUnit = args.UnitDefend;
            Scene domainScene = defendUnit.DomainScene();
            defendUnit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Dead, 1);
            MapComponent mapComponent = domainScene.GetComponent<MapComponent>();
            int sceneTypeEnum = mapComponent.SceneTypeEnum;
            int sceneId = mapComponent.SceneId;

            Unit player = args.UnitAttack;
            if (args.UnitAttack != null && !args.UnitAttack.IsDisposed)
            {
                player = domainScene.GetComponent<UnitComponent>().Get(args.UnitAttack.GetMasterId());
            }
            if (player != null)
            {
                player.GetComponent<TaskComponent>().OnKillUnit(defendUnit, sceneTypeEnum);
                player.GetComponent<ChengJiuComponent>().OnKillUnit(defendUnit);
                player.GetComponent<PetComponent>().OnKillUnit(defendUnit);
            }
            if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                List<Unit> units = FubenHelp.GetUnitList(domainScene, UnitType.Player);
                for (int k = 0; k < units.Count; k++)
                {
                    units[k].GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum, sceneId);
                }
                UnitFactory.CreateDropItems(defendUnit, player, sceneTypeEnum, units.Count);
            }
            else if (player != null)
            {
                player.GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum, sceneId);
                UnitFactory.CreateDropItems(defendUnit, player, sceneTypeEnum, 1);
            }
            switch (sceneTypeEnum)
            {
                case SceneTypeEnum.PetDungeon:
                    domainScene.GetComponent<PetFubenSceneComponent>().OnKillEvent();
                    break;
                case SceneTypeEnum.CellDungeon:
                    domainScene.GetComponent<CellDungeonComponent>().OnKillEvent();
                    break;
                case SceneTypeEnum.PetTianTi:
                    domainScene.GetComponent<PetTianTiComponent>().OnKillEvent();
                    break;
                case SceneTypeEnum.TeamDungeon:
                    domainScene.GetComponent<TeamDungeonComponent>().OnKillEvent(defendUnit);
                    break;
                case SceneTypeEnum.BaoZang:
                    ;
                    break;
                case SceneTypeEnum.MiJing:
                    domainScene.GetComponent<MiJingComponent>().OnKillEvent(defendUnit);
                    break;
                case SceneTypeEnum.Tower:
                    domainScene.GetComponent<TowerComponent>().OnKillEvent(defendUnit);
                    break;
                case SceneTypeEnum.RandomTower:
                    domainScene.GetComponent<RandomTowerComponent>().OnKillEvent(defendUnit);
                    break;
                case SceneTypeEnum.LocalDungeon:
                    domainScene.GetComponent<LocalDungeonComponent>().OnKillEvent(defendUnit, player);
                    break;
                case SceneTypeEnum.Battle:
                    domainScene.GetComponent<BattleDungeonComponent>().OnKillEvent(defendUnit, player);
                    break;
                case SceneTypeEnum.TrialDungeon:
                    domainScene.GetComponent<TrialDungeonComponent>().OnKillEvent(defendUnit);
                    break;
            }
            OnUnitDead(args).Coroutine();
        }
    }
}