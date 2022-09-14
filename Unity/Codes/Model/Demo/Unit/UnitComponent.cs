using System.Collections.Generic;

namespace ET
{
	public class UnitComponent: Entity, IAwake, IDestroy
	{
		public List<Unit> Units = new List<Unit>();
    }
}