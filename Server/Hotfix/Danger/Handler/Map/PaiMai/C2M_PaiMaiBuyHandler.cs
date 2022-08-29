using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PaiMaiBuyHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiBuyRequest, M2C_PaiMaiBuyResponse>
    {
        //拍卖行购买道具
        protected override async ETTask Run(Unit unit, C2M_PaiMaiBuyRequest request, M2C_PaiMaiBuyResponse response, Action reply)
        {
         
            //背包是否有位置
            if (unit.GetComponent<BagComponent>().GetSpaceNumber() >= 1)
            {
                //钱是否足够
                if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < request.PaiMaiItemInfo.Price)
                {
                    response.Error = ErrorCore.ERR_GoldNotEnoughError;
                }
                else
                {
                    long paimaiServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
                    P2M_PaiMaiBuyResponse r_GameStatusResponse = (P2M_PaiMaiBuyResponse)await ActorMessageSenderComponent.Instance.Call
                        (paimaiServerId, new M2P_PaiMaiBuyRequest()
                        {
                            PaiMaiItemInfo = request.PaiMaiItemInfo
                        });

                    await unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, (r_GameStatusResponse.PaiMaiItemInfo.Price * -1).ToString());

                    //背包添加道具
                    unit.GetComponent<BagComponent>().OnAddItemData(r_GameStatusResponse.PaiMaiItemInfo.BagInfo);

                    //给出售者邮件发送金币
                    MailInfo mailInfo = new MailInfo();
                    mailInfo.Status = 0;
                    mailInfo.Context = "你拍卖行出售的道具已经被其他玩家购买。";
                    mailInfo.Title = "拍卖行邮件";
                    mailInfo.MailId = IdGenerater.Instance.GenerateId();
                    BagInfo reward = new BagInfo();
                    reward.ItemID = 1;
                    int sellPrice = (int)(r_GameStatusResponse.PaiMaiItemInfo.Price * 0.95f);     //5%手续费
                    reward.ItemNum = sellPrice;
                    mailInfo.ItemList.Add(reward);

                    //发送邮件
                    //await MailHelp.SendUserMail(unit.DomainScene().DomainZone(), unit.GetComponent<UserInfoComponent>().UserInfo.UserId, mailInfo);

                    //存储邮件
                    long mailServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;      //获取邮件消息ID
                    E2M_EMailSendResponse g_EMailSendResponse = (E2M_EMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                        (mailServerId, new M2E_EMailSendRequest() { Id = request.PaiMaiItemInfo.UserId, MailInfo = mailInfo });
                }
            }
            else
            {
                response.Error = ErrorCore.ERR_BagIsFull;
            }
            reply();
        }
    }
}
