namespace ET
{
    [MessageHandler]
    public class M2C_UnionApplyHandler : AMHandler<M2C_UnionApplyResult>
    {

        protected override void  Run(Session session, M2C_UnionApplyResult message)
        {
            session.ZoneScene().GetComponent<ReddotComponent>().AddReddont( ReddotType.UnionApply );
        }
    }
}
