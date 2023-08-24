using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.RunRaceDungeonTimer)]
    public class RunRaceDungeonTimer : ATimer<RunRaceDungeonComponent>
    {
        public override void Run(RunRaceDungeonComponent self)
        {
            try
            {
                self.Check().Coroutine();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class RunRaceDungeonComponentAwake : AwakeSystem<RunRaceDungeonComponent>
    {

        public override void Awake(RunRaceDungeonComponent self)
        {
            self.Timer = TimerComponent.Instance.NewRepeatedTimer( 1000, TimerType.RunRaceDungeonTimer, self );
        }
    }

    [ObjectSystem]
    public class RunRaceDungeonComponentDestroy : DestroySystem<RunRaceDungeonComponent>
    {

        public override void Destroy(RunRaceDungeonComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class RunRaceDungeonComponentSystem
    {

        public static async ETTask Check(this RunRaceDungeonComponent self)
        {
            Vector3 vector3 = new Vector3(-11f, 1f, 45f);
            List<Unit> units = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];   
                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                if (numericComponent.GetAsInt(NumericType.RunRaceRankId) != 0)
                {
                    continue;
                }

                if (Vector3.Distance(units[i].Position, vector3) > 2f)
                {
                    continue;
                }

                Log.Console("RunRaceDungeonComponent。玩家到达终点11111");

                long mapInstanceId = DBHelper.GetRankServerId( self.DomainZone() );
                RankingInfo rankPetInfo = new RankingInfo();
                UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
                rankPetInfo.UserId = userInfoComponent.UserInfo.UserId;
                rankPetInfo.PlayerName = userInfoComponent.UserInfo.Name;
                rankPetInfo.PlayerLv = userInfoComponent.UserInfo.Lv;
                rankPetInfo.Combat = userInfoComponent.UserInfo.Combat;
                rankPetInfo.Occ = userInfoComponent.UserInfo.Occ;
                R2M_RankRunRaceResponse Response = (R2M_RankRunRaceResponse)await ActorMessageSenderComponent.Instance.Call
                         (mapInstanceId, new M2R_RankRunRaceRequest()
                         {
                             RankingInfo = rankPetInfo
                         });
                if (unit.IsDisposed || Response.Error != ErrorCore.ERR_Success)
                {
                    continue;
                }

                numericComponent.ApplyValue(  NumericType.RunRaceRankId,Response.RankId  );

                List<Unit> unitlist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
                M2C_RankRunRaceMessage m2C_RankRun = new M2C_RankRunRaceMessage() { RankList = Response.RankList };
                MessageHelper.SendToClient(unitlist, m2C_RankRun);


                ///完善发送奖励的流程。
                ///背包未满发背包 背包满了发邮件
                //RankRewardConfig rankRewardConfig = RankHelper.GetRankReward(Response.RankId, 5);
                //if (rankRewardConfig == null)
                //{
                //    continue;
                //}
                //M2C_RankRunRaceReward m2C_RankRunRace = new M2C_RankRunRaceReward() { };
                //MessageHelper.SendToClient(unit, m2C_RankRunRace);
            }
        }
    }
}