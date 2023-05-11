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
                case NumericType.RechargeNumber:
                    int rechargeNumber = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeNumber);
                    int addNumer = rechargeNumber - (int)args.OldValue;
                    UI uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                    uI.GetComponent<UIMainComponent>().OnRechageSucess(addNumer);
                    break;
                case NumericType.Now_Stall:
                    int stallType = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Stall);
                    args.Unit.GetComponent<HeroHeadBarComponent>().OnUnitStallUpdate(stallType);
                    args.Unit.GetComponent<GameObjectComponent>().OnUnitStallUpdate(stallType);
                    if (args.Unit.MainHero)
                    {
                        uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                        uI.GetComponent<UIMainComponent>().UIStall.SetActive(stallType == 1);
                    }
                    break;
                case NumericType.UnionId_0:
                    long unionId = args.Unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
                    UI uifriend = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIFriend);
                    if (args.Unit.MainHero && uifriend != null && unionId > 0)
                    {
                        uifriend.GetComponent<UIFriendComponent>().OnCreateUnion();
                    }
                    if (args.Unit.MainHero && uifriend != null && unionId == 0)
                    {
                        uifriend.GetComponent<UIFriendComponent>().OnLeaveUnion();
                    }
                    if (args.Unit.MainHero)
                    {
                        UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain).GetComponent<UIMainComponent>().Btn_Union.SetActive(unionId > 0);
                    }
                    break;
                case NumericType.BossBelongID:
                    long bossbelongid = args.Unit.GetComponent<NumericComponent>().GetAsLong(NumericType.BossBelongID);
                    UI uImain = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                    uImain.GetComponent<UIMainComponent>().UIMainHpBar.OnUpdateBelongID(args.Unit.Id, bossbelongid);
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
                case NumericType.TitleID:
                    args.Unit.GetComponent<HeroHeadBarComponent>()?.UpdateShow();
                    break;
                case NumericType.ZeroClock:
                    zoneScene.GetComponent<UserInfoComponent>().ClearDayData();
                    zoneScene.GetComponent<TaskComponent>().OnZeroClockUpdate();
                    zoneScene.GetComponent<ActivityComponent>().OnZeroClockUpdate();
                    UIHelper.GetUI(zoneScene, UIType.UIMain).GetComponent<UIMainComponent>().OnZeroClockUpdate();
                    break;
                case NumericType.HongBao:
                    int hongbao= args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HongBao);
                    UIHelper.GetUI(zoneScene, UIType.UIMain).GetComponent<UIMainComponent>().OnHongBao(hongbao);
                    break;
                case NumericType.PointRemain:
                    ReddotComponent reddotComponent = args.Unit.ZoneScene().GetComponent<ReddotComponent>();
                    reddotComponent.UpdateReddont(ReddotType.RolePoint);
                    break;
                case NumericType.BossInCombat:
                    int incombat = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.BossInCombat);
                    args.Unit.GetComponent<MonsterActRangeComponent>()?.OnBossInCombat(incombat);
                    break;
                case NumericType.Now_AI:
                    args.Unit.GetComponent<HeroHeadBarComponent>()?.UpdateAI();
                    break;
                case NumericType.HorseRide:
                    args.Unit.GetComponent<GameObjectComponent>()?.OnUpdateHorse();
                    args.Unit.GetComponent<HeroHeadBarComponent>()?.OnUpdateHorse();
                    break;
                case NumericType.HorseFightID:
                    if (args.Unit.MainHero)
                    {
                        uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                        uI.GetComponent<UIMainComponent>().OnHorseRide();
                    }
                    break;
                case NumericType.JiaYuanPickOther:
                case NumericType.JiaYuanGatherOther:
                    uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIJiaYuanMain);
                    if (uI != null)
                    {
                        uI.GetComponent<UIJiaYuanMainComponent>().UIJiaYuaVisitComponent.UpdateGatherTimes();
                    }
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
