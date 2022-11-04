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
            if (distance < 3f)
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
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene());

            long instanceId = unit.InstanceId;
            while (true)
            {
                if (instanceId != unit.InstanceId)
                {
                    return;
                }
                //Log.ILog.Debug("Behaviour_Attack: Execute");
                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target != null && target.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Dead) == 0)
                {
                    Vector3 direction = target.Position - unit.Position;
                    float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));

                    float value = RandomHelper.RandFloat01();
                    int actSkillId =  aiComponent.ZoneScene().GetComponent<SkillSetComponent>().GetAckSkillId();
                    if (value > 0.1f)
                    {
                        target.GetComponent<SkillManagerComponent>().SendUseSkill(actSkillId, 0, Mathf.FloorToInt(ange), target.Id, 0f).Coroutine();
                    }
                    else
                    {
                        //触发技能
                        SkillPro skillPro = aiComponent.ZoneScene().GetComponent<SkillSetComponent>().GetCanUseSkill();
                        if (skillPro != null)
                        {
                            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillPro.SkillID);
                            float targetDistance = skillConfig.SkillZhishiType == 1 ? Vector3.Distance(unit.Position, target.Position) : 0;
                            target.GetComponent<SkillManagerComponent>().SendUseSkill(skillPro.SkillID, 0, Mathf.FloorToInt(ange), target.Id, targetDistance).Coroutine();
                        }
                    }
                }
                else
                {
                    //拾取道具
                    List<DropInfo> ids = MapHelper.GetCanShiQu(aiComponent.ZoneScene());
                    if (ids.Count > 0)
                    {
                        Log.ILog.Debug("Behaviour_Attack: SendShiquItem");
                        await MapHelper.SendShiquItem(aiComponent.ZoneScene(), ids);
                        await aiComponent.ZoneScene().GetComponent<BagComponent>().CheckYaoShui();
                    }
                    aiComponent.TargetID = 0;
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_ZhuiJi);
                    return;
                }

                int maxHp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxHp);
                int curHp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp);
                if (curHp < maxHp * 0.5)
                {
                    BagInfo bagInfo = aiComponent.ZoneScene().GetComponent<BagComponent>().GetBagInfo(10010001);
                    if (bagInfo != null)
                    {
                        Log.ILog.Debug("Behaviour_Attack: SendUseItem->AddHp");
                        ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                        unit.GetComponent<SkillManagerComponent>().SendUseSkill(int.Parse(itemConfig.ItemUsePar), itemConfig.Id,
                            (int)Quaternion.QuaternionToEuler(unit.Rotation).y, 0, 0).Coroutine();
                    }
                }

                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet)
                {
                    Log.ILog.Debug("Behaviour_Attack: Eixt2");
                    return;
                }
            }
        }
    }
}
