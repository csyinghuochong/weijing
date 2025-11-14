using System;
using UnityEngine;

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

        public static byte[] Read(string name)
        {
            return  ResourcesComponent.Instance.LoadAsset<TextAsset>($"Assets/Bundles/Recast/{name}.bytes").bytes;
            //return File.ReadAllBytes(Path.Combine("../Config/RecastNavData", name));
        }

        private async ETTask RunAsync(EventType.AppStart args)
        {
            //debug run time

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
            Game.Scene.AddComponent<SceneManagerComponent>();
            Game.Scene.AddComponent<SoundComponent>();
            Game.Scene.AddComponent<NumericWatcherComponent>();     //数值监听组件
            Game.Scene.AddComponent<ShouJiChapterInfoComponent>();
            Game.Scene.AddComponent<GameObjectPoolComponent>();

            Game.Scene.AddComponent<IosPurchasingComponent>();

            if (GlobalHelp.GetPlatform() == 7)
            {
                Game.Scene.AddComponent<GooglePurchasingComponent>();
                ServerHelper.InitServerList("StartConfig/Google");
            }
            else
            {
                if (GlobalHelp.IsOutNetMode)
                {
                    VersionMode version = GlobalHelp.VersionMode;
                    ServerHelper.InitServerList(version == VersionMode.BanHao ? "StartConfig/BanHao" : "StartConfig/Beta");
                }
                else
                {
                    ServerHelper.InitServerList("StartConfig/Localhost");
                }
            }
            Log.ILog.Debug($"ServerItems.:{ServerHelper.GetServerList().Count}");

            Game.Scene.AddComponent<NavmeshComponent, Func<string, byte[]>>(Read);
            
            GameSettingLanguge.InitMulLanguageData();

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
