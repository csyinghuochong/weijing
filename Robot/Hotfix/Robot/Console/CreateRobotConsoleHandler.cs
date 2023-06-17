using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using CommandLine;
using NLog;
using UnityEngine;

namespace ET
{
    [ConsoleHandler(ConsoleMode.CreateRobot)]
    public class CreateRobotConsoleHandler: IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.CreateRobot:
                    Log.Console("CreateRobot args error!");
                    break;
                default:
                    CreateRobotArgs options = null;
                    Parser.Default.ParseArguments<CreateRobotArgs>(content.Split(' '))
                            .WithNotParsed(error => throw new Exception($"CreateRobotArgs error!"))
                            .WithParsed(o => { options = o; });

                    // 获取当前进程的RobotScene
                    using (ListComponent<StartSceneConfig> thisProcessRobotScenes = ListComponent<StartSceneConfig>.Create())
                    {
                        List<StartSceneConfig> robotSceneConfigs = StartSceneConfigCategory.Instance.Robots;
                        foreach (StartSceneConfig robotSceneConfig in robotSceneConfigs)
                        {
                            if (robotSceneConfig.Process != Game.Options.Process)
                            {
                                continue;
                            }
                            thisProcessRobotScenes.Add(robotSceneConfig);
                        }

                        RobotConfig robotConfig = RobotConfigCategory.Instance.Get(options.RobotId);
                        if (robotConfig.Behaviour == 4)   //世界boss机器人
                        {
                            string[] messageInfo = $"{2000002}@{7};{0};{15}@{72000003}".Split('@');
                            string[] positionInfo = messageInfo[1].Split(";");
                            Vector3 targetPosition = new Vector3(float.Parse(positionInfo[0]), float.Parse(positionInfo[1]), float.Parse(positionInfo[2]));
                            for (int i = 0; i < options.Num; i++)
                            {
                                int index = i % thisProcessRobotScenes.Count;
                                StartSceneConfig robotSceneConfig = thisProcessRobotScenes[index];
                                Scene robotScene = Game.Scene.Get(robotSceneConfig.Id);
                                RobotManagerComponent robotManagerComponent = robotScene.GetComponent<RobotManagerComponent>();
                                int robotZone = robotManagerComponent.ZoneIndex++;
                                Log.Console($"create robot11 {robotZone}");

                                Scene robot = await robotManagerComponent.NewRobot(options.Zone, robotZone, options.RobotId);
                                if (robot == null)
                                {
                                    continue;
                                }
                                BehaviourComponent behaviourComponent = robot.AddComponent<BehaviourComponent, int>(options.RobotId);
                                if (behaviourComponent == null)
                                {
                                    continue;
                                }
                                behaviourComponent.TargetPosition = targetPosition;
                                behaviourComponent.MessageValue = $"{2000002}@{7};{0};{15}@{72000003}";
                                behaviourComponent.CreateTime = TimeHelper.ClientNow();
                                await TimerComponent.Instance.WaitAsync(1000);
                            }
                        }
                        else
                        {
                            // 创建机器人
                            for (int i = 0; i < options.Num; ++i)
                            {
                                int index = i % thisProcessRobotScenes.Count;
                                StartSceneConfig robotSceneConfig = thisProcessRobotScenes[index];
                                Scene robotScene = Game.Scene.Get(robotSceneConfig.Id);
                                RobotManagerComponent robotManagerComponent = robotScene.GetComponent<RobotManagerComponent>();
                                int robotZone = robotManagerComponent.ZoneIndex++;
                                Log.Console($"create robot11 {robotZone}");

                                Scene robot = await robotManagerComponent.NewRobot(options.Zone, robotZone, options.RobotId);
                                if (robot == null)
                                {
                                    continue;
                                }
                                BehaviourComponent behaviourComponent = robot.AddComponent<BehaviourComponent, int>(options.RobotId);
                                if (behaviourComponent == null)
                                {
                                    continue;
                                }
                                behaviourComponent.CreateTime = TimeHelper.ClientNow();
                                await TimerComponent.Instance.WaitAsync(1000);
                            }
                        }
                    }                  
                    break;
            }
            contex.Parent.RemoveComponent<ModeContex>();
            await ETTask.CompletedTask;
        }
    }
}