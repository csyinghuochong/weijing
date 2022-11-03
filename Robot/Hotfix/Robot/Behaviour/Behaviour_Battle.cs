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
            if (aiComponent.NewBehaviour == BehaviourType.Behaviour_Battle)
            {
                return true;
            }
            return false;
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            TeamComponent teamComponent = zoneScene.GetComponent<TeamComponent>();
            Log.ILog.Debug("Behaviour_Battle: Enter");
            while (true)
            {
                Log.ILog.Debug("Behaviour_Battle: Execute");
               
                int errorCode = await BattleHelper.OnButtonEnter(zoneScene);
                if (errorCode != 0)
                {
                    Log.Info($"Behaviour_Battle: errorCode {errorCode}");
                }
                else
                {
                    zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Target);
                    return;
                }

                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool ret = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!ret)
                {
                    Log.ILog.Debug("Behaviour_Battle: Exit1");
                    return;
                }
            }
        }
    }
}
