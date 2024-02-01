using System.Collections.Generic;
using System.Linq;

namespace ET
{
	public class PlayerComponent : Entity, IAwake, IDestroy
	{
		public readonly Dictionary<long, Player> idPlayers = new Dictionary<long, Player>();
		
		public Dictionary<long, long> instanceToId = new Dictionary<long, long>();	

		public int Count
		{
			get
			{
				return this.idPlayers.Count;
			}
		}
	}
}