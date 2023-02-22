using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class R2M_RankUpdateHandler : AMActorLocationHandler<Unit, R2M_RankUpdateMessage>
    {
        protected override async ETTask Run(Unit unit, R2M_RankUpdateMessage message)
        {
            Log.Debug($"排名更新:  {unit.Id} {message.RankId} {message.PetRankId} ");
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RankID, message.RankId);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.PetRankID, message.PetRankId);
            await ETTask.CompletedTask;
        }
    }
}
