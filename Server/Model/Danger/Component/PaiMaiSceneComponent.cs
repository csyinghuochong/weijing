

using System.Collections.Generic;

namespace ET
{
    public class PaiMaiSceneComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        /// <summary>
        /// 拍卖会
        /// </summary>
        public int AuctionItem;
        /// <summary>
        /// 0没开始 1开始 2结束
        /// </summary>
        public int AuctionStatus;  
        public long AuctionPrice;
        public long AuctionStart;  //起拍价
        public long AuctioUnitId;
        public int AuctionItemNum;
        public string AuctionPlayer;

        public List<long> AuctionJoinList = new List<long>();

        //拍卖行存储列表
        public DBPaiMainInfo dBPaiMainInfo = new DBPaiMainInfo();      

        //出价记录
        public List<PaiMaiAuctionRecord> AuctionRecords = new List<PaiMaiAuctionRecord>();

        //拍卖
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Consume = new List<PaiMaiItemInfo>();
        public long UpdateTimeConsume;
        //材料
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Material = new List<PaiMaiItemInfo>();
        public long UpdateTimeMaterial;
        //装备
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Equipment = new List<PaiMaiItemInfo>();
        public long UpdateTimeEquipment;
        //宝石
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Gemstone = new List<PaiMaiItemInfo>();
        public long UpdateTimeGemstone;

    }
}
