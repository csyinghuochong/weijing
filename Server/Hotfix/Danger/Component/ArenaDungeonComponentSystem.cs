using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ObjectSystem]
    public class ArenaDungeonComponentAwake : AwakeSystem<ArenaDungeonComponent>
    {

        public override void Awake(ArenaDungeonComponent self)
        {
        }
    }

    public static class ArenaDungeonComponentSystem
    {

        /// <summary>
        /// 战场关闭， 禁止进入
        /// </summary>
        /// <param name="self"></param>
        public static void OnArenaClose(this ArenaDungeonComponent self)
        {
            List<Unit> unitlist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            for (int i = 0; i < unitlist.Count; i++)
            {
                unitlist[i].GetComponent<NumericComponent>().ApplyValue(NumericType.ArenaNumber, 1);
            }

            self.OnUpdateRank();
        }

        public static void OnUpdateRank(this ArenaDungeonComponent self)
        {
            List<Unit> unitlist = UnitHelper.GetAliveUnitList(self.DomainScene(), UnitType.Player);

            ArenaInfo arenaInfo = self.DomainScene().GetComponent<ArenaInfo>();
            for (int i = 0; i < unitlist.Count; i++)
            {
                ArenaPlayerStatu arenaPlayerStatu = arenaInfo.PlayerList[unitlist[i].Id];
                arenaPlayerStatu.RankId = unitlist.Count;
                arenaInfo.PlayerList[unitlist[i].Id] = arenaPlayerStatu;
            }

            self.M2C_AreneInfoResult.LeftPlayer = unitlist.Count;
            MessageHelper.SendToClient(unitlist, self.M2C_AreneInfoResult);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="players"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="rewardList"></param>
        public static void SendReward(this ArenaDungeonComponent self, List<ArenaPlayerStatu> players,  string rewardList)
        {
            long serverTime = TimeHelper.ServerNow();

            for (int i = 0; i < players.Count; i++)
            {
                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Title = "角斗场排名奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();

                if (players[i].RankId > 0)
                {
                    mailInfo.Context = $"恭喜你在角斗场中获得第{players[i].RankId}名,获得如下奖励";
                }
                else
                {
                    mailInfo.Context = $"参与角斗场,获得如下奖励";
                }
                string[] needList = rewardList.Split('@');
                for (int k = 0; k < needList.Length; k++)
                {
                    string[] itemInfo = needList[k].Split(';');
                    if (itemInfo.Length < 2)
                    {
                        continue;
                    }
                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.BattleWin}_{serverTime}" });
                }
                MailHelp.SendUserMail(self.DomainZone(), players[i].UnitId, mailInfo).Coroutine();
            }
        }

        public static List<ArenaPlayerStatu> GetNoRankPlayers(this ArenaDungeonComponent self)
        {
            List<ArenaPlayerStatu> arenaPlayerStatus = new List<ArenaPlayerStatu>();    
            ArenaInfo arenaInfo = self.DomainScene().GetComponent<ArenaInfo>();
            foreach (var item in arenaInfo.PlayerList)
            {
                if (item.Value.RankId == 0)
                {
                    arenaPlayerStatus.Add(item.Value);
                }
            }
            return arenaPlayerStatus;
        }

        public static List<ArenaPlayerStatu> GetRankPlayers(this ArenaDungeonComponent self, int start, int end)
        {
            List<ArenaPlayerStatu> arenaPlayerStatus = new List<ArenaPlayerStatu>();
            ArenaInfo arenaInfo = self.DomainScene().GetComponent<ArenaInfo>();
            foreach (var item in arenaInfo.PlayerList)
            {
                if (item.Value.RankId == 0)
                {
                    continue;
                }
                if (item.Value.RankId >= start && item.Value.RankId <= end)
                {
                    arenaPlayerStatus.Add((ArenaPlayerStatu)item.Value);
                }
            }
            return arenaPlayerStatus;
        }

        /// <summary>
        /// 踢出还在副本的玩家
        /// </summary>
        /// <param name="self"></param>
        public static  void KickOutPlayer(this ArenaDungeonComponent self)
        {
            List<Unit> units = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Player)
                {
                    continue;
                }
                if (units[i].IsDisposed || units[i].IsRobot())
                {
                    continue;
                }
                TransferHelper.MainCityTransfer(units[i]).Coroutine();
            }
        }

        /// <summary>
        /// 时间到
        /// </summary>
        /// <param name="sel"></param>
        /// <returns></returns>
        public static async ETTask OnArenaOver(this ArenaDungeonComponent self)
        {
            ArenaInfo arenaInfo = self.DomainScene().GetComponent<ArenaInfo>();
            foreach ((long unitid, ArenaPlayerStatu ArenaPlayerStatu) in arenaInfo.PlayerList)
            {
                LogHelper.LogDebug($"OnArenaOver: {self.DomainZone()} {unitid} {ArenaPlayerStatu.RankId}");
            }
           
            //战场关闭之前退出的玩家
            self.SendReward(self.GetNoRankPlayers(), "1;100000@10010083;5@10010085;20");
            //第一名玩家的奖励
            self.SendReward(self.GetRankPlayers(1, 1), "1;500000@10010083;20@10010085;100@10011007;1");
            //第一名玩家的奖励
            self.SendReward(self.GetRankPlayers(2, 5), "1;200000@10010083;15@10010085;50");
            //第2-30名玩家的奖励
            self.SendReward(self.GetRankPlayers(6, 10), "1;150000@10010083;10@10010085;30");
            //第2-30名玩家的奖励
            self.SendReward(self.GetRankPlayers(11, 20), "1;150000@10010083;5@10010085;20");

            self.KickOutPlayer();

            await ETTask.CompletedTask;
        }

        public static void OnUnitDisconnect(this ArenaDungeonComponent self, long unitId)
        {
            self.OnUpdateRank();
        }

        public static void OnKillEvent(this ArenaDungeonComponent self, Unit defend, Unit attack)
        {
            if (defend.Type != UnitType.Player)
            {
                return;
            }
            if (attack ==null || attack.Type != UnitType.Player)
            {
                return;
            }

            ArenaInfo arenaInfo = self.DomainScene().GetComponent<ArenaInfo>();
            if (!arenaInfo.PlayerList.ContainsKey(attack.Id))
            {
                LogHelper.LogDebug($"ArenaDungeon:  {attack.Id}not found");
                return;
            }
            ArenaPlayerStatu arenaPlayerStatu = arenaInfo.PlayerList[attack.Id];
            arenaPlayerStatu.KillNumber = arenaPlayerStatu.KillNumber + 1;
            arenaInfo.PlayerList[attack.Id] = arenaPlayerStatu;

            self.OnUpdateRank();
        }
    }
}