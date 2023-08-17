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

            bool timeRet = await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(1000, 5000), cancellationToken);
            if (!timeRet || zoneScene.IsDisposed)
            {
                return;
            }

            await EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.LocalDungeon, 10001, 0);
            timeRet = await TimerComponent.Instance.WaitAsync(TimeHelper.Second * 10, cancellationToken);
            if (!timeRet)
            {
                return;
            }
            while (true)
            {
                
                await EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.LocalDungeon, 0,0, "1002");
                timeRet = await TimerComponent.Instance.WaitAsync(TimeHelper.Second * 10, cancellationToken);
                if (!timeRet)
                {
                    return;
                }

                await EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.LocalDungeon, 0,0, "1009");
                timeRet = await TimerComponent.Instance.WaitAsync(TimeHelper.Second * 10, cancellationToken);
                if (!timeRet)
                {
                    return;
                }

                timeRet = await TimerComponent.Instance.WaitAsync(TimeHelper.Second * 10, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}