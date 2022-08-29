using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_YueKaOpenHandler : AMActorLocationRpcHandler<Unit, C2M_YueKaOpenRequest, M2C_YueKaOpenResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_YueKaOpenRequest request, M2C_YueKaOpenResponse response, Action reply)
        {
            int cost = int.Parse( GlobalValueConfigCategory.Instance.Get(37).Value );
            //判定是否是月卡用户
            if (!unit.GetComponent<UserInfoComponent>().IsYueKaStates(unit.GetComponent<NumericComponent>()))
            {
                //判定是否钻石足够
                if (unit.GetComponent<UserInfoComponent>().UserInfo.Diamond >= cost)
                {
                    //开启月卡
                    unit.GetComponent<UserInfoComponent>().UpdateYueKaTime();

                    unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, (cost*-1).ToString()).Coroutine();
                    
                    long addPilao = int.Parse(GlobalValueConfigCategory.Instance.Get(26).Value) - int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);
                    unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.PiLao, addPilao.ToString()).Coroutine();
                }
                else
                {
                    response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                }
            }
            else
            {
                response.Error = ErrorCore.ERR_RoleYueKaRepeat;
            }

            reply();
            await ETTask.CompletedTask;
        }

    }
}
