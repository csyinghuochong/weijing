using UnityEngine;

namespace ET
{
    [Event]
    public class Session_OnSessionCreate : AEventClass<EventType.SessionCreate>
    {

        protected override void Run(object cls)
        {
            EventType.SessionCreate args = cls as EventType.SessionCreate;
            PlayerPrefsHelp.RecordRelinkMessage($"SessionCreate : {args.SessionId}   {args.RemoteAddress}£¡£¡");
        }
    }

    [Event]
    public class Session_OnSessionDispose : AEventClass<EventType.SessionDispose>
    {

        protected override void Run(object cls)
        {
            EventType.SessionDispose args = cls as EventType.SessionDispose;
            PlayerPrefsHelp.RecordRelinkMessage($"SessionDispose : {args.SessionId}   {args.RemoteAddress}£¡£¡");
        }
    }

    [Event]
    public class Session_LoginException : AEventClass<EventType.LoginException>
    {

        protected override void Run(object cls)
        {
            EventType.LoginException args = cls as EventType.LoginException;
            PlayerPrefsHelp.RecordRelinkMessage($"LoginException :    {args.Exception}£¡£¡");
        }
    }
}

