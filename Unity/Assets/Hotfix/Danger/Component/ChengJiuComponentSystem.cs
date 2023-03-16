using System.Collections.Generic;
using System.Linq;

namespace ET
{

    public static class ChengJiuComponentSystem
    {
        public static async ETTask ReceivedReward(this ChengJiuComponent self, int rewardId)
        {
            M2C_ChengJiuRewardResponse r2C_Bag = (M2C_ChengJiuRewardResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(new C2M_ChengJiuRewardRequest() {  RewardId = rewardId });
            if (r2C_Bag.Error != 0)
            {
                return;
            }

            self.AlreadReceivedId.Add(rewardId);
        }

        public static async ETTask GetChengJiuList(this ChengJiuComponent self)
        {
            M2C_ChengJiuListResponse r2C_Respose = (M2C_ChengJiuListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(new C2M_ChengJiuListRequest());
            self.ChengJiuCompleteList = r2C_Respose.ChengJiuCompleteList;
            self.TotalChengJiuPoint = r2C_Respose.TotalChengJiuPoint;
            self.AlreadReceivedId = r2C_Respose.AlreadReceivedId;
            self.JingLingList = r2C_Respose.JingLingList;
            self.RandomDrop = r2C_Respose.RandomDrop;
            self.JingLingId = r2C_Respose.JingLingId;
         
            self.ChengJiuProgessList = new Dictionary<int, ChengJiuInfo>();
            for (int  i = 0; i < r2C_Respose.ChengJiuProgessList.Count; i++)
            {
                self.ChengJiuProgessList.Add(r2C_Respose.ChengJiuProgessList[i].ChengJiuID, r2C_Respose.ChengJiuProgessList[i]);
            }
            HintHelp.GetInstance().DataUpdate(DataType.ChengJiuUpdate);
        }

        public static List<int> GetChaptersByType(this ChengJiuComponent self, int type)
        {
            return ChengJiuHelper.Instance.ChengJiuTypeData[type].ChengJiuChapterTask.Keys.ToList();
        }

        public static List<int> GetTasksByChapter(this ChengJiuComponent self,  int typeid, int subType)
        {
            return ChengJiuHelper.Instance.ChengJiuTypeData[typeid].ChengJiuChapterTask[subType];
        }

        public static void OnActiveJingLing(this ChengJiuComponent self, int jid)
        {
            if (self.JingLingList.Contains(jid))
            {
                return;
            }
            self.JingLingList.Add(jid);
        }
    }

}
