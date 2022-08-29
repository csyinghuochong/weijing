using System.Collections.Generic;

namespace ET
{
    public class MailComponent : Entity,IAwake, ITransfer
    {
        public List<MailInfo> MailInfoList = new List<MailInfo>();

#if !SERVER
        public MailInfo SelectMail;
#endif
    }
}
