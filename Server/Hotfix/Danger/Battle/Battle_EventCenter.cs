using System.Collections.Generic;

namespace ET
{

    //所有属性都会进来这个事件
    //发送客户端数值更新消息   EventType.NumericApplyChangeValue
   
    public static class SendNumbericChange 
    {
        public static M2C_UnitNumericUpdate m2C_UnitNumericUpdate = new M2C_UnitNumericUpdate();

        public static  void Broadcast(EventType.NumericChangeEvent args)
        {
            if (args.Defend == null || args.Defend.IsDisposed)
            {
                return;
            }

            //主城不广播任何血量相关数值
			if (args.Defend.SceneType == SceneTypeEnum.MainCityScene)
            {
                if (args.NumericType == NumericType.Now_MaxHp || args.NumericType == NumericType.Now_Hp)
                {
                    return;
                }
            }

            m2C_UnitNumericUpdate.UnitId = args.Defend.Id;
            m2C_UnitNumericUpdate.NumericType = args.NumericType;
            m2C_UnitNumericUpdate.NewValue = args.NewValue;
            m2C_UnitNumericUpdate.OldValue = args.OldValue;
            m2C_UnitNumericUpdate.SkillId = args.SkillId;
            m2C_UnitNumericUpdate.DamgeType = args.DamgeType;
            m2C_UnitNumericUpdate.AttackId = args.Attack != null ? args.Attack.Id : 0;
            MessageHelper.Broadcast(args.Defend, m2C_UnitNumericUpdate);
        }

        public static void SendToClient(EventType.NumericChangeEvent args)
        {
            if (args.Defend == null)
            {
                LogHelper.LogDebug("NumericChangeEvent args.Parent == null");
                return;
            }
            if (args.Defend.IsDisposed)
            {
                LogHelper.LogDebug($"NumericChangeEvent args.Parent.IsDisposed {args.Defend.Id}");
            }
            if (args.Defend.GetComponent<UnitGateComponent>() == null)
            {
                return;
            }

            m2C_UnitNumericUpdate.UnitId = args.Defend.Id;
            m2C_UnitNumericUpdate.NumericType = args.NumericType;
            m2C_UnitNumericUpdate.NewValue = args.NewValue;
            m2C_UnitNumericUpdate.OldValue = args.OldValue;
            m2C_UnitNumericUpdate.SkillId = args.SkillId;
            m2C_UnitNumericUpdate.DamgeType = args.DamgeType;
            m2C_UnitNumericUpdate.AttackId = 0;
            MessageHelper.SendToClient(args.Defend, m2C_UnitNumericUpdate);
        }
    }

    //击杀事件
    [Event]
    public class KillEvent_NotifyUnit : AEvent<EventType.KillEvent>
    {

        private async ETTask OnRemoveUnit(EventType.KillEvent args, long waittime)
        {
            Unit unitDefend = args.UnitDefend;
            await TimerComponent.Instance.WaitAsync(waittime);
            if (unitDefend.IsDisposed)
            {
                return;
            }
            if (unitDefend.Type != UnitType.Player && args.WaitRevive == 0 && DllHelper.BattleCheck)
            {
                unitDefend.GetParent<UnitComponent>().Remove(unitDefend.Id);
            }
        }

        protected override void Run(EventType.KillEvent args)
        {
            Unit defendUnit = args.UnitDefend;
            Unit mainAttack = args.UnitAttack;

            bool selfDeath = defendUnit == mainAttack;
            if (selfDeath)
            {
                //自爆怪
                if (defendUnit.ConfigId != 90000001 && defendUnit.ConfigId != 90000002 && defendUnit.ConfigId != 90000005)
                {
                    Log.Warning($"找不到击杀方主人.defendUnit == mainAttack: {defendUnit.ConfigId}");
                }
                OnRemoveUnit(args, 1).Coroutine();
                return;
            }

            if (mainAttack == null || mainAttack.IsDisposed)
            {
                Log.Warning($"找不到击杀方主人.mainAttack == null ");
                OnRemoveUnit(args, 1).Coroutine();
                return;
            }
            int attackconfid = mainAttack.ConfigId;
            Scene domainScene = defendUnit.DomainScene();
            MapComponent mapComponent = domainScene.GetComponent<MapComponent>();
            int sceneId = mapComponent.SceneId;
            int sceneTypeEnum = mapComponent.SceneTypeEnum;
            if (mainAttack.Type != UnitType.Player)
            {
                mainAttack = domainScene.GetComponent<UnitComponent>().Get(mainAttack.GetMasterId());
            }
            if ((mainAttack == null || mainAttack.IsDisposed) && defendUnit.Type == UnitType.Monster
                && defendUnit.ConfigId != 90000001 && defendUnit.ConfigId != 90000002 && defendUnit.ConfigId != 90000005)
            {
                if (sceneTypeEnum == SceneTypeEnum.LocalDungeon)
                {
                    Log.Warning($"找不到击杀方主人.LocalDungeon1： 防： {defendUnit.ConfigId}  攻： {attackconfid} ");
                    mainAttack = domainScene.GetComponent<LocalDungeonComponent>().MainUnit;
                }
                if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
                {
                    Log.Warning($"找不到击杀方主人.TeamDungeon：   防： {defendUnit.ConfigId}   攻：  {attackconfid}");
                }
            }

            if (mainAttack != null && !mainAttack.IsDisposed)
            {
                int realPlayer = 1;
                List<long> allAttackIds = new List<long>();
                if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
                {
                    List<Unit> units = UnitHelper.GetUnitList(domainScene, UnitType.Player);
                    for (int k = 0; k < units.Count; k++)
                    {
                        allAttackIds.Add(units[k].Id);
                    }
                    realPlayer = UnitHelper.GetRealPlayer(domainScene);
                }
                else
                {
                    allAttackIds = defendUnit.GetComponent<AttackRecordComponent>().GetBeAttackPlayerList();
                    if (!allAttackIds.Contains(mainAttack.Id))
                    {
                        allAttackIds.Add(mainAttack.Id);
                    }
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
                    attackUnit.GetComponent<UserInfoComponent>().OnKillUnit(defendUnit, sceneTypeEnum, sceneId);
                }

                UnitFactory.CreateDropItems(defendUnit, mainAttack, sceneTypeEnum, realPlayer);

                if (mainAttack.Type == UnitType.Player)
                {
                    int jinglingid = mainAttack.GetComponent<ChengJiuComponent>().JingLingId;
                    if (jinglingid != 0)
                    {
                        JingLingConfig jingLingConfig = JingLingConfigCategory.Instance.Get(jinglingid);
                        if (jingLingConfig.FunctionType == JingLingFunctionType.ExtraDrop)
                        {
                            int dropid = int.Parse(jingLingConfig.FunctionValue);
                            UnitFactory.CreateDropItems(mainAttack, defendUnit, 1, dropid, "1");
                        }
                    }
                }

                if (mainAttack.Type == UnitType.Player && defendUnit.Type == UnitType.Player
                 && SceneConfigHelper.UseSceneConfig(sceneTypeEnum))
                {
                    SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
                    string attackname = mainAttack.GetComponent<UserInfoComponent>().UserInfo.Name;
                    string defendname = defendUnit.GetComponent<UserInfoComponent>().UserInfo.Name;
                    string killtext = $"<color=#B6FF00>{attackname}</color> 在<color=#FFA313>{sceneConfig.Name}</color> 击败了 <color=#00F6E6>{defendname}</color>";
                    ServerMessageHelper.SendBroadMessage(defendUnit.DomainZone(), NoticeType.KillEvent, killtext);
                }
            }

            long waittime = defendUnit.IsChest() ? 1000 : 200;
            if (defendUnit.Type == UnitType.Monster)
            {
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(defendUnit.ConfigId);
                if (monsterConfig.DeathSkillId != 0)
                {
                    waittime = 1000;
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
                case SceneTypeEnum.Solo:
                    domainScene.GetComponent<SoloDungeonComponent>().OnKillEvent(mainAttack,defendUnit);
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
                case SceneTypeEnum.Union:
                    domainScene.GetParent<UnionSceneComponent>().OnKillEvent(domainScene, defendUnit);
                    break;
                
                case SceneTypeEnum.TrialDungeon:
                    domainScene.GetComponent<TrialDungeonComponent>().OnKillEvent(defendUnit);
                    break;
                case SceneTypeEnum.TowerOfSeal:
                    domainScene.GetComponent<TowerOfSealComponent>().OnKillEvent(defendUnit);
                    break;
                case SceneTypeEnum.Demon:
                    domainScene.GetComponent<DemonDungeonComponent>().OnKillEvent(defendUnit, mainAttack).Coroutine();
                    break;
                default:
                    break;
            }

            OnRemoveUnit(args, waittime).Coroutine();
        }
    }
}