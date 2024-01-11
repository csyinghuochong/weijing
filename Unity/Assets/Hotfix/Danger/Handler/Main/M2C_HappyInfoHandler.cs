using System;


namespace ET
{

    [MessageHandler]
    public class M2C_HappyInfoHandler : AMHandler<M2C_HappyInfoResult>
    {
        protected override void Run(Session session, M2C_HappyInfoResult message)
        {
            session.ZoneScene().GetComponent<BattleMessageComponent>().M2C_HappyInfoResult = message;
            EventType.HappyInfo.Instance.m2C_Battle = message;
            EventType.HappyInfo.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.HappyInfo.Instance);
        }
    }
}
