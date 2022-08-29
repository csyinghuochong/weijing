
using System;

namespace ET
{

    public static class MailComponentSystem
    {

        //领取邮件
        public static async ETTask OnReceiveMail(this MailComponent self, long mailID)
        {
            Unit unit = self.GetParent<Unit>();

            //领取邮件
            long mailServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
            E2M_EMailReceiveResponse g_SendChatRequest = (E2M_EMailReceiveResponse)await ActorMessageSenderComponent.Instance.Call
                (mailServerId, new M2E_EMailReceiveRequest() { Id = unit.GetComponent<UserInfoComponent>().UserInfo.UserId, MailId = mailID });

            MailInfo mailInfo = g_SendChatRequest.MailInfo;
            if (mailInfo != null)
            {
                unit.GetComponent<BagComponent>().OnAddItemData(mailInfo.ItemList);
            }

        }
    }
}
