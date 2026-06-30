using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;


namespace ET
{

    [MessageHandler]
    public class C2A_XiaoQiCheckLoginHandler : AMRpcHandler<C2A_XiaoQiCheckLogin, A2C_XiaoQiCheckLogin>
    {
        protected override async ETTask Run(Session session, C2A_XiaoQiCheckLogin request, A2C_XiaoQiCheckLogin response, Action reply)
        {
            response.longResule = await X7LoginHelper.CheckLoginServer(request.tokenkey);
            //Log.Console($"C2A_TikTokVerifyUser sign: {sign}    result: {result}");
            //Log.Warning($"C2A_TikTokVerifyUser sign: {sign}    result: {result}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}