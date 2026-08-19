using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class G2Robot_MessageHandler : AMActorHandler<Scene, G2Robot_MessageRequest>
    {
        protected override async ETTask Run(Scene scene, G2Robot_MessageRequest message)
        {
            RobotManagerComponent robotManagerComponent = scene.GetComponent<RobotManagerComponent>();

            Log.Console($"message: {message}");

            switch (message.MessageType)
            {
                case NoticeType.RunRace:
                    int robotId = 901;
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.NewRobot, 1))
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            int robotZone = robotManagerComponent.ZoneIndex++;
                            robotId = BattleHelper.GetBattleRobotId(9, 0);
                            if (robotId == 0)
                            {
                                continue;
                            }
                            Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                            robotScene?.AddComponent<BehaviourComponent, int>(robotId);
                            await TimerComponent.Instance.WaitAsync(500);
                        }
                    }
                    break;
                case NoticeType.Demon:
                    robotId = 10001;
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.NewRobot, 1))
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            int robotZone = robotManagerComponent.ZoneIndex++;
                            robotId = BattleHelper.GetBattleRobotId(10, 0);
                            if (robotId == 0)
                            {
                                continue;
                            }
                            Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                            robotScene?.AddComponent<BehaviourComponent, int>(robotId);
                            await TimerComponent.Instance.WaitAsync(500);
                        }
                    }
                    break;
                case NoticeType.CreateRobot:
                    robotId = int.Parse(message.Message.Split('#')[0]);
                    int number = int.Parse(message.Message.Split('#')[1]);
                    for (int i = 0; i < number; ++i)
                    {
                        int robotZone = robotManagerComponent.ZoneIndex++;
                        Log.Console($"create robot22 {robotZone}");
                        Scene robot = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                        if (robot == null)
                        {
                            continue;
                        }
                        BehaviourComponent behaviourComponent = robot.AddComponent<BehaviourComponent, int>(robotId);
                        if (behaviourComponent == null)
                        {
                            continue;
                        }
                        behaviourComponent.CreateTime = TimeHelper.ClientNow();
                        await TimerComponent.Instance.WaitAsync(200);
                    }
                    break;
                case NoticeType.CreateRobotMainCity:

                    Console.WriteLine($"CreateRobotMainCity:  {message.Message}");

                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.RemoveRobot, 1))
                    {

                        int  robotIndex = int.Parse(message.Message.Split('#')[1]);

                        List<Entity> ts = robotManagerComponent.Children.Values.ToList();
                        for (int i = 0; i < ts.Count; i++)
                        {
                           
                            Scene robotScene = ts[i] as Scene;
                            if (robotScene.GetComponent<BehaviourComponent>() == null)
                            {
                                continue;
                            }
                            if (robotScene.GetComponent<BehaviourComponent>().GetBehaviour() != 12)
                            {
                                continue;
                            }
                            if (message.Zone != robotScene.GetComponent<AccountInfoComponent>().ServerId)
                            {
                                continue;
                            }
                            Console.WriteLine($"主城移动机器人退出111  :{robotScene.GetComponent<AccountInfoComponent>().Account}");

                            robotScene.GetComponent<AttackComponent>().RemoveTimer();
                            robotManagerComponent.RemoveRobot(robotScene, "主城移动机器人").Coroutine();
                            await TimerComponent.Instance.WaitAsync(200);
                        }
                        Log.Console($"create robot22  robotIndex : {robotIndex}");
                        for (int i = 0; i < 10; i++)
                        {
                            robotId = 12001 +  i;
                            int robotZone = robotManagerComponent.ZoneIndex++;
                            Log.Console($"create robot22 {robotZone}  {robotId}");
                            Scene robot = await robotManagerComponent.NewRobotBatch(message.Zone, robotZone, robotId, robotIndex);
                            if (robot == null)
                            {
                                Log.Console($"create robot22 robot == null 111");
                                continue;
                            }
                            BehaviourComponent behaviourComponent = robot.AddComponent<BehaviourComponent, int>(robotId);
                            if (behaviourComponent == null)
                            {
                                Log.Console($"create robot22 robot == null 222");
                                continue;
                            }
                            behaviourComponent.CreateTime = TimeHelper.ClientNow();
                            await TimerComponent.Instance.WaitAsync(200);
                        }
                    }

                      
                    break;
                case NoticeType.TeamDungeon:
                    int robotnumber = 0;
                    long lastteamtime = 0;
                    string[] teamInfo = message.Message.Split('_');
                    int fubenId = int.Parse(teamInfo[0]);
                    long teamId = long.Parse(teamInfo[1]);
                    robotManagerComponent.TeamRobot.TryGetValue(teamId, out lastteamtime);
                    if(TimeHelper.ServerNow() - lastteamtime < 10000)
                    {
                        return;
                    }
                    Console.WriteLine($" NoticeType.TeamDungeon {message.Message}");

                    if (robotManagerComponent.TeamRobot.ContainsKey(teamId))
                    {
                        robotManagerComponent.TeamRobot[teamId] = TimeHelper.ServerNow();
                    }
                    else
                    {
                        robotManagerComponent.TeamRobot.Add( teamId, TimeHelper.ServerNow());
                    }

                    int totalnumber = 0;
                    while (robotnumber < 1)
                    {
                        totalnumber++ ;
                        if (totalnumber >= 2)
                        {
                            break;
                        }
                        int robotZone = robotManagerComponent.ZoneIndex++;
                      
                        robotId = BattleHelper.GetTeamRobotId(fubenId);
                        Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                        if (robotScene == null)
                        {
                            continue;
                        }
                        BehaviourComponent behaviourComponent =  robotScene?.AddComponent<BehaviourComponent, int>(robotId);
                        if (behaviourComponent == null)
                        {
                            continue;
                        }
                        behaviourComponent.MessageValue = message.Message;
                        behaviourComponent.CreateTime = TimeHelper.ClientNow();
                        robotnumber++;
                        await TimerComponent.Instance.WaitAsync(500);
                    }
                    break;
                case NoticeType.YeWaiBoss:
                    //sceneid@x;y;z
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.NewRobot, 1))
                    {
                        string[] messageInfo = message.Message.Split('@');
                        string[] positionInfo = messageInfo[1].Split(";");
                        robotnumber = int.Parse(messageInfo[3]);
                        Vector3 targetPosition = new Vector3(float.Parse(positionInfo[0]), float.Parse(positionInfo[1]), float.Parse(positionInfo[2]));
                        for (int i = 0; i < robotnumber; i++)
                        {
                            int robotZone = robotManagerComponent.ZoneIndex++;
                            robotId = BattleHelper.GetBattleRobotId(4, int.Parse(messageInfo[2]));
                            if (robotId == 0)
                            {
                                continue;
                            }
                            Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                            if (robotScene == null)
                            {
                                continue;
                            }
                            BehaviourComponent behaviourComponent = robotScene?.AddComponent<BehaviourComponent, int>(robotId);
                            behaviourComponent.TargetPosition = targetPosition;
                            behaviourComponent.MessageValue = message.Message;
                            await TimerComponent.Instance.WaitAsync(500);
                        }
                    } 
                    break;
                case NoticeType.SoloBegin:
                    Log.Debug($"机器人数量[SoloBegin]");
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.NewRobot, 1))
                    {
                        for (int i = 0; i < 0; i++)
                        {
                            int robotZone = robotManagerComponent.ZoneIndex++;
                            robotId = BattleHelper.GetBattleRobotId(6, 0);
                            if (robotId == 0)
                            {
                                continue;
                            }
                            Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                            robotScene?.AddComponent<BehaviourComponent, int>(robotId);
                            await TimerComponent.Instance.WaitAsync(500);
                        }
                    }
                    break;
                case NoticeType.ArenaOpen:
                    Log.Debug($"机器人数量[ArenaOpen]");
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.NewRobot, 1))
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            int robotZone = robotManagerComponent.ZoneIndex++;
                            robotId = BattleHelper.GetBattleRobotId(5, 0);
                            if (robotId == 0)
                            {
                                continue;
                            }
                            Scene robotScene = await robotManagerComponent.NewRobot(message.Zone, robotZone, robotId);
                            robotScene?.AddComponent<BehaviourComponent, int>(robotId);
                            await TimerComponent.Instance.WaitAsync(500);
                        }
                    }

                    break;
                case NoticeType.BattleOpen:
                    robotManagerComponent.RunBattleOpenRobots(message.Message).Coroutine();
                    break;
                case NoticeType.SoloOver:
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.RemoveRobot, 1))
                    {
                        List<Entity> ts = robotManagerComponent.Children.Values.ToList();
                        for (int i = 0; i < ts.Count; i++)
                        {
                            Scene robotScene = ts[i] as Scene;
                            if (robotScene.GetComponent<BehaviourComponent>() == null)
                            {
                                continue;
                            }
                            if (robotScene.GetComponent<BehaviourComponent>().GetBehaviour() != 6)
                            {
                                continue;
                            }
                            if (message.Zone != robotScene.GetComponent<AccountInfoComponent>().ServerId)
                            {
                                continue;
                            }
                            robotScene.GetComponent<AttackComponent>().RemoveTimer();
                            robotManagerComponent.RemoveRobot(robotScene, "Solo结束").Coroutine();
                            await TimerComponent.Instance.WaitAsync(500);
                        }
                    }
                    break;
                case NoticeType.BattleOver:
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.RemoveRobot, 1))
                    {
                        List<Entity>  ts = robotManagerComponent.Children.Values.ToList();
                        for (int i = 0; i < ts.Count; i++)
                        {
                            Scene robotScene = ts[i] as Scene;
                            if (robotScene.GetComponent<BehaviourComponent>() == null)
                            {
                                continue;
                            }
                            if (robotScene.GetComponent<BehaviourComponent>().GetBehaviour() != 3)
                            {
                                continue;
                            }
                            if (message.Zone != robotScene.GetComponent<AccountInfoComponent>().ServerId)
                            {
                                continue;
                            }
                            robotScene.GetComponent<AttackComponent>().RemoveTimer();
                            robotManagerComponent.RemoveRobot(robotScene, "战场结束").Coroutine();
                            await TimerComponent.Instance.WaitAsync(200);
                        }
                    }
                    break;

            }
            await ETTask.CompletedTask;
        }
    }
}
