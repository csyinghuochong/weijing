namespace ET
{

    //角斗场
    public class Behaviour_Arena : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Arena;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            Log.Debug($"Behaviour_Arena: Execute");
            while (true)
            {
                int errorCode = await  EnterFubenHelp.RequestTransfer(zoneScene, 1, 0, 0, "1002");
                Log.Debug($"Behaviour_Arena: errorCode {errorCode}");

                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool ret = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!ret)
                {
                    Log.Debug("Behaviour_Arena: Exit1");
                    return;
                }
            }
        }
    }
}
