using UnityEngine;

namespace ET
{
    public class Behaviour_Task : BehaviourHandler
    {

        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Task;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            //有任务完成
            TaskComponent taskComponent = aiComponent.ZoneScene().GetComponent<TaskComponent>();
            if (1 == RandomHelper.RandomNumber(0, 100) && taskComponent.GetCompltedTaskList().Count > 0)
            {
                Log.Debug("Behaviour_Attack:To Behaviour_Task");
                aiComponent.ChangeBehaviour(BehaviourType.Behaviour_Task);
                return true;
            }

            if (aiComponent.NewBehaviour == BehaviourType.Behaviour_Task)
            {
                return true;
            }
            return false;
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            TaskComponent taskComponent = zoneScene.GetComponent<TaskComponent>();
            Log.Debug("Behaviour_Task: Execute");
            while (true)
            {
                int errorCode = ErrorCore.ERR_Success;
                int taskFubenId = taskComponent.GetTaskFubenId();

                MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
                if (mapComponent.SceneTypeEnum ==SceneTypeEnum.LocalDungeon)
                {
                    //先退出副本
                    EnterFubenHelp.RequestQuitFuben(zoneScene);
                    Log.Debug("Behaviour_Task: Eixt Fuben");
                }
                await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(100, 2000));
                errorCode = await EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.LocalDungeon, taskFubenId);
                Log.Debug("Behaviour_Task: Enter Fuben");
                await TimerComponent.Instance.WaitAsync(2000);
                await taskComponent.CheckTaskList();

                //可能需要传入cancellationToken
                errorCode = await taskComponent.OnExcuteTask();

                //转换攻击行为
                if (errorCode == 0)
                {
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_ZhuiJi);

                    //几率转wudi
                    if (0.5f >= RandomHelper.RandFloat01())
                    {
                        Log.Debug("Behaviour_Task: #wudi");
                        C2M_GMCommandRequest c2M_GMCommandRequest = new C2M_GMCommandRequest() { GMMsg = "#wudi", Account= "test01" };
                        zoneScene.GetComponent<SessionComponent>().Session.Send(c2M_GMCommandRequest);
                    }
                    return;
                } 
              
                bool timeRet = await TimerComponent.Instance.WaitAsync(20000, cancellationToken);
                if (!timeRet)
                {
                    Log.Debug("Behaviour_Task: Eixt2");
                    return;
                }
            }
        }
    }
}
