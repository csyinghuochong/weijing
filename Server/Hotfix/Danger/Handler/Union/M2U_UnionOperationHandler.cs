using System;


namespace ET
{

    [ActorMessageHandler]
    public class M2U_UnionOperationHandler : AMActorRpcHandler<Scene, M2U_UnionOperationRequest, U2M_UnionOperationResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionOperationRequest request, U2M_UnionOperationResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.UnionOperate, request.UnionId))
            {
                DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
                if (dBUnionInfo == null)
                {
                    reply();
                    return;
                }

                switch (request.OperateType)
                {
                    case 1:
                        if (dBUnionInfo.UnionInfo.Level == 0)
                        {
                            dBUnionInfo.UnionInfo.Level = 1;
                        }
                        int level = dBUnionInfo.UnionInfo.Level;
                        dBUnionInfo.UnionInfo.Exp += int.Parse(request.Par);
                        UnionConfig unionConfig = UnionConfigCategory.Instance.Get(level);
                        if (dBUnionInfo.UnionInfo.Exp >= unionConfig.Exp && UnionConfigCategory.Instance.Contain(level + 1))
                        {
                            dBUnionInfo.UnionInfo.Level++;
                            dBUnionInfo.UnionInfo.Exp -= unionConfig.Exp;

                            MailInfo mailInfo = new MailInfo();
                            mailInfo.Title = "家族升级";
                            mailInfo.Context = "恭喜您!您所在得家族等级获得提升,这是家族升级的奖励!";

                            long serverTime = TimeHelper.ServerNow();
                            UnionConfig unionCof = UnionConfigCategory.Instance.Get(dBUnionInfo.UnionInfo.Level);
                            string[] rewardStrList = unionCof.UpAllReward.Split(';');
                            for (int i = 0; i < rewardStrList.Length; i++) {
                                string[] rewardList = rewardStrList[i].Split(',');
                                mailInfo.ItemList.Add(new BagInfo() { ItemID = int.Parse(rewardList[0]), ItemNum = int.Parse(rewardList[1]), GetWay = $"{ItemGetWay.UnionUpLv}_{serverTime}" });
                            }

                            for (int i = 0; i < dBUnionInfo.UnionInfo.UnionPlayerList.Count; i++)
                            {
                                MailHelp.SendUserMail(scene.DomainZone(), dBUnionInfo.UnionInfo.UnionPlayerList[i].UserID, mailInfo).Coroutine();
                            }

                            string noticeContent = $"恭喜 <color=#{ComHelp.QualityReturnColor(5)}>{dBUnionInfo.UnionInfo.UnionName}</color> 家族等级提升至{dBUnionInfo.UnionInfo.Level}级";
                            ServerMessageHelper.SendBroadMessage(scene.DomainZone(), NoticeType.Notice, noticeContent);

                        }
                        DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
                        break;
                    case 2:
                        response.Par = dBUnionInfo.UnionInfo.Level.ToString();
                        break;
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
