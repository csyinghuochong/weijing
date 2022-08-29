using System.Collections.Generic;
using UnityEngine;

namespace ET
{
	[ActorMessageHandler]
	public class C2M_PathfindingResultHandler : AMActorLocationHandler<Unit, C2M_PathfindingResult>
	{
		protected override async ETTask Run(Unit unit, C2M_PathfindingResult message)
		{
			Vector3 target = new Vector3(message.X, message.Y, message.Z);

			unit.GetComponent<SkillManagerComponent>().InterruptSkill();
			unit.FindPathMoveToAsync(target, null, !message.YaoGan).Coroutine();
			
			await ETTask.CompletedTask;
		}
	}
}