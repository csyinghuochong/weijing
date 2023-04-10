using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanPetPositionHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPetPositionRequest, M2C_JiaYuanPetPositionResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPetPositionRequest request, M2C_JiaYuanPetPositionResponse response, Action reply)
        {
            if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum != SceneTypeEnum.JiaYuan)
            {
                reply();
                return;
            }

            List<Unit> units = unit.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Pet)
                {
                    continue;
                }

                if (units[i].GetComponent<AIComponent>().AIConfigId!= 11)
                {
                    continue;
                }

                response.PetList.Add( new UnitInfo()
                { 
                    UnitId = units[i].Id,
                    ConfigId = units[i].ConfigId,
                    X = units[i].Position.x,
                    Y = units[i].Position.y,
                    Z = units[i].Position.z,
                });
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
