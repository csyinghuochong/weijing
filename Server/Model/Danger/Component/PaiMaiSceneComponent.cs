

using System.Collections.Generic;

namespace ET
{
    public class PaiMaiSceneComponent : Entity, IAwake, IDestroy
    {
        public long Timer;


        public long AuctionOverTimer;

        /// <summary>
        /// 0没开始 1当前时间小于该值表示开始 2当前时间大于等于该值表示结束  -1也表示结束
        /// </summary>
        public long AuctionStatus;  //结束时间


        /// <summary>
        /// 拍卖会
        /// </summary>
        public int AuctionItem;
       
        public long AuctionPrice;
        public long AuctionStart;  //起拍价
        public long AuctioUnitId;
        public int AuctionItemNum;
        public string AuctionPlayer;

        public List<long> AuctionJoinList = new List<long>();

        //拍卖行存储列表
        public DBPaiMainInfo dBPaiMainInfo = new DBPaiMainInfo();          //废弃掉， 里面的数据分散到以下几个列表

        //Administrator:
        //1：消耗性道具
        //2：材料
        //3：装备
        //4：宝石
        //5：宠物之核
        /// <summary>
        /// 拍卖上架 id = 1000 + 道具类型(itemconfig.ItemType) 最多十个列表
        /// </summary>
        public DBPaiMainInfo dBPaiMainInfo_Consume = new DBPaiMainInfo();       //消耗品  dBPaiMainInfo.PaiMaiItemInfos里面的消耗品1
        public DBPaiMainInfo dBPaiMainInfo_Material = new DBPaiMainInfo();      //材料    dBPaiMainInfo.PaiMaiItemInfos里面的材料
        public DBPaiMainInfo dBPaiMainInfo_Equipment = new DBPaiMainInfo();     //装备    dBPaiMainInfo.PaiMaiItemInfos里面的装备
        public DBPaiMainInfo dBPaiMainInfo_Gemstone = new DBPaiMainInfo();      //宝石    dBPaiMainInfo.PaiMaiItemInfos里面的宝石

        /// <summary>
        /// 拍卖商店 id = 1011
        /// </summary>
        public DBPaiMainInfo dBPaiMainInfo_Shop = new DBPaiMainInfo();      //拍卖商店   dBPaiMainInfo.PaiMaiShopItemInfos   

        /// <summary>
        /// 摆摊道具 id  = 1012
        /// </summary>
        public DBPaiMainInfo dBPaiMainInfo_Stall = new DBPaiMainInfo();         //摆摊    dBPaiMainInfo.PaiMaiItemInfos里面的摆摊

        //出价记录
        public List<PaiMaiAuctionRecord> AuctionRecords = new List<PaiMaiAuctionRecord>();
        
    }
}
