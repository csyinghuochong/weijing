using UnityEngine;

namespace ET
{

    [Event]
    public class Unit_OnHpUpdate : AEventClass<EventType.UnitHpUpdate>
    {
        protected override  void Run(object upchange)
        {
            EventType.UnitHpUpdate args = upchange as EventType.UnitHpUpdate;
            if (args.Defend == null || args.Defend.IsDisposed)
            {
                return;
            }

            Scene zoneScene = args.Defend.ZoneScene();
            long myunitid = UnitHelper.GetMyUnitId(zoneScene);
            //更新当前血量
            UIUnitHpComponent heroHeadBarComponent = args.Defend.GetComponent<UIUnitHpComponent>();
            if (SettingHelper.ShowBlood && heroHeadBarComponent != null && heroHeadBarComponent.GameObject)
            {
                heroHeadBarComponent.UpdateBlood();

                GameObject  GameObject = heroHeadBarComponent.GameObject;
                bool showfloattext = args.Attack != null && UnitTypeHelper.GetMasterId(args.Attack) == myunitid;
                if (args.Defend.MainHero || UnitTypeHelper.GetMasterId(args.Defend) == myunitid || showfloattext)
                {
                    FallingFontComponent fallingFontComponent = args.Defend.DomainScene().GetComponent<FallingFontComponent>();

                    //触发飘字
                    fallingFontComponent.Play(GameObject, args.ChangeHpValue, args.Defend, args.DamgeType);

                    //触发受击特效
                    FunctionEffect.GetInstance().PlayHitEffect(args.Defend, args.SkillID);
                }

                bool maiattack = args.Attack != null && args.Attack.MainHero;
                if (args.ChangeHpValue < 0 && maiattack)
                {
                    args.Defend.GetComponent<GameObjectComponent>().OnHighLight();
                }

                //攻击英雄或者Boss不能骑马
                if (args.ChangeHpValue < 0 && maiattack && args.Attack != args.Defend && (args.Defend.Type == UnitType.Player || args.Defend.IsBoss()))
                {
                    zoneScene.GetComponent<BattleMessageComponent>().SetRideTargetUnit(args.Defend.Id);
                }
                if (args.ChangeHpValue < 0 && args.Defend.MainHero && args.Attack != args.Defend && (args.Attack.Type == UnitType.Player || args.Attack.IsBoss()))
                {
                    zoneScene.GetComponent<BattleMessageComponent>().SetRideTargetUnit(args.Attack.Id);
                }
            }


            MapComponent mapComponent = args.Defend.ZoneScene().GetComponent<MapComponent>();
            //主界面血條
            UI mainui = UIHelper.GetUI(args.Defend.ZoneScene(), UIType.UIMain);
            mainui?.GetComponent<UIMainComponent>().OnUpdateHP(args.Defend, mapComponent.SceneTypeEnum);

            if (mapComponent.SceneTypeEnum == SceneTypeEnum.PetDungeon
             || mapComponent.SceneTypeEnum == SceneTypeEnum.PetTianTi)
            {
                UI petmain = UIHelper.GetUI(args.Defend.ZoneScene(), UIType.UIPetMain);
                petmain?.GetComponent<UIPetMainComponent>()?.OnUnitHpUpdate(args.Defend);
            }
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.TrialDungeon
                && args.Defend.Type == UnitType.Monster)
            {
                UI trialmain = UIHelper.GetUI(args.Defend.ZoneScene(), UIType.UITrialMain);
                trialmain?.GetComponent<UITrialMainComponent>()?.OnUpdateHurt(args.ChangeHpValue * -1);
            }
        }
    }
}