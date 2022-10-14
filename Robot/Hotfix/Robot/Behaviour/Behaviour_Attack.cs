using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class Behaviour_Attack : BehaviourHandler
    {
        public override string BehaviourId()
        {
            return BehaviourType.Behaviour_Attack;
        }

        public override int Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            //if (!string.IsNullOrEmpty(aiComponent.NewBehaviour))
            //{
            //    return 1;
            //}
            if (aiComponent.TargetID == 0)
            {
                return 1;
            }
            Unit target = aiComponent.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
            if (target == null || target.IsDisposed)
            {
                return 1;
            }
            float distance = PositionHelper.Distance2D(target, UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene()));
            if (distance < 1f)
            {
                return 0;
            }
            else
            {
                return 1;
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
                if (target != null && target.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Hp) > 0
                   && PositionHelper.Distance2D(target, unit) <= 1)
                {
                    Vector3 direction = target.Position - unit.Position;
                    float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));

                    C2M_SkillCmd cmd = aiComponent.c2mSkillCmd;
                    //触发技能
                    int skillID = aiComponent.ZoneScene().GetComponent<SkillSetComponent>().GetCanUseSkill();
                    float targetDistance = Vector3.Distance(unit.Position, target.Position);
                    MapHelper.SendUseSkill(aiComponent.ZoneScene(), skillID, 0,Mathf.FloorToInt(ange), target.Id, targetDistance).Coroutine();
                }
                else
                {
                    //拾取道具
                    List<DropInfo> ids = MapHelper.GetCanShiQu(aiComponent.ZoneScene());
                    if (ids.Count > 0)
                    {
                        Log.ILog.Debug("Behaviour_Attack: SendShiquItem");
                        await aiComponent.ZoneScene().GetComponent<BagComponent>().CheckItemList_1();
                        await MapHelper.SendShiquItem(aiComponent.ZoneScene(), ids);
                    }

                    //有任务完成
                    TaskComponent taskComponent = aiComponent.ZoneScene().GetComponent<TaskComponent>();
                    if (1 == RandomHelper.RandomNumber(0,100) && taskComponent.GetCompltedTaskList().Count > 0)
                    {
                        Log.ILog.Debug("Behaviour_Attack:To Behaviour_Task");
                        aiComponent.ChangeBehaviour(BehaviourType.Behaviour_Task);
                        return;
                    }
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_ZhuiJi);
                    return;
                }

                int maxHp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxHp);
                int curHp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp);
                if (curHp < maxHp * 0.5)
                {
                    Log.ILog.Debug("Behaviour_Attack: SendUseItem->AddHp");
                    BagInfo bagInfo = aiComponent.ZoneScene().GetComponent<BagComponent>().GetBagInfo(10010001);
                    if (bagInfo != null)
                    {
                        await aiComponent.ZoneScene().GetComponent<BagComponent>().SendUseItem(bagInfo);
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
