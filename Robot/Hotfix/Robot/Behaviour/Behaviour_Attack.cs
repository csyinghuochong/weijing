using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class Behaviour_Attack : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Attack;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.TargetID == 0)
            {
                return false;
            }
            Unit target = aiComponent.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
            if (target == null || target.IsDisposed)
            {
                return false;
            }
            float distance = PositionHelper.Distance2D(target, UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene()));
            if (distance < aiComponent.ActDistance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            BagComponent bagComponent1 = aiComponent.ZoneScene().GetComponent<BagComponent>();
            bagComponent1.CheckBagIsFull();
            long instanceId = unit.InstanceId;
            while (true)
            {
                if (instanceId != unit.InstanceId)
                {
                    return;
                }
                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target != null && target.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Dead) == 0
                    && Vector3.Distance(unit.Position,target.Position) < aiComponent.ActDistance)
                {
                    int[] weights = new int[] { 70, 30};
                    int index = RandomHelper.RandomByWeight(weights);
                    if (index == 0)
                    {
                        zoneScene.GetComponent<AttackComponent>().AutoAttack_1(unit, target);
                    }
                    if (index == 1)
                    {
                        //触发技能
                        SkillPro skillPro = aiComponent.ZoneScene().GetComponent<SkillSetComponent>().GetCanUseSkill();
                        if (skillPro.SkillSetType == (int)SkillSetEnum.Skill)
                        {
                            Vector3 direction = target.Position - unit.Position;
                            float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
                            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkill(skillPro.SkillID, bagComponent1.GetEquipType()));
                            float targetDistance = skillConfig.SkillZhishiType == 1 ? Vector3.Distance(unit.Position, target.Position) : 0;
                            unit.GetComponent<SkillManagerComponent>().SendUseSkill(skillPro.SkillID, 0, Mathf.FloorToInt(ange), target.Id, targetDistance).Coroutine();
                        }
                    }

                    int maxHp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxHp);
                    int curHp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp);
                    if (curHp < maxHp * 0.75)
                    {
                        UserInfo userInfo = zoneScene.GetComponent<UserInfoComponent>().UserInfo;
                        ItemConfig itemConfig = ItemConfigCategory.Instance.Get(BattleHelper.GetYaoShuiItemID(userInfo.Lv));
                        unit.GetComponent<SkillManagerComponent>().SendUseSkill(int.Parse(itemConfig.ItemUsePar), itemConfig.Id,
                            (int)Quaternion.QuaternionToEuler(unit.Rotation).y, 0, 0).Coroutine();
                    }
                }
                else
                {
                    aiComponent.TargetID = 0;
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_ZhuiJi);
                    return;
                }

                bool timeRet = await TimerComponent.Instance.WaitAsync(zoneScene.GetComponent<AttackComponent>().CDTime + 10, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}
