namespace ET
{
    //战场
    public class Behaviour_Battle : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Battle;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            await zoneScene.GetComponent<BagComponent>().CheckEquipList();
            while (true)
            {
                int errorCode = await NetHelper.OnRobotEnter(zoneScene);
                if (errorCode != 0)
                {
                    Log.Debug($"Behaviour_Battle: errorCode {errorCode}");
                }
                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool ret = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!ret)
                {
                    Log.Debug("Behaviour_Battle: Exit1");
                    return;
                }
            }
        }
    }
}
