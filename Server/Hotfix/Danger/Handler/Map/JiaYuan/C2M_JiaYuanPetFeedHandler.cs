using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanPetFeedHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPetFeedRequest, M2C_JiaYuanPetFeedResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPetFeedRequest request, M2C_JiaYuanPetFeedResponse response, Action reply)
        {
            if (request.BagInfoIDs.Count < 1)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            List<int> ItemIdList = new List<int> ();
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            for (int i = request.BagInfoIDs.Count - 1; i >= 0; i--)
            {
                BagInfo useBagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.BagInfoIDs[i]);
                if (useBagInfo == null)
                {
                    request.BagInfoIDs.RemoveAt(i);
                    continue;
                }
                ItemIdList.Add(useBagInfo.ItemID);
            }

            if (ItemIdList.Count == 0)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            //计算心情值
            int moodvalue = 0;
            for (int i = 0; i < ItemIdList.Count; i++)
            {
                moodvalue += 1;
            }
            unit.GetComponent<JiaYuanComponent>().UpdatePetMood(request.PetId, moodvalue);

            //消耗道具
            for (int i = request.BagInfoIDs.Count - 1; i >= 0; i--)
            {
                bagComponent.OnCostItemData(request.BagInfoIDs[i], 1);
            }
            response.MoodAdd = moodvalue;
            response.JiaYuanPetList = unit.GetComponent<JiaYuanComponent>().JiaYuanPetList_2;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
