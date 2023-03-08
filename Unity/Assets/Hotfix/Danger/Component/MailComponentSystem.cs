using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class MailComponentAwakeSystem : AwakeSystem<MailComponent>
    {
        public override void Awake(MailComponent self)
        {

        }
    }

    public static  class MailComponentSystem
    {

        public static async ETTask<int> SendReceiveMail(this MailComponent self)
        {
            if (self.SelectMail == null)
            {
                return ErrorCore.ERR_NetWorkError;
            }

            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() < self.SelectMail.ItemList.Count)
            {
                HintHelp.GetInstance().ShowHintError(ErrorCore.ERR_BagIsFull);
                return ErrorCore.ERR_BagIsFull;
            }
            C2M_ReceiveMailRequest c2E_ReceiveMailRequest = new C2M_ReceiveMailRequest() { MailId = self.SelectMail.MailId };
            M2C_ReceiveMailResponse sendChatResponse = (M2C_ReceiveMailResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_ReceiveMailRequest);
            if (sendChatResponse.Error != 0)
            {
                return sendChatResponse.Error;
            }

            for (int i = self.MailInfoList.Count - 1; i >= 0; i--)
            {
                if (self.MailInfoList[i].MailId == self.SelectMail.MailId)
                {
                    self.MailInfoList.RemoveAt(i);
                }
            }

            HintHelp.GetInstance().DataUpdate(DataType.OnMailUpdate);
            return ErrorCore.ERR_Success;
        }

        public static async ETTask SendGetMailList(this MailComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            C2E_GetAllMailRequest c2E_GetAllMailRequest = new C2E_GetAllMailRequest() {  ActorId = userInfo.UserId };
            E2C_GetAllMailResponse sendChatResponse = (E2C_GetAllMailResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);
            self.MailInfoList = sendChatResponse.MailInfos;

            int error = sendChatResponse.Error;
            if (error != 0)
            {
                return;
            }

            HintHelp.GetInstance().DataUpdate(DataType.OnMailUpdate);
        }

        public static void SendGetMailReward(this MailComponent self)
        {
            HintHelp.GetInstance().DataUpdate(DataType.OnMailUpdate);
        }

        public static void OnRecvMailUpdate(this MailComponent self, M2C_UpdateMailInfo message)
        {
            
        }

    }

}
