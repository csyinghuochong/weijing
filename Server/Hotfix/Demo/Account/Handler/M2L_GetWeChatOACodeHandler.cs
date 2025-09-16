using System;

namespace ET
{
    //登录中心服
    public class M2L_GetWeChatOACodeHandler : AMActorRpcHandler<Scene, M2L_GetWeChatOACode, L2M_GetWeChatOACode>
    {
        protected override async ETTask Run(Scene scene, M2L_GetWeChatOACode request, L2M_GetWeChatOACode response, Action reply)
        {
            try
            {
                await ETTask.CompletedTask;
                response.Code = scene.GetComponent<WeChatOACodeComponent>().GenerateWeChatOACode(request.UnitID);
                reply();
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
        }
    }
}