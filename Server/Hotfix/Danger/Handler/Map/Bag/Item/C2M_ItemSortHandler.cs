namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemSortHandler : AMActorLocationHandler<Unit, C2M_ItemSortRequest>
    {

        protected override async ETTask Run(Unit unit, C2M_ItemSortRequest message)
        {
            await ETTask.CompletedTask;
        }

    }
}
