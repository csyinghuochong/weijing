using System.Linq;

namespace ET
{
    [MessageHandler]
	public class M2C_RemoveUnitsHandler : AMHandler<M2C_RemoveUnits>
	{
		protected override void Run(Session session, M2C_RemoveUnits message)
		{
            Scene zoneScene = session.ZoneScene();

            UnitComponent unitComponent = zoneScene.CurrentScene()?.GetComponent<UnitComponent>();

            BattleMessageComponent  battlemessageComponent =  zoneScene.GetComponent<BattleMessageComponent>();

            foreach (long unitId in message.Units)
			{
				Unit unit = unitComponent.Get(unitId);
				if (unit == null)
				{
					continue;
				}
				long  delayRemove  = 0;
				if (unit.Type == UnitType.Monster
					&& unit.GetMonsterType() != 5)
				{
                    delayRemove = 1000;
				}
                if (unit.Type == UnitType.Npc && ConfigHelper.TurtleList.Contains(unit.ConfigId))
                {
                    delayRemove = 3000;
                }

				bool showdrofly = false;
				if (battlemessageComponent.PickItemIds.Contains(unit.Id))
				{
                    delayRemove = 3000;
					showdrofly = true;	
                    battlemessageComponent.PickItemIds.Remove(unit.Id);
                }

                if (delayRemove > 0)
				{
					//RunAsyncRemove(unit, delayRemove).Coroutine();
					unit.AddComponent<DeleyRemoveComponent, long>(delayRemove);
                }
				else
				{
					unitComponent.Remove(unitId);
                }

				if (showdrofly)
				{
                    EventType.UnitDropFly.Instance.Unit = unit;
                    EventType.UnitDropFly.Instance.ZoneScene = session.ZoneScene();
                    Game.EventSystem.PublishClass(EventType.UnitDropFly.Instance);
                }
            }

            EventType.UnitRemove.Instance.RemoveIds = message.Units;
			EventType.UnitRemove.Instance.ZoneScene = session.ZoneScene();
            Game.EventSystem.PublishClass(EventType.UnitRemove.Instance);
        }

		private async ETTask RunAsyncRemove(Unit unit, long delayRemove)
		{
			long instanceid = unit.InstanceId;
			UnitComponent unitComponent = unit.GetParent<UnitComponent>();
			await TimerComponent.Instance.WaitAsync(delayRemove);
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
