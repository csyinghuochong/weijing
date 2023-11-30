using System.Collections.Generic;
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

			ListComponent<long> allunitids = ListComponent<long>.Create();
            UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			foreach (UnitInfo unitInfo in message.Units)
			{
				allunitids.Add(unitInfo.UnitId);

                if (CheckUnitExist(unitComponent, unitInfo.UnitId,unitInfo.X,unitInfo.Y,unitInfo.Z))
				{
					continue;
				}
				UnitFactory.CreateUnit(currentScene, unitInfo);
			}
			foreach (SpilingInfo unitInfo in message.Spilings)
			{
                allunitids.Add(unitInfo.UnitId);

                if (CheckUnitExist(unitComponent, unitInfo.UnitId, unitInfo.X, unitInfo.Y, unitInfo.Z))
   				{
					continue;
				}
				UnitFactory.CreateSpiling(currentScene, unitInfo);
			}
			foreach (DropInfo unitInfo in message.Drops)
			{
                allunitids.Add(unitInfo.UnitId);

                if (CheckUnitExist(unitComponent, unitInfo.UnitId, unitInfo.X, unitInfo.Y, unitInfo.Z))
				{
					continue;
				}
				UnitFactory.CreateDropItem(currentScene, unitInfo);
			}
			foreach (TransferInfo unitInfo in message.Transfers)
			{
                allunitids.Add(unitInfo.UnitId);

                if (CheckUnitExist(unitComponent, unitInfo.UnitId, unitInfo.X, unitInfo.Y, unitInfo.Z))
				{
					continue;
				}
				UnitFactory.CreateTransferItem(currentScene, unitInfo);
			}


			if (message.UpdateAll == 1)
			{
                //移除不存在的unit. 只检测玩家 。怪物和掉落
                List<Unit> allunits = unitComponent.GetAll();
                for (int i = allunits.Count - 1; i >= 0; i--)
                {
                    int unitType = allunits[i].Type;
                    if (unitType != UnitType.Player && unitType != UnitType.Monster && unitType != UnitType.DropItem)
                    {
                        continue;
                    }
					if (allunits[i].MainHero)
					{
						continue;
					}

                    if (!allunitids.Contains(allunits[i].Id))
                    {
                        unitComponent.Remove(allunits[i].Id);
                        continue;
                    }
                }
            }
			
        }
	}
}
