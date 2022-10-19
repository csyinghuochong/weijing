using System;

namespace ET
{
    public class G2M_RequestEnterGameStateHandler : AMActorLocationRpcHandler<Unit, G2M_RequestEnterGameState, M2G_RequestEnterGameState>
    {
        protected override async ETTask Run(Unit unit, G2M_RequestEnterGameState request, M2G_RequestEnterGameState response, Action reply)
        {
            try
            {
                if (request.GateSessionActorId != 0)
                {
                    unit.GetComponent<DBSaveComponent>().OnRelogin(request.GateSessionActorId);
                }
                else
                {
                    unit.GetComponent<DBSaveComponent>().OnDisconnect();
                }
            }
            catch (Exception ex)
            {
                Log.Debug($" {unit.Id}  {ex.ToString()}");
            }
            reply();
            await ETTask.CompletedTask; 
        }
    }
}