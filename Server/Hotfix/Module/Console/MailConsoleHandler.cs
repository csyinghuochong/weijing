using System.Collections.Generic;
using System.Linq;


namespace ET
{

    [ConsoleHandler(ConsoleMode.Mail)]
    public class MailConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.Mail:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have mail zone userid items title");
                    break;
                default:
                    //mail 区服(0所有区服  1指定区服)  玩家ID(0所有玩家)  道具 邮件标题
                    //mail  1 0 1; 10000  "清档补偿"
                    string[] mailInfo = content.Split(" ");
                    if (mailInfo[0]!= "mail" && mailInfo.Length < 5)
                    {
                        return;
                    }

                    List<int> zoneList = new List<int> {  };
                    if (mailInfo[1] == "0")
                    {
                        List<StartZoneConfig> listprogress = StartZoneConfigCategory.Instance.GetAll().Values.ToList();
                        for (int i = 0; i < listprogress.Count; i++)
                        {
                            if (listprogress[i].Id >= ComHelp.MaxZone)
                            {
                                continue;
                            }
                            zoneList.Add(listprogress[i].Id);
                        }
                    }
                    else
                    {
                        zoneList.Add(int.Parse(mailInfo[1]));
                    }

                    string titie = "邮件";
                    if (mailInfo[4] == "1")
                    {
                        titie = "清档补偿！";
                    }

                    for (int i = 0; i < zoneList.Count; i++)
                    {
                        long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "EMail").InstanceId;
                        E2M_GMEMailSendResponse g2M_UpdateUnitResponse = (E2M_GMEMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                            (gateServerId, new M2E_GMEMailSendRequest()
                            { 
                                UserId = long.Parse(mailInfo[2]),
                                Itemlist = mailInfo[3],
                                Title = titie,    
                                Zone = zoneList[i],
                            });
                    }

                    Log.Info("邮件发送完成！");
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}
