namespace ET
{
    [ActorMessageHandler]
    public class R2M_RankUpdateHandler : AMActorLocationHandler<Unit, R2M_RankUpdateMessage>
    {
        protected override async ETTask Run(Unit unit, R2M_RankUpdateMessage message)
        {
            switch (message.RankType)
            {
                case 1:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RankID, message.RankId);
                    break;
                case 2:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.PetRankID, message.RankId);
                    break;
                case 3:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RaceDonationRankID, message.RankId);
                    break;
                default:
                    break;
            }
            await ETTask.CompletedTask;
        }
    }
}
