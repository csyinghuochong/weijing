using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{

#if SERVER
    [ConsoleHandler(ConsoleMode.ChaXun)]
    public class ChaXunConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.ChaXun:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have chaxun zone username");
                    break;
                default:
                    //chaxun 1 ""
                    string[] chaxunInfo = content.Split(" ");
                    if (chaxunInfo[0] != "chaxun")
                    {
                        return;
                    }

                    int zone = int.Parse(chaxunInfo[1]);
                    int pyzone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;
                    long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                    //查询全区金币异常
                    if (chaxunInfo.Length == 2)
                    {
                        List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
                        for (int i = 0; i < userinfoComponentList.Count; i++)
                        {
                            UserInfoComponent userInfoComponent = userinfoComponentList[i];
                            if (userInfoComponent.UserInfo.RobotId != 0)
                            {
                                continue;
                            }
                            long gold = userInfoComponent.UserInfo.Gold;
                            long diamond = userInfoComponent.UserInfo.Diamond;

                            if (gold > 1000000 || diamond > 10000)
                            {
                                long unitId = userinfoComponentList[0].Id;

                                List<BagComponent> baginfoInfoList = await Game.Scene.GetComponent<DBComponent>().Query<BagComponent>(pyzone, d => d.Id == unitId);
                                List<BagInfo> bagInfosAll = baginfoInfoList[0].GetAllItems();

                                string infolist = $"{userInfoComponent.UserInfo.Name}:  \n";
                                infolist = infolist + $"金币： {gold} \n";
                                infolist = infolist + $"钻石： {diamond} \n";

                                for (int b = 0; b < bagInfosAll.Count; b++)
                                {
                                    infolist = infolist + $"{bagInfosAll[b].ItemID};{bagInfosAll[b].ItemNum}\n";
                                }
                                LogHelper.LogWarning(infolist);
                            }
                        }
                    }

                    //查询单个玩家
                    if (chaxunInfo.Length == 3)
                    {
                        LogHelper.LogDebug($"name: {chaxunInfo[2]}");
                        List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0&&d.UserInfo.Name == chaxunInfo[2]);
                        if (userinfoComponentList.Count == 0)
                        {
                            return;
                        }
                        long unitId = userinfoComponentList[0].Id;
                        IActorResponse reqEnter = (M2G_RequestEnterGameState)await MessageHelper.CallLocationActor(unitId, new G2M_RequestEnterGameState()
                        {
                            GateSessionActorId = -1
                        });
                        if (reqEnter.Error != ErrorCode.ERR_Success)
                        {
                            LogHelper.LogDebug("玩家不在线！");
                        }
                        else
                        {
                            LogHelper.LogDebug(reqEnter.Message);
                        }
                    }
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
#endif
}
