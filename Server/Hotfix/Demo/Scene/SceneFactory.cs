using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ET
{
    public static class SceneFactory
    {
        public static Scene Create(Entity parent, string name, SceneType sceneType)
        {
            long instanceId = IdGenerater.Instance.GenerateInstanceId();
            return Create(parent, instanceId, instanceId, parent.DomainZone(), name, sceneType);
        }

        public static Dictionary<int, List<int>> GetAllYeWaiScene()
        {
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();
            if (ComHelp.IsInnerNet())
            {
                keyValuePairs.Add(1, new List<int>() { 101, 102 });
            }
            else
            {
                keyValuePairs.Add(1, new List<int>() { 101, 102 });
            }
            return keyValuePairs;
        }

        public static List<int> GetAllZoneList()
        {
            List<int> idList = new List<int> { };
            List<StartZoneConfig> zoneList = StartZoneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < zoneList.Count; i++)
            {
                if (zoneList[i].Id >= ComHelp.MaxZone)
                {
                    continue;
                }
                if (!StartSceneConfigCategory.Instance.Gates.ContainsKey(zoneList[i].Id))
                {
                    continue;
                }
                idList.Add(zoneList[i].Id);
            }
            return idList;
        }

        public static void CreateYeWaiScene(Entity parent)
        {
            List<int> zoneList = GetAllZoneList();

            Dictionary<int, List<int>> keyValuePairs = GetAllYeWaiScene();
            foreach (var item in keyValuePairs)
            {
                int process = item.Key;
                List<int> mapidList = item.Value;
                for (int i = 0; i < mapidList.Count; i++)
                {
                    uint mapId = (uint)mapidList[i];
                    InstanceIdStruct instanceIdStruct = new InstanceIdStruct(process, mapId);
                    long instanceId = instanceIdStruct.ToLong();

                    for (int z = 0; z < zoneList.Count; z++)
                    {
                        SceneFactory.Create(parent, mapId, instanceId, zoneList[i], $"Map{mapId}", SceneType.Map, null);
                    }
                }
            }
        }

        public static Scene Create(Entity parent, long id, long instanceId, int zone, string name, SceneType sceneType, StartSceneConfig startSceneConfig = null)
        {
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(zone);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);

            Scene scene = EntitySceneFactory.CreateScene(id, instanceId, zone, sceneType, name, parent);
            scene.AddComponent<MailBoxComponent, MailboxType>(MailboxType.UnOrderMessageDispatcher);
            switch (scene.SceneType)
            {
                case SceneType.Account:
                    scene.AddComponent<NetKcpComponent, IPEndPoint, int>(startSceneConfig.InnerIPOutPort, SessionStreamDispatcherType.SessionStreamDispatcherServerOuter);
                    scene.AddComponent<TokenComponent>();
                    scene.AddComponent<FangChenMiComponent>();
                    scene.AddComponent<AccountSessionsComponent>();
                    break;
                case SceneType.LoginCenter:
                    scene.AddComponent<LoginInfoRecordComponent>();
                    break;
                case SceneType.AccountCenter:
                    scene.AddComponent<AccountCenterComponent>();
                    scene.AddComponent<NetKcpComponent, IPEndPoint, int>(startSceneConfig.InnerIPOutPort, SessionStreamDispatcherType.SessionStreamDispatcherServerOuter);
                    break;
                case SceneType.Realm:
                    scene.AddComponent<NetKcpComponent, IPEndPoint, int>(startSceneConfig.InnerIPOutPort, SessionStreamDispatcherType.SessionStreamDispatcherServerOuter);
                    scene.AddComponent<TokenComponent>();
                    break;
                case SceneType.Queue:
                    scene.AddComponent<NetKcpComponent, IPEndPoint, int>(startSceneConfig.InnerIPOutPort, SessionStreamDispatcherType.SessionStreamDispatcherServerOuter);
                    scene.AddComponent<QueueSessionsComponent>();
                    break;
                case SceneType.Gate:
                    scene.AddComponent<NetKcpComponent, IPEndPoint, int>(startSceneConfig.InnerIPOutPort, SessionStreamDispatcherType.SessionStreamDispatcherServerOuter);
                    scene.AddComponent<PlayerComponent>();
                    scene.AddComponent<GateSessionKeyComponent>();
                    break;
                case SceneType.GateMap:
                    scene.AddComponent<UnitComponent>();
                    break;
                case SceneType.Location:
                    scene.AddComponent<LocationComponent>();
                    break;
                case SceneType.DBCache:
                    scene.AddComponent<DBCacheComponent>();
                    break;
                case SceneType.Chat:
                    scene.AddComponent<ChatSceneComponent>();
                    break;
                case SceneType.EMail:
                    scene.AddComponent<MailSceneComponent>();
                    break;
                case SceneType.Activity:
                    scene.AddComponent<ActivitySceneComponent>();
                    break;
                case SceneType.Rank:
                    scene.AddComponent<RankSceneComponent>();
                    break;
                case SceneType.PaiMai:
                    scene.AddComponent<PaiMaiSceneComponent>();
                    break;
                case SceneType.Center:
                    scene.AddComponent<CenterServerComponent>();
                    break;
                case SceneType.Team:
                    scene.AddComponent<TeamSceneComponent>();
                    break;
                case SceneType.Friend:
                    scene.AddComponent<FriendSceneComponent>();
                    break;
                case SceneType.FubenCenter:
                    scene.AddComponent<FubenCenterComponent>();
                    break;
                case SceneType.Union:
                    scene.AddComponent<UnionSceneComponent>();
                    break;
                case SceneType.ReCharge:
                    scene.AddComponent<ReChargeWXComponent>();
                    scene.AddComponent<ReChargeQDComponent>();
                    scene.AddComponent<ReChargeAliComponent>();
                    break;
                case SceneType.Battle:
                    scene.AddComponent<BattleSceneComponent>();
                    break;
                case SceneType.Fuben:           //临时副本
                    scene.AddComponent<MapComponent>();
                    scene.AddComponent<UnitComponent>();
                    scene.AddComponent<ServerInfoComponent>();
                    scene.AddComponent<AOIManagerComponent>();
                    //scene.AddComponent<RecastPathComponent>();
                    break;
                case SceneType.Map:             //野外地图
                    scene.AddComponent<MapComponent>();
                    scene.AddComponent<UnitComponent>();
                    scene.AddComponent<ServerInfoComponent>();
                    scene.AddComponent<AOIManagerComponent>();
                    scene.AddComponent<YeWaiReviveComponent>();
                    scene.AddComponent<NpcComponent>();
                    //scene.AddComponent<RecastPathComponent>();
                    break;
            }
            return scene;
        }
    }
}