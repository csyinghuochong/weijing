using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_HongBaoOpenRequestHandler : AMActorLocationRpcHandler<Unit, C2M_HongBaoOpenRequest, M2C_HongBaoOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HongBaoOpenRequest request, M2C_HongBaoOpenResponse response, Action reply)
        {
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HongBao) == 0)
            {
                //获取当前玩家等级
                int playerLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                int minGold = 2000;
                int maxGold = 10000;

                if (playerLv >= 1 && playerLv <= 19) {
                    minGold = 10000;
                    maxGold = 75000;
                }


                if (playerLv >= 20 && playerLv <= 29)
                {
                    minGold = 20000;
                    maxGold = 100000;
                }


                if (playerLv >= 30 && playerLv <= 39)
                {
                    minGold = 30000;
                    maxGold = 120000;
                }


                if (playerLv >= 40 && playerLv <= 49)
                {
                    minGold = 40000;
                    maxGold = 150000;
                }

                if (playerLv >= 50)
                {
                    minGold = 50000;
                    maxGold = 200000;
                }

                int hongbaoAmount = RandomHelper.RandomNumber(minGold, maxGold);
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.HongBao, 1);
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, hongbaoAmount.ToString());
                response.HongbaoAmount = hongbaoAmount;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
