using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class Behaviour_Local : BehaviourHandler
    {

        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Local;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            while (true)
            {
                bool timeRet = await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(1000, 5000), cancellationToken);
                if (!timeRet || zoneScene.IsDisposed)
                {
                    return;
                }

                int taskFubenId = 10006;
                await EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.LocalDungeon, taskFubenId);
                aiComponent.TargetPosition = new Vector3(160f, 30f, -3f);

                timeRet = await TimerComponent.Instance.WaitAsync(TimeHelper.Minute * 5, cancellationToken);
                if (!timeRet)
                {
                    return;


                }
            }

        }
    }
}