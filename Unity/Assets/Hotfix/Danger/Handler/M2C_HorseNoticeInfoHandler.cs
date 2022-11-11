namespace ET
{

    [MessageHandler]
    public class M2C_HorseNoticeInfoHandler : AMHandler<M2C_HorseNoticeInfo>
    {
        protected override void  Run(Session session, M2C_HorseNoticeInfo message)
        {

            session.ZoneScene().GetComponent<ChatComponent>().HorseNoticeInfo = message;
            EventType.DataUpdate.Instance.DataType = DataType.HorseNotice;
            EventSystem.Instance.PublishClass(EventType.DataUpdate.Instance);

#if !SERVER && NOT_UNITY
            if (message.NoticeType == NoticeType.StopSever)
            {
                Log.Debug("停服维护");
                session.ZoneScene().Dispose();  
                return;
            }
#endif
        }
    }

}
