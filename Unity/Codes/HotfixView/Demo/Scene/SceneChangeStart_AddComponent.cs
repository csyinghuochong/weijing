namespace ET
{

    public class SceneChangeStart_AddComponent: AEventClass<EventType.SceneChangeStart>
    {
        protected override void  Run(object cls)
        {
            RunAsync(cls as EventType.SceneChangeStart).Coroutine();
        }

        private async ETTask RunAsync(EventType.SceneChangeStart args)
        {
            Scene currentScene = args.ZoneScene.CurrentScene();

            // 加载场景资源
            //await ResourcesComponent.Instance.LoadSceneAsync($"{currentScene.Name}.unity3d");
            // 切换到map场景

            //SceneChangeComponent sceneChangeComponent = null;
            //try
            //{
            //    sceneChangeComponent = Game.Scene.AddComponent<SceneChangeComponent>();
            //    {
            //        await sceneChangeComponent.ChangeSceneAsync(currentScene.Name);
            //    }
            //}
            //finally
            //{
            //    sceneChangeComponent?.Dispose();
            //}

            //先卸载旧资源
            if (args.LastSceneType > (int)SceneTypeEnum.MainCityScene)
            {
                GameObjectPool.Instance.DisposeAll();
                UI uimain = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
                uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.OnExitBattle();
            }
            Game.Scene.GetComponent<SceneManagerComponent>().SceneAssetRequest = null;
            UI uI = await UIHelper.Create(args.ZoneScene, UIType.UILoading);
            uI.GetComponent<UILoadingComponent>().OnInitUI(args.SceneType, args.ChapterId);
            if (UIHelper.GetUI(args.ZoneScene, UIType.UILobby) != null)
            {
                UIHelper.Remove(args.ZoneScene, UIType.UILobby);
            }
            Game.Scene.GetComponent<SceneManagerComponent>().ChangeScene(args.ZoneScene, args.SceneType, args.ChapterId).Coroutine();
        }
    }
}