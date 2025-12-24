using UnityEngine;

namespace ET
{
    public class Login_NetworkChangeDetector : AEventClass<EventType.NetworkChangeDetector>
    {
        protected override void Run(object numerice)
        {
            EventType.NetworkChangeDetector args = numerice as EventType.NetworkChangeDetector;
            NetworkChangeDetector networkChangeDetector = GameObject.Find("Global").GetComponent<NetworkChangeDetector>();
            networkChangeDetector.OnNetworkChanged_2 = () =>
            {
                Log.ILog.Debug($"Login_NetworkChangeDetector");
            };
        }
    }
}