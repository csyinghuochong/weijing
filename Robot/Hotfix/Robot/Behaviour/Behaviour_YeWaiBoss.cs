namespace ET
{

    //野外BOSS
    public class Behaviour_YeWaiBoss : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_YeWaiBoss;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            await ETTask.CompletedTask;
        }
     }
}
