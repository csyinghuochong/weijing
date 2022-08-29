using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				unit.GetComponent<StateComponent>().StateTypeAdd((StateTypeData)message.StateType, message.StateValue);
			}
			else
			{
				//移除
				unit.GetComponent<StateComponent>().StateTypeRemove((StateTypeData)message.StateType);
			}
			
			await ETTask.CompletedTask;
		}
	}
}
