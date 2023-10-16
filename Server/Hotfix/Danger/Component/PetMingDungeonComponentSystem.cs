using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    public static class PetMingDungeonComponentSystem
    {
        public static async ETTask GeneratePetFuben(this PetMingDungeonComponent self, int mineType, int postion)
        {
            long chargeServerId = DBHelper.GetActivityServerId(self.DomainZone());
            A2M_PetMingPlayerInfoResponse r_GameStatusResponse = (A2M_PetMingPlayerInfoResponse)await ActorMessageSenderComponent.Instance.Call
                (chargeServerId, new M2A_PetMingPlayerInfoRequest()
                {
                    MingType = mineType, 
                    Postion = postion,
                });

            Log.Console($"r_GameStatusResponse:  {r_GameStatusResponse.PetMingPlayerInfo}");
            if (r_GameStatusResponse.Error != ErrorCode.ERR_Success)
            {
                return;
            }
        }
    }
}
