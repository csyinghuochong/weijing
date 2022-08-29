namespace ET
{

    [Event]
    public class UnitHp_OnChange : AEventClass<EventType.UnitHpUpdate>
    {
        protected override  void Run(object upchange)
        {
            EventType.UnitHpUpdate args = upchange as EventType.UnitHpUpdate;
            //更新当前血量
            HeroHeadBarComponent heroHeadBarComponent = args.Unit.GetComponent<HeroHeadBarComponent>();
            if (heroHeadBarComponent!= null)
            {
                heroHeadBarComponent.UpdateBlood();
            }

            FallingFontComponent fallingFontComponent = args.Unit.DomainScene().GetComponent<FallingFontComponent>();
            if (fallingFontComponent != null)
            {
                //触发飘字
                fallingFontComponent.Play(args.ChangeHpValue, args.Unit, args.DamgeType);
            }

            //触发受击特效
            if (args.SkillID != 0)
            {
                FunctionEffect.GetInstance().PlayHitEffect(args.Unit, args.SkillID);
            }

            //主界面血條
            UI mainui = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
            mainui.GetComponent<UIMainComponent>().OnUpdateHP(args.Unit);

            MapComponent mapComponent = args.Unit.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.PetDungeon)
            {
                UI petmain = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIPetMain);
                petmain?.GetComponent<UIPetMainComponent>().OnUnitHpUpdate(args.Unit);
            }
        }
    }
}