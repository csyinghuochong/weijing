using Alipay.AopSdk.Core.Domain;
using System;
using System.Collections.Generic;

namespace ET
{
    [Timer(TimerType.SoloTimer)]
    public class SoloTimer : ATimer<SoloSceneComponent>
    {
        public override void Run(SoloSceneComponent self)
        {
            try
            {
                self.OnSoloBegin(30 * 60).Coroutine();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class SoloSceneComponentAwake : AwakeSystem<SoloSceneComponent>
    {
        //竞技场初始化
        public override void Awake(SoloSceneComponent self)
        {
            self.OnZeroClockUpdate();
        }
    }

    public static class SoloSceneComponentSystem
    {
        //每日零点清理竞技场更新数据
        public static void OnZeroClockUpdate(this SoloSceneComponent self)
        {
            self.BeginSoloTimer();
        }

        public static void BeginSoloTimer(this SoloSceneComponent self)
        {
            //当前时间
            DateTime dateTime = TimeHelper.DateTimeNow();
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;   
            //获取竞技场开启时间
            long openTime = FunctionHelp.GetSoloBeginTime();
            if (curTime < openTime)
            {
                //时间未到,把开启时间传进来,猜测是到了指定时间开启SoloSceneComponent组件的awake,因为传进去self了,返回一个定时器的ID
                self.SoloTimer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + TimeHelper.Second * (openTime - curTime), TimerType.SoloTimer, self);
                1841249387418943516
                return;
            }

            //活动进行中,获取活动结束时间
            long closeTime = FunctionHelp.GetSoloOverTime();
            if (curTime < closeTime)
            {
                //传入还有多少时间结束
                self.OnSoloBegin(closeTime - curTime).Coroutine();
                return;
            }
        }

        public static async ETTask OnSoloBegin(this SoloSceneComponent self, long time)
        {
            //通知机器人
            if (DBHelper.GetOpenServerDay(self.DomainZone()) > 0)
            {
                long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
                MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = self.DomainZone(), MessageType = NoticeType.SoloBegin });
            }

            //传入定时器,倒计时结束触发OnSoloOver
            for (int i = 0; i < time; i++)
            {
                await TimerComponent.Instance.WaitAsync(1000);
                //每秒进行一次匹配效验
                self.CheckMatch(i).Coroutine();
            }
            self.OnSoloOver();
        }


        //加入竞技场匹配列表
        public static void OnJoinMatch(this SoloSceneComponent self, SoloPlayerInfo teamPlayerInfo)
        {
            //判断是否在当前的列表中
            for (int i = 0; i < self.MatchList.Count; i++)
            {
                if (self.MatchList[i].UnitId == teamPlayerInfo.UnitId)
                {
                    return;
                }
            }
            self.MatchList.Add(teamPlayerInfo);
        }

        //匹配监测机制
        public static async ETTask CheckMatch(this SoloSceneComponent self, int time)
        {
            LogHelper.LogWarning("竞技场开始匹配", true);
            //30,秒内 低战力/高战力>=0.8 60秒 低战力/高战力>= 0.6 90秒 低战力/高战力>=0)
            float range = 0f;
            if (time < 30)
            {
                range = 0.8f;
            }
            else if (time < 60)
            {
                range = 0.6f;
            }
            else
            {
                range = 0f;
            }

            //超时移除
            long serverTime = TimeHelper.ServerNow();
            for (int i = self.MatchList.Count - 1; i >= 0; i--)
            {
                if (serverTime - self.MatchList[i].MatchTime > 105*1000)
                { 
                    self.MatchList.RemoveAt(i);
                    continue;
                }
            }
            self.MatchList.Sort(delegate (SoloPlayerInfo a, SoloPlayerInfo b)
            {
                return (int)a.Combat - (int)b.Combat;
            });

            //通知玩家
            long gateServerId = DBHelper.GetGateServerId(self.DomainZone());
            List<long> playerlist = new List<long>();
            for (int i = self.MatchList.Count - 1; i >= 0; i--)
            {
                //两两匹配
                int t = i - 1;
                if (t < 0)
                {
                    break;
                }

                SoloPlayerInfo soloPlayerInfo_i = self.MatchList[i];
                SoloPlayerInfo soloPlayerInfo_t = self.MatchList[t];
                if (soloPlayerInfo_i.Combat * 1f / soloPlayerInfo_t.Combat <= range )
                {
                    i--;
                    self.MatchList.RemoveAt(t);
                    playerlist.Add(soloPlayerInfo_i.UnitId);
                    playerlist.Add(soloPlayerInfo_t.UnitId);

                    if (!self.SoloResult.ContainsKey(soloPlayerInfo_i.UnitId))
                    {
                        self.SoloResult.Add(soloPlayerInfo_i.UnitId, new SoloResultInfo());
                    }
                    self.SoloResult[soloPlayerInfo_i.UnitId].FubenId = soloPlayerInfo_i.UnitId;

                    if (!self.SoloResult.ContainsKey(soloPlayerInfo_t.UnitId))
                    {
                        self.SoloResult.Add(soloPlayerInfo_t.UnitId, new SoloResultInfo());
                    }
                    self.SoloResult[soloPlayerInfo_t.UnitId].FubenId = soloPlayerInfo_i.UnitId;
                    continue;
                }
            }

            self.m2C_SoloMatchResult.Result = 1;
            for (int i = 0; i < playerlist.Count; i++)
            {
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = playerlist[i]
                    });
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, self.m2C_SoloMatchResult);
                }
            }
        }

        //竞技场结束
        public static void OnSoloOver(this SoloSceneComponent self)
        {
            self.MatchList.Clear();
        }
    }
}
