using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_FubenTimesResetHandler : AMActorLocationRpcHandler<Unit, C2M_FubenTimesResetRequest, M2C_FubenTimesResetResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_FubenTimesResetRequest request, M2C_FubenTimesResetResponse response, Action reply)
        {
            if (request.SceneType != SceneTypeEnum.PetTianTi)
            {
                response.Error = ErrorCore.ERR_NetWorkError;
                reply();
                return;
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.FubenTimesReset) > 0)
            {
                response.Error = ErrorCore.ERR_RequestRepeatedly;
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (!bagComponent.OnCostItemData($"3;200"))
            {
                response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                reply();
                return;
            }
            int sceneId = BattleHelper.GetSceneIdByType(request.SceneType);
            numericComponent.ApplyValue(NumericType.FubenTimesReset, 1 | SceneTypeEnum.PetTianTi);
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            userInfoComponent.ClearFubenTimes(sceneId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
