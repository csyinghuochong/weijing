
using System;
using UnityEngine;

namespace ET
{
	[Event]
	public class LoginFinish_CreateLobbyUI : AEventClass<EventType.LoginFinish>
	{
		protected override  void Run(object cls)
		{
			EventType.LoginFinish args = cls as EventType.LoginFinish;
			FangChenMiComponent fangChenMiComponent = args.ZoneScene.GetComponent<FangChenMiComponent>();
			if (fangChenMiComponent.GetPlayerAge() < 18)
			{
				DateTime dateTime = TimeHelper.DateTimeNow();
				string minute = (60 - dateTime.Minute).ToString();
				string content = ErrorHelp.Instance.ErrorHintList[ErrorCore.ERR_FangChengMi_Tip1];
				content = content.Replace("{0}", minute);
				PopupTipHelp.OpenPopupTip_3(args.ZoneScene, "防沉迷提示",
					content,
					() => 
					{
						OnLoginSucess(args).Coroutine();
					}
					).Coroutine();
			}
			else
			{
					OnLoginSucess(args).Coroutine();
			}
		}

		public static async ETTask OnLoginSucess(EventType.LoginFinish args)
		{
			FloatTipManager.Instance.ShowFloatTip("登录成功!");
			var path = ABPathHelper.GetScenePath("CreateRole");
			await ResourcesComponent.Instance.LoadSceneAsync(path);
			await TimerComponent.Instance.WaitAsync(500);
			GameObject go = GameObject.Find("HeroPosition");
			go.transform.localPosition = new Vector3(100, 100, 0);

			UIComponent.Instance.MainCamera.transform.localPosition = new Vector3(-1.8f, 1.5f, -17f);
			UIComponent.Instance.MainCamera.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);

			FloatTipManager.Instance.ShowFloatTip("账号已完成实名认证!");
			await TimerComponent.Instance.WaitAsync(500);

			AccountInfoComponent PlayerComponent = args.ZoneScene.GetComponent<AccountInfoComponent>();
			await UIHelper.Create(args.ZoneScene, PlayerComponent.CreateRoleList.Count > 0 ? UIType.UILobby : UIType.UICreateRole);
			UIHelper.Remove(args.ZoneScene, UIType.UILogin);
		}
	}
}
