using AlibabaCloud.SDK.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ET
{
    //游戏服务器处理
    [MessageHandler]
    public class C2A_SendSmsVerifyCodeHandler : AMRpcHandler<C2A_SendSmsVerifyCode, A2C_SendSmsVerifyCode>
    {
        protected override async ETTask Run(Session session, C2A_SendSmsVerifyCode request, A2C_SendSmsVerifyCode response, Action reply)
        {
            try
            {
                await ETTask.CompletedTask;
                if (session.GetComponent<SessionLockingComponent>() != null)
                {
                    response.Error = ErrorCode.ERR_RequestRepeatedly;
                    reply();
                    session.Disconnect().Coroutine();
                    return;
                }

                using (session.AddComponent<SessionLockingComponent>())
                {
                    response.Error = SendSmsVerifyCode.Send(request.PhoneNumber);

                    //AccountCenterComponent playerInfoList = session.DomainScene().GetComponent<AccountCenterComponent>();
                    //string code =  playerInfoList.GenerateVerification(request.PhoneNumber);
                    //Sample.Send_2(request.PhoneNumber, 1, 1, code);

                    reply();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }
    }
}

