

namespace ET
{
    public class PaiMaiSceneComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public long Overtime = 24 * 60 * 60 * 1000;
        public DBPaiMainInfo dBPaiMainInfo = new DBPaiMainInfo();       //拍卖行存储列表

        /// <summary>
        /// 竞拍
        /// </summary>
        public int JinPaiItem;
        public int JinPaiPrice;
        public bool JinPaiBegin;
        public bool JinPaiOver; 
    }
}
