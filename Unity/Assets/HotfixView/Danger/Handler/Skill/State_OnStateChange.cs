using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class State_OnStateChange : AEventClass<EventType.StateChange>
    {
        protected override void Run(object numerice)
        {
            EventType.StateChange args = numerice as EventType.StateChange;
            M2C_UnitStateUpdate message = args.m2C_UnitStateUpdate;

            FsmComponent fsmComponent = args.Unit.GetComponent<FsmComponent>();
            if (fsmComponent == null)
            {
                return;
            }
            if (message.StateType == StateTypeEnum.Singing && message.StateOperateType == 1)
            {
                EventType.DataUpdate.Instance.DataType = DataType.UpdateSing;
                EventType.DataUpdate.Instance.DataParamString = $"{args.Unit.Id}_1_{message.StateValue}";
                Game.EventSystem.PublishClass(EventType.DataUpdate.Instance);
                fsmComponent.ChangeState(FsmStateEnum.FsmSinging);

                if (args.Unit.Type == UnitType.Monster)
                {
                    SkillInfo skillInfo = new SkillInfo();
                    skillInfo.PosX = args.Unit.Position.x;
                    skillInfo.PosY = args.Unit.Position.y;
                    skillInfo.PosZ = args.Unit.Position.z;
                    skillInfo.TargetAngle = int.Parse(message.StateValue.Split('_')[1]);
                    skillInfo.WeaponSkillID = int.Parse(message.StateValue.Split('_')[0]);
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillInfo.WeaponSkillID);
                    //Unit mainUnit = UnitHelper.GetMyUnitFromCurrentScene(args.Unit.DomainScene());
                    //bool canattack = mainUnit.IsCanAttackUnit(args.Unit);
                    args.Unit.GetComponent<SkillYujingComponent>()?.ShowMonsterSkillYujin(skillInfo, skillConfig.SkillFrontSingTime, true);
                }
            }
            if (message.StateType == StateTypeEnum.Singing && message.StateOperateType == 2)
            {
                EventType.DataUpdate.Instance.DataType = DataType.UpdateSing;
                EventType.DataUpdate.Instance.DataParamString = $"{args.Unit.Id}_2_0";
                Game.EventSystem.PublishClass(EventType.DataUpdate.Instance);
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState);
            }
            if (message.StateType == StateTypeEnum.OpenBox && message.StateOperateType == 1)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmOpenBox);
            }
            if (message.StateType == StateTypeEnum.OpenBox && message.StateOperateType == 2)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState);
            }

            // 隐身功能 实现思路应该要优化
            if (message.StateType == StateTypeEnum.Stealth && message.StateOperateType == 1)
            {
                args.Unit.GetComponent<GameObjectComponent>().EnterStealth();
            }
            if (message.StateType == StateTypeEnum.Stealth && message.StateOperateType == 2)
            {
                args.Unit.GetComponent<GameObjectComponent>().ExitStealth();
            }

            // 隐藏状态
            if (message.StateType == StateTypeEnum.Hide && message.StateOperateType == 1)
            {
                args.Unit.GetComponent<GameObjectComponent>().EnterHide();
            }
            if (message.StateType == StateTypeEnum.Hide && message.StateOperateType == 2)
            {
                args.Unit.GetComponent<GameObjectComponent>().ExitHide();
            }

            // 霸体红色描边
            if (message.StateType == StateTypeEnum.BaTi && message.StateOperateType == 1)
            {
                args.Unit.GetComponent<GameObjectComponent>().Material.shader = GlobalHelp.Find(StringBuilderHelper.Outline);
            }
            if (message.StateType == StateTypeEnum.BaTi && message.StateOperateType == 2)
            {
                args.Unit.GetComponent<GameObjectComponent>().Material.shader =
                        GlobalHelp.Find(args.Unit.GetComponent<GameObjectComponent>().OldShader);
            }
        }
    }
}
