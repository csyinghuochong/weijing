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

        private async ETTask OnRemoveUnit(EventType.KillEvent args)
        {
            Unit unitDefend = args.UnitDefend;
         
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
            MapComponent mapComponent = domainScene.GetComponent<MapComponent>();
           
            int sceneTypeEnum = mapComponent.SceneTypeEnum;
            int sceneId = mapComponent.SceneId;

            Unit mainAttack = args.UnitAttack;
            if (args.UnitAttack != null && !args.UnitAttack.IsDisposed)
            {
                mainAttack = domainScene.GetComponent<UnitComponent>().Get(args.UnitAttack.GetMasterId());
            }

            //队友共享
            List<long> allAttackIds = defendUnit.GetComponent<AttackRecordComponent>().GetBeAttackPlayerList();
            if (mainAttack != null && !allAttackIds.Contains(mainAttack.Id))
            {
                allAttackIds.Add(mainAttack.Id);
            }
            for (int i = 0; i < allAttackIds.Count; i++)
            {
                Unit attackUnit = domainScene.GetComponent<UnitComponent>().Get(allAttackIds[i]);
                if (attackUnit == null || attackUnit.Type != UnitType.Player)
                {
                    continue;
                }
                attackUnit.GetComponent<TaskComponent>().OnKillUnit(defendUnit, sceneTypeEnum);
                attackUnit.GetComponent<ChengJiuComponent>().OnKillUnit(defendUnit);
                attackUnit.GetComponent<PetComponent>().OnKillUnit(defendUnit);
            }

            if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                List<Unit> units = FubenHelp.GetUnitList(domainScene, UnitType.Player);
                for (int k = 0; k < units.Count; k++)
                {
                    units[k].GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum, sceneId);
                }
                UnitFactory.CreateDropItems(defendUnit, mainAttack, sceneTypeEnum, units.Count);
            }
            else
            {
                if (mainAttack != null)
                {
                    mainAttack.GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum, sceneId);
                    UnitFactory.CreateDropItems(defendUnit, mainAttack, sceneTypeEnum, 1);
                }
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
                    domainScene.GetComponent<LocalDungeonComponent>().OnKillEvent(defendUnit, mainAttack);
                    break;
                case SceneTypeEnum.Battle:
                    domainScene.GetComponent<BattleDungeonComponent>().OnKillEvent(defendUnit, mainAttack);
                    break;
                case SceneTypeEnum.Arena:
                    domainScene.GetComponent<ArenaDungeonComponent>().OnKillEvent(defendUnit, mainAttack);
                    break;
                case SceneTypeEnum.TrialDungeon:
                    domainScene.GetComponent<TrialDungeonComponent>().OnKillEvent(defendUnit);
                    break;
            }
            OnRemoveUnit(args).Coroutine();
        }
    }
}