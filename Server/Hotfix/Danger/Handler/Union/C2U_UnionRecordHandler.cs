using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionRecordHandler : AMActorRpcHandler<Scene, C2U_UnionRecordRequest, U2C_UnionRecordResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionRecordRequest request, U2C_UnionRecordResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await DBHelper.GetComponentCache<DBUnionInfo>(scene.DomainZone(), request.UnionId);
            if (dBUnionInfo == null)
            {
                reply();
                return;
            }

            for (int i = dBUnionInfo.UnionInfo.DonationRecords.Count - 1; i >=0; i--)
            {
                DonationRecord donationRecord = dBUnionInfo.UnionInfo.DonationRecords[i];
                UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(scene.DomainZone(), donationRecord.UnitId);
                if (userInfoComponent == null)
                {
                    dBUnionInfo.UnionInfo.UnionPlayerList.RemoveAt(i);
                    continue;
                }
                donationRecord.Name = userInfoComponent.UserInfo.Name;
            }
            response.DonationRecords = dBUnionInfo.UnionInfo.DonationRecords;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
