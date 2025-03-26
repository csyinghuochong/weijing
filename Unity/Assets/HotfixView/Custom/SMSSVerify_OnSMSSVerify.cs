
namespace ET
{
    public class SMSSVerify_OnSMSSVerify : AEventClass<EventType.SMSSVerify>
    {
        protected override void Run(object numerice)
        {
            EventType.SMSSVerify args = numerice as EventType.SMSSVerify;

           (int, string) vss =  SMSSVerifyHelper.ConnectSSL(args.Phone, args.Code);
            if (vss.Item1 == 200)
            {
                args.Action(args.Phone);
            }
            else
            {
                args.Action(string.Empty);
            }
        }
    }
}
