using UnityEngine;

namespace ET
{

    //闲逛
    public class Behaviour_Stroll : BehaviourHandler
    {
        public override string BehaviourId()
        {
            return BehaviourType.Behaviour_Stroll;
        }

        public override int Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.NewBehaviour == BehaviourType.Behaviour_Stroll)
            {
                return 0;
            }
            return 1;
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            int number = 100000;
            Scene zoneScene = aiComponent.ZoneScene();
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            Log.ILog.Debug("Behaviour_Stroll: Enter");
            while (number > 0)
            {
                Log.ILog.Debug("Behaviour_Stroll: Execute");
                int random = RandomHelper.RandomNumber(0, aiComponent.PositionList.Count);
                Vector3 vector3 = aiComponent.PositionList[random];
                int ret = await myUnit.MoveToAsync2(vector3);
                if (ret != 0)
                {
                    Log.ILog.Debug("Behaviour_Stroll: Eixt1");
                    return;
                }
                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool timeRet = await TimerComponent.Instance.WaitAsync(20000, cancellationToken);
                if (!timeRet)
                {
                    Log.ILog.Debug("Behaviour_Stroll: Eixt2");
                    return;
                }
                //几率转任务
                if (0.02f >= RandomHelper.RandFloat01())
                {
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_Task);
                    return;
                }

                number--;
            }
        }


    }
}
