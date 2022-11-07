namespace ET
{

    [Event]
    public class PetRank_OnSettlement : AEventClass<EventType.PetRankSettlement>
    {
        protected override void  Run(object cls)
        {
            RunAsync(cls as EventType.PetRankSettlement).Coroutine();
        }

        private async ETTask RunAsync(EventType.PetRankSettlement args)
        {
            await TimerComponent.Instance.WaitAsync(2000);

            PopupTipHelp.OpenPopupTip_2(args.Scene, args.m2C_PetRankSettlement.BattleResult == CombatResultEnum.Win ? "胜利" : "失败", "获取奖励",
                 () => { EnterFubenHelp.RequestQuitFuben(args.Scene); }
                 ).Coroutine();
        }

    }
}
