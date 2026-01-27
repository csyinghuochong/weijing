using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class R2A_BroadcastHandler : AMActorRpcHandler<Scene, R2A_Broadcast, A2R_Broadcast>
    {
        protected override async ETTask Run(Scene session, R2A_Broadcast request, A2R_Broadcast response, Action reply)
        {
            //Log.Console("R2A_Broadcast_a: " + session.Name);

            switch (request.LoadType)
            {
                case 1: 
                    //狩猎
                    ConfigData.ShowLieOpen = request.LoadValue == "1";
                    Console.WriteLine($" ConfigData.ShowLieOpen:  {ConfigData.ShowLieOpen}");
                    break;
                 case 2:
                    //等级
                    int zone = int.Parse(request.LoadValue);
                    ConfigData.ServerInfoList[zone] = request.ServerInfo;
                    //if (zone == 5)
                    //{
                    //    Console.WriteLine($" ConfigData.ServerInfoList:  {zone}  {request.ServerInfo.WorldLv}");
                    //}
                    break;
                case 3:
                    Console.WriteLine($"R2A_Broadcast ConfigData.V1ActivityList:  {request.V1ActivityList.Count}");
                    ConfigData.V1ActivityList = request.V1ActivityList;
                    break;
                case 4:
                    Console.WriteLine("request.LoadType = 4");
                    List<int> zones = ServerMessageHelper.GetAllZone();
                    foreach (int czone in zones)
                    {
                        long fubenCenterId = DBHelper.GetFubenCenterId(czone);
                        R2F_WorldLvUpdateRequest crequest = new R2F_WorldLvUpdateRequest() { };
                        await ActorMessageSenderComponent.Instance.Call(fubenCenterId, crequest);
                    }
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
