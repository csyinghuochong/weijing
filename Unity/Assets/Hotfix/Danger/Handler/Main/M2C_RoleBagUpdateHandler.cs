
namespace ET
{
    [MessageHandler]
    public class M2C_RoleBagUpdateHandler : AMHandler<M2C_RoleBagUpdate>
    {
        protected override  void Run(Session session, M2C_RoleBagUpdate message)
        {
            //宠物之核背包提示
            for (int i = 0; i < message.BagInfoAdd.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(message.BagInfoAdd[i].ItemID);
                if (itemConfig.ItemType == ItemTypeEnum.PetHeXin)
                {
                    session.ZoneScene().GetComponent<ReddotComponent>().AddReddont(ReddotType.PetHeXinAdd);
                    break;
                }
            }

            session.ZoneScene().GetComponent<BagComponent>().OnRecvBagUpdate(message);
        }
    }
}
