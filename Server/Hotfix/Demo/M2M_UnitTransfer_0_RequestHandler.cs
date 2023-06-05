using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class M2M_UnitTransfer_0_RequestHandler : AMActorRpcHandler<Scene, M2M_UnitTransfer_0_Request, M2M_UnitTransfer_0_Response>
    {
        protected override async ETTask Run(Scene scene, M2M_UnitTransfer_0_Request request, M2M_UnitTransfer_0_Response response, Action reply)
        {
            Dictionary<long, List<byte[]>> components = scene.GetComponent<UnitComponent>().UnitComponents;
            if (!components.ContainsKey(request.Unit.Id))
            {
                components.Add(request.Unit.Id, new List<byte[]>());
            }
            if (request.ParamInfo.Equals(DBHelper.BagComponent))
            {
                components[request.Unit.Id].Clear();
            }

            components[request.Unit.Id].AddRange(request.EntityBytes);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
