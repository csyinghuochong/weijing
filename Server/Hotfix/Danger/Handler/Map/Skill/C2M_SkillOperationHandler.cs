using System;

namespace ET
{
	//技能通用操作
    [ActorMessageHandler]
    public class C2M_SkillOperationHandler : AMActorLocationRpcHandler<Unit, C2M_SkillOperation, M2C_SkillOperation>
    {
		protected override async ETTask Run(Unit unit, C2M_SkillOperation request, M2C_SkillOperation response, Action reply)
		{
			GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(request.OperationType == 1 ? 20 : 29);
			int needGold = int.Parse(globalValueConfig.Value);
			UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
			if (userInfoComponent.UserInfo.Diamond < needGold)
			{
				response.Error = ErrorCore.ERR_DiamondNotEnoughError;
				reply();
				return;
			}

			//request.OperationType  = 1 重置技能点
			//request.OperationType  = 2 重置职业
			int level = userInfoComponent.UserInfo.Lv;
			int sp = userInfoComponent.UserInfo.Sp;
			switch (request.OperationType)
			{
				case 1:
					userInfoComponent.UpdateRoleData(UserDataType.Diamond, (needGold * -1).ToString()).Coroutine();
					userInfoComponent.UpdateRoleData(UserDataType.Sp, (level - sp - 1).ToString()).Coroutine();
					unit.GetComponent<SkillSetComponent>().OnSkillReset();
					break;
				case 2:
					sp =unit.GetComponent<SkillSetComponent>().OnOccReset();
					userInfoComponent.UpdateRoleData(UserDataType.Sp, sp.ToString()).Coroutine();
					break;
			}

			reply();
			await ETTask.CompletedTask;
		}
	}
}
