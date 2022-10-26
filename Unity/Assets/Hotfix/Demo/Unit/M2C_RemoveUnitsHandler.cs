namespace ET
{
	[MessageHandler]
	public class M2C_RemoveUnitsHandler : AMHandler<M2C_RemoveUnits>
	{
		protected override void Run(Session session, M2C_RemoveUnits message)
		{
			UnitComponent unitComponent = session.ZoneScene().CurrentScene()?.GetComponent<UnitComponent>();
			foreach (long unitId in message.Units)
			{
				Unit unit = unitComponent.Get(unitId);
				if (unit == null)
				{
					continue;
				}
				bool async = false;
				if (unit.Type == UnitType.Monster
					&& unit.GetMonsterType() != 5)
				{
					async = true;
				}
				if (async)
				{
					RunAsync(unit).Coroutine();
				}
				else
				{
					unitComponent.Remove(unitId);
				}
			}
		}

		private async ETTask RunAsync(Unit unit)
		{
			long instanceid = unit.InstanceId;
			UnitComponent unitComponent = unit.ZoneScene().CurrentScene().GetComponent<UnitComponent>();
			await TimerComponent.Instance.WaitAsync(1000);
			if (instanceid != unit.InstanceId || unit.InstanceId == 0 || unitComponent.IsDisposed)
			{
				return;
			}
			if (unitComponent.Get(unit.Id) == null)
			{
				return;
			}
			unitComponent.Remove(unit.Id);
		}
	}
}
