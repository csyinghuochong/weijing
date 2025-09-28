

namespace ET
{
    public class RealName_OnRealName : AEvent<EventType.RealName>
    {
        protected override void Run(EventType.RealName args)
        {
            RunAsync(args).Coroutine();
        }

        private async ETTask RunAsync(EventType.RealName args)
        {
            await TimerComponent.Instance.WaitFrameAsync();
            RealNameCode result_check = FangChenMiHelper.OnDoFangchenmi(new
            {
                ai = args.ai,
                name = args.name,
                idNum = args.idNum,
            }, EType.Check);

            //RealNameCode result_check = await FangChenMiHelper.OnDoFangchenmi_2(args.idNum, args.name );

            args.AccountScene.GetComponent<ObjectWait>()?.Notify(new WaitType.WaitRealNameCode
            {
                Message = result_check
            });

            //RealNameCode result_check = await FangChenMiHelper.OnDoFangchenmi_2(args.idNum, args.name);

            //args.AccountScene.GetComponent<ObjectWait>()?.Notify(new WaitType.WaitRealNameCode
            //{
            //    Message = result_check
            //});
        }
    }
}
