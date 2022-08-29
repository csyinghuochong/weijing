using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
	//设置技能位置
	[ActorMessageHandler]
	public class C2M_SkillInitHandler : AMActorLocationRpcHandler<Unit, C2M_SkillInitRequest, M2C_SkillInitResponse>
	{
		protected override async ETTask Run(Unit unit, C2M_SkillInitRequest request, M2C_SkillInitResponse response, Action reply)
		{
			response.SkillList = unit.GetComponent<SkillSetComponent>().SkillList;
			response.TianFuList = unit.GetComponent<SkillSetComponent>().TianFuList;
			reply();
			await ETTask.CompletedTask;
		}
	}
}
