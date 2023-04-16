namespace ET
{
    [ActorMessageHandler]
    public class P2M_PaiMaiAuctionOverHandler : AMActorLocationHandler<Unit, P2M_PaiMaiAuctionOverRequest>
    {
        protected override async ETTask Run(Unit unit, P2M_PaiMaiAuctionOverRequest request)
        {
            if (unit.GetComponent<BagComponent>().OnCostItemData($"{request.Price}_1"))
            {
                unit.GetComponent<BagComponent>().OnAddItemData($"{request.ItemID};1", $"{ItemGetWay.PaiMaiBuy}_{TimeHelper.ServerNow()}");
            }
            await ETTask.CompletedTask;
        }
    }
}
