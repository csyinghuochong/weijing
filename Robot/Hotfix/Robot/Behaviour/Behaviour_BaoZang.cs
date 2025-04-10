using UnityEngine;

namespace ET
{
    public class Behaviour_BaoZang : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_BaoZang;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            //boss被干掉就退出
            Scene zoneScene = aiComponent.ZoneScene();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            int sceneId = BattleHelper.GetSceneIdByType(SceneTypeEnum.BaoZang);
            await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(10000, 30000));

            await EnterFubenHelp.RequestTransfer(aiComponent.ZoneScene(), SceneTypeEnum.BaoZang, sceneId);
        }
    }
}
