using UnityEngine;

namespace ET
{
	[MessageHandler]
	public class M2C_CreateUnitsHandler : AMHandler<M2C_CreateUnits>
	{

		private bool CheckUnitExist(UnitComponent unitComponent, long unitid, float x,float y,float z)
		{
			if (unitComponent.Get(unitid) != null)
			{
				unitComponent.Get(unitid).Position = new Vector3(x,y,z);
				return true;
			}
			return false;
		}

		protected override void Run(Session session, M2C_CreateUnits message)
		{
			Scene currentScene = session.ZoneScene().CurrentScene();
			if (currentScene == null)
			{
				return;
			}
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			foreach (UnitInfo unitInfo in message.Units)
			{
				if (CheckUnitExist(unitComponent, unitInfo.UnitId,unitInfo.X,unitInfo.Y,unitInfo.Z))
				{
					continue;
				}
				UnitFactory.CreateUnit(currentScene, unitInfo);
			}
			foreach (SpilingInfo unitInfo in message.Spilings)
			{
				if (CheckUnitExist(unitComponent, unitInfo.UnitId, unitInfo.X, unitInfo.Y, unitInfo.Z))
   				{
					continue;
				}
				UnitFactory.CreateSpiling(currentScene, unitInfo);
			}
			foreach (DropInfo unitInfo in message.Drops)
			{
				if (CheckUnitExist(unitComponent, unitInfo.UnitId, unitInfo.X, unitInfo.Y, unitInfo.Z))
				{
					continue;
				}
				UnitFactory.CreateDropItem(currentScene, unitInfo);
			}
			foreach (TransferInfo unitInfo in message.Transfers)
			{
				if (CheckUnitExist(unitComponent, unitInfo.UnitId, unitInfo.X, unitInfo.Y, unitInfo.Z))
				{
					continue;
				}
				UnitFactory.CreateTransferItem(currentScene, unitInfo);
			}
			foreach (NpcInfo unitInfo in message.Npcs)
			{
				if (CheckUnitExist(unitComponent, unitInfo.UnitId, unitInfo.X, unitInfo.Y, unitInfo.Z))
				{
					continue;
				}
				UnitFactory.CreateNpcItem(currentScene, unitInfo);
			}
			foreach (RolePetInfo unitInfo in message.Pets)
			{
				if (CheckUnitExist(unitComponent, unitInfo.Id, unitInfo.X, unitInfo.Y, unitInfo.Z))
				{
					continue;
				}
				UnitFactory.CreateRolePet(currentScene, unitInfo);
			}
		}
	}
}
