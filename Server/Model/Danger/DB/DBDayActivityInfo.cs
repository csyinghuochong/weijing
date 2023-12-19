using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;
using System.Collections.Generic;


namespace ET
{

    [BsonIgnoreExtraElements]
	public class DBDayActivityInfo : Entity
	{
		public int LastHour;
		
		/// <summary>
		/// 周任务
		/// </summary>
		public int WeeklyTask;

		/// <summary>
		/// 小龟历史胜利次数
		/// </summary>
		public List<int> TurtleWinTimes = new List<int>() { }; 

        //神秘商品
        public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

		//战区活动
		public List<ZhanQuReceiveNumber> ZhanQuReveives = new List<ZhanQuReceiveNumber>();

		//首胜记录
		public List<FirstWinInfo> FirstWinInfos = new List<FirstWinInfo>();

		//宠物矿场(矿场类型->玩家ID)
		public List<PetMingPlayerInfo> PetMingList = new List<PetMingPlayerInfo>();

        [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfArrays)]
        public Dictionary<long, long> PetMingChanChu = new Dictionary<long, long>();

		//核心矿
		public List<KeyValuePairInt> PetMingHexinList = new List<KeyValuePairInt> { };

        /// <summary>
        /// 竞猜数字->竞猜玩家列表
        /// </summary>
        //[BsonDictionaryOptions(DictionaryRepresentation.ArrayOfArrays)]
        //public Dictionary<int, List<long>> GuessPlayerList = new Dictionary<int, List<long>>();
    }

}
