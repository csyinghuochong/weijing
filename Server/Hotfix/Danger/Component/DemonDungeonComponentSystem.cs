using System;
using System.Collections.Generic;

namespace ET
{
    public static class DemonDungeonComponentSystem
    {

        public static void OnBegin(this DemonDungeonComponent self)
        {
            self.IsOver = false;
            if (self.DomainZone() == 5)
            {
                long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
                MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest()
                {
                    Zone = self.DomainZone(),
                    MessageType = NoticeType.Demon,
                    Message = string.Empty
                });
            }
        }

        public static void OnClose(this DemonDungeonComponent self)
        {
            Log.Console("生成恶魔");
            List<Unit> destlist = new List<Unit>();
            List<Unit> sourcelist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);

            ///开始后会根据当前场景的人数随机生成X个 恶魔
            int demonNumber = sourcelist.Count - 1;

            RandomHelper.GetRandListByCount(sourcelist, destlist, demonNumber);

            for (int i = 0; i < destlist.Count; i++)
            {
                Log.Console($"生成恶魔: {destlist[i].Id}");

                destlist[i].GetComponent<NumericComponent>().ApplyValue(NumericType.BattleCamp, CampEnum.CampPlayer_2);
                destlist[i].GetComponent<NumericComponent>().ApplyValue(NumericType.RunRaceTransform, 90000017);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonBig(destlist[i], true);
            }

            //生成怪物
            //int sceneid = self.DomainScene().GetComponent<MapComponent>().SceneId;
            //SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneid);
            //FubenHelp.CreateMonsterList(self.DomainScene(), sceneConfig.CreateMonster);
            //FubenHelp.CreateMonsterList(self.DomainScene(), sceneConfig.CreateMonsterPosi);
        }

        public static  void SendCampReward(this DemonDungeonComponent self, int campId, int rewardId)
        {
            MailInfo mailInfo = new MailInfo();
            string rewardTime = rewardId == 100 ? "胜利" : "参与";
            mailInfo.Status = 0;
            mailInfo.Title = "恶魔活动奖励";
            mailInfo.Context = $"恶魔活动{rewardTime}奖励";
            mailInfo.MailId = IdGenerater.Instance.GenerateId();

            GlobalValueConfig globalValue = GlobalValueConfigCategory.Instance.Get(rewardId);
            string[] rewardList = globalValue.Value.Split('@');
            for (int i = 0; i < rewardList.Length; i++)
            {
                string[] rewardItem = rewardList[i].Split(';');
                mailInfo.ItemList.Add(new BagInfo()
                {
                    ItemID = int.Parse(rewardItem[0]),
                    ItemNum = int.Parse(rewardItem[1]), 
                });
            }
            List<Unit> sourcelist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            for (int i = 0; i < sourcelist.Count; i++)
            {
                if (campId != sourcelist[i].GetComponent<NumericComponent>().GetAsInt(NumericType.BattleCamp))
                {
                    continue;
                }

                MailHelp.SendUserMail(self.DomainZone(), sourcelist[i].Id, mailInfo).Coroutine();
            }
        }

        public static async ETTask SendRankReward(this DemonDungeonComponent self)
        {
            //1059
            long rankserverid = DBHelper.GetRankServerId(self.DomainZone());
            ////恶魔结束. 发送奖励
            A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                         (rankserverid, new A2A_ActivityUpdateRequest() { Hour = -1, FunctionId = 1059, FunctionType = 2 });
        }

        public static async ETTask OnUpdateScore(this DemonDungeonComponent self, Unit unit, int score)
        {
            long mapInstanceId = DBHelper.GetRankServerId( self.DomainZone() );
            RankingInfo rankPetInfo = new RankingInfo();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            rankPetInfo.UserId = userInfoComponent.UserInfo.UserId;
            rankPetInfo.PlayerName = userInfoComponent.UserInfo.Name;
            rankPetInfo.PlayerLv = userInfoComponent.UserInfo.Lv;
            rankPetInfo.Occ = userInfoComponent.UserInfo.Occ;
            rankPetInfo.Combat = score;

            R2M_RankDemonResponse Response = (R2M_RankDemonResponse)await ActorMessageSenderComponent.Instance.Call
                     (mapInstanceId, new M2R_RankDemonRequest()
                     {
                         RankingInfo = rankPetInfo
                     });

            //推给客户端
            List<Unit> sourcelist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            self.M2C_RankDemonMessage.RankList = Response.RankList;
            MessageHelper.SendToClient(sourcelist, self.M2C_RankDemonMessage);
        }

        public static async ETTask OnKillEvent(this DemonDungeonComponent self, Unit defend, Unit attack)
        {
            //90000017大恶魔   90000018小恶魔   90000019幽灵

            int monsterId = defend.GetComponent<NumericComponent>().GetAsInt(NumericType.RunRaceTransform);

            //1被恶魔打败的玩家会变成小恶魔,
            if (defend.Type == UnitType.Player && monsterId == 0)
            {
                string attackName = attack.GetComponent<UserInfoComponent>().UserInfo.Name;
                defend.SetBornPosition(defend.Position, true);
                defend.GetComponent<HeroDataComponent>().OnRevive();

                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.BattleCamp, CampEnum.CampPlayer_2 );
                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.RunRaceTransform, 90000018);
                defend.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.DemonName, attackName, true);
                defend.GetComponent<UserInfoComponent>().UpdateRoleDataBroadcast(UserDataType.DemonName, attackName);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonBig(defend, true);

                await  self.OnUpdateScore(attack, 50);
            }

            //如果大恶魔 / 小恶魔被击败将进入幽灵模式,幽灵模式不能放任何技能，其他玩家也玩不见自己,只能移动.  添加一个隐身buff
            if (defend.Type == UnitType.Player && (monsterId == 90000017 || monsterId == 90000018))
            {
                defend.SetBornPosition(defend.Position, true);
                defend.GetComponent<HeroDataComponent>().OnRevive();
                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.RunRaceTransform, 90000019);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonGhost(defend, true);
                BuffData buffData_1 = new BuffData();
                buffData_1.SkillId = 67000278;
                buffData_1.BuffId = 99004004;
                defend.GetComponent<BuffManagerComponent>().BuffFactory(buffData_1, defend, null, true);

                await self.OnUpdateScore(attack, monsterId == 90000017 ? 500 : 50);
            }

            //玩家或者大恶魔全部死亡，游戏结束
            if (!self.IsOver)
            {
                int playerNumber = 0;
                int demonNumber = 0;
                List<Unit> sourcelist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
                for (int i = 0; i < sourcelist.Count; i++)
                {
                    int transformId = sourcelist[i].GetComponent<NumericComponent>().GetAsInt(NumericType.RunRaceTransform);
                    if (transformId == 0)
                    {
                        playerNumber++;
                    }
                    if (transformId == 90000017)
                    {
                        demonNumber++;
                    }
                }

                //游戏结束， 发阵营奖励
                if (demonNumber == 0)
                {
                    Log.Console("恶魔活动: 玩家胜利");

                    self.IsOver = true;
                    self.SendCampReward(1, 100);
                    self.SendCampReward(2, 101);
                    self.SendRankReward().Coroutine();
                }
                if (playerNumber == 0)
                {
                    Log.Console("恶魔活动: 恶魔胜利");

                    self.IsOver = true;
                    self.SendCampReward(1, 101);
                    self.SendCampReward(2, 100);
                    self.SendRankReward().Coroutine();
                }
            }
        }

    }
}
