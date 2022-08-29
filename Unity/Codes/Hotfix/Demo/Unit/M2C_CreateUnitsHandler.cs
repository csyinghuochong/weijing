namespace ET
{
	[MessageHandler]
	public class M2C_CreateUnitsHandler : AMHandler<M2C_CreateUnits>
	{
		protected override void Run(Session session, M2C_CreateUnits message)
		{
			Scene currentScene = session.ZoneScene().CurrentScene();
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			
			foreach (UnitInfo unitInfo in message.Units)
			{
				Unit unit = UnitFactory.CreateUnit(currentScene, unitInfo);
			}
			foreach (SpilingInfo unitInfo in message.Spilings)
			{
				UnitFactory.CreateSpiling(currentScene, unitInfo);
			}
			foreach (DropInfo unitInfo in message.Drops)
			{
				UnitFactory.CreateDropItem(currentScene, unitInfo);
			}
			foreach (TransferInfo transferInfo in message.Transfers)
			{
				UnitFactory.CreateTransferItem(currentScene, transferInfo);
			}
			foreach (NpcInfo npcInfo in message.Npcs)
			{
				UnitFactory.CreateNpcItem(currentScene, npcInfo);
			}
			foreach (RolePetInfo petInfo in message.Pets)
			{
				UnitFactory.CreateRolePet(currentScene, petInfo);
			}
		}
	}
}
