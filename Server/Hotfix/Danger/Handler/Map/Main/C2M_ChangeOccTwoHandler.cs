using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ChangeOccTwoHandler : AMActorLocationRpcHandler<Unit, C2M_ChangeOccTwoRequest, M2C_ChangeOccTwoResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ChangeOccTwoRequest request, M2C_ChangeOccTwoResponse response, Action reply)
        {
            //判断当前角色等级是否达到
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Lv < 18) 
            {
                response.Error = ErrorCore.ERR_Occ_Hint_1;
                reply();
                return;
            }

            int OccTwo = unit.GetComponent<UserInfoComponent>().UserInfo.OccTwo;
            //判断当前角色是否已经进行转职
            if (OccTwo != 0)
            {
                response.Error = ErrorCore.ERR_Occ_Hint_2;
                reply();
                return;
            }

            unit.GetComponent<SkillSetComponent>().OnChangeOccTwoRequest(request.OccTwoID);
            unit.GetComponent<TaskComponent>().OnChangeOccTwo();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
