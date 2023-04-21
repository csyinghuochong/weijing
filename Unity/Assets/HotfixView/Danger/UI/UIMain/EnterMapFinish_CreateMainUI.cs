
using UnityEngine;

namespace ET
{

    [Event]
    class EnterMapFinish_CreateMainUI : AEventClass<EventType.EnterMapFinish>
    {
		protected override void  Run(object cls)
		{
			EventType.EnterMapFinish args = cls as EventType.EnterMapFinish;
			Scene zoneScene = args.ZoneScene;
			Game.Scene.GetComponent<SoundComponent>().InitData(args.ZoneScene.GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos);
			UIHelper.Remove(args.ZoneScene, UIType.UILobby);
			UIHelper.Create(args.ZoneScene, UIType.UIMain).Coroutine();

			AccountInfoComponent accountInfoComponent = args.ZoneScene.GetComponent<AccountInfoComponent>();
			long roleId = accountInfoComponent.CurrentRoleId;
			args.ZoneScene.GetComponent<FangChenMiComponent>().OnLogin().Coroutine();
			GameObject.Find("Global").GetComponent<Init>().OpenBuglyAgent($"{accountInfoComponent.ServerId}_{roleId}");

#if UNITY_IPHONE
			GlobalHelp.InitIOSPurchase();

			string info = PlayerPrefsHelp.GetString("IOS_" + roleId.ToString());
			if (!string.IsNullOrEmpty(info))
			{
				NetHelper.SendIOSPayVerifyRequest(zoneScene, info);
				PlayerPrefsHelp.SetString("IOS_" + roleId.ToString(), string.Empty);
				FloatTipManager.Instance.ShowFloatTip("重连成功_IOS！");
			}

			ShareSdkHelper.MobPushOperate(1);
#endif

#if UNITY_ANDROID
			TapSDKHelper.Init();
			TapSDKHelper.SetUser(roleId.ToString());
			TapSDKHelper.TestTrackEvent("", "");
			//Log.Error("test bugly");
#endif

		}
	}
}
