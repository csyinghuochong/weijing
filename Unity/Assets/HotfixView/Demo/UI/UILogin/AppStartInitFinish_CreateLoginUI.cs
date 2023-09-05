

using UnityEngine;

namespace ET
{
	[Event]
	public class AppStartInitFinish_CreateLoginUI : AEventClass<EventType.AppStartInitFinish>
	{
		protected override async void  Run(object cls)
		{
			Log.ILog.Debug(("EventType.AppStartInitFinish11"));

			EventType.AppStartInitFinish args = cls as EventType.AppStartInitFinish;
			await UIHelper.Create(args.ZoneScene, UIType.UILogin);
			GameObject.Find("Global").GetComponent<Init>().Updater.SetActive(false);

            Log.ILog.Debug(("EventType.AppStartInitFinish22"));

            args.ZoneScene.GetComponent<MapComponent>().SceneTypeEnum = (int)SceneTypeEnum.LoginScene;
			Game.Scene.GetComponent<SceneManagerComponent>().ChangeScene(args.ZoneScene, (int)SceneTypeEnum.LoginScene, SceneTypeEnum.NONE, 1).Coroutine();
		}
	}
}
