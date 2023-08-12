using UnityEngine;

namespace ET
{

    [Event]
    public class Unit_OnHpUpdate : AEventClass<EventType.UnitHpUpdate>
    {
        protected override  void Run(object upchange)
        {
            EventType.UnitHpUpdate args = upchange as EventType.UnitHpUpdate;
            Unit unitDefend = args.Defend;
            Unit unitAttack = args.Attack;  

            if (unitDefend == null || unitDefend.IsDisposed)
            {
                return;
            }

            Scene zoneScene = unitDefend.ZoneScene();
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();

            long myunitid = UnitHelper.GetMyUnitId(zoneScene);

            bool mainattack = unitAttack != null && unitAttack.MainHero;
            if (args.ChangeHpValue < 0 && mainattack)
            {
                unitDefend.GetComponent<GameObjectComponent>()?.OnHighLight();
            }

            bool isnotattackSelf = unitAttack != null && unitAttack != unitDefend;
            bool defendisPlayerorBoss = unitDefend.Type == UnitType.Player || unitDefend.IsBoss();
            bool attackidPlayerorBoss = unitAttack!= null && (unitAttack.Type == UnitType.Player || unitAttack.IsBoss());

            //攻击英雄或者Boss不能骑马
            if (args.ChangeHpValue < 0 && mainattack && isnotattackSelf && defendisPlayerorBoss)
            {
                zoneScene.GetComponent<BattleMessageComponent>().SetRideTargetUnit(unitDefend.Id);
            }
            if (args.ChangeHpValue < 0 && unitDefend.MainHero && isnotattackSelf && attackidPlayerorBoss)
            {
                zoneScene.GetComponent<BattleMessageComponent>().SetRideTargetUnit(unitAttack.Id);
            }

            //更新当前血量
            UIUnitHpComponent heroHeadBarComponent = unitDefend.GetComponent<UIUnitHpComponent>();
            if (SettingHelper.ShowBlood && heroHeadBarComponent != null && heroHeadBarComponent.GameObject)
            {
                heroHeadBarComponent.UpdateBlood();

                GameObject  GameObject = heroHeadBarComponent.GameObject;
                bool showfloattext = unitAttack != null && UnitTypeHelper.GetMasterId(unitAttack) == myunitid;
                if (unitDefend.MainHero || UnitTypeHelper.GetMasterId(unitDefend) == myunitid || showfloattext)
                {
                    FallingFontComponent fallingFontComponent = unitDefend.DomainScene().GetComponent<FallingFontComponent>();

                    //触发飘字
                    fallingFontComponent.Play(GameObject, args.ChangeHpValue, unitDefend, args.DamgeType);

                    //触发受击特效
                    FunctionEffect.GetInstance().PlayHitEffect(unitDefend, args.SkillID);
                }
            }

            //主界面血條
            UI mainui = UIHelper.GetUI(zoneScene, UIType.UIMain);
            mainui?.GetComponent<UIMainComponent>().OnUpdateHP(unitDefend, mapComponent.SceneTypeEnum);

            if (mapComponent.SceneTypeEnum == SceneTypeEnum.PetDungeon
             || mapComponent.SceneTypeEnum == SceneTypeEnum.PetTianTi)
            {
                UI petmain = UIHelper.GetUI(zoneScene, UIType.UIPetMain);
                petmain?.GetComponent<UIPetMainComponent>()?.OnUnitHpUpdate(unitDefend);
            }
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.TrialDungeon && unitDefend.Type == UnitType.Monster)
            {
                UI trialmain = UIHelper.GetUI(zoneScene, UIType.UITrialMain);
                trialmain?.GetComponent<UITrialMainComponent>()?.OnUpdateHurt(args.ChangeHpValue * -1);
            }
        }
    }
}