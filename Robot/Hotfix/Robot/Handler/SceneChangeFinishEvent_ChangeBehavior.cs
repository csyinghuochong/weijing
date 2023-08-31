using System;


namespace ET
{

    public class SceneChangeFinishEvent_ChangeBehavior : AEventClass<EventType.SceneChangeFinish>
    {

        private async ETTask RunAsync(Scene zoneScene)
        {
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.MainCityScene)
            {
                return;
            }
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.Battle
             || mapComponent.SceneTypeEnum == SceneTypeEnum.Arena
             || mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon
             || mapComponent.SceneTypeEnum == SceneTypeEnum.LocalDungeon)
            {
                await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(5000, 10000));
                if (zoneScene.IsDisposed)
                {
                    return;
                }
                zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Target);
            }
            if ( mapComponent.SceneTypeEnum == SceneTypeEnum.Demon
              || mapComponent.SceneTypeEnum == SceneTypeEnum.RunRace)
            {
                await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(60000 * 2, 60000 * 6));
                if (zoneScene.IsDisposed)
                {
                    return;
                }
                zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Target);
            }
        }

        protected override void Run(object cls)
        {
            EventType.SceneChangeFinish args = (EventType.SceneChangeFinish)cls;

            Scene zoneScene = args.ZoneScene;
            RunAsync(zoneScene).Coroutine();
        }
    }
}
