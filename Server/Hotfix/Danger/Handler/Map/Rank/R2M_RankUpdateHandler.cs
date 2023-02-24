namespace ET
{
    [ActorMessageHandler]
    public class R2M_RankUpdateHandler : AMActorLocationHandler<Unit, R2M_RankUpdateMessage>
    {
        protected override async ETTask Run(Unit unit, R2M_RankUpdateMessage message)
        {
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RankID, message.RankId);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.PetRankID, message.PetRankId);
            await ETTask.CompletedTask;
        }
    }
}
