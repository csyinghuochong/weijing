using System;

namespace ET
{
    public class G2M_RequestEnterGameStateHandler : AMActorLocationRpcHandler<Unit, G2M_RequestEnterGameState, M2G_RequestEnterGameState>
    {
        protected override async ETTask Run(Unit unit, G2M_RequestEnterGameState request, M2G_RequestEnterGameState response, Action reply)
        {
            try
            {
                if (request.GateSessionActorId != 0)  //重连
                {
                    unit.GetComponent<DBSaveComponent>().OnRelogin(request.GateSessionActorId);
                }
                if(request.GateSessionActorId == 0)  //重登
                {
                    unit.GetComponent<DBSaveComponent>().OnDisconnect();
                }
                if (request.GateSessionActorId == -1) //查询
                {
                    response.Message = "玩家在线: {unit.Id}";
                    //Log.Debug(response.Message);
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