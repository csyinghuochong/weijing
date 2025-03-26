using System.Net;
using UnityEngine;
using System.Text;

namespace ET
{
    public class Apple_OnAppleSignIn : AEventClass<EventType.AppleSignIn>
    {
        protected override void Run(object numerice)
        {
            EventType.AppleSignIn args = numerice as EventType.AppleSignIn;
            Init init = GameObject.Find("Global").GetComponent<Init>();
            init.AppleSignInHandler = args.AppleSignInHandler;

            Log.ILog.Debug($"apple SignInWithApple");

            if (GlobalHelp.IsEditorMode)
            {
                args.AppleSignInHandler("apple_112121212212212");
            }
            else
            {
                init.SignInWithApple(args.Account);
            }
        }
    }
}