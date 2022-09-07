using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_FirstWinInfoHandler : AMActorHandler<Scene, M2A_FirstWinInfoMessage>
    {
        protected override async ETTask Run(Scene scene, M2A_FirstWinInfoMessage message)
        {
            DBDayActivityInfo dBFirstWinInfo = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo;
            for (int i= 0; i < dBFirstWinInfo.FirstWinInfos.Count; i++)
            {
                FirstWinInfo firstWinInfo = dBFirstWinInfo.FirstWinInfos[i];
                if (firstWinInfo.FirstWinId == message.FirstWinInfo.FirstWinId
                 && firstWinInfo.Difficulty == message.FirstWinInfo.Difficulty)
                {
                    return;
                }
            }

            MailInfo mailInfo = new MailInfo();
            mailInfo.Status = 0;
            mailInfo.Context = $"首杀奖励";
            mailInfo.Title = "首杀奖励";
            mailInfo.MailId = IdGenerater.Instance.GenerateId();
            FirstWinConfig firstWinConfig = FirstWinConfigCategory.Instance.Get(message.FirstWinInfo.FirstWinId);
            string rewardList = firstWinConfig.RewardList_1;
            if (message.FirstWinInfo.Difficulty == 2)
            {
                rewardList = firstWinConfig.RewardList_2;
            }
            if (message.FirstWinInfo.Difficulty == 3)
            {
                rewardList = firstWinConfig.RewardList_3;
            }
            string[] needList = rewardList.Split('@');

            long serverTime = TimeHelper.ServerNow();
            for (int k = 0; k < needList.Length; k++)
            {
                string[] itemInfo = needList[k].Split(';');
                if (itemInfo.Length < 2)
                {
                    continue;
                }
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.FirstWin}_{serverTime}" });
            }

            dBFirstWinInfo.FirstWinInfos.Add(message.FirstWinInfo);
            long mailServerId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
            E2M_EMailSendResponse g_EMailSendResponse = (E2M_EMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                     (mailServerId, new M2E_EMailSendRequest()
                     {
                         Id = message.FirstWinInfo.UserId,
                         MailInfo = mailInfo
                     });

            await ETTask.CompletedTask;
        }
    }
}
