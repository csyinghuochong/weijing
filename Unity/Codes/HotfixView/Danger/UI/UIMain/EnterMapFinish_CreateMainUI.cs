


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
			UIHelper.Remove(args.ZoneScene, UIType.UILobby).Coroutine();
			UIHelper.Create(args.ZoneScene, UIType.UIMain).Coroutine();

			args.ZoneScene.GetComponent<FangChenMiComponent>().OnLogin().Coroutine();
			GameObject.Find("Global").GetComponent<Init>().OpenBuglyAgent(args.ZoneScene.GetComponent<AccountInfoComponent>().CurrentRoleId);
		}

	}
}
