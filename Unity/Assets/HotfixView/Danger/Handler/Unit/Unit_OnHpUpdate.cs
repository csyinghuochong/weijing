using UnityEngine;

namespace ET
{

    [Event]
    public class Unit_OnHpUpdate : AEventClass<EventType.UnitHpUpdate>
    {
        protected override  void Run(object upchange)
        {
            EventType.UnitHpUpdate args = upchange as EventType.UnitHpUpdate;

            GameObject HeadBar = null;
            //更新当前血量
            UIUnitHpComponent heroHeadBarComponent = args.Unit.GetComponent<UIUnitHpComponent>();
            if (heroHeadBarComponent!= null)
            {
                HeadBar = heroHeadBarComponent.GameObject;
                heroHeadBarComponent.UpdateBlood();
            }

            Unit attack = args.Attack;
            long myunitid = UnitHelper.GetMyUnitId(args.Unit.ZoneScene());
            if (SettingHelper.ShowBlood && HeadBar!= null )
            {
                bool mainattack = attack != null && UnitTypeHelper.GetMasterId(attack) == myunitid;
                if (args.Unit.MainHero  || UnitTypeHelper.GetMasterId(args.Unit) == myunitid|| mainattack)
                {
                    FallingFontComponent fallingFontComponent = args.Unit.DomainScene().GetComponent<FallingFontComponent>();

                    //触发飘字
                    fallingFontComponent.Play(HeadBar, args.ChangeHpValue, args.Unit, args.DamgeType);

                    //触发受击特效
                    FunctionEffect.GetInstance().PlayHitEffect(args.Unit, args.SkillID);
                }
                if (mainattack)
                {
                    args.Unit.GetComponent<GameObjectComponent>().OnHighLight();
                }
            }
            
            if (args.Unit.MainHero)
            {
                args.Unit.GetComponent<SingingComponent>().BeAttacking();
            }
            MapComponent mapComponent = args.Unit.ZoneScene().GetComponent<MapComponent>();
            //主界面血條
            UI mainui = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
            mainui?.GetComponent<UIMainComponent>().OnUpdateHP(args.Unit, mapComponent.SceneTypeEnum);

            if (mapComponent.SceneTypeEnum == SceneTypeEnum.PetDungeon
             || mapComponent.SceneTypeEnum == SceneTypeEnum.PetTianTi)
            {
                UI petmain = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIPetMain);
                petmain?.GetComponent<UIPetMainComponent>().OnUnitHpUpdate(args.Unit);
            }
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.TrialDungeon && args.Unit.Type == UnitType.Monster)
            {
                UI trialmain = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UITrialMain);
                trialmain.GetComponent<UITrialMainComponent>().OnUpdateHurt(args.ChangeHpValue * -1);
            }
        }
    }
}