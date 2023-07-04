using System.Collections.Generic;

namespace ET
{
	public class UnitComponent: Entity, IAwake,IDestroy
	{
		public int SceneType;

		public List<long> AoI = new List<long>();

		public List<Unit> Units = new List<Unit>();

		public Dictionary<long, List<byte[]>> UnitComponents = new Dictionary<long, List<byte[]>>();
	}
}