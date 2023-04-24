namespace ET
{

	[ActorMessageHandler]
    public class C2M_UnitStateUpdateHandler : AMActorLocationHandler<Unit, C2M_UnitStateUpdate>
    {
		protected override async ETTask Run(Unit unit, C2M_UnitStateUpdate message)
		{

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
