
using System.Linq;
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
				NetHelper.SendIOSPayVerifyRequest(zoneScene, info).Coroutine();
				PlayerPrefsHelp.SetString("IOS_" + roleId.ToString(), string.Empty);
				FloatTipManager.Instance.ShowFloatTip("重连成功_IOS！");
			}

			ShareSdkHelper.MobPushOperate(1);
#endif

			if (GlobalHelp.GetPlatform() == 7)
			{
				string googleInfo = PlayerPrefsHelp.GetString("Google_" + roleId.ToString());
				if (!string.IsNullOrEmpty(googleInfo))
				{
					NetHelper.SendGooglePayVerifyRequest(zoneScene, googleInfo).Coroutine();
					PlayerPrefsHelp.SetString("Google_" + roleId.ToString(), string.Empty);
					FloatTipManager.Instance.ShowFloatTip("重连成功_Google！");
				}
			}

			if (GlobalHelp.GetPlatform() == 100)
            {
                CreateRoleInfo createRoleInfo = accountInfoComponent.CreateRoleList.FirstOrDefault(p => p.UserID == accountInfoComponent.CurrentRoleId);
                OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(createRoleInfo.PlayerOcc);
                EventType.QuDaoEnterGame.Instance.ZoneScene = zoneScene;
                EventType.QuDaoEnterGame.Instance.EnterGameInfo = $"{createRoleInfo.UserID}_{createRoleInfo.PlayerName}_{accountInfoComponent.ServerId}_{accountInfoComponent.ServerName}_{createRoleInfo.PlayerOcc}_{occupationConfig.OccupationName}";
                EventSystem.Instance.PublishClass(EventType.QuDaoEnterGame.Instance);
            }

#if UNITY_ANDROID
            TapSDKHelper.SetUser(roleId.ToString());
            TapSDKHelper.TestTrackEvent("", "");
			//Log.Error("test bugly");
#endif

			Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
			unit.GetComponent<UIUnitHpComponent>()?.OnGetUseInfoUpdate();
        }
    }
}
