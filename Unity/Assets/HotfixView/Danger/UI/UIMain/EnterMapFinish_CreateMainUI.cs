
using System.Collections.Generic;
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
				GlobalHelp.InitGooglePurchase();

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
			
			if (GlobalHelp.GetPlatform() == 1)
			{
				string serverName = accountInfoComponent.ServerName;
				UserInfo userInfo = zoneScene.GetComponent<UserInfoComponent>().UserInfo;
				NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(zoneScene).GetComponent<NumericComponent>();
				TapSDKHelper.UserUpdate_rolename(userInfo.Name);
				TapSDKHelper.UserUpdate_servername(serverName);
				TapSDKHelper.UserUpdate_isFirstCreateRole(accountInfoComponent.CreateRoleList.Count);
				TapSDKHelper.UserUpdate_rechargeNumber(numericComponent.GetAsInt(NumericType.RechargeNumber));
				TapSDKHelper.UserUpdate_combat(userInfo.Combat);
				TapSDKHelper.UserUpdate_level(userInfo.Lv);
				TapSDKHelper.UserUpdate_gold((int)userInfo.Gold);
				TapSDKHelper.UserUpdate_diamond((int)userInfo.Diamond);
				List<TaskPro> taskPros = zoneScene.GetComponent<TaskComponent>().RoleTaskList;
				foreach (TaskPro taskPro in taskPros)
				{
					if (taskPro.TrackStatus == 0)
					{
						continue;
					}

					TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);

					if (taskConfig.TaskType == TaskTypeEnum.Main)
					{
						Log.Debug($"当前主线任务 {taskConfig.Id} {taskConfig.TaskName}");
						TapSDKHelper.UserUpdate_currentTaskId(taskConfig.Id);
						TapSDKHelper.UserUpdate_currentTaskName(taskConfig.TaskName);
						return;
					}
				}
			}

			if (GlobalHelp.GetPlatform() == 8)
			{
				EventType.TikTokRoleLogin.Instance.ZoneScene = args.ZoneScene;
                EventType.TikTokRoleLogin.Instance.GameUserID = accountInfoComponent.Account;
                EventType.TikTokRoleLogin.Instance.GameRoleID = accountInfoComponent.CurrentRoleId.ToString();
                EventType.TikTokRoleLogin.Instance.LastRoleLoginTime = TimeHelper.ClientNow();
                EventSystem.Instance.PublishClass(EventType.TikTokRoleLogin.Instance);
            }
#endif

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
			unit.GetComponent<UIUnitHpComponent>()?.OnGetUseInfoUpdate();
        }
    }
}
