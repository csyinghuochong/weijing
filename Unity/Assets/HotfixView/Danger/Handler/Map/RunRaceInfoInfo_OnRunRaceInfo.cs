namespace ET
{
    [Event]
    public class RunRaceInfoInfo_OnRunRaceInfo: AEventClass<EventType.RunRaceInfo>
    {
        protected override void Run(object obj)
        {
            EventType.RunRaceInfo args = obj as EventType.RunRaceInfo;

            UI ui = UIHelper.GetUI(args.ZonScene, UIType.UIRunRaceMain);
            ui?.GetComponent<UIRunRaceMainComponent>().UpdateRanking(args.M2CRankRunRaceMessage);
        }
    }
}