using Alipay.AopSdk.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

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

            int trigger = 0;
            //传入定时器,倒计时结束触发OnSoloOver
            for (int i = 0; i < time; i++)
            {
                trigger++;
                await TimerComponent.Instance.WaitAsync(1000);
                //每5秒秒进行一次匹配效验
                if (trigger >= 5)
                {
                    trigger = 0;
                    self.CheckMatch(i).Coroutine();
                }
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
            self.MatchList.Add(teamPlayerInfo);     //临时加 测试人数不够

            //添加积分列表
            if (!self.PlayerIntegralList.ContainsKey(teamPlayerInfo.UnitId)) {
                self.PlayerIntegralList.Add(teamPlayerInfo.UnitId,0);
            }

        }

        //添加玩家缓存
        public static void OnAddSoloDateList(this SoloSceneComponent self, long unitID , string name,int occ)
        {
            if (!self.AllPlayerDateList.ContainsKey(unitID)) {
                SoloPlayerInfo soloPlayerInfo = new SoloPlayerInfo();
                soloPlayerInfo.Name = name;
                soloPlayerInfo.Occ = occ;
                self.AllPlayerDateList.Add(unitID,soloPlayerInfo);
            }
        }

        //匹配监测机制
        public static async ETTask CheckMatch(this SoloSceneComponent self, int time)
        {
            //LogHelper.LogWarning("竞技场开始匹配 time =" + time, true);
            //30,秒内 低战力/高战力>=0.8 60秒 低战力/高战力>= 0.6 90秒 低战力/高战力>=0)
            float range = 1f;  //战力调整系数
            /*
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
            */
            //超时移除
            long serverTime = TimeHelper.ServerNow();
            //匹配超过一定时间移除匹配列表
            /*
            for (int i = self.MatchList.Count - 1; i >= 0; i--)
            {
                if (serverTime - self.MatchList[i].MatchTime > 105*1000)
                { 
                    self.MatchList.RemoveAt(i);
                    continue;
                }
            }
            */

            //定义了一个比较器进行排序
            self.MatchList.Sort(delegate (SoloPlayerInfo a, SoloPlayerInfo b)
            {
                return (int)a.Combat - (int)b.Combat;
            });

            Dictionary<long, long> fubenids = new Dictionary<long, long>();

            //通知玩家
            long gateServerId = DBHelper.GetGateServerId(self.DomainZone());
            List<SoloPlayerInfo> playerlist = new List<SoloPlayerInfo>();
            for (int i = self.MatchList.Count - 1; i >= 0; i--)
            {
                //两两匹配  i和t进行匹配
                int t = i - 1;
                if (t < 0)
                {
                    break;
                }

                //获取对应玩家数据
                SoloPlayerInfo soloPlayerInfo_i = self.MatchList[i];
                SoloPlayerInfo soloPlayerInfo_t = self.MatchList[t];

                //这里还需要添加判断2个目标是否掉线

                //获取双方战力进行匹配
                if (soloPlayerInfo_i.Combat * 1f / soloPlayerInfo_t.Combat <= range )
                {
                    //匹配成功
                    i--;
                    self.MatchList.RemoveAt(t);

                    //存入匹配缓存数据,方便下面发送消息
                    playerlist.Add(soloPlayerInfo_i);
                    playerlist.Add(soloPlayerInfo_t);

                    //把匹配的结果和要进入的副本ID存入缓存
                    long fubenId = self.GetSoloInstanceId(soloPlayerInfo_i.UnitId, soloPlayerInfo_t.UnitId);
                    SoloMatchInfo soloResultInfo = new SoloMatchInfo()
                    {
                        UnitId_1 = soloPlayerInfo_i.UnitId,
                        UnitId_2 = soloPlayerInfo_t.UnitId,
                        FubenId = fubenId
                    };
                    self.MatchResult[fubenId] = soloResultInfo;
                    fubenids[soloPlayerInfo_i.UnitId] = fubenId;
                    fubenids[soloPlayerInfo_t.UnitId] = fubenId;
                    continue;
                }
            }

            //对缓存的匹配数据进行发送消息
            for (int i = 0; i < playerlist.Count; i++)
            {
                self.m2C_SoloMatchResult.Result = 1;
                self.m2C_SoloMatchResult.FubenInstanceId = fubenids[playerlist[i].UnitId];

               //循环给每个要进入的玩家发送进入副本的消息
               //发送消息获取对应的玩家数据
               G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = playerlist[i].UnitId
                    });
                //判断目标是玩家且当前是在线的
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    //给对应玩家发送进入地图的消息
                    MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, self.m2C_SoloMatchResult);

                    //匹配成功的要移除匹配列表
                    if (self.MatchList.Contains(playerlist[i]))
                    {
                        self.MatchList.Remove(playerlist[i]);
                    }
                }
            }
        }

        public static long GetSoloInstanceId(this SoloSceneComponent self, long unitID_1, long unitID_2)
        {
            //动态创建副本
            int sceneId = 7000001;
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            //创建新的副本场景,并给副本场景附加对应组件
            Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "Solo" + fubenid.ToString(), SceneType.Fuben);
            SoloDungeonComponent soloDungeonComponent = fubnescene.AddComponent<SoloDungeonComponent>();
            soloDungeonComponent.Init();

            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.Solo, sceneId, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            return fubenInstanceId;
        }

        public static List<SoloPlayerResultInfo> GetSoloResult(this SoloSceneComponent self) {

            //进行排序
            Dictionary<long,int> dicSort = self.PlayerIntegralList.OrderByDescending(o => o.Value).ToDictionary(p => p.Key, o => o.Value);

            List<SoloPlayerResultInfo> soloResultInfoList = new List<SoloPlayerResultInfo>();

            int num = 0;

            foreach (long unitId in dicSort.Keys) {

                SoloPlayerResultInfo soloPlayerRes = new SoloPlayerResultInfo();
                soloPlayerRes.Combat = self.PlayerIntegralList[unitId];
                if (self.AllPlayerDateList.ContainsKey(unitId)) {
                    soloPlayerRes.Name = self.AllPlayerDateList[unitId].Name;
                    soloPlayerRes.Occ = self.AllPlayerDateList[unitId].Occ;
                    soloPlayerRes.WinNum = self.AllPlayerDateList[unitId].WinNum;
                    soloPlayerRes.FailNum = self.AllPlayerDateList[unitId].FailNum;
                }
                soloResultInfoList.Add(soloPlayerRes);

                num += 1;
                //最多显示前5即可
                if (num >= 5) {
                    break;
                }
            }

            return soloResultInfoList;

        }

        //竞技场结束
        public static void OnSoloOver(this SoloSceneComponent self)
        {
            self.MatchList.Clear();
            self.AllPlayerDateList.Clear();
        }
    }
}
