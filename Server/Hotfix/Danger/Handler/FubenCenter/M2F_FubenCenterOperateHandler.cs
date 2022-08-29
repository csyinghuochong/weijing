using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2F_FubenCenterOperateHandler : AMActorRpcHandler<Scene, M2F_FubenCenterOperateRequest, F2M_FubenCenterOpenResponse>
    {
        protected override async ETTask Run(Scene scene, M2F_FubenCenterOperateRequest request, F2M_FubenCenterOpenResponse response, Action reply)
        {
            FubenCenterComponent fubenCenterComponent= scene.GetComponent<FubenCenterComponent>();
            if (request.OperateType == 1)
            {
                fubenCenterComponent.FubenInstanceList.Add(request.FubenInstanceId);
            }
            else
            { 
                fubenCenterComponent.FubenInstanceList.Remove(request.FubenInstanceId);
            }
            Log.ILog.Debug($"FubenCenterOperate {request.OperateType} {request.FubenInstanceId} {fubenCenterComponent.FubenInstanceList.Count}");
            response.ServerInfo = fubenCenterComponent.ServerInfo;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
