namespace ET
{
    [Event]
    public class RunRace_OnRunRaceBattleInfo : AEventClass<EventType.RunRaceBattleInfo>
    {
        protected override void Run(object obj)
        {
            EventType.RunRaceBattleInfo args = obj as EventType.RunRaceBattleInfo;

            UI ui = UIHelper.GetUI(args.ZonScene, UIType.UIRunRaceMain);
            ui?.GetComponent<UIRunRaceMainComponent>()?.UpdateNextTransformTime(args.M2C_RunRaceBattleInfo);
        }
    }
}