using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    //所有属性都会进来这个事件
    //发送客户端数值更新消息   EventType.NumericApplyChangeValue
    public static class SendNumbericChange 
    {
        public static  void Broadcast(EventType.NumericChangeEvent args)
        {
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

        public static void  SendToClient(EventType.NumericChangeEvent args)
        {
            if (args.Parent.IsDisposed)
            {
                return;
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
        protected override void Run(EventType.KillEvent args)
        {
            Unit defendUnit = args.UnitDefend;
            defendUnit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Dead, 1);
            if (args.UnitAttack != null && !args.UnitAttack.IsDisposed)
            {
                Unit player = null;
                int sceneTypeEnum = args.UnitAttack.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
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
                    UnitFactory.CreateDropItems(defendUnit, player, sceneTypeEnum);
                }
                if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
                {
                    List<Unit> units = args.UnitAttack.DomainScene().GetComponent<UnitComponent>().GetAll();
                    for (int k = 0; k < units.Count; k++)
                    {
                        if (units[k].Type == UnitType.Player)
                        {
                            units[k].GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum);
                        }
                    }
                }
                else if(player != null)
                {
                    player.GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum);
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
                        args.UnitAttack.DomainScene().GetComponent<TowerComponent>().OnKillEvent();
                        break;
                    case SceneTypeEnum.RandomTower:
                        args.UnitAttack.DomainScene().GetComponent<RandomTowerComponent>().OnKillEvent(args.UnitDefend);
                        break;
                    case SceneTypeEnum.LocalDungeon:
                        args.UnitAttack.DomainScene().GetComponent<LocalDungeonComponent>().OnKillEvent(args.UnitDefend);
                        break;
                    case SceneTypeEnum.Battle:
                        args.UnitAttack.DomainScene().GetComponent<BattleDungeonComponent>().OnKillEvent(args.UnitDefend);
                        break;
                }
            }

            if (defendUnit.Type == UnitType.Monster)
            {
                if (args.WaitRevive > 0)
                {
                    //NumericComponent numericComponent = defendUnit.GetComponent<NumericComponent>();
                    //defendUnit.Position = new Vector3(numericComponent.GetAsFloat(NumericType.Born_X),
                    //    numericComponent.GetAsFloat(NumericType.Born_Y),
                    //    numericComponent.GetAsFloat(NumericType.Born_Z));
                    return;
                }
                //下一帧移除defend
                defendUnit.RemoveComponent<DeathTimeComponent>();
                defendUnit.GetParent<UnitComponent>().Remove(defendUnit.Id);
            }
            else if (defendUnit.Type != UnitType.Player)
            {
                defendUnit.GetParent<UnitComponent>().Remove(defendUnit.Id);
            }
            //RunAsync(args).Coroutine();
        }
    }
}