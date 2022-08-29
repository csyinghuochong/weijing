

namespace ET
{
    public static class AccountInfoComponentSystem
    {

        public static int GetRechargeNumber(this AccountInfoComponent self, long userId)
        { 
            int result = 0;
            for (int i = 0; i < self.PlayerInfo.RechargeInfos.Count; i++)
            {
                RechargeInfo rechargeInfo = self.PlayerInfo.RechargeInfos[i];
                if (rechargeInfo.UserId != userId)
                {
                    continue;
                }
                result += rechargeInfo.Amount;
            }

            return result;
        }

    }
}
