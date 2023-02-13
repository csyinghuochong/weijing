
namespace ET
{
	[ActorMessageHandler]
	public class R2M_RankNo1Handler : AMActorLocationHandler<Unit, R2M_RankNo1Message>
	{
		protected override async ETTask Run(Unit unit, R2M_RankNo1Message message)
		{
			Log.Debug($"排名更新:  {unit.Id} {message.RankId}");

			if (unit.Id == 1679287029914992640)
			{
				Log.Debug($"排名更新1[抹茶星冰乐]:  {unit.Id} {message.RankId}");
			}
			unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RankID, message.RankId);
			await ETTask.CompletedTask;
		}
	}
}