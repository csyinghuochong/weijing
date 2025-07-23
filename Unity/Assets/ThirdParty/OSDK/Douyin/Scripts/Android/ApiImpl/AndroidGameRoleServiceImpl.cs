using System;
using UnityEngine;

#if UNITY_ANDROID
namespace Douyin.Game
{
    public class AndroidGameRoleServiceImpl : IGameRoleService
    {
        public void ReportGameRole(string gameUserId, GameAccountRole role, Action onSuccess, Action<BaseErrorEntity<RoleReportErrorEnum>> onFailed)
        {
            var callback = new GameRoleReportResult(onSuccess, onFailed);
            var roleObj = AndroidGameRoleServiceBridgeFactory.CSharpDouYinInfoToJavaObject(role);
            AndroidUnityBridge.CallServiceMethodEx(AndroidGameRoleServiceBridgeFactory.GameRolePackageName,
                "reportGameRole",gameUserId, roleObj, callback);
        }
        
        public sealed class GameRoleReportResult : AndroidJavaProxy
        {
            private Action _onSuccess;
            private Action<BaseErrorEntity<RoleReportErrorEnum>>  _onFailed;

            public GameRoleReportResult(Action onSuccess, Action<BaseErrorEntity<RoleReportErrorEnum>> onFailed) :
                base(AndroidGameRoleServiceBridgeFactory.GameRoleReportResultClass)
            {
                _onSuccess = onSuccess;
                _onFailed = onFailed;
            }

            public void onSuccess()
            {
                SDKInternalUnityDispatcher.PostTask(() => { _onSuccess?.Invoke(); });
            }

            public void onFailed(int code, string message)
            {
                SDKInternalUnityDispatcher.PostTask(() =>
                {
                    var errorWrapper = new GameRoleErrorWrapper();
                    var errorEntity = new BaseErrorEntity<RoleReportErrorEnum>();
                    var wrapperEntity = errorWrapper.Wrapper(errorEntity, code, message);
                    _onFailed?.Invoke(wrapperEntity);
                });
            }
        }
    }
}
#endif