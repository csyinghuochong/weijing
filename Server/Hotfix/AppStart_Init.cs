using System;
using System.Collections.Generic;
using System.Net;

namespace ET
{
    public class AppStart_Init: AEvent<EventType.AppStart>
    {
        protected override void Run(EventType.AppStart args)
        {
            RunAsync(args).Coroutine();
        }
        
        private async ETTask RunAsync(EventType.AppStart args)
        {
            Game.Scene.AddComponent<ConfigComponent>();
            await ConfigComponent.Instance.LoadAsync();

            TimeInfo.Instance.TimeZone = 8;
            StartProcessConfig processConfig = StartProcessConfigCategory.Instance.Get(Game.Options.Process);

            Game.Scene.AddComponent<TimerComponent>();
            Game.Scene.AddComponent<OpcodeTypeComponent>();
            Game.Scene.AddComponent<MessageDispatcherComponent>();
            Game.Scene.AddComponent<SessionStreamDispatcher>();
            Game.Scene.AddComponent<CoroutineLockComponent>();
            // 发送普通actor消息
            Game.Scene.AddComponent<ActorMessageSenderComponent>();
            // 发送location actor消息
            Game.Scene.AddComponent<ActorLocationSenderComponent>();
            // 访问location server的组件
            Game.Scene.AddComponent<LocationProxyComponent>();
            Game.Scene.AddComponent<ActorMessageDispatcherComponent>();
            // 数值订阅组件
            Game.Scene.AddComponent<NumericWatcherComponent>();
            
            Game.Scene.AddComponent<NetThreadComponent>();
            
            Game.Scene.AddComponent<NavmeshComponent, Func<string, byte[]>>(RecastFileReader.Read);

            Game.Scene.AddComponent<RecastPathComponent>();

            //添加db数据库的链接
            //"mongodb://127.0.0.1:27017/", "ET"
            Game.Scene.AddComponent<DBComponent>();
            Game.Scene.AddComponent<AIDispatcherComponent>();
            Game.Scene.AddComponent<SkillDispatcherComponent>();
            Game.Scene.AddComponent<BuffDispatcherComponent>();
            Game.Scene.AddComponent<ShouJiChapterInfoComponent>();

            switch (Game.Options.AppType)
            {
                case AppType.Server:
                {
                    //await MergeZoneHelper.QueryAccount(4, 1551686987356897280);
                    //await TimerComponent.Instance.WaitAsync(600000);
                    Game.Scene.AddComponent<NetInnerComponent, IPEndPoint, int>(processConfig.InnerIPPort, SessionStreamDispatcherType.SessionStreamDispatcherServerInner);

                    var processScenes = StartSceneConfigCategory.Instance.GetByProcess(Game.Options.Process);
                    foreach (StartSceneConfig startConfig in processScenes)
                    {
                         SceneFactory.Create(Game.Scene, startConfig.Id, startConfig.InstanceId, startConfig.Zone, startConfig.Name,
                            startConfig.Type, startConfig);
                    }
                    //SceneFactory.CreateYeWaiScene(Game.Scene);
                    break;
                }
                case AppType.MergeZone:
                    string[] zones =  Game.Options.Parameters.Split('_');
                    int oldzone = int.Parse(zones[0]);
                    int newzone = int.Parse(zones[1]);
                    await  MergeZoneHelper.MergeZone(oldzone, newzone);
                    Log.Info("合区完成！");
                    break;
                case AppType.DeleteZone:
                    int delezone = int.Parse(Game.Options.Parameters);
                    await DeleteZoneHelper.DeletionZone(delezone);
                    Log.Info("删档完成！");
                    break;
                case AppType.Watcher:
                {
                    StartMachineConfig startMachineConfig = WatcherHelper.GetThisMachineConfig();
                    WatcherComponent watcherComponent = Game.Scene.AddComponent<WatcherComponent>();
                    watcherComponent.Start(Game.Options.CreateScenes);
                    Game.Scene.AddComponent<NetInnerComponent, IPEndPoint, int>(NetworkHelper.ToIPEndPoint($"{startMachineConfig.InnerIP}:{startMachineConfig.WatcherPort}"), SessionStreamDispatcherType.SessionStreamDispatcherServerInner);
                    break;
                }
                case AppType.GameTool:
                    break;
            }

            if (Game.Options.Console == 1)
            {
                Game.Scene.AddComponent<ConsoleComponent>();
            }
        }
    }
}