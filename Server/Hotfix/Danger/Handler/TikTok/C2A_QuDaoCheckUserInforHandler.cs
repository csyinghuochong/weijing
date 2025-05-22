using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;


namespace ET
{

    [MessageHandler]
    public class C2A_QuDaoCheckUserInforHandler : AMRpcHandler<C2A_QuDaoCheckUserInfor, A2C_QuDaoCheckUserInfor>
    {
        protected override async ETTask Run(Session session, C2A_QuDaoCheckUserInfor request, A2C_QuDaoCheckUserInfor response, Action reply)
        {
            long serverNow = TimeHelper.ServerNow() / 1000;
            Dictionary<string, string> paramslist = new Dictionary<string, string>();
            paramslist.Add("token", request.token);
            paramslist.Add("uid", request.uid);

            string result = HttpHelper.OnWebRequestPost_Form("http://checkuser.quickapi.net/v2/checkUserInfo", paramslist);
            //OnWebRequestPost_1: {"code":-1001,"log_id":"202311141714565D4B186ED56A781CCE8D","message":"invalid parameter: app_id error"}

            if (ComHelp.IsInnerNet())
            {
                result = "1";
            }
            Console.WriteLine($"C2A_QuDaoCheckUserInforHandler:  {result}");

            reply();
            await ETTask.CompletedTask;
        }
    }
}