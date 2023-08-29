using System;

namespace ET
{
	//技能通用操作
    [ActorMessageHandler]
    public class C2M_SkillOperationHandler : AMActorLocationRpcHandler<Unit, C2M_SkillOperation, M2C_SkillOperation>
    {
		protected override async ETTask Run(Unit unit, C2M_SkillOperation request, M2C_SkillOperation response, Action reply)
		{
            //request.OperationType  = 1 重置技能点
            //request.OperationType  = 2 重置职业
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            int level = userInfoComponent.UserInfo.Lv;
			int sp = userInfoComponent.UserInfo.Sp;
			switch (request.OperationType)
			{
				case 1:
                    GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(20);
                    int needGold = int.Parse(globalValueConfig.Value);
                    userInfoComponent = unit.GetComponent<UserInfoComponent>();
                    if (userInfoComponent.UserInfo.Gold < needGold)
                    {
                        response.Error = ErrorCode.ERR_GoldNotEnoughError;
                        reply();
                        return;
                    }

                    userInfoComponent.UpdateRoleMoneySub(UserDataType.Gold, (needGold * -1).ToString());
					userInfoComponent.UpdateRoleData(UserDataType.Sp, (level - sp - 1).ToString());
					unit.GetComponent<SkillSetComponent>().OnSkillReset();
					break;
				case 2:
                     globalValueConfig = GlobalValueConfigCategory.Instance.Get(29);
                     needGold = int.Parse(globalValueConfig.Value);
                   
                    if (userInfoComponent.UserInfo.Diamond < needGold)
                    {
                        response.Error = ErrorCode.ERR_DiamondNotEnoughError;
                        reply();
                        return;
                    }

                    sp = unit.GetComponent<SkillSetComponent>().OnOccReset();
					userInfoComponent.UpdateRoleData(UserDataType.Sp, sp.ToString());
					break;
			}

			reply();
			await ETTask.CompletedTask;
		}
	}
}
