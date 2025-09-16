
using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_GetWeChatOACodeHandler : AMActorLocationRpcHandler<Unit, C2M_GetWeChatOACode, M2C_GetWeChatOACode>
    {
        protected override async ETTask Run(Unit unit, C2M_GetWeChatOACode request, M2C_GetWeChatOACode response, Action reply)
        {
            long LoginCenterConfigSceneId = StartSceneConfigCategory.Instance.LoginCenterConfig.InstanceId;

            var L2M_GetWeChatOACod = (L2M_GetWeChatOACode)await MessageHelper.CallActor(LoginCenterConfigSceneId, new M2L_GetWeChatOACode()
            {
                UnitID = unit.Id
            });

            if (L2M_GetWeChatOACod != null)
            {
                response.Error = L2M_GetWeChatOACod.Error;
                response.Code = L2M_GetWeChatOACod.Code;
            }
            else
            {
                response.Error = ErrorCode.ERR_NetWorkError;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
