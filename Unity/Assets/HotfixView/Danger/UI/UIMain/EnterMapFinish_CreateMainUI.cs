
using UnityEngine;

namespace ET
{

    [Event]
    class EnterMapFinish_CreateMainUI : AEventClass<EventType.EnterMapFinish>
    {
		protected override void  Run(object cls)
		{
			EventType.EnterMapFinish args = cls as EventType.EnterMapFinish;
			Game.Scene.GetComponent<SoundComponent>().InitData(args.ZoneScene.GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos);
			UIHelper.Remove(args.ZoneScene, UIType.UILobby);
			//UIHelper.Create(args.ZoneScene, UIType.UIMain).Coroutine();

			long roleId = args.ZoneScene.GetComponent<AccountInfoComponent>().CurrentRoleId;
			args.ZoneScene.GetComponent<FangChenMiComponent>().OnLogin().Coroutine();
			GameObject.Find("Global").GetComponent<Init>().OpenBuglyAgent(roleId);
#if UNITY_ANDROID
			TapSDKHelper.Init();
			TapSDKHelper.SetUser(roleId.ToString());
			TapSDKHelper.TrackEvent("", "");
			Log.Error("test bugly");
#endif

		}
	}
}
