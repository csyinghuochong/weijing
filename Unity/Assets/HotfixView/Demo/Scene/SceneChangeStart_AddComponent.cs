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
            //if (args.LastSceneType > (int)SceneTypeEnum.MainCityScene)
            //{
            //    GameObjectPoolComponent.Instance.DisposeAll();
            //}
            Game.Scene.GetComponent<SceneManagerComponent>().SceneAssetRequest = null;
            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();

            UI uI = await UIHelper.Create(args.ZoneScene, UIType.UILoading);
            uI.GetComponent<UILoadingComponent>().OnInitUI(args.LastSceneType, args.SceneType, args.ChapterId);

            UI uimain = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
            if (uimain != null)
            {
                UIHelper.Remove(args.ZoneScene, UIType.UIMapBig);
                uimain.GetComponent<UIMainComponent>().BeginEnterScene(args.LastSceneType);
            }

            switch (args.LastSceneType)
            {
                case SceneTypeEnum.PetTianTi:
                case SceneTypeEnum.PetDungeon:
                case SceneTypeEnum.PetMing:
                    UIHelper.Remove(args.ZoneScene, UIType.UIPetMain);
                    break;
                case SceneTypeEnum.LocalDungeon:
                    DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(args.LastChapterId);
                    switch (dungeonConfig.MapType)
                    {
                        case SceneSubTypeEnum.LocalDungeon_1:
                            UIHelper.Remove(args.ZoneScene, UIType.UIDungeonHappyMain);
                            break;
                        default:
                            break;
                    }
                    break;
                case SceneTypeEnum.Tower:
                    UIHelper.Remove(args.ZoneScene, UIType.UITowerOpen);
                    break;
                case SceneTypeEnum.Happy:
                    UIHelper.Remove(args.ZoneScene, UIType.UIHappyMain);
                    break;
                case SceneTypeEnum.Battle:
                    UIHelper.Remove(args.ZoneScene, UIType.UIBattleMain);
                    break;
                case SceneTypeEnum.Arena:
                    UIHelper.Remove(args.ZoneScene, UIType.UIArenaMain);
                    break;
                case SceneTypeEnum.TeamDungeon:
                    UIHelper.Remove(args.ZoneScene, UIType.UITeamMain);
                    break;
                case SceneTypeEnum.TrialDungeon:
                    UIHelper.Remove(args.ZoneScene, UIType.UITrialMain);
                    break;
                case SceneTypeEnum.TowerOfSeal:
                    UIHelper.Remove(args.ZoneScene, UIType.UITowerOfSealMain);
                    break;
                case SceneTypeEnum.JiaYuan:
                    UIHelper.Remove(args.ZoneScene, UIType.UIJiaYuanMain);
                    break;
                case SceneTypeEnum.RunRace:
                    UIHelper.Remove(args.ZoneScene, UIType.UIRunRaceMain);
                    break;
                case SceneTypeEnum.Demon:
                    UIHelper.Remove(args.ZoneScene, UIType.UIDemonMain);
                    break;
                case SceneTypeEnum.MiJing:
                    UIHelper.Remove(args.ZoneScene, UIType.UIMiJingMain);
                    break;
                default:
                    break;
            }

            await Game.Scene.GetComponent<SceneManagerComponent>().ChangeScene(args.ZoneScene, args.SceneType, args.LastSceneType, args.ChapterId);
        }

    }
}