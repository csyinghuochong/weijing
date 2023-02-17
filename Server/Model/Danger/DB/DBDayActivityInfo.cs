using MongoDB.Bson.Serialization.Attributes;
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

		//神秘商品
		public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

		//战区活动
		public List<ZhanQuReceiveNumber> ZhanQuReveives = new List<ZhanQuReceiveNumber>();

		//首胜记录
		public List<FirstWinInfo> FirstWinInfos = new List<FirstWinInfo>();

	}

}
