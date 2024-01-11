
namespace ET
{
    [MessageHandler]
    public class M2C_BagUpdateHandler : AMHandler<M2C_RoleBagUpdate>
    {
        protected override  void Run(Session session, M2C_RoleBagUpdate message)
        {
            session.ZoneScene().GetComponent<BagComponent>().OnRecvBagUpdate(message);
        }
    }
}
