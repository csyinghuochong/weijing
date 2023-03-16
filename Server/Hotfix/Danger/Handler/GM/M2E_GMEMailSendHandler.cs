using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    internal class M2E_GMEMailSendHandler : AMActorRpcHandler<Scene, M2E_GMEMailSendRequest, E2M_GMEMailSendResponse>
    {
        protected override async ETTask Run(Scene scene, M2E_GMEMailSendRequest request, E2M_GMEMailSendResponse response, Action reply)
        {
            List<DBMailInfo> dBMailInfos = null;

            if (request.UserName == "0")
            {
                dBMailInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBMailInfo>(scene.DomainZone(), d => d.Id > 0);
            }
            else
            {
                List<UserInfoComponent> accountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(scene.DomainZone(), d => d.UserInfo.Name == request.UserName);
                if (accountInfoList.Count > 0)
                {
                    dBMailInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBMailInfo>(scene.DomainZone(), d => d.Id == accountInfoList[0].Id);
                }
            }

            if (dBMailInfos != null)
            {
                long serverTime = TimeHelper.ServerNow();
                for (int i = 0; i < dBMailInfos.Count; i++)
                {
                    List<NumericComponent> numericInfoList = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(scene.DomainZone(), d => d.Id == dBMailInfos[i].Id);
                    if (numericInfoList.Count == 0)
                    {
                        continue;
                    }
                    List<UserInfoComponent> userinfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(scene.DomainZone(), d => d.Id == dBMailInfos[i].Id);
                    if (userinfoComponents.Count == 0)
                    {
                        continue;
                    }
                    if (userinfoComponents[0].UserInfo.RobotId > 0)
                    {
                        continue;
                    }

                    switch (request.MailType)
                    {
                        case 2: // 充值>=6元 10011003
                            if (numericInfoList[0].GetAsLong(NumericType.RechargeNumber) < int.Parse(request.Title))
                            {
                                continue;
                            }
                            break;
                        case 3: //20级以上 补
                            if (userinfoComponents[0].UserInfo.Lv < int.Parse(request.Title))
                            {
                                continue;
                            }
                            break;
                        default:
                            break;
                    }

                    MailInfo mailInfo = new MailInfo();
                    mailInfo.Status = 0;
                    mailInfo.Context = "福利发放";
                    mailInfo.Title = "福利发放";
                    mailInfo.MailId = IdGenerater.Instance.GenerateId();
                    string[] needList = request.Itemlist.Split('@');
                    for (int k = 0; k < needList.Length; k++)
                    {
                        string[] itemInfo = needList[k].Split(';');
                        if (itemInfo.Length < 2)
                        {
                            continue;
                        }
                        int itemId = int.Parse(itemInfo[0]);
                        int itemNum = int.Parse(itemInfo[1]);
                        mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.ReceieMail}_{serverTime}" });
                    }

                    await MailHelp.SendUserMail((int)request.ActorId, dBMailInfos[i].Id, mailInfo);
                }
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}