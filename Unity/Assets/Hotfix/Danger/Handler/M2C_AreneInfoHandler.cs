using System;


namespace ET
{

    [MessageHandler]
    public class M2C_AreneInfoHandler : AMHandler<M2C_AreneInfoResult>
    {
        protected override void Run(Session session, M2C_AreneInfoResult message)
        {
            session.ZoneScene().GetComponent<BattleMessageComponent>().M2C_AreneInfoResult= message;
            EventType.AreneInfo.Instance.m2C_Battle = message;
            EventType.AreneInfo.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.AreneInfo.Instance);
        }
    }
}
