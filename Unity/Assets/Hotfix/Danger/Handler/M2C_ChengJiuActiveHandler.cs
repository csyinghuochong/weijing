namespace ET
{

    [MessageHandler]
    public class M2C_ChengJiuActiveHandler : AMHandler<M2C_ChengJiuActiveMessage>
    {
        protected override void Run(Session session, M2C_ChengJiuActiveMessage message)
        {
            HintHelp.GetInstance().ShowHint($"激活新的成就  {ChengJiuConfigCategory.Instance.Get(message.ChengJiuId).Name}！");
        }
    }
}
