#if UNITY_IOS
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Douyin.Game
{
    public class iOSGameRoleServiceImpl : IGameRoleService
    {   
        private delegate void OSDKGameRoleReportCallback();
        private delegate void OSDKGameRoleReportFailCallback(int errorCode, string errorMsg);

        private static Action _onSuccess;
        private static Action<BaseErrorEntity<RoleReportErrorEnum>>  _onFailed;

        public void ReportGameRole(string gameUserId, GameAccountRole role, Action onSuccess, Action<BaseErrorEntity<RoleReportErrorEnum>> onFailed)
        {
            _onSuccess = onSuccess;
            _onFailed = onFailed;
            
            OSDKGameRoleReport(gameUserId, 
                               role.RoleId, 
                               role.RoleName, 
                               role.RoleLevel, 
                               role.ServerId, 
                               role.ServerName, 
                               role.AvatarUrl,
                               Json.Serialize(role.Extra),
                               OSDKGameRoleReportCallbackMethod,
                               OSDKGameRoleReportFailCallbackMethod);
        }

        [DllImport("__Internal")]
        private static extern void OSDKGameRoleReport(string gameUserID, string roleID, string roleName, string roleLevel, string serverID, string serverName, string avatarUrl, string extraJsonString, OSDKGameRoleReportCallback successCallback, OSDKGameRoleReportFailCallback failCallback);

        [AOT.MonoPInvokeCallback(typeof(OSDKGameRoleReportCallback))]
        private static void OSDKGameRoleReportCallbackMethod()
        {
            SDKInternalUnityDispatcher.PostTask(() =>
            {
                if (_onSuccess == null) return;
                _onSuccess.Invoke();
            });
            
        }

        [AOT.MonoPInvokeCallback(typeof(OSDKGameRoleReportFailCallback))]
        private static void OSDKGameRoleReportFailCallbackMethod(int errorCode, string errorMsg)
        {
            SDKInternalUnityDispatcher.PostTask(() =>
            {
                if (_onFailed == null) return;
                var baseErrorEntity = new BaseErrorEntity<RoleReportErrorEnum>();
                var errorEntity = new GameRoleErrorWrapper().Wrapper(baseErrorEntity, errorCode, errorMsg);
                _onFailed.Invoke(errorEntity);
            });
            
        }
    }
}

#endif