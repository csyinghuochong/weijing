namespace ET
{
    [Event]
    public class RunRaceRewardInfo_ShowReward: AEventClass<EventType.RunRaceRewardInfo>
    {
        protected override void Run(object a)
        {
            EventType.RunRaceRewardInfo args = a as EventType.RunRaceRewardInfo;
            ShowReward(args).Coroutine();
        }

        private async ETTask ShowReward(EventType.RunRaceRewardInfo args)
        {
            UI ui = await UIHelper.Create(args.ZonScene, UIType.UICommonReward);
            ui.GetComponent<UICommonRewardComponent>().OnUpdateUI(args.M2CRankRunRaceReward.RewardList);
        }
    }
}