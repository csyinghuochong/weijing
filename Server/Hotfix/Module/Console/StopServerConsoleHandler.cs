using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ConsoleHandler(ConsoleMode.StopServer)]
    public class StopServerConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.StopServer:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must zone");
                    break;
                default:
                    string[] ss = content.Split(" ");
                    string zoneid = ss[1];
    
                    List<int> zoneList = new List<int> { };
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
                            zoneList.Add(listprogress[i].Id);
                        }
                    }
                    else
                    {
                        zoneList.Add(int.Parse(zoneid));
                    }
                    
                    for (int i = 0; i < zoneList.Count; i++)
                    {
                        long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Chat").InstanceId;
                        A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                            (chatServerId, new A2A_ServerMessageRequest()
                            {
                                MessageType = NoticeType.StopSever,
                                MessageValue = "停服维护"
                            }) ;
                        long accountServerId = StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Account").InstanceId;
                        g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                            (accountServerId, new A2A_ServerMessageRequest()
                            {
                                MessageType = NoticeType.StopSever,
                            });
                    }
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}
