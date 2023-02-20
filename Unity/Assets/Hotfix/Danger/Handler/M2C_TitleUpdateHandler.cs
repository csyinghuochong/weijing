
namespace ET
{

    [MessageHandler]
    public class M2C_TitleUpdateHandler : AMHandler<M2C_TitleUpdateResult>
    {
        protected override void Run(Session session, M2C_TitleUpdateResult message)
        {
            session.ZoneScene().GetComponent<TitleComponent>().TitleList = message.TitleList;   
        }
    }
}
