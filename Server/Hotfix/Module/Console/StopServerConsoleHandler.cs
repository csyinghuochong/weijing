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
                    if (ss.Length < 4)
                    {
                        Log.Console($"C must zone");
                        return;
                    }
                    //stopserver 0[区] 0[开] 0[验]
     
                    List<int> zoneList = new List<int> { };
                    if (ss[1] == "0")
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
                        zoneList.Add(int.Parse(ss[1]));
                    }

                    if (ss[2] == "0")
                    {
                        //全部广播停服维护
                        for (int i = 0; i < zoneList.Count; i++)
                        {
                            long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Chat").InstanceId;
                            A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                                (chatServerId, new A2A_ServerMessageRequest()
                                {
                                    MessageType = NoticeType.StopSever,
                                    MessageValue = "停服维护"
                                });
                        }
                    }
                    
                    long accountServerId = StartSceneConfigCategory.Instance.AccountCenterConfig.InstanceId;
                    A2A_ServerMessageRResponse response = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                        (accountServerId, new A2A_ServerMessageRequest()
                        {
                            MessageType = NoticeType.StopSever,
                            MessageValue = $"{ss[2]}_{ss[3]}"
                        });
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}
