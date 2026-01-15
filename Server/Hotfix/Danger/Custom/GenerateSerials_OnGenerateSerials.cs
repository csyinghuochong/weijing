namespace ET
{
    public class GenerateSerials_OnGenerateSerials : AEvent<EventType.GenerateSerials>
    {
        protected override void Run(EventType.GenerateSerials args)
        {

            //20240715  生成8/9/10/11批
            Log.Warning($"生成序列号: ");

            //args.AccountCenterScene.GetComponent<AccountCenterComponent>().CheckSerials();
            args.AccountCenterScene.GetComponent<AccountCenterComponent>().GenerateSerials(11);
        }
    }
}
