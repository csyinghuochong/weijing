using UnityEngine;

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
            //boss被干掉就退出
            Scene zoneScene = aiComponent.ZoneScene();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            if (Vector3.Distance(unit.Position, aiComponent.TargetPosition)< 0.5f
                && AIHelp.GetNearestEnemy(unit) == null)
            {
                aiComponent.Exit();
                return false;   
            }
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            int sceneId = int.Parse(aiComponent.MessageValue.Split('@')[0]);
            int errorCode = await EnterFubenHelp.RequestTransfer(aiComponent.ZoneScene(), SceneTypeEnum.YeWaiScene, sceneId);
            if (errorCode == ErrorCode.ERR_Success)
            {
                await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(10000, 30000));
                aiComponent.ChangeBehaviour(BehaviourType.Behaviour_Target);
            }
        }
     }
}
