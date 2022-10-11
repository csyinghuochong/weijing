using UnityEngine;

namespace ET
{
    [Event]
    public class Login_OnReturnLogin : AEventClass<EventType.ReturnLogin>
    {

        protected override  void Run(object cls)
        {
            RunAsync(cls as EventType.ReturnLogin).Coroutine();
        }

        private  void RunAsync2(EventType.ReturnLogin args)
        {
            Camera camera = UIComponent.Instance.MainCamera.gameObject.GetComponent<Camera>();
            camera.GetComponent<MyCamera_1>().enabled = false;

            //reload dll
            //GameObjectPoolComponent.Instance.DisposeAll();
            //GameObject.Destroy(GameObject.Find("Global"));
            //Game.Scene.GetComponent<SceneManagerComponent>().ChangeScene(args.ZoneScene, (int)SceneTypeEnum.InitScene, 1).Coroutine();
            //CodeLoader.Instance.OnApplicationQuit();    //Game.Close
            //CodeLoader.Instance.Dispose();              //this.monoTypes.Clear()

            //not  reload dll
            Game.Scene.GetComponent<SceneManagerComponent>().ChangeScene(args.ZoneScene, (int)SceneTypeEnum.LoginScene, 1).Coroutine();
            args.ZoneScene.Dispose();
            GameObjectPoolComponent.Instance.DisposeAll();
            Scene zoneScene = SceneFactory.CreateZoneScene(1, "Game", Game.Scene);

            EventType.AppStartInitFinish.Instance.ZoneScene = zoneScene;
            Game.EventSystem.PublishClass(EventType.AppStartInitFinish.Instance);
        }

        private async ETTask RunAsync(EventType.ReturnLogin args)
        {
            UIHelper.Clear();
            UnitHelper.LoadingScene = false;
            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            mapComponent.SceneTypeEnum = (int)SceneTypeEnum.LoginScene;

            if (args.ErrorCode == ErrorCore.ERR_OtherAccountLogin)
            {
                PopupTipHelp.OpenPopupTip_2(args.ZoneScene, "异地登录", "账号异地登录！",
                  () =>
                  {
                  }).Coroutine();
                long instanceId = args.ZoneScene.InstanceId;
                await TimerComponent.Instance.WaitAsync(2000);
                if (instanceId != args.ZoneScene.InstanceId)
                {
                    return;
                }
                RunAsync2(args);
            }
            else
            {
                RunAsync2(args);
            }

        }
    }
}
