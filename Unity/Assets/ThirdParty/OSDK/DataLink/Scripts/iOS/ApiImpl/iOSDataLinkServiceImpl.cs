using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#if UNITY_IOS

namespace Douyin.Game
{
    public class iOSDataLinkServiceImpl : IDataLinkService
    {

        private static Action<EventListenerResult> _eventListenerAction;
        private delegate void EventStatusDelegate(string eventName, int code, string reportMessage);

        public bool OnGameActive()
        {
            return OSDKOnGameActive();
        }

        public bool OnAccountRegister(string gameUserID)
        {
            return OSDKOnAccountRegister(gameUserID);
        }

        public bool OnRoleRegister(string gameUserID, string gameRoleID)
        {
            return OSDKOnRoleRegister(gameUserID, gameRoleID);
        }

        public bool OnAccountLogin(string gameUserID, long lastLoginTime)
        {
            return OSDKOnAccountLogin(gameUserID, lastLoginTime);
        }

        public bool OnRoleLogin(string gameUserID, string gameRoleID, long lastRoleLoginTime)
        {
            return OSDKOnRoleLogin(gameUserID, gameRoleID, lastRoleLoginTime);
        }

        public bool OnPay(string gameUserID, string gameRoleID, string gameOrderID, long totalAmount, string productID, string productName, string productDesc)
        {
            return OSDKOnPay(gameUserID, gameRoleID, gameOrderID, totalAmount, productID, productName, productDesc);
        }

        public bool OnPaySpecial(string gameUserID, string gameRoleID, string gameOrderID, string payType, long payRangeMin, long payRangeMax, string productID, string productName, string productDesc)
        {
            return OSDKOnPaySpecial(gameUserID, gameRoleID, gameOrderID, payType, payRangeMin, payRangeMax, productID, productName, productDesc);
        }

        public bool CustomEvent(string eventName, string jsonParams)
        {
            return OSDKCustomEvent(eventName, jsonParams);
        }

        public bool UpdateCloudGameInfo(CloudGameInfo cloudGameInfo)
        {
            return true;
        }

        public void SetDataLinkEventListener(Action<EventListenerResult> eventListenerAction)
        {
            _eventListenerAction = eventListenerAction;
            OSDKSetDataLinkDelegate(OSDKSetDelegateMethod);
        }

        [AOT.MonoPInvokeCallback(typeof(EventStatusDelegate))]
        private static void OSDKSetDelegateMethod(string eventName, int code, string reportMessage)
        {
            SDKInternalUnityDispatcher.PostTask(() =>
            {
                _eventListenerAction?.Invoke(new EventListenerResult(eventName, code, reportMessage));
            });
        }

        public Action<EventListenerResult> GetDataLinkEventListener()
        {
            return _eventListenerAction;
        }
        
        [DllImport("__Internal")]
        private static extern bool OSDKSetDataLinkDelegate(EventStatusDelegate callback);
        [DllImport("__Internal")]
        private static extern bool OSDKOnGameActive(); 
        [DllImport("__Internal")]
        private static extern bool OSDKOnAccountRegister(string gameUserID); 
        [DllImport("__Internal")]
        private static extern bool OSDKOnRoleRegister(string gameUserID, string gameRoleID); 
        [DllImport("__Internal")]
        private static extern bool OSDKOnAccountLogin(string gameUserID, long lastLoginTime); 
        [DllImport("__Internal")]
        private static extern bool OSDKOnRoleLogin(string gameUserID, string gameRoleID, long lastRoleLoginTime); 
        [DllImport("__Internal")]
        private static extern bool OSDKOnPay(string gameUserID, string gameRoleID, string gameOrderID, long totalAmount, string productID, string productName, string productDesc); 
        [DllImport("__Internal")]
        private static extern bool OSDKOnPaySpecial(string gameUserID, string gameRoleID, string gameOrderID, string payType, long payRangeMin, long payRangeMax, string productID, string productName, string productDesc);
        [DllImport("__Internal")]
        private static extern bool OSDKCustomEvent(string eventName, string paramsJsonString); 
    }
}

#endif