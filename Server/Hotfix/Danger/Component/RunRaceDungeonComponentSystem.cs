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
            self.NextTransforTime = TimeHelper.ServerNow() + TimeHelper.Second * 20;
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

        public static void OnEnter(this RunRaceDungeonComponent self, Unit unit)
        {
            M2C_RunRaceBattleInfo m2C_RunRaceBattle = new M2C_RunRaceBattleInfo() { NextTransforTime = self.NextTransforTime };
            MessageHelper.SendToClient(unit, m2C_RunRaceBattle);
        }

        public static void OnTransform(this RunRaceDungeonComponent self)
        {
            List<Unit> unitlist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);

            for (int i = 0; i < unitlist.Count; i++)
            {
                Unit unit = unitlist[i];    
                int runracemonster = ConfigHelper.RunRaceMonsterList[RandomHelper.RandomNumber(0, ConfigHelper.RunRaceMonsterList.Count)];
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RunRaceMonster, runracemonster);
                Function_Fight.GetInstance().UnitUpdateProperty_RunRace(unit, true);

                M2C_RunRaceBattleInfo m2C_RunRaceBattle = new M2C_RunRaceBattleInfo() { NextTransforTime = self.NextTransforTime };
                MessageHelper.SendToClient(unit, m2C_RunRaceBattle);
            }
        }

        public static async ETTask Check(this RunRaceDungeonComponent self)
        {
            long serverTime = TimeHelper.ServerNow();
            if (serverTime >= self.NextTransforTime)
            {
                self.NextTransforTime = serverTime + TimeHelper.Second * 20;
                self.OnTransform();
               
            }

            Vector3 vector3 = new Vector3(-11.36f, 0.98f, 45.02f);
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

                if (Response.RankId <= 3)
                {
                    string messagecontent = $"恭喜{userInfoComponent.UserInfo.Name} 获得奔跑大赛第{Response.RankId}名";
                    ServerMessageHelper.SendBroadMessage( self.DomainZone(), NoticeType.Notice, messagecontent);
                }

                numericComponent.ApplyValue(  NumericType.RunRaceRankId,Response.RankId  );

                List<Unit> unitlist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
                M2C_RankRunRaceMessage m2C_RankRun = new M2C_RankRunRaceMessage() { RankList = Response.RankList };
                MessageHelper.SendToClient(unitlist, m2C_RankRun);

                // 领取奖励
                RankRewardConfig rankRewardConfig = RankHelper.GetRankReward(Response.RankId, 5);
                if (rankRewardConfig == null)
                {
                    continue;
                }
                BagComponent bagComponent = unit.GetComponent<BagComponent>();

                string[] itemList = rankRewardConfig.RewardItems.Split('@');
                List<RewardItem> rewardItems = new List<RewardItem>();
                MailInfo mailInfo = new MailInfo();
                for (int k = 0; k < itemList.Length; k++)
                {
                    string[] itemInfo = itemList[k].Split(';');
                    if (itemInfo.Length < 2)
                    {
                        continue;
                    }

                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    rewardItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNum });
                    mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.ShowLie}_{serverTime}" });
                }

                if (itemList.Length <= bagComponent.GetLeftSpace())
                {
                    bagComponent.OnAddItemData(rankRewardConfig.RewardItems, $"{ItemGetWay.RunRace}_{serverTime}");
                }
                else
                {
                    // 发送邮箱
                    int zone = self.DomainZone();
                    Log.Console($"发放赛跑大赛排行榜奖励： {zone}");
                    long mailServerId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;

                    mailInfo.Status = 0;
                    mailInfo.Context = $"恭喜您获得赛跑大赛排行榜第{Response.RankId}名奖励";
                    mailInfo.Title = "赛跑大赛排行榜奖励";
                    mailInfo.MailId = IdGenerater.Instance.GenerateId();
                    E2M_EMailSendResponse g_EMailSendResponse = (E2M_EMailSendResponse)await ActorMessageSenderComponent.Instance.Call(mailServerId,
                        new M2E_EMailSendRequest() { Id = userInfoComponent.UserInfo.UserId, MailInfo = mailInfo });

                }

                M2C_RankRunRaceReward m2C_RankRunRace = new M2C_RankRunRaceReward() { RewardList = rewardItems };
                MessageHelper.SendToClient(unit, m2C_RankRunRace);
            }
        }
    }
}