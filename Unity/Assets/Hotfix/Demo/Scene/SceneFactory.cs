namespace ET
{
    public static class SceneFactory
    {
        public static Scene CreateZoneScene(int zone, string name, Entity parent)
        {
            Scene zoneScene = EntitySceneFactory.CreateScene(Game.IdGenerater.GenerateInstanceId(), zone, SceneType.Zone, name, parent);
            zoneScene.AddComponent<ZoneSceneFlagComponent>();
            zoneScene.AddComponent<NetKcpComponent, int>(SessionStreamDispatcherType.SessionStreamDispatcherClientOuter);
			zoneScene.AddComponent<CurrentScenesComponent>();
            zoneScene.AddComponent<ObjectWait>();
            zoneScene.AddComponent<AccountInfoComponent>();
            zoneScene.AddComponent<FangChenMiComponent>();
            zoneScene.AddComponent<RechargeComponent>();
            zoneScene.AddComponent<MapComponent>();
            zoneScene.AddComponent<UserInfoComponent>();
            zoneScene.AddComponent<BagComponent>();
            zoneScene.AddComponent<FriendComponent>();
            zoneScene.AddComponent<TeamComponent>();
            zoneScene.AddComponent<MailComponent>();
            zoneScene.AddComponent<PetComponent>();
            zoneScene.AddComponent<ChatComponent>();
            zoneScene.AddComponent<TaskComponent>();
            zoneScene.AddComponent<SkillSetComponent>();
            zoneScene.AddComponent<ChengJiuComponent>();
            zoneScene.AddComponent<CellDungeonComponent>();
            zoneScene.AddComponent<EnergyComponent>();
            zoneScene.AddComponent<ActivityComponent>();
            zoneScene.AddComponent<ReddotComponent>();
            zoneScene.AddComponent<GuideComponent>();
            zoneScene.AddComponent<SessionComponent>();
            zoneScene.AddComponent<ShoujiComponent>();
            zoneScene.AddComponent<AttackComponent>();
            zoneScene.AddComponent<TitleComponent>();
            zoneScene.AddComponent<JiaYuanComponent>();
            zoneScene.AddComponent<BattleMessageComponent>();

            EventType.AfterCreateZoneScene.Instance.ZoneScene = zoneScene;
            Game.EventSystem.PublishClass(EventType.AfterCreateZoneScene.Instance);
            return zoneScene;
        }
        
        public static Scene CreateCurrentScene(long id, int zone, string name, CurrentScenesComponent currentScenesComponent)
        {
            Scene currentScene = EntitySceneFactory.CreateScene(id, zone, SceneType.Current, name, currentScenesComponent);
            currentScenesComponent.Scene = currentScene;

            EventType.AfterCreateCurrentScene.Instance.CurrentScene = currentScene;
            Game.EventSystem.PublishClass(EventType.AfterCreateCurrentScene.Instance);
            return currentScene;
        }
        
        
    }
}