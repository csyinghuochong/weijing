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
                    
                    if (chaxunInfo[0] != "chaxun" && chaxunInfo.Length != 2)
                    {
                        Log.Console($"C must have chaxun zone username");
                        return;
                    }

                    int zone = int.Parse(chaxunInfo[1]);
                    int pyzone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;

                    long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                    List<UserInfoComponent> userinfoInfoList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);

                    for (int i = 0; i < userinfoInfoList.Count; i++)
                    { 
                        UserInfoComponent userInfoComponent = userinfoInfoList[i];
                        if (userInfoComponent.UserInfo.RobotId != 0)
                        {
                            continue;
                        }
                        long gold = userInfoComponent.UserInfo.Gold;
                        long diamond = userInfoComponent.UserInfo.Diamond;

                        if (gold > 10000 || diamond > 10000)
                        {
                            long unitId = userinfoInfoList[0].Id;

                            List<BagComponent> baginfoInfoList = await Game.Scene.GetComponent<DBComponent>().Query<BagComponent>(pyzone, d => d.Id == unitId);
                            List<BagInfo> bagInfosAll = baginfoInfoList[0].GetAllItems();

                            string infolist = $"{userInfoComponent.UserInfo.Name}:  \n";
                            infolist = infolist + $"金币： {gold} \n";
                            infolist = infolist + $"钻石： {diamond} \n";

                            for (int b = 0; b < bagInfosAll.Count; b++)
                            {
                                infolist = infolist + $"{bagInfosAll[b].ItemID};{bagInfosAll[b].ItemNum}\n";
                            }
                            Log.Warning(infolist);
                        }
                    }

                    break;
            }

            await ETTask.CompletedTask;
        }
    }
#endif
}
