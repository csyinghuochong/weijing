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
            UIUnitHpComponent heroHeadBarComponent = args.Defend.GetComponent<UIUnitHpComponent>();
            if (heroHeadBarComponent!= null)
            {
                HeadBar = heroHeadBarComponent.GameObject;
                heroHeadBarComponent.UpdateBlood();
            }

            Scene zoneScene = args.Defend.ZoneScene();
            long myunitid = UnitHelper.GetMyUnitId(zoneScene);
            if (SettingHelper.ShowBlood && HeadBar!= null )
            {
                bool mainattack = args.Attack != null && UnitTypeHelper.GetMasterId(args.Attack) == myunitid;
                if (args.Defend.MainHero  || UnitTypeHelper.GetMasterId(args.Defend) == myunitid|| mainattack)
                {
                    FallingFontComponent fallingFontComponent = args.Defend.DomainScene().GetComponent<FallingFontComponent>();

                    //触发飘字
                    fallingFontComponent.Play(HeadBar, args.ChangeHpValue, args.Defend, args.DamgeType);

                    //触发受击特效
                    FunctionEffect.GetInstance().PlayHitEffect(args.Defend, args.SkillID);
                }

                if (args.Attack != null && args.Attack.MainHero)
                {
                    args.Defend.GetComponent<GameObjectComponent>().OnHighLight();
                }

                //攻击英雄或者Boss不能骑马
                if (args.Attack!=null && args.Attack.MainHero && ( args.Defend.Type == UnitType.Player || args.Defend.IsBoss()) )
                {
                    zoneScene.ZoneScene().GetComponent<BattleMessageComponent>().SetRideTargetUnit(args.Defend.Id);
                }
                if (args.Defend.MainHero && args.Attack != null && (args.Attack.Type == UnitType.Player|| args.Attack.IsBoss()))
                {
                    zoneScene.ZoneScene().GetComponent<BattleMessageComponent>().SetRideTargetUnit(args.Attack.Id);
                }
            }
            
            if (args.Defend.MainHero)
            {
                args.Defend.GetComponent<SingingComponent>().BeAttacking();
            }
            MapComponent mapComponent = args.Defend.ZoneScene().GetComponent<MapComponent>();
            //主界面血條
            UI mainui = UIHelper.GetUI(args.Defend.ZoneScene(), UIType.UIMain);
            mainui?.GetComponent<UIMainComponent>().OnUpdateHP(args.Defend, mapComponent.SceneTypeEnum);

            if (mapComponent.SceneTypeEnum == SceneTypeEnum.PetDungeon
             || mapComponent.SceneTypeEnum == SceneTypeEnum.PetTianTi)
            {
                UI petmain = UIHelper.GetUI(args.Defend.ZoneScene(), UIType.UIPetMain);
                petmain?.GetComponent<UIPetMainComponent>().OnUnitHpUpdate(args.Defend);
            }
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.TrialDungeon && args.Defend.Type == UnitType.Monster)
            {
                UI trialmain = UIHelper.GetUI(args.Defend.ZoneScene(), UIType.UITrialMain);
                trialmain.GetComponent<UITrialMainComponent>().OnUpdateHurt(args.ChangeHpValue * -1);
            }
        }
    }
}