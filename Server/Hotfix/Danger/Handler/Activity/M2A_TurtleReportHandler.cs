using MongoDB.Driver.Core.Servers;
using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_TurtleReportHandler : AMActorRpcHandler<Scene, M2A_TurtleReportRequest, A2M_TurtleReportResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_TurtleReportRequest request, A2M_TurtleReportResponse response, Action reply)
        {
            DBDayActivityInfo dBDayActivityInfo = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo;
            if (dBDayActivityInfo.TurtleWinTimes.Count < 3)
            {
                dBDayActivityInfo.TurtleWinTimes = new List<int> { 0,0,0 };
            }
            
            int index = ConfigHelper.TurtleList.IndexOf( request.TurtleId );
            if (index != -1)
            {
                dBDayActivityInfo.TurtleWinTimes[index]++;
            }

            //发竞猜邮件
            List<long> playerids = null;
            scene.GetComponent<ActivitySceneComponent>().TurtleSupportList.TryGetValue(request.TurtleId, out playerids);
            if (playerids != null)
            {
                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Context = "小龟竞猜奖励";
                mailInfo.Title = "小龟竞猜奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();

                string[] needList = GlobalValueConfigCategory.Instance.Get(57).Value.Split('@');
                for (int k = 0; k < needList.Length; k++)
                {
                    string[] itemInfo = needList[k].Split(';');
                    if (itemInfo.Length < 2)
                    {
                        continue;
                    }
                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.Turtle}_{TimeHelper.ServerNow()}" });
                }

                for (int i = 0; i < playerids.Count; i++)
                {
                    MailHelp.SendUserMail(scene.DomainZone(), playerids[i], mailInfo).Coroutine();
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
