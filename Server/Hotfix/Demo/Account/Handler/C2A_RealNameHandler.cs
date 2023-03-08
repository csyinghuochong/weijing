using System;

namespace ET
{

    [MessageHandler]
    public class C2A_RealNameHandler : AMRpcHandler<C2A_RealNameRequest, A2C_RealNameResponse>
    {
        protected override async ETTask Run(Session session, C2A_RealNameRequest request, A2C_RealNameResponse response, Action reply)
        {
            if (string.IsNullOrEmpty(request.IdCardNO) || string.IsNullOrEmpty(request.Name))
            {
                response.Error = ErrorCore.ERR_RealNameFail;
                reply();
                return;
            }

            long dbCacheId = DBHelper.GetDbCacheId(session.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.AccountId, Component = DBHelper.DBAccountInfo });
            DBAccountInfo accountInfo = d2GGetUnit.Component as DBAccountInfo;

            RealNameCode result_check = new RealNameCode();
            result_check.realNameData = new RealNameData();
            result_check.realNameData.result = new RealNameResult();
            using ListComponent<string> testCard = new ListComponent<string>();
            for (int i = 0; i < 30; i++)
            {
                testCard.Add($"400001{1990+i}01012996");
            }
            //内网
            if (ComHelp.IsInnerNet() || testCard.Contains(request.IdCardNO))
            {
                result_check.errcode = 0;
                result_check.realNameData.result.status = 0;
            }
            else
            {
                string ai = accountInfo.Id + "_";
                if (ai.Length < 32)
                {
                    for (int i = ai.Length; i < 32; i++)
                    {
                        ai += "a";
                    }
                }
                result_check = FangChenMiHelper.OnDoFangchenmi(new
                {
                    ai = ai,
                    name = request.Name,
                    idNum = request.IdCardNO,
                }, EType.Check);
            }
            if (result_check == null || result_check.realNameData == null || result_check.realNameData.result == null)
            {
                response.Error = ErrorCore.ERR_RealNameFail;
                reply();
                return;
            }

            if (result_check.errcode == 0 && result_check.realNameData.result.status == 0)  //认证成功
            {
                Log.Debug($"OnDoFangchenmi  sucess");
                PlayerInfo playerInfo = new PlayerInfo();
                playerInfo.Name = request.Name;
                playerInfo.IdCardNo = request.IdCardNO;
                playerInfo.RealName = 1;

                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = accountInfo.Id, Component = accountInfo, ComponentType = DBHelper.DBAccountInfo });
                long accountZone = DBHelper.GetAccountCenter();
                Center2A_SaveAccount saveAccount = (Center2A_SaveAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_SaveAccount()
                {
                    AccountId = accountInfo.Id,
                    AccountName = accountInfo.Account,
                    Password = accountInfo.Password,
                    PlayerInfo = playerInfo,
                });
                response.ErrorCode = ErrorCore.ERR_Success;
            }
            else
            {
                Log.Debug($"OnDoFangchenmi  fail");
                response.ErrorCode = ErrorCore.ERR_RealNameFail;
            }
            reply();
        }
    } 
}
