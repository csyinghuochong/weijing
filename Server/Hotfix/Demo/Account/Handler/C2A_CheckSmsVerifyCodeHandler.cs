using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlibabaCloud.SDK.Sample;

namespace ET
{
    //游戏服务器处理
    [MessageHandler]
    public class C2A_CheckSmsVerifyCodeHandler : AMRpcHandler<C2A_CheckSmsVerifyCode, A2C_CheckSmsVerifyCode>
    {
        protected override async ETTask Run(Session session, C2A_CheckSmsVerifyCode request, A2C_CheckSmsVerifyCode response, Action reply)
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
                    response.Error = CheckSmsVerifyCode.Check(request.PhoneNumber, request.Code, string.Empty);
                    
                    //AccountCenterComponent playerInfoList = session.DomainScene().GetComponent<AccountCenterComponent>();
                    //bool code = playerInfoList.CheckVerification(request.PhoneNumber, request.Code);
                    //response.Error = code ? ErrorCode.ERR_Success : ErrorCode.MOBILE_CHECK_ILLEGAL;
                    //Console.WriteLine($"Check: {request.PhoneNumber} {request.Code}  {code}");

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

