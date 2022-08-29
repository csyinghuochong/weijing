using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq;
using System.Runtime.Serialization;
using System.Net.Http;
using System.Net;

namespace ET
{
    public class AppStart_Init: AEvent<EventType.AppStart>
    {
        protected override void Run(EventType.AppStart args)
        {
            RunAsync(args).Coroutine();
        }

        /// <summary>
        /// 测试 aot泛型
        /// </summary>
        public void TestAOTGeneric()
        {

        }

        private async ETTask RunAsync(EventType.AppStart args)
        {
     

            Game.Scene.AddComponent<TimerComponent>();
            Game.Scene.AddComponent<CoroutineLockComponent>();

            // 加载配置
            Game.Scene.AddComponent<ResourcesComponent>();
            //await ResourcesComponent.Instance.LoadBundleAsync("config.unity3d");
            Game.Scene.AddComponent<ConfigComponent>();
            ConfigComponent.Instance.Load();
            //ResourcesComponent.Instance.UnloadBundle("config.unity3d");
            
            Game.Scene.AddComponent<OpcodeTypeComponent>();
            Game.Scene.AddComponent<MessageDispatcherComponent>();
            
            Game.Scene.AddComponent<NetThreadComponent>();
            Game.Scene.AddComponent<SessionStreamDispatcher>();
            Game.Scene.AddComponent<ZoneSceneManagerComponent>();
            
            Game.Scene.AddComponent<GlobalComponent>();

            Game.Scene.AddComponent<AIDispatcherComponent>();

            Game.Scene.AddComponent<DataUpdateComponent>();
            Game.Scene.AddComponent<SkillDispatcherComponent>();
            Game.Scene.AddComponent<BuffDispatcherComponent>();
            Game.Scene.AddComponent<EffectDispatcherComponent>();
            Game.Scene.AddComponent<FsmDispatchComponent>();
            Game.Scene.AddComponent<SceneManagerComponent>();
            Game.Scene.AddComponent<SoundComponent>();
            Game.Scene.AddComponent<NumericWatcherComponent>();     //数值监听组件
            Game.Scene.AddComponent<ShouJiChapterInfoComponent>();
            TimeInfo.Instance.TimeZone = 8;
            //await ResourcesComponent.Instance.LoadBundleAsync("unit.unity3d");

            Log.ILog.Debug("AppStart_Init   RunAsync");

            Scene zoneScene = SceneFactory.CreateZoneScene(1, "Game", Game.Scene);
            EventType.AppStartInitFinish.Instance.ZoneScene = zoneScene;
            Game.EventSystem.PublishClass(EventType.AppStartInitFinish.Instance);
            await ETTask.CompletedTask;
        }
    }
}
