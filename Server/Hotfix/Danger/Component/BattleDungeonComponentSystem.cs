using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ObjectSystem]
    public class BattleDungeonComponentAwakeSystem : AwakeSystem<BattleDungeonComponent>
    {

        public override void Awake(BattleDungeonComponent self)
        {
            self.CampKillNumber_1 = 0;
            self.CampKillNumber_2 = 0;
        }
    }

    public static class BattleDungeonComponentSystem
    {
        public static void OnKillEvent(this BattleDungeonComponent self, Unit defend)
        {
            if (defend.Type != UnitType.Player)
            {
                return;
            }
            if (UnitHelper.GetBattleCamp(defend) == CampEnum.CampPlayer_1)
            {
                self.CampKillNumber_2++;
            }
            else
            {
                self.CampKillNumber_1++;
            }
        }

        public static async ETTask SendReward(this BattleDungeonComponent self, int winCamp)
        {
            await TimerComponent.Instance.WaitAsync(1000);
            if (winCamp == 0)
            {
                return;
            }
        }

        /// <summary>
        /// 踢出还在副本的玩家
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask KickOutPlayer(this BattleDungeonComponent self)
        {
            await TimerComponent.Instance.WaitAsync(2000);


        }

        public static void OnBattleOver(this BattleDungeonComponent self)
        {
            int winCamp = 0;
            if (self.CampKillNumber_1 > self.CampKillNumber_2)
            {
                winCamp = CampEnum.CampPlayer_1;
            }
            if (self.CampKillNumber_2 > self.CampKillNumber_1)
            {
                winCamp = CampEnum.CampPlayer_2;
            }
            self.SendReward(winCamp).Coroutine();
            self.KickOutPlayer().Coroutine();
        }
    }
}
