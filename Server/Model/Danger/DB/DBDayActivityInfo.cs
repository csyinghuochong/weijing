using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

	[BsonIgnoreExtraElements]
	public class DBDayActivityInfo : Entity
	{
		public int Day;

		public int LastHour;

		//神秘商品
		public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

		//战区活动
		public List<ZhanQuReceiveNumber> ZhanQuReveives = new List<ZhanQuReceiveNumber>();

		//首胜记录
		public List<FirstWinInfo> FirstWinInfos = new List<FirstWinInfo>();

	}

}
