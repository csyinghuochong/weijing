using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ActorMessageHandler]
    public class G2Robot_MessageHandler : AMActorHandler<Scene, G2Robot_MessageRequest>
    {
        protected override async ETTask Run(Scene scene, G2Robot_MessageRequest message)
        {
            RobotManagerComponent robotManagerComponent = scene.GetComponent<RobotManagerComponent>();
            switch (message.MessageType)
            {
                case NoticeType.TeamDungeon:
                    List<Entity> ts = robotManagerComponent.Children.Values.ToList();
                    Log.Debug($"机器人数量:{ts.Count}");

                    for (int i = 0; i < 2; i++)
                    {
                        int robotZone = robotManagerComponent.ZoneIndex++;
                        string[] teamInfo = message.Message.Split('_');
                        int fubenId = int.Parse(teamInfo[0]);
                        long teamId = long.Parse(teamInfo[1]);
                        int robotId = BattleHelper.GetTeamRobotId(fubenId);
                        Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                        BehaviourComponent behaviourComponent =  robotScene?.AddComponent<BehaviourComponent, int>(robotId);
                        behaviourComponent.MessageValue = message.Message;
                        await TimerComponent.Instance.WaitAsync(200);
                    }
                    break;
                case NoticeType.BattleOpen:
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.NewRobot, message.Zone))
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            int robotZone = robotManagerComponent.ZoneIndex++;
                            int robotId = BattleHelper.GetBattleRobotId(3);
                            Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                            robotScene?.AddComponent<BehaviourComponent, int>(robotId);
                            await TimerComponent.Instance.WaitAsync(200);
                        }
                    }
                    break;
                case NoticeType.BattleClose:
                    List<Entity> ts = robotManagerComponent.Children.Values.ToList();
                    for (int i = 0; i < ts.Count; i++)
                    {
                        Scene robotScene = ts[i] as Scene;
                        if (robotScene.GetComponent<BehaviourComponent>().GetBehaviour() != 3)
                        {
                            continue;
                        }
                        robotScene.Dispose();
                        robotManagerComponent.ZoneIndex--;  
                        await TimerComponent.Instance.WaitFrameAsync();
                    }
                    break;

            }
            await ETTask.CompletedTask;
        }
    }
}
