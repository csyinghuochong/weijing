using System;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR

namespace Douyin.Game
{
    public class EditorDataLinkServiceImpl : IDataLinkService
    {
        private Action<EventListenerResult> _eventListenerAction;
        public bool OnGameActive()
        {
            _eventListenerAction?.Invoke( new EventListenerResult("onGameActive", 0, "上报成功"));
            return true;
        }

        public bool OnAccountRegister(string gameUserID)
        {
            _eventListenerAction?.Invoke(new EventListenerResult("onAccountRegister", 0, "上报成功"));
            return true;
        }

        public bool OnRoleRegister(string gameUserID, string gameRoleID)
        {
            _eventListenerAction?.Invoke(new EventListenerResult("onRoleRegister", 0, "上报成功"));
            return true;
        }

        public bool OnAccountLogin(string gameUserID, long lastLoginTime)
        {
            _eventListenerAction?.Invoke(new EventListenerResult("onAccountLogin", 0, "上报成功"));
            return true;
        }

        public bool OnRoleLogin(string gameUserID, string gameRoleID, long lastRoleLoginTime)
        {
            _eventListenerAction?.Invoke(new EventListenerResult("onRoleLogin", 0, "上报成功"));
            return true;
        }

        public bool OnPay(string gameUserID, string gameRoleID, string gameOrderID, long totalAmount, string productID, string productName, string productDesc)
        {
            _eventListenerAction?.Invoke(new EventListenerResult("onPay", 0, "上报成功"));
            return true;
        }

        public bool OnPaySpecial(string gameUserID, string gameRoleID, string gameOrderID, string payType, long payRangeMin, long payRangeMax, string productID, string productName, string productDesc)
        {
            _eventListenerAction?.Invoke(new EventListenerResult("onPaySpecial", 0, "上报成功"));
            return true;
        }

        public bool CustomEvent(string eventName, string jsonParams)
        {
            _eventListenerAction?.Invoke(new EventListenerResult("customEvent", 0, "上报成功"));
            return true;
        }
        
        public bool UpdateCloudGameInfo(CloudGameInfo cloudGameInfo)
        {
            _eventListenerAction?.Invoke(new EventListenerResult("updateCloudGameInfo", 0, "上报成功"));
            return true;
        }

        public void SetDataLinkEventListener(Action<EventListenerResult> eventListenerAction)
        {
            _eventListenerAction = eventListenerAction;
        }

        public Action<EventListenerResult> GetDataLinkEventListener()
        {
            return _eventListenerAction;
        }
    }
}

#endif