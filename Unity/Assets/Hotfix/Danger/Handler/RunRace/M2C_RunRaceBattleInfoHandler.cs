using System;


namespace ET
{

    [MessageHandler]
    public class M2C_RunRaceBattleInfoHandler : AMHandler<M2C_RunRaceBattleInfo>
    {
        protected override void Run(Session session, M2C_RunRaceBattleInfo message)
        {
            session.ZoneScene().GetComponent<BattleMessageComponent>().M2C_RunRaceBattleInfo = message;
            EventType.RunRaceBattleInfo.Instance.M2C_RunRaceBattleInfo = message;
            EventType.RunRaceBattleInfo.Instance.ZonScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.RunRaceBattleInfo.Instance);
        }
    }
}
