using System;

namespace ET
{
    public class G2M_RequestExitGameHandler : AMActorLocationRpcHandler<Unit, G2M_RequestExitGame, M2G_RequestExitGame>
    {
        protected override async ETTask Run(Unit unit, G2M_RequestExitGame request, M2G_RequestExitGame response, Action reply)
        {

            try
            {
                reply();

                await unit.RemoveLocation();

                DBSaveComponent dBSaveComponent = unit.GetComponent<DBSaveComponent>();
                if (dBSaveComponent != null)
                {
                    dBSaveComponent.OnDisconnect();
                }
                else
                {
                    unit.GetParent<UnitComponent>().Remove(unit.Id);
                }
            }
            catch (Exception e) 
            {
                Log.Error(e.ToString());
            }

            await ETTask.CompletedTask;
        }
    }

}