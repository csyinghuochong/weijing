namespace ET
{
	[MessageHandler]
	public class M2C_CreateMyUnitHandler : AMHandler<M2C_CreateMyUnit>
	{
#if NOT_UNITY
		private async ETTask OnRobotEnterFuben(Scene zoneScene)
		{
			MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
			if (mapComponent.SceneTypeEnum == SceneTypeEnum.MainCityScene)
			{
				return;
			}
			if (mapComponent.SceneTypeEnum == SceneTypeEnum.Battle
			 || mapComponent.SceneTypeEnum == SceneTypeEnum.Arena
			 || mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
			{
				await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(5000, 10000));
				if (zoneScene.IsDisposed)
				{
					return;
				}
				zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Target);
			}
		}
#endif

		protected override void Run(Session session, M2C_CreateMyUnit message)
		{
			// 通知场景切换协程继续往下走
			session.DomainScene().GetComponent<ObjectWait>().Notify(new WaitType.Wait_CreateMyUnit() {Message = message});

#if NOT_UNITY
			OnRobotEnterFuben(session.ZoneScene()).Coroutine();
#endif
		}
	}
}
