using UnityEngine;

namespace ET
{
    //闲逛
    public class Behaviour_Stroll : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Stroll;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            int number = 100000;
            Scene zoneScene = aiComponent.ZoneScene();
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            Log.ILog.Debug("Behaviour_Stroll: Enter");
            while (number > 0)
            {
                int random = RandomHelper.RandomNumber(0, BehaviourComponent.StrollPositionList.Count);
                Vector3 vector3 = BehaviourComponent.StrollPositionList[random];

                if (Vector3.Distance(myUnit.Position, vector3) > 1f)
                {
                    myUnit.MoveToAsync2(vector3).Coroutine();
                }
                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool timeRet = await TimerComponent.Instance.WaitAsync(60000, cancellationToken);
                if (!timeRet)
                {
                    Log.ILog.Debug("Behaviour_Stroll: Eixt2");
                    return;
                }
                //几率转其他
                if (0.8f >= RandomHelper.RandFloat01())
                {
                    aiComponent.ChangeBehaviour(aiComponent.Behaviours[1].KeyId);
                    return;
                }

                number--;
            }
        }


    }
}
