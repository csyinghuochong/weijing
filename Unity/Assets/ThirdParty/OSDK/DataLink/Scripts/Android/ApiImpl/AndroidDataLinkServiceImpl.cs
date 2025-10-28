using System;
using UnityEngine;

#if UNITY_ANDROID

namespace Douyin.Game
{
    public class AndroidDataLinkServiceImpl : IDataLinkService
    {
        private const string DataLinkClassName = "com.bytedance.ttgame.tob.optional.datalink.api.IDataLinkService";

        private const string Interface_DataLinkEventListener_Delegate =
            "com.bytedance.ttgame.tob.optional.datalink.api.IDataLinkEventListener";

        private Action<EventListenerResult> _eventListenerAction;

        private bool CallDataLinkMethod(string methodName, params AndroidJavaObject[] args)
        {
            var boolReturn = AndroidUnityBridge.CallServiceMethod(DataLinkClassName, methodName, args);
            return AndroidUnityBridge.GetReturn<bool>(boolReturn);
        }

        private AndroidJavaObject StrToAndroidJavaObject(string str)
        {
            return new AndroidJavaObject("java.lang.String", str);
        }
        
        private AndroidJavaObject LongToAndroidJavaObject(long l)
        {
            return new AndroidJavaObject("java.lang.Long", l);
        }
        
        public bool OnGameActive()
        {
            return CallDataLinkMethod("onGameActive", null);
        }

        public bool OnAccountRegister(string gameUserID)
        {
            return CallDataLinkMethod("onAccountRegister", StrToAndroidJavaObject(gameUserID));
        }

        public bool OnRoleRegister(string gameUserID, string gameRoleID)
        {
            return CallDataLinkMethod("onRoleRegister", StrToAndroidJavaObject(gameUserID),
                StrToAndroidJavaObject(gameRoleID));
        }

        public bool OnAccountLogin(string gameUserID, long lastLoginTime)
        {
            return CallDataLinkMethod("onAccountLogin", StrToAndroidJavaObject(gameUserID),
                LongToAndroidJavaObject(lastLoginTime));
        }

        public bool OnRoleLogin(string gameUserID, string gameRoleID, long lastRoleLoginTime)
        {
            return CallDataLinkMethod("onRoleLogin",  StrToAndroidJavaObject(gameUserID), StrToAndroidJavaObject(gameRoleID),
                LongToAndroidJavaObject(lastRoleLoginTime));
        }

        public bool OnPay(string gameUserID, string gameRoleID, string gameOrderID, long totalAmount, string productID, string productName, string productDesc)
        {
            return CallDataLinkMethod("onPay", StrToAndroidJavaObject(gameUserID), StrToAndroidJavaObject(gameRoleID),
                StrToAndroidJavaObject(gameOrderID), LongToAndroidJavaObject(totalAmount),
                StrToAndroidJavaObject(productID), StrToAndroidJavaObject(productName),
                StrToAndroidJavaObject(productDesc));
        }

        public bool OnPaySpecial(string gameUserID, string gameRoleID, string gameOrderID, string payType, long payRangeMin, long payRangeMax, string productID, string productName, string productDesc)
        {
            return CallDataLinkMethod("onPaySpecial", StrToAndroidJavaObject(gameUserID),
                StrToAndroidJavaObject(gameRoleID), StrToAndroidJavaObject(gameOrderID),
                StrToAndroidJavaObject(payType), LongToAndroidJavaObject(payRangeMin),
                LongToAndroidJavaObject(payRangeMax), StrToAndroidJavaObject(productID),
                StrToAndroidJavaObject(productName), StrToAndroidJavaObject(productDesc));
        }

        public bool CustomEvent(string eventName, string jsonParams)
        {
            return CallDataLinkMethod("customEvent", StrToAndroidJavaObject(eventName), StrToAndroidJavaObject(jsonParams));
        }

        public bool UpdateCloudGameInfo(CloudGameInfo cloudGameInfo)
        {
            return CallDataLinkMethod("updateCloudGameInfo", CSharpCloudGameInfoToJavaObject(cloudGameInfo));
        }

        public void SetDataLinkEventListener(Action<EventListenerResult> eventListenerAction)
        {
            _eventListenerAction = eventListenerAction;
            var eventDelegate = new DataLinkEventDelegate(eventListenerAction);
            AndroidUnityBridge.CallServiceMethodEx(DataLinkClassName, "setDataLinkEventListener", eventDelegate);
        }

        public Action<EventListenerResult> GetDataLinkEventListener()
        {
            return _eventListenerAction;
        }

        private AndroidJavaObject CSharpCloudGameInfoToJavaObject(CloudGameInfo cloudGameInfo)
        {
            try
            {
                var androidJavaObject = new AndroidJavaObject("com.bytedance.ttgame.tob.common.host.api.config.CloudGameInfo");
                androidJavaObject.Set("cloudGameName",cloudGameInfo.CloudGameName);
                androidJavaObject.Set("hostPackageName",cloudGameInfo.HostPackageName);
                androidJavaObject.Set("hostVersionName",cloudGameInfo.HostVersionName);
                androidJavaObject.Set("hostVersionCode",cloudGameInfo.HostVersionCode);
                androidJavaObject.Set("hostDeviceModel",cloudGameInfo.HostDeviceModel);
                androidJavaObject.Set("hostIp",cloudGameInfo.HostIp);
                androidJavaObject.Set("hostUserAgent",cloudGameInfo.HostUserAgent);
                androidJavaObject.Set("hostOsType",cloudGameInfo.HostOsType);
                androidJavaObject.Set("hostMac",cloudGameInfo.HostMac);
                androidJavaObject.Set("hostAndroidId",cloudGameInfo.HostAndroidId);
                androidJavaObject.Set("hostOaid",cloudGameInfo.HostOaid);
                androidJavaObject.Set("hostImei",cloudGameInfo.HostImei);
                androidJavaObject.Set("hostIdfa",cloudGameInfo.HostIdfa);
                androidJavaObject.Set("hostCaid",cloudGameInfo.HostCaid);
                androidJavaObject.Set("extra", AndroidSDKInternalHelper.CSharpHashMap(cloudGameInfo.Extra));
                return androidJavaObject;
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
            
        }
        
        private sealed class DataLinkEventDelegate : AndroidJavaProxy
        {
            private readonly Action<EventListenerResult> _dataLinkEventDelegate;

            public DataLinkEventDelegate(Action<EventListenerResult> dataLinkEventDelegate)
                : base(Interface_DataLinkEventListener_Delegate)
            {
                _dataLinkEventDelegate = dataLinkEventDelegate;
            }

            public void onEventStatus(string eventName, int eventStatus, string message)
            {
                _dataLinkEventDelegate?.Invoke(new EventListenerResult(eventName, eventStatus, message));
            }
        }
        
    }
}

#endif