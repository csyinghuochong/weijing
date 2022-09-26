using System;
using System.Collections.Generic;
using System.Linq;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_EMailReceiveHandler : AMActorLocationRpcHandler<Unit, C2M_ReceiveMailRequest, M2C_ReceiveMailResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ReceiveMailRequest request, M2C_ReceiveMailResponse response, Action reply)
        {
            //领取邮件
            long mailServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
            E2M_EMailReceiveResponse g_SendChatRequest = (E2M_EMailReceiveResponse)await ActorMessageSenderComponent.Instance.Call
                (mailServerId, new M2E_EMailReceiveRequest() { Id = unit.GetComponent<UserInfoComponent>().UserInfo.UserId, MailId = request.MailId });

            MailInfo mailInfo = g_SendChatRequest.MailInfo;
            if (mailInfo != null)
            {
                unit.GetComponent<BagComponent>().OnAddItemData(mailInfo.ItemList);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
