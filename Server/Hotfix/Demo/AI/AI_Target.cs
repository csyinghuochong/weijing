namespace ET
{
    [AIHandler]
    public class AI_Target : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {

            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            await ETTask.CompletedTask;
        }
    }
}