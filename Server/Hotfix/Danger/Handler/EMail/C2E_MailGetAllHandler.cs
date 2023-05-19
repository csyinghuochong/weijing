using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2E_MailGetAllHandler : AMActorRpcHandler<Scene, C2E_GetAllMailRequest, E2C_GetAllMailResponse>
    {
        protected override async ETTask Run(Scene scene, C2E_GetAllMailRequest request, E2C_GetAllMailResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.ActorId, Component = DBHelper.DBMailInfo });
            if (d2GGetUnit.Component != null)
            {
                DBMailInfo dBMailInfo = d2GGetUnit.Component as DBMailInfo;
                int getnumber = Math.Min(100, dBMailInfo.MailInfoList.Count);
                response.MailInfos = dBMailInfo.MailInfoList.GetRange(0, getnumber);

                for (int i = response.MailInfos.Count - 1; i >= 0; i--)
                {
                    if (response.MailInfos[i].ItemList.Count != 1)
                    {
                        continue;
                    }
                    if (response.MailInfos[i].ItemList[0].ItemID == 10032003)
                    {
                        response.MailInfos.RemoveAt(i);
                        continue;
                    }
                }
            }
            reply();
        }

    }
}
