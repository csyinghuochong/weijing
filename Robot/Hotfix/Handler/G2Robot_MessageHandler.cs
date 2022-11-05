using System;

namespace ET
{

    [ActorMessageHandler]
    public class G2Robot_MessageHandler : AMActorHandler<Scene, G2Robot_MessageRequest>
    {
        protected override async ETTask Run(Scene scene, G2Robot_MessageRequest message)
        {
            RobotManagerComponent robotManagerComponent = scene.GetComponent<RobotManagerComponent>();

            int robotZone = robotManagerComponent.ZoneIndex++;
            Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, 2001);
            robotScene?.AddComponent<BehaviourComponent, int>(2001);

            await ETTask.CompletedTask;
        }
    }
}
