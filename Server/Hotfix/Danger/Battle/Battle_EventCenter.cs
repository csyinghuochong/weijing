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
            if (args.Parent == null || args.Parent.IsDisposed)
            {
                return;
            }

            //主城不广播任何血量相关数值
			if (args.Parent.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == SceneTypeEnum.MainCityScene)
            {
                if (args.NumericType == NumericType.Now_MaxHp || args.NumericType == NumericType.Now_Hp)
                {
                    return;
                }
            }

            m2C_UnitNumericUpdate.UnitId = args.Parent.Id;
            m2C_UnitNumericUpdate.NumericType = args.NumericType;
            m2C_UnitNumericUpdate.NewValue = args.NewValue;
            m2C_UnitNumericUpdate.OldValue = args.OldValue;
            m2C_UnitNumericUpdate.SkillId = args.SkillId;
            m2C_UnitNumericUpdate.DamgeType = args.DamgeType;
            m2C_UnitNumericUpdate.AttackId = args.Attack != null ? args.Attack.Id : 0;
            MessageHelper.Broadcast(args.Parent, m2C_UnitNumericUpdate);
        }

        public static void SendToClient(EventType.NumericChangeEvent args)
        {
            if (args.Parent == null)
            {
                LogHelper.LogDebug("NumericChangeEvent args.Parent == null");
                return;
            }
            if (args.Parent.IsDisposed)
            {
                LogHelper.LogDebug($"NumericChangeEvent args.Parent.IsDisposed {args.Parent.Id}");
            }
            if (args.Parent.GetComponent<UnitGateComponent>() == null)
            {
                return;
            }

            m2C_UnitNumericUpdate.UnitId = args.Parent.Id;
            m2C_UnitNumericUpdate.NumericType = args.NumericType;
            m2C_UnitNumericUpdate.NewValue = args.NewValue;
            m2C_UnitNumericUpdate.OldValue = args.OldValue;
            m2C_UnitNumericUpdate.SkillId = args.SkillId;
            m2C_UnitNumericUpdate.DamgeType = args.DamgeType;
            m2C_UnitNumericUpdate.AttackId = 0;
            MessageHelper.SendToClient(args.Parent, m2C_UnitNumericUpdate);
        }
    }

    //击杀事件
    [Event]
    public class KillEvent_NotifyUnit : AEvent<EventType.KillEvent>
    {

        private async ETTask OnRemoveUnit(EventType.KillEvent args)
        {
            Unit unitDefend = args.UnitDefend;

            long waittime = unitDefend.IsChest() ? 1000 : 500;
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
            //if (mainAttack == null)
            //{
            //    return;
            //}
            
            Scene domainScene = defendUnit.DomainScene();
            MapComponent mapComponent = domainScene.GetComponent<MapComponent>();
            int sceneId = mapComponent.SceneId;
            int sceneTypeEnum = mapComponent.SceneTypeEnum;
            if (args.UnitAttack!=null && !args.UnitAttack.IsDisposed && args.UnitAttack.Type != UnitType.Player)
            {
                mainAttack = domainScene.GetComponent<UnitComponent>().Get(args.UnitAttack.GetMasterId());
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
            }
            OnRemoveUnit(args).Coroutine();
        }
    }
}