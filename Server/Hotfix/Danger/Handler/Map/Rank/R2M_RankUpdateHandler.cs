namespace ET
{
    [ActorMessageHandler]
    public class R2M_RankUpdateHandler : AMActorLocationHandler<Unit, R2M_RankUpdateMessage>
    {
        protected override async ETTask Run(Unit unit, R2M_RankUpdateMessage message)
        {
            Log.Console($"R2M_RankUpdateMessage； {message.RankId} {message.OccRankId}");
            switch (message.RankType)
            {
                case 1:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.CombatRankID, message.RankId);
                    unit.GetComponent<TaskComponent>().TriggerTaskEvent( TaskTargetType.CombatRank_83, message.RankId, 1);
                    unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.CombatRank_83, message.RankId, 1);
                    break;
                case 2:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.PetTianTiRankID, message.RankId);
                    unit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.PetTianTiRank_82, message.RankId, 1);
                    unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.PetTianTiRank_82, message.RankId, 1);
                    break;
                case 3:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RaceDonationRankID, message.RankId);
                    break;
                case 4:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.SoloRankId, message.RankId);
                    break;
                default:
                    break;
            }
            await ETTask.CompletedTask;
        }
    }
}
