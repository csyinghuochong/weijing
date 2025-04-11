using System.Net;

namespace ET
{

    [Event]
    public class Relink_OnBeginRelink : AEventClass<EventType.BeginRelink>
    {

        protected override void Run(object cls)
        {
            EventType.BeginRelink args = (EventType.BeginRelink)cls;
            if (UIHelper.GetUI(args.ZoneScene, UIType.UILoading) != null)
            {
                UIHelper.Remove(args.ZoneScene, UIType.UILoading);
                EventType.ReturnLogin.Instance.ZoneScene = args.ZoneScene;
                Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
                return;
            }

            PlayerPrefsHelp.RecordRelinkMessage($"Session断开准备重连.SesszionError.{GetLocalIp()} {args.ErrorCode}！！");
            args.ZoneScene.GetComponent<RelinkComponent>().CheckRelink().Coroutine();
        }

        static string GetLocalIp()
        {
            string addressIP = string.Empty;
            foreach (IPAddress ipAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    addressIP = ipAddress.ToString();
                    break;
                }
            }
            return addressIP;
        }
    }
}
