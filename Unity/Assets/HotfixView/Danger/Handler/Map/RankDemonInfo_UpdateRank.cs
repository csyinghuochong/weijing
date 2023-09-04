namespace ET
{
    [Event]
    public class RankDemonInfo_UpdateRank: AEventClass<EventType.RankDemonInfo>
    {
        protected override void Run(object obj)
        {
            EventType.RankDemonInfo args = obj as EventType.RankDemonInfo;

            UI ui = UIHelper.GetUI(args.ZoneScene, UIType.UIDemonMain);
            ui?.GetComponent<UIDemonMainComponent>().UpdateRanking(args.M2CRankDemonMessage);
        }
    }
}