using System;

namespace ET
{

    [ActorMessageHandler]
    public class Mail2M_SendServerMailHandler : AMActorLocationHandler<Unit, Mail2M_SendServerMailItem>
    {

        protected override async ETTask Run(Unit unit, Mail2M_SendServerMailItem message)
        {
            Log.Console($"asdsadada : 全服邮件{message.ServerMailItem.ServerMailIId}");
            if (message.ServerMailItem.ServerMailIId > unit.GetComponent<UserInfoComponent>().UserInfo.ServerMailIdCur)
            {
                unit.GetComponent<UserInfoComponent>().UserInfo.ServerMailIdCur = message.ServerMailItem.ServerMailIId;
            }
            await ETTask.CompletedTask;
        }
    }
}
