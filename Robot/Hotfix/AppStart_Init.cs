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
            Game.Scene.AddComponent<TimerComponent>();
            Game.Scene.AddComponent<CoroutineLockComponent>();

            // 加载配置
            Game.Scene.AddComponent<ConfigComponent>();
            await ConfigComponent.Instance.LoadAsync();
            
            Game.Scene.AddComponent<OpcodeTypeComponent>();
            Game.Scene.AddComponent<MessageDispatcherComponent>();
            Game.Scene.AddComponent<SessionStreamDispatcher>();
            Game.Scene.AddComponent<NetThreadComponent>();
            Game.Scene.AddComponent<ZoneSceneManagerComponent>();
            Game.Scene.AddComponent<BehaviourDispatcherComponent>();
            Game.Scene.AddComponent<RobotCaseDispatcherComponent>();
            Game.Scene.AddComponent<RobotCaseComponent>();
            Game.Scene.AddComponent<NumericWatcherComponent>();
            Game.Scene.AddComponent<BuffDispatcherComponent>();
            Game.Scene.AddComponent<ShouJiChapterInfoComponent>();
            Game.Scene.AddComponent<SkillDispatcherComponent>();

            Game.Scene.AddComponent<ActorMessageDispatcherComponent>();

            StartProcessConfig processConfig = StartProcessConfigCategory.Instance.Get(Game.Options.Process);
            Game.Scene.AddComponent<NetInnerComponent, IPEndPoint, int>(processConfig.InnerIPPort, SessionStreamDispatcherType.SessionStreamDispatcherServerInner);

            var processScenes = StartSceneConfigCategory.Instance.GetByProcess(Game.Options.Process);
            foreach (StartSceneConfig startConfig in processScenes)
            {
                await RobotSceneFactory.Create(Game.Scene, startConfig.Id, startConfig.InstanceId, startConfig.Zone, startConfig.Name, startConfig.Type, startConfig);
            }
            
            if (Game.Options.Console == 1)
            {
                Game.Scene.AddComponent<ConsoleComponent>();
            }
        }
    }
}
