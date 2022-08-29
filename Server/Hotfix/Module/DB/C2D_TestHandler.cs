using System;
using System.Collections.Generic;

namespace ET
{
    public class C2D_TestHandler : AMActorRpcHandler<Scene, C2D_Test, D2C_Test>
    {
        protected override async ETTask Run(Scene scene, C2D_Test request, D2C_Test response, Action reply)
        {
            Log.Info($"{scene.Name} 收到消息: {request.TestMsg}");
            List<BagInfo> bagInfos = new List<BagInfo>(); //await Game.Scene.GetComponent<DBComponent>().Query<BagInfo>(scene.DomainZone(), d => d.BagInfoID != 0);
            Log.Info($"baginfos count:{bagInfos.Count.ToString()}");

            //await RunTestCache(scene, bagInfos);
            long time = TimeHelper.ServerNow();
            using var list = ListComponent<ETTask>.Create();
            for (int i = 0; i < 1000; i++)
            {
                //list.List.Add(RunTestCache(scene,bagInfos));
            }
            await ETTaskHelper.WaitAll(list);
            Log.Info($"总计用时：{(TimeHelper.ServerNow() - time).ToString()}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}