using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class G2M_KickPlayerHandler : AMActorLocationHandler<Scene, G2M_KickPlayerRequest>
    {
        protected override async ETTask Run(Scene scene, G2M_KickPlayerRequest request)
        {
            Unit unit = scene.GetComponent<UnitComponent>().Get(request.UnitId);
            if (unit != null)
            {
                //MessageHelper.SendToClient(unit, new M2C_KickPlayerMessage());

                Log.Debug($"G2M_KickPlayerRequest: {unit.Id}");
                await unit.RemoveLocation();
                unit.GetComponent<DBSaveComponent>().OnDisconnect();
            }

            await ETTask.CompletedTask;
        }
    }
}
