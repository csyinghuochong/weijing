using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class P2E_PaiMaiOverTimeHandler : AMActorRpcHandler<Scene, P2E_PaiMaiOverTimeRequest, E2P_PaiMaiOverTimeResponse>
    {
        protected override async ETTask Run(Scene scene, P2E_PaiMaiOverTimeRequest request, E2P_PaiMaiOverTimeResponse response, Action reply)
        {
            
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.PaiMaiItemInfo.UserId, Component = DBHelper.DBMailInfo });
            DBMailInfo dBMainInfo = d2GGetUnit.Component as DBMailInfo;

            long mailid = IdGenerater.Instance.GenerateId();
            dBMainInfo.MailInfoList.Add(new MailInfo() { MailId = mailid, Context = "拍卖下架_" + mailid.ToString(), Title = "拍卖下架", ItemList = new List<BagInfo>() { request.PaiMaiItemInfo.BagInfo } });

            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = request.PaiMaiItemInfo.UserId, Component = dBMainInfo, ComponentType = DBHelper.DBMailInfo });

            reply();
        }
    }
}
