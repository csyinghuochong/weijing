using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_LingDiUpHandler : AMActorLocationRpcHandler<Unit, C2M_LingDiUpRequest, M2C_LingDiUpResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_LingDiUpRequest request, M2C_LingDiUpResponse response, Action reply)
        {
            int lingdiLv = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiLv);
            int lingdiExp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiExp);
            LingDiConfig lingDiConfig = LingDiConfigCategory.Instance.Get(lingdiLv);
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < lingDiConfig.GoldUp)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;    
            }
            int mapLevel = LingDiConfigCategory.Instance.GetAll().Values.Count;
            if (lingdiLv >= mapLevel && lingdiExp >= lingDiConfig.UpExp)
            {
                reply();
                return;
            }

            int addExp = lingDiConfig.AddExp;
            int needCoin = lingDiConfig.GoldUp;
            //if (addExp + lingdiExp >= lingDiConfig.UpExp && lingdiLv < mapLevel)
            //{
            //    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Ling_DiLv, lingdiLv + 1);
            //    addExp = addExp + lingdiExp - lingDiConfig.UpExp;
            //}
            //unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Ling_DiExp, addExp + lingdiExp);
            LingDiHelp.OnAddLingDiExp(unit, addExp, true);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData( UserDataType.Gold, (needCoin * -1).ToString()).Coroutine();

            reply();
            await ETTask.CompletedTask;
        }
    }
}
