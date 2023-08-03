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
                fsmComponent.ChangeState(FsmStateEnum.FsmSinging, message.StateValue);

                if (args.Unit.Type == UnitType.Monster)
                {
                    SkillInfo skillInfo = new SkillInfo();
                    skillInfo.PosX = args.Unit.Position.x;
                    skillInfo.PosY = args.Unit.Position.y;
                    skillInfo.PosZ = args.Unit.Position.z;
                    skillInfo.TargetAngle = int.Parse(message.StateValue.Split('_')[1]);
                    skillInfo.WeaponSkillID = int.Parse(message.StateValue.Split('_')[0]);
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillInfo.WeaponSkillID);
                    args.Unit.GetComponent<SkillYujingComponent>()?.ShowMonsterSkillYujin(skillInfo, skillConfig.SkillFrontSingTime, true);
                }
            }
            if (message.StateType == StateTypeEnum.Singing && message.StateOperateType == 2)
            {
                EventType.DataUpdate.Instance.DataType = DataType.UpdateSing;
                EventType.DataUpdate.Instance.DataParamString = $"{args.Unit.Id}_2_0";
                Game.EventSystem.PublishClass(EventType.DataUpdate.Instance);
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState, message.StateValue);
            }
            if (message.StateType == StateTypeEnum.OpenBox && message.StateOperateType == 1)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmOpenBox, message.StateValue);
            }
            if (message.StateType == StateTypeEnum.OpenBox && message.StateOperateType == 2)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState, message.StateValue);
            }

            if (message.StateType == StateTypeEnum.Stealth&& message.StateOperateType == 1)
            {
                //进入隐身
                //args.Unit.GetComponent<GameObjectComponent>()
                //args.Unit.GetComponent<UIUnitHpComponent>()
            }
            if (message.StateType == StateTypeEnum.Stealth && message.StateOperateType == 2)
            {
                //退出隐身

            }
        }
    }
}
