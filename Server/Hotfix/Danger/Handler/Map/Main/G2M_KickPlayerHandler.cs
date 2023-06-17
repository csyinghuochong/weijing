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
            Console.WriteLine($"G2M_KickPlayerRequest: {scene.Id}");
            if (unit != null)
            {
                //MessageHelper.SendToClient(unit, new M2C_KickPlayerMessage());
                Console.WriteLine($"G2M_KickPlayerRequest: !=null  Disposed:{unit.IsDisposed}");
                //await unit.RemoveLocation();
                //DBSaveComponent dBSaveComponent = unit.GetComponent<DBSaveComponent>();
                //if (dBSaveComponent != null)
                //{
                //    Console.WriteLine($"G2M_KickPlayerRequest: dBSaveComponent != null");
                //    dBSaveComponent.OnDisconnect();
                //}
                //else
                //{
                //    Console.WriteLine($"G2M_KickPlayerRequest: dBSaveComponent == null");
                //    unit.GetParent<UnitComponent>().Remove(unit.Id);
                //}
                unit.OnKickPlayer(false).Coroutine();
            }
            else
            {
                Log.Debug($"G2M_KickPlayerRequest ==null");
            }

            await ETTask.CompletedTask;
        }
    }
}
