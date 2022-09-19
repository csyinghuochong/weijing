namespace ET
{

    [Event]
    public class Unit_OnNumericUpdate : AEventClass<EventType.UnitNumericUpdate>
    {
        protected override void Run(object numerice)
        {
            EventType.UnitNumericUpdate args = numerice as EventType.UnitNumericUpdate;
            switch (args.NumericType)
            {
                case NumericType.Now_Stall:
                    int stallType = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Stall);
                    args.Unit.GetComponent<HeroHeadBarComponent>().OnUnitStallUpdate(stallType);
                    args.Unit.GetComponent<GameObjectComponent>().OnUnitStallUpdate(stallType).Coroutine();

                    if (args.Unit.MainHero)
                    {
                        UI uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                        uI.GetComponent<UIMainComponent>().UIStall.SetActive(stallType == 1);
                    }
                    break;
                case NumericType.Now_Damage:
                    UI uI_2 = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                    uI_2.GetComponent<UIMainComponent>().OnUpdateDamage(args.Unit);
                    break;
                case NumericType.Pet_ChouKa:
                    UI uipet = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIPetEgg);
                    uipet?.GetComponent<UIPetEggComponent>().UpdateChouKaTime();
                    break;
                case NumericType.Now_Weapon:
                    int weaponId = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon);
                    if (weaponId != 0)
                    {
                        ItemConfig itemConfig = ItemConfigCategory.Instance.Get(weaponId);
                        args.Unit.GetComponent<ChangeEquipComponent>().ChangeWeapon(itemConfig.ItemModelID);
                    }
                    else
                    {
                        args.Unit.GetComponent<ChangeEquipComponent>().ChangeWeapon("");
                    }
                    break;
                case NumericType.Now_XiLian:
                    break;
                case NumericType.Ling_DiLv:
                    break;
                case NumericType.Ling_DiExp:
                    break;
                case NumericType.Pet_Skin:
                    args.Unit.RemoveComponent<EffectViewComponent>();
                    args.Unit.RemoveComponent<GameObjectComponent>();
                    args.Unit.RemoveComponent<AnimatorComponent>();
                    args.Unit.RemoveComponent<HeroTransformComponent>();
                    args.Unit.RemoveComponent<FsmComponent>();
                    args.Unit.RemoveComponent<HeroHeadBarComponent>();
                    args.Unit.AddComponent<GameObjectComponent>();
                    break;
                case NumericType.ZeroClock:
                    UserInfoComponent userInfoComponent = args.Unit.ZoneScene().GetComponent<UserInfoComponent>();
                    ActivityComponent activityComponent = args.Unit.ZoneScene().GetComponent<ActivityComponent>();
                    userInfoComponent.UserInfo.DayFubenTimes.Clear();
                    userInfoComponent.UserInfo.ChouKaRewardIds.Clear();
                    break;
                case NumericType.PointRemain:
                    ReddotComponent reddotComponent = args.Unit.ZoneScene().GetComponent<ReddotComponent>();
                    reddotComponent.UpdateReddont(ReddotType.RolePoint);
                    break;
                case NumericType.Tower_ID:
                    int towerId = args.Unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Tower_ID);
                    if (towerId != 0)
                    {
                        uI_2 = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                        uI_2.GetComponent<UIMainComponent>().OnTowerOpen(towerId);
                    }
                    break;
            }
        }

    }
}
