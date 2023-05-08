using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Behaviour_Solo : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Solo;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            Log.Debug($"Behaviour_Solo: Execute");
            while (true)
            {
                int errorCode = await NetHelper.RequestSoloMatch(zoneScene);
                Log.Debug($"Behaviour_Solo: errorCode {errorCode}");
                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool ret = await TimerComponent.Instance.WaitAsync(5 * TimeHelper.Minute, cancellationToken);
                if (!ret)
                {
                    Log.Debug("Behaviour_Solo: Exit1");
                    return;
                }
            }
        }
    }
}
