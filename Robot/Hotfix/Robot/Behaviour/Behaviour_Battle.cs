using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Log.ILog.Debug("Behaviour_TeamDungeon: Enter");
            while (true)
            {
                Log.ILog.Debug("Behaviour_TeamDungeon: Execute");

                //获取队伍列表
                int errorCode = await EnterFubenHelp.RequestTransfer(zoneScene, SceneTypeEnum.Battle, 1);
                if (errorCode != 0)
                {
                    Log.Info($"Behaviour_TeamDungeon: Execute {errorCode}");
                }
                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool ret = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!ret)
                {
                    Log.ILog.Debug("Behaviour_TeamDungeon: Exit1");
                    return;
                }
            }
        }
    }
}
