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
            Log.ILog.Debug("Behaviour_Attack: Enter");
            Scene zoneScene = aiComponent.ZoneScene();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            aiComponent.ZoneScene().GetComponent<BagComponent>().CheckBagIsFull();
            long instanceId = unit.InstanceId;
            while (true)
            {
                if (instanceId != unit.InstanceId)
                {
                    return;
                }
                //Log.ILog.Debug("Behaviour_Attack: Execute");
                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target != null && target.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Dead) == 0
                    && Vector3.Distance(unit.Position,target.Position) < aiComponent.ActDistance)
                {
                    int[] weights = new int[] { 70, 10, 30};
                    int index = RandomHelper.RandomByWeight(weights);
                    if (zoneScene.GetComponent<AttackComponent>() == null)
                    {
                        Log.Debug($"AttackComponent == null {zoneScene.Id}:{zoneScene.IsDisposed}");
                        Log.Debug($"AttackComponent == null {zoneScene.GetComponent<UserInfoComponent>()!=null}");
                        return;
                    }
                    if (index == 0)
                    {
                        zoneScene.GetComponent<AttackComponent>().AutoAttack_1(unit, target);
                    }
                    if (index == 1)
                    {
                        int maxHp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxHp);
                        int curHp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp);
                        if (curHp < maxHp * 0.5)
                        {
                            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(10010001);
                            unit.GetComponent<SkillManagerComponent>().SendUseSkill(int.Parse(itemConfig.ItemUsePar), itemConfig.Id,
                                (int)Quaternion.QuaternionToEuler(unit.Rotation).y, 0, 0).Coroutine();
                        }
                    }
                    if (index == 2)
                    {
                        //触发技能
                        SkillPro skillPro = aiComponent.ZoneScene().GetComponent<SkillSetComponent>().GetCanUseSkill();
                        if (skillPro.SkillSetType == (int)SkillSetEnum.Skill)
                        {
                            Vector3 direction = target.Position - unit.Position;
                            float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
                            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillPro.SkillID);
                            float targetDistance = skillConfig.SkillZhishiType == 1 ? Vector3.Distance(unit.Position, target.Position) : 0;
                            target.GetComponent<SkillManagerComponent>().SendUseSkill(skillPro.SkillID, 0, Mathf.FloorToInt(ange), target.Id, targetDistance).Coroutine();
                        }
                    }
                }
                else
                {
                    aiComponent.TargetID = 0;
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_ZhuiJi);
                    return;
                }

                bool timeRet = await TimerComponent.Instance.WaitAsync(200, cancellationToken);
                if (!timeRet)
                {
                    Log.ILog.Debug("Behaviour_Attack: Eixt2");
                    return;
                }
            }
        }
    }
}
