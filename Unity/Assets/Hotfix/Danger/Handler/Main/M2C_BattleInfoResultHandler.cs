using System;


namespace ET
{

    [MessageHandler]
    public class M2C_BattleInfoResultHandler : AMHandler<M2C_BattleInfoResult>
    {
        protected override void Run(Session session, M2C_BattleInfoResult message)
        {
            EventType.BattleInfo.Instance.m2C_Battle = message;
            EventType.BattleInfo.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.BattleInfo.Instance);
        }
    }
}