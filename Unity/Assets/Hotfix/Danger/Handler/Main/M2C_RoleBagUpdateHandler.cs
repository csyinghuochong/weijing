
namespace ET
{
    [MessageHandler]
    public class M2C_RoleBagUpdateHandler : AMHandler<M2C_RoleBagUpdate>
    {
        protected override  void Run(Session session, M2C_RoleBagUpdate message)
        {
            //宠物之核背包提示


            session.ZoneScene().GetComponent<BagComponent>().OnRecvBagUpdate(message);
        }
    }
}
