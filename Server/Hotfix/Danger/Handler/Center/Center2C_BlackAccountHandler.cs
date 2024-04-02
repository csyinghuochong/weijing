using System;
using System.Collections.Generic;

namespace ET
{

    [MessageHandler]
    public class Center2C_BlackAccountHandler : AMRpcHandler<C2Center_BlackAccountRequest, Center2C_BlackAccountResponse>
    {
        protected override async ETTask Run(Session session, C2Center_BlackAccountRequest request, Center2C_BlackAccountResponse response, Action reply)
        {
            List<DBCenterAccountInfo> centerAccountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(session.DomainZone(), d => d.Account == request.Account && d.Password == request.Password);
            DBCenterAccountInfo dBCenterAccountInfo = centerAccountInfoList != null && centerAccountInfoList.Count > 0 ? centerAccountInfoList[0] : null;
            if (dBCenterAccountInfo != null)
            {
                ///确认要不要删除所有区服的账号数据
                dBCenterAccountInfo.AccountType = 2;////(int)AccountType.Delete;
                await Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(session.DomainZone(), dBCenterAccountInfo); 
            }
        }
    }
}
