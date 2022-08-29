using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2C_CenterServerInfoHandler : AMActorRpcHandler<Scene, C2C_CenterServerInfoReuest, C2C_CenterServerInfoRespone>
    {

        protected override async ETTask Run(Scene scene, C2C_CenterServerInfoReuest request, C2C_CenterServerInfoRespone response, Action reply)
        {
            //Log.ILog.Info("scene.DomainZone() = " + scene.DomainZone());
            List<DBCenterServerInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterServerInfo>(scene.DomainZone(), d => d.Id == scene.DomainZone());
            DBCenterServerInfo dBServerInfo = result[0];
            switch (request.infoType)
            {
                case 1:     //充值是否开启
                    if (dBServerInfo.RechageDic.Contains(request.Zone))
                    {
                        response.Value = "1";
                    }
                    else
                    {
                        response.Value = dBServerInfo.RechageOpen.ToString();
                    }
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
