using System;
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
                    //mail 区服(0所有区服  1指定区服)  玩家ID(0所有玩家)  道具 邮件类型 参数 管理员
                    //mail 0 0 1;1 2 “6” tt
                    string[] mailInfo = content.Split(" ");
                    if (mailInfo[0]!= "mail" && mailInfo.Length < 6)
                    {
                        Log.Console("邮件发送失败！");
                        return;
                    }
                    try
                    {
                        int mailtype = int.Parse(mailInfo[4]);
                    }
                    catch(Exception ex)
                    {
                        Log.Console("邮件发送失败！" + ex.ToString());
                        return;
                    }

#if SERVER
                    //全服邮件
                    if (mailInfo[1] == "0")
                    {
                        if (mailInfo.Length < 7 && mailInfo[6] != DllHelper.Admin)
                        {
                            Log.Console("发送全服邮件0！");
                            return;
                        }
                        Log.Console("发送全服邮件1！");
                    }
#endif
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
                            if (!StartSceneConfigCategory.Instance.Gates.ContainsKey(listprogress[i].Id))
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

                    for (int i = 0; i < zoneList.Count; i++)
                    {
                        try
                        {
                            int pyzone = StartZoneConfigCategory.Instance.Get(zoneList[i]).PhysicZone;
                            long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(pyzone, "EMail").InstanceId;
                            E2M_GMEMailSendResponse g2M_UpdateUnitResponse = (E2M_GMEMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                                (gateServerId, new M2E_GMEMailSendRequest()
                                {
                                    UserName = mailInfo[2],
                                    Itemlist = mailInfo[3],
                                    Title = mailInfo[5],
                                    ActorId = zoneList[i],
                                    MailType = int.Parse(mailInfo[4]),
                                    Param = int.Parse(mailInfo[5]),
                                });
                            if (g2M_UpdateUnitResponse.Error == ErrorCode.ERR_Success)
                            {
                                Log.Console($"邮件发送成功！：{pyzone}区");
                            }
                            else
                            {
                                Log.Console($"邮件发送失败！：{pyzone}区：" + g2M_UpdateUnitResponse.Message);
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Console("邮件发送异常！： " + ex.ToString());
                        }
                    }
                    break;
            }
            
            await ETTask.CompletedTask;
        }
    }
}
