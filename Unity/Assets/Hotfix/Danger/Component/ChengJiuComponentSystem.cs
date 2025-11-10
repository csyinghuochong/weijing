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

        public static async ETTask<int> RequestOpenMagicka(this ChengJiuComponent self, int position)
        {
            M2C_MagickaSlotOpenResponse r2C_Bag = (M2C_MagickaSlotOpenResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call
                (
                new C2M_MagickaSlotOpenRequest() { Position = position }
                );
            if (r2C_Bag.Error == 0)
            {
                self.MagickaSlotIdList = r2C_Bag.MagickaSlotIds;

            }
            return r2C_Bag.Error;
        }

        public static async ETTask<int> RequestMagicZhuru(this ChengJiuComponent self, int position, List<long> costs)
        {
            C2M_MagickaZhuruRequest request = new C2M_MagickaZhuruRequest() { Position = position, OperateBagID = costs };
            M2C_MagickaZhuruResponse response = (M2C_MagickaZhuruResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if(response.Error == ErrorCode.ERR_Success)
            {
                self.MagickaSlotIdList = response.MagickaSlotIds;
            }
            return response.Error;
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
            self.MagickaSlotIdList = r2C_Respose.MagickaSlotIds;
         
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
            EventType.JingLingGet.Instance.ZoneScene = self.ZoneScene();
            EventType.JingLingGet.Instance.JingLingId = jid;
            EventSystem.Instance.PublishClass(EventType.JingLingGet.Instance);
        }

        public static int GetCurrentMagickaSlotIdByPosition(this ChengJiuComponent self, int position)
        {
            MagickaSlotInfo magickaSlotInfo = self.GetCurrentMagickaSlotByPosition(position);   
            return magickaSlotInfo != null ? magickaSlotInfo.SlotId : 0;
        }

        public static MagickaSlotInfo GetCurrentMagickaSlotByPosition(this ChengJiuComponent self, int position)
        {
            foreach (var magicinfo in self.MagickaSlotIdList)
            {
                MagickaSlotConfig magickaSlotConfig = MagickaSlotConfigCategory.Instance.Get(magicinfo.SlotId);
                if (magickaSlotConfig.Position == position + 1)
                {
                    return magicinfo;
                }
            }
            return null;
        }

        public static int GetMaxMagickaSlotIdPosition(this ChengJiuComponent self)
        {
            int position = 0;
            foreach (var slotinfo in MagickaSlotConfigCategory.Instance.GetAll())
            {
                if (slotinfo.Value.Position > position)
                {
                    position = slotinfo.Value.Position;
                }
            }
            return position;
        }

        public static int GetFirstMagickaSlotIdByPosition(this ChengJiuComponent self, int position)
        {
            int id = 0;
            foreach (var slotinfo in MagickaSlotConfigCategory.Instance.GetAll())
            {
                if (slotinfo.Value.Position == position + 1 && id < slotinfo.Key)
                {
                    id = slotinfo.Key;
                    break;
                }
            }
            return id;
        }

        public static int GetCurrentMagickaTotalLevel(this ChengJiuComponent self)
        {
            int totallevel = 0;
            foreach (var magicinfo in self.MagickaSlotIdList)
            {
                MagickaSlotConfig magickaSlotConfig = MagickaSlotConfigCategory.Instance.Get(magicinfo.SlotId);
                totallevel += magickaSlotConfig.MagicLevel;
            }
            return totallevel;
        }

        public static int GetNextMagickaSlotIdByPosition(this ChengJiuComponent self, int position)
        {
            int id = self.GetCurrentMagickaSlotIdByPosition(position);
            foreach (var slotinfo in MagickaSlotConfigCategory.Instance.GetAll())
            {
                if (slotinfo.Value.Position == position + 1 && id < slotinfo.Key)
                {
                    id = slotinfo.Key;
                    break;
                }
            }
            return id;
        }
    }

}
