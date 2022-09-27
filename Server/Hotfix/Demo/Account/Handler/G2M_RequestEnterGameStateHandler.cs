using System;

namespace ET
{
    public class G2M_RequestEnterGameStateHandler : AMActorLocationRpcHandler<Unit, G2M_RequestEnterGameState, M2G_RequestEnterGameState>
    {
        protected override async ETTask Run(Unit unit, G2M_RequestEnterGameState request, M2G_RequestEnterGameState response, Action reply)
        {
            if (request.GateSessionActorId != 0)
            {

                await unit.GetComponent<DBSaveComponent>().OnRelogin(request.GateSessionActorId);
            }
            else
            {


                await  unit.GetComponent<DBSaveComponent>().OnDisconnect();
            }
            reply();
        }
    }
}