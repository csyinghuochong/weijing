using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ConsoleHandler(ConsoleMode.OnLineNumer)]
    public class OnLineConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.OnLineNumer:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have zone id");
                    break;
                default:
                    string[] ss = content.Split(" ");
                    string zoneid = ss[1];

                    int number = 0;
                    int robot = 0;
                    if (zoneid == "0")
                    {
                        List<StartZoneConfig> listprogress = StartZoneConfigCategory.Instance.GetAll().Values.ToList();
                        for (int i = 0; i < listprogress.Count; i++)
                        {
                            if (listprogress[i].Id >= ComHelp.MaxZone)
                            {
                                continue;
                            }
                            if (!StartSceneConfigCategory.Instance.Gates.ContainsKey(listprogress[i].Id))
                            {
                                continue;
                            }

                            long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(listprogress[i].Id, "Gate1").InstanceId;
                            G2G_UnitListResponse g2M_UpdateUnitResponse = (G2G_UnitListResponse)await ActorMessageSenderComponent.Instance.Call
                                (gateServerId, new G2G_UnitListRequest() { });
                            number += g2M_UpdateUnitResponse.OnLinePlayer;
                            robot += g2M_UpdateUnitResponse.OnLineRobot;
                        }
                    }
                    else
                    {
                        long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(int.Parse(zoneid), "Gate1").InstanceId;
                        G2G_UnitListResponse g2M_UpdateUnitResponse = (G2G_UnitListResponse)await ActorMessageSenderComponent.Instance.Call
                            (gateServerId, new G2G_UnitListRequest() { });
                        number = g2M_UpdateUnitResponse.OnLinePlayer;
                        robot = g2M_UpdateUnitResponse.OnLineRobot;
                    }
                    string zonestr = zoneid == "0" ? "全部" : zoneid;
                    Log.Console($"{zonestr}区 在线人数: {number}  {robot}");
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}
