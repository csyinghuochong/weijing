namespace ET
{

    [MessageHandler]
    public class M2C_MailUpdateHandler : AMHandler<M2C_UpdateMailInfo>
    {

        protected override void  Run(Session session, M2C_UpdateMailInfo message)
        {
            session.ZoneScene().GetComponent<ReddotComponent>().AddReddont(ReddotType.Email);
        }
    }
}
