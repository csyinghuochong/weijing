using System;

namespace ET
{
    public static class SceneChangeHelper
    {
        // 场景切换协程
        public static async ETTask SceneChangeTo(Scene zoneScene, int sceneType, int chapterId, int sonId, long sceneInstanceId)
        {
            //zoneScene.RemoveComponent<AIComponent>();
            int lastSceneType = zoneScene.GetComponent<MapComponent>().SceneTypeEnum;
            zoneScene.GetComponent<MapComponent>().SetMapInfo(sceneType, chapterId, sonId);
            CurrentScenesComponent currentScenesComponent = zoneScene.GetComponent<CurrentScenesComponent>();
            currentScenesComponent.Scene?.Dispose(); // 删除之前的CurrentScene，创建新的
            //Scene currentScene = SceneFactory.CreateCurrentScene(sceneInstanceId, zoneScene.Zone, chapterId.ToString(), currentScenesComponent);
            Scene currentScene = SceneFactory.CreateCurrentScene(IdGenerater.Instance.GenerateInstanceId(), zoneScene.Zone, chapterId.ToString(), currentScenesComponent);
            UnitComponent unitComponent = currentScene.AddComponent<UnitComponent>();

            // 可以订阅这个事件中创建Loading界面
            EventType.SceneChangeStart.Instance.ZoneScene = zoneScene;
            EventType.SceneChangeStart.Instance.LastSceneType = lastSceneType;
            EventType.SceneChangeStart.Instance.SceneType = sceneType;
            EventType.SceneChangeStart.Instance.ChapterId =   chapterId;
            EventType.SceneChangeStart.Instance.SonId = sonId;
            Game.EventSystem.PublishClass(EventType.SceneChangeStart.Instance);

            // 等待CreateMyUnit的消息
            WaitType.Wait_CreateMyUnit waitCreateMyUnit = await zoneScene.GetComponent<ObjectWait>().Wait<WaitType.Wait_CreateMyUnit>();
            M2C_CreateMyUnit m2CCreateMyUnit = waitCreateMyUnit.Message;
            Unit unit = null;
            try
            {
                unit = UnitFactory.CreateUnit(currentScene, m2CCreateMyUnit.Unit, true);
                unitComponent.Add(unit);
                zoneScene.GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
                //zoneScene.RemoveComponent<AIComponent>();

                EventType.SceneChangeFinish.Instance.ZoneScene = zoneScene;
                EventType.SceneChangeFinish.Instance.CurrentScene = currentScene;
                Game.EventSystem.PublishClass(EventType.SceneChangeFinish.Instance);   //挂在当前Scene组件

                // 通知等待场景切换的协程
                zoneScene.GetComponent<ObjectWait>().Notify(new WaitType.Wait_SceneChangeFinish());
            }
            catch (Exception ex)
            { 
                Log.Error(ex);
            }
        }
    }
}