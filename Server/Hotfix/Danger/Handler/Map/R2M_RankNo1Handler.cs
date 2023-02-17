
namespace ET
{
	[ActorMessageHandler]
	public class R2M_RankNo1Handler : AMActorLocationHandler<Unit, R2M_RankNo1Message>
	{
		protected override async ETTask Run(Unit unit, R2M_RankNo1Message message)
		{
			Log.Debug($"排名更新:  {unit.Id} {message.RankId}");
			unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RankID, message.RankId);
			await ETTask.CompletedTask;
		}
	}
}