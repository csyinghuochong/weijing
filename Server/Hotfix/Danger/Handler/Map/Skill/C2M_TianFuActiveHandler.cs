using System;

namespace ET
{
    //激活天赋
    [ActorMessageHandler]
    public class C2M_TianFuActiveHandler : AMActorLocationRpcHandler<Unit, C2M_TianFuActiveRequest, M2C_TianFuActiveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TianFuActiveRequest request, M2C_TianFuActiveResponse response, Action reply)
        {
            SkillSetComponent skillSetComponent = unit.GetComponent<SkillSetComponent>();
            int oldId = skillSetComponent.HaveSameTianFu(request.TianFuId);
            if (oldId != 0 && oldId != request.TianFuId)
            {
                // GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(48);
                TalentConfig talentConfig = TalentConfigCategory.Instance.Get(request.TianFuId);
                int num = 50000 + talentConfig.LearnRoseLv * 100;
                string cost = "1;" + num;
                if (!unit.GetComponent<BagComponent>().OnCostItemData(cost))
                {
                    response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }
            }

            unit.GetComponent<SkillSetComponent>().OnActiveTianfu(request);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
