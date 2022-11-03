namespace ET
{

    public class Team_OnRecvTeamInvite : AEventClass<EventType.RecvTeamInvite>
    {
        protected override void Run(object cls)
        {
            EventType.RecvTeamInvite args = (EventType.RecvTeamInvite)cls;
            PopupTipHelp.OpenPopupTip( args.ZoneScene, "组队邀请", $"{args.m2C_TeamInviteResult.TeamPlayerInfo.PlayerName}邀请你组队",
                () => 
                {
                    args.ZoneScene.GetComponent<TeamComponent>().AgreeTeamInvite(args.m2C_TeamInviteResult).Coroutine();
                }
                ).Coroutine();
        }
    }

    public class Team_OnTeamDungeonOpen : AEventClass<EventType.RecvTeamDungeonOpen>
    {
        protected override void Run(object cls)
        {
            EventType.RecvTeamDungeonOpen args = (EventType.RecvTeamDungeonOpen)cls;
            PopupTipHelp.OpenPopupTip(args.ZoneScene, "组队邀请", $"是否进入副本",
                () =>
                {
                    RunAsync(args).Coroutine();
                }
                ).Coroutine();
        }

        private async ETTask RunAsync(EventType.RecvTeamDungeonOpen args)
        {
            TeamComponent teamComponent = args.ZoneScene.GetComponent<TeamComponent>();
            TeamInfo teamInfo = teamComponent.GetSelfTeam();

            int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
            int times = args.ZoneScene.GetComponent<UserInfoComponent>().GetTeamDungeonTimes();
            if (totalTimes - times <= 0)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_TimesIsNot);
                return;
            }
            int errorCode = await EnterFubenHelp.RequestTransfer(args.ZoneScene, (int)SceneTypeEnum.TeamDungeon, 0);
            if (errorCode != ErrorCore.ERR_Success)
            {
                ErrorHelp.Instance.ErrorHint(errorCode);
            }
            UIHelper.Remove(args.ZoneScene, UIType.UITeamDungeon);
        }
    }

    [Event]
    public class Team_OnTeamDungeonSettlement : AEventClass<EventType.TeamDungeonSettlement>
    {
        protected override void Run(object cls)
        {
            RunAsync(cls as EventType.TeamDungeonSettlement).Coroutine();
        }

        private async ETTask RunAsync(EventType.TeamDungeonSettlement args)
        {
            await TimerComponent.Instance.WaitAsync(3000);
            if (UIHelper.GetUI(args.Scene, UIType.UITeamDungeonSettlement) != null)
                return;
            int sceneTypeEnum = args.Scene.GetComponent<MapComponent>().SceneTypeEnum;
            if (sceneTypeEnum == (int)SceneTypeEnum.MainCityScene)
            {
                return;
            }
            UI ui = await UIHelper.Create(args.Scene, UIType.UITeamDungeonSettlement);
            ui.GetComponent<UITeamDungeonSettlementComponent>().OnUpdateUI(args.m2C_FubenSettlement);
        }
    }

    
    [Event]
    public class Team_OnTeamDungeonBoxReward : AEventClass<EventType.TeamDungeonBoxReward>
    {
        protected override void Run(object cls)
        {
            EventType.TeamDungeonBoxReward args = (EventType.TeamDungeonBoxReward)cls;
            UI ui = UIHelper.GetUI(args.Scene, UIType.UITeamDungeonSettlement);
            if (ui != null)
            {
                ui.GetComponent<UITeamDungeonSettlementComponent>().OnTeamDungeonBoxReward(args.m2C_FubenSettlement);
            }
        }
    }
}
