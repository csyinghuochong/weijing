using System;


namespace ET
{

    [MessageHandler]
    public class M2C_UnionRaceInfoHandler : AMHandler<M2C_UnionRaceInfoResult>
    {

        protected override void Run(Session session, M2C_UnionRaceInfoResult message)
        {
            EventType.UnionRaceInfo.Instance.m2C_Battle = message;
            EventType.UnionRaceInfo.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.UnionRaceInfo.Instance);
        }
    }
}
