using System.Collections.Generic;
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
            int number = 10000;
            Scene zoneScene = aiComponent.ZoneScene();
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            await zoneScene.GetComponent<BagComponent>().CheckEquipList();
            Log.Debug("Behaviour_Stroll: Enter");
            while (number > 0)
            {
                if (myUnit.IsDisposed)
                {
                    return;
                }

                List<int> allnpc = SceneConfigCategory.Instance.NpcIdList;
                int npcid = allnpc[RandomHelper.RandomNumber(0, allnpc.Count)];
                NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcid);
                Vector3 vector3 = (new Vector3()
                {
                    x = npcConfig.Position[0] * 0.01f + RandomHelper.RandomNumberFloat(-1f, 1f),
                    y = npcConfig.Position[1] * 0.01f,
                    z = npcConfig.Position[2] * 0.01f + RandomHelper.RandomNumberFloat(-1f, 1f),
                });
                if (Vector3.Distance(myUnit.Position, vector3) > 1f)
                {
                    myUnit.MoveToAsync2(vector3).Coroutine();
                    Log.Debug($"Behaviour_Stroll: {npcConfig.Name}");
                }
                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool timeRet = await TimerComponent.Instance.WaitAsync( TimeHelper.Minute * 5 , cancellationToken);
                if (!timeRet)
                {
                    Log.Debug("Behaviour_Stroll: Eixt2");
                    return;
                }

                //几率退出
                if (0.01f >= RandomHelper.RandFloat01()&& (TimeHelper.ClientNow() - aiComponent.CreateTime) >= TimeHelper.Hour * 12)
                {
                    zoneScene.GetParent<RobotManagerComponent>().RemoveRobot(zoneScene, "随机退出").Coroutine();
                    return;
                }

                //几率转其他
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
