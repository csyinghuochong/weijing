namespace ET
{

    [Event]
    public class Unit_OnNumericUpdate : AEventClass<EventType.UnitNumericUpdate>
    {
        protected override void Run(object numerice)
        {
            EventType.UnitNumericUpdate args = numerice as EventType.UnitNumericUpdate;
            Scene zoneScene = args.Unit.ZoneScene();
            switch (args.NumericType)
            {
                case NumericType.Now_Stall:
                    int stallType = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Stall);
                    args.Unit.GetComponent<HeroHeadBarComponent>().OnUnitStallUpdate(stallType);
                    args.Unit.GetComponent<GameObjectComponent>().OnUnitStallUpdate(stallType);

                    if (args.Unit.MainHero)
                    {
                        UI uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                        uI.GetComponent<UIMainComponent>().UIStall.SetActive(stallType == 1);
                    }
                    break;
                case NumericType.PetChouKa:
                    UI uipet = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIPetEgg);
                    uipet?.GetComponent<UIPetEggComponent>().UpdateChouKaTime();
                    break;
                case NumericType.Now_Weapon:
                    int weaponId = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon);
                    args.Unit.GetComponent<ChangeEquipComponent>()?.ChangeWeapon(weaponId);
                    break;
                case NumericType.Now_XiLian:
                    break;
                case NumericType.Ling_DiLv:
                    break;
                case NumericType.Ling_DiExp:
                    break;
                case NumericType.PetSkin:
                    args.Unit.RemoveComponent<EffectViewComponent>();
                    args.Unit.RemoveComponent<GameObjectComponent>();
                    args.Unit.RemoveComponent<AnimatorComponent>();
                    args.Unit.RemoveComponent<HeroTransformComponent>();
                    args.Unit.RemoveComponent<FsmComponent>();
                    args.Unit.RemoveComponent<HeroHeadBarComponent>();
                    args.Unit.AddComponent<GameObjectComponent>();
                    break;
                case NumericType.ZeroClock:
                    UserInfoComponent userInfoComponent = zoneScene.GetComponent<UserInfoComponent>();
                    userInfoComponent.UserInfo.DayFubenTimes.Clear();
                    userInfoComponent.UserInfo.ChouKaRewardIds.Clear();
                    userInfoComponent.UserInfo.MysteryItems.Clear();
                    zoneScene.GetComponent<TaskComponent>().OnZeroClockUpdate();
                    zoneScene.GetComponent<ActivityComponent>().OnZeroClockUpdate();
                    break;
                case NumericType.PointRemain:
                    ReddotComponent reddotComponent = args.Unit.ZoneScene().GetComponent<ReddotComponent>();
                    reddotComponent.UpdateReddont(ReddotType.RolePoint);
                    break;
                case NumericType.BossInCombat:
                    int incombat = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.BossInCombat);
                    args.Unit.GetComponent<MonsterActRangeComponent>()?.OnBossInCombat(incombat);
                    Log.ILog.Debug($"BossInCombat {args.Unit.Id} {incombat}");
                    break;
                case NumericType.Now_AI:
                    args.Unit.GetComponent<HeroHeadBarComponent>()?.UpdateAI();
                    break;
                case NumericType.Now_Horse:
                    args.Unit.GetComponent<GameObjectComponent>()?.OnUpdateHorse();
                    break;
                case NumericType.BattleTodayKill:
                    UI uI_2 = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIBattleMain);
                    uI_2?.GetComponent<UIBattleMainComponent>().OnUpdateSelfKill();
                    break;
                case NumericType.PetExtendNumber:
                    Log.Debug("NumericType.PetExtendNumber");
                    break;
                case NumericType.TowerId:
                    int towerId = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.TowerId);
                    uI_2 = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UITowerOpen);
                    uI_2.GetComponent<UITowerOpenComponent>().OnUpdateUI(towerId);
                    break;
            }
        }

    }
}
