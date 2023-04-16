

namespace ET
{
    public class PaiMaiSceneComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public long Overtime = 24 * 60 * 60 * 1000;
        public DBPaiMainInfo dBPaiMainInfo = new DBPaiMainInfo();       //拍卖行存储列表

        /// <summary>
        /// 拍卖会
        /// </summary>
        public int AuctionItem;
        public int AuctionStatus;  //0没开始 1开始 2结束
        public long AuctionTimer;
        public long AuctionPrice;
        public long AuctioUnitId;
    }
}
