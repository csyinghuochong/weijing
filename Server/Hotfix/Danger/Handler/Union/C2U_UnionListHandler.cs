using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2U_UnionListHandler : AMActorRpcHandler<Scene, C2U_UnionListRequest, U2C_UnionListResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionListRequest request, U2C_UnionListResponse response, Action reply)
        {
            List<UnionListItem> unionList = new List<UnionListItem>();
            List<DBUnionInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionInfo>(scene.DomainZone(), _account => _account.UnionInfo!=null);
            for (int i = result.Count -1; i >=0 ; i--)
            {
                DBUnionInfo dBUnionInfo = result[i];
                if (dBUnionInfo == null)
                {
                    continue;
                }
                UnionListItem unionListItem = new UnionListItem();
                unionListItem.UnionName = dBUnionInfo.UnionInfo.UnionName;
                unionListItem.PlayerNumber = dBUnionInfo.UnionInfo.UnionPlayerList.Count;
                unionListItem.UnionId = dBUnionInfo.UnionInfo.UnionId;
                unionList.Add(unionListItem);
            }
            response.UnionList = unionList;
            reply();
        }
    }
}
