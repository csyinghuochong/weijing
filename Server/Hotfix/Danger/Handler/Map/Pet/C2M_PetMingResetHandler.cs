using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetMingResetHandler : AMActorLocationRpcHandler<Unit, C2M_PetMingResetRequest, M2C_PetMingResetResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetMingResetRequest request, M2C_PetMingResetResponse response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.PetMineReset) >= 3)
            {
                response.Error = ErrorCode.ERR_TimesIsNot;
                reply();
                return;
            }

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();   
            if (userInfoComponent.UserInfo.Diamond < 200)
            {
                response.Error = ErrorCode.ERR_DiamondNotEnoughError;
                reply();
                return;
            }
            int sceneid = BattleHelper.GetSceneIdByType( SceneTypeEnum.PetMing );
            numericComponent.ApplyChange( null, NumericType.PetMineReset, 1, 0 );
            userInfoComponent.UpdateRoleData( UserDataType.Diamond,  "-200");
            userInfoComponent.AddFubenTimes(sceneid, 5);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
