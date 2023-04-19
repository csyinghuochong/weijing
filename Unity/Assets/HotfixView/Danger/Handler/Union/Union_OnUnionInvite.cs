using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Union_OnUnionInvite : AEventClass<EventType.UnionInvite>
    {
        protected override void Run(object numerice)
        {
            EventType.UnionInvite args = numerice as EventType.UnionInvite;
            M2C_UnionInviteMessage message = args.M2C_UnionInviteMessage;
            PopupTipHelp.OpenPopupTip(args.ZoneScene, "家族邀请", $"玩家{message.PlayerName}邀请你加入{message.UnionName},是否接受?", () =>
              {
                  if (args.ZoneScene.IsDisposed )
                  {
                      return;
                  }
                  C2M_UnionInviteReplyRequest request = new C2M_UnionInviteReplyRequest() { UnionId = message.UnionId, ReplyCode = 1 };
                  args.ZoneScene.GetComponent<SessionComponent>().Session.Send(request);
              }, null).Coroutine();
        }
    }
}
