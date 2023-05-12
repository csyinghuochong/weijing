using UnityEngine;

namespace ET
{
    [Event]
    public class Union_OnUnionRaceInfo : AEventClass<EventType.UnionRaceInfo>
    {
        protected override void Run(object cls)
        {
            EventType.UnionRaceInfo args = cls as EventType.UnionRaceInfo;

            PopupTipHelp.OpenPopupTip_2( args.ZoneScene, "争霸赛结束", "争霸赛已结束,请及时退出结算奖励!", () =>
            {
                EnterFubenHelp.RequestQuitFuben(args.ZoneScene);
            } ).Coroutine();
        }
    }
}
