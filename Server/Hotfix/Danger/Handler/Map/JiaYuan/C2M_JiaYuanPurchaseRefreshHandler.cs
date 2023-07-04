//using System;

//namespace ET
//{

//    [ActorMessageHandler]
//    public class C2M_JiaYuanPurchaseRefreshHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPurchaseRefresh, M2C_JiaYuanPurchaseRefresh>
//    {
//        protected override async ETTask Run(Unit unit, C2M_JiaYuanPurchaseRefresh request, M2C_JiaYuanPurchaseRefresh response, Action reply)
//        {
//            long jiayuanzijin = unit.GetComponent<UserInfoComponent>().UserInfo.JiaYuanFund;
//            int refreshtime = unit.GetComponent<NumericComponent>().GetAsInt( NumericType.JiaYuanPurchaseRefresh );
//            long needzijin = refreshtime >= 1 ? JiaYuanHelper.JiaYuanPurchaseRefresh : 0;

//            if (refreshtime >= 3)
//            {
//                response.Error = ErrorCore.ERR_TimesIsNot;
//                reply();
//                return;
//            }

//            if (jiayuanzijin < needzijin)
//            {
//                response.Error = ErrorCore.ERR_HouBiNotEnough;
//                reply();
//                return;
//            }

//            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.JiaYuanPurchaseRefresh, refreshtime + 1);
//            unit.GetComponent<UserInfoComponent>().UpdateRoleData(  UserDataType.JiaYuanFund, (needzijin * -1).ToString() );

//            reply();
//            await ETTask.CompletedTask;
//        }
//    }
//}
