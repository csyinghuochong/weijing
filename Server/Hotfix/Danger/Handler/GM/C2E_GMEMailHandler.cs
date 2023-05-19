using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2E_GMEMailHandler : AMActorRpcHandler<Scene, C2E_GMEMailRequest, E2C_GMEMailResponse>
    {

        protected override async ETTask Run(Scene scene, C2E_GMEMailRequest request, E2C_GMEMailResponse response, Action reply)
        {
            if (request.UserId == 0)
            {
                //全服邮件
            }
            else
            {
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserId, Component = DBHelper.DBMailInfo });
                DBMailInfo dBMainInfo = d2GGetUnit.Component as DBMailInfo;

                if (dBMainInfo.MailInfoList.Count > 100)
                {
                    dBMainInfo.MailInfoList.RemoveAt(0);
                }
                request.MailInfo.MailId = IdGenerater.Instance.GenerateId();
                dBMainInfo.MailInfoList.Add(request.MailInfo);
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = request.UserId, EntityByte = MongoHelper.ToBson(dBMainInfo), ComponentType = DBHelper.DBMailInfo });
            }
            reply();
        }

    }
}
