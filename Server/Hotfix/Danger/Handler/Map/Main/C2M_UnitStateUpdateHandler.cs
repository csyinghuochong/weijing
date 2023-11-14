namespace ET
{

	[ActorMessageHandler]
    public class C2M_UnitStateUpdateHandler : AMActorLocationHandler<Unit, C2M_UnitStateUpdate>
    {
		protected override async ETTask Run(Unit unit, C2M_UnitStateUpdate message)
		{
			//驭剑的光能击吟唱前可以给自己加buff
			if (message.StateOperateType == 1 &&  message.StateType == StateTypeEnum.Singing)
			{
                //"StateValue":"61022102_0
                int buffid = 0;
                int skillid = int.Parse(message.StateValue.Split('_')[0]);
			
				ConfigHelper.SingingBuffList.TryGetValue(skillid, out buffid);
				if (buffid != 0)
				{
                    BuffData buffData_1 = new BuffData();
                    buffData_1.SkillId = 67000278;
                    buffData_1.BuffId = buffid;
                    unit.GetComponent<BuffManagerComponent>().BuffFactory(buffData_1, unit, null);
                }
            }

            if (message.StateOperateType == 1)
			{
				//增加
				unit.GetComponent<StateComponent>().StateTypeAdd(message.StateType, message.StateValue);
			}
			else
			{
				//移除
				unit.GetComponent<StateComponent>().StateTypeRemove(message.StateType);
			}
			
			await ETTask.CompletedTask;
		}
	}
}
