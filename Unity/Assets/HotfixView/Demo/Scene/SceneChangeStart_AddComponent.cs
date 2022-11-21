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
                GameObjectPoolComponent.Instance.DisposeAll();
            }
            Game.Scene.GetComponent<SceneManagerComponent>().SceneAssetRequest = null;
            UI uI = await UIHelper.Create(args.ZoneScene, UIType.UILoading);
            uI.GetComponent<UILoadingComponent>().OnInitUI(args.LastSceneType, args.SceneType, args.ChapterId);

            switch (args.LastSceneType)
            {
                case SceneTypeEnum.PetTianTi:
                case SceneTypeEnum.PetDungeon:
                    UIHelper.Remove(args.ZoneScene, UIType.UIPetMain);
                    break;
                case SceneTypeEnum.Tower:
                    UIHelper.Remove(args.ZoneScene, UIType.UITowerOpen);
                    break;
                case SceneTypeEnum.Battle:
                    UIHelper.Remove(args.ZoneScene, UIType.UIBattleMain);
                    break;
                case SceneTypeEnum.TeamDungeon:
                    UIHelper.Remove(args.ZoneScene, UIType.UITeamMain);
                    break;
                case SceneTypeEnum.TrialDungeon:
                    UIHelper.Remove(args.ZoneScene, UIType.UITrialMain);
                    break;
            }
            Game.Scene.GetComponent<SceneManagerComponent>().ChangeScene(args.ZoneScene, args.SceneType, args.LastSceneType, args.ChapterId).Coroutine();
        }
    }
}