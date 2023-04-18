namespace ET
{
    [ActorMessageHandler]
    public class P2M_PaiMaiAuctionOverHandler : AMActorLocationHandler<Unit, P2M_PaiMaiAuctionOverRequest>
    {
        protected override async ETTask Run(Unit unit, P2M_PaiMaiAuctionOverRequest request)
        {
            Log.Debug($"PaiMaiAuctionOver:  {unit.DomainZone()} {unit.Id}");
            if (unit.GetComponent<BagComponent>().OnCostItemData($"{request.Price}_1"))
            {
                unit.GetComponent<BagComponent>().OnAddItemData($"{request.ItemID};{request.ItemNumber}", $"{ItemGetWay.PaiMaiBuy}_{TimeHelper.ServerNow()}");
            }
            else
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Message, "金币不足，竞拍失败！") ;
            }
            await ETTask.CompletedTask;
        }
    }
}
