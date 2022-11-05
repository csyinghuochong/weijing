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
                case NoticeType.BattleOpen:
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.NewRobot, 1))
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            int robotZone = robotManagerComponent.ZoneIndex++;
                            Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, 3001);
                            robotScene?.AddComponent<BehaviourComponent, int>(3001);
                            await TimerComponent.Instance.WaitAsync(200);
                        }
                    }
                    break;
                case NoticeType.BattleClose:
                    List<Entity> ts = robotManagerComponent.Children.Values.ToList();
                    for (int i = 0; i < ts.Count; i++)
                    {
                        (ts[i] as Scene).GetComponent<SessionComponent>().Session.Dispose();
                        ts[i].Dispose();
                        await TimerComponent.Instance.WaitFrameAsync();
                    }
                    break;
            }
            await ETTask.CompletedTask;
        }
    }
}
