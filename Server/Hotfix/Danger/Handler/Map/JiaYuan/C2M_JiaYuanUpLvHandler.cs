using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanUpLvHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanUpLvRequest, M2C_JiaYuanUpLvResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanUpLvRequest request, M2C_JiaYuanUpLvResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            int lvid = userInfoComponent.UserInfo.JiaYuanLv;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(lvid);
            if (jiaYuanConfig.NextID == 0)
            {
                reply();
                return;
            }
            if (userInfoComponent.UserInfo.Lv < jiaYuanConfig.NeedRoseLv)
            {
                response.Error = ErrorCore.ERR_LevelIsNot;
                reply();
                return;
            }
            if (userInfoComponent.UserInfo.JiaYuanExp < jiaYuanConfig.Exp)
            {
                response.Error = ErrorCore.ERR_ExpNoEnough;
                reply();
                return;
            }

            userInfoComponent.UpdateRoleData(UserDataType.JiaYuanExp, (jiaYuanConfig.Exp * -1).ToString());
            userInfoComponent.UpdateRoleData(UserDataType.JiaYuanLv, "1");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
