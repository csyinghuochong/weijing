using System.Collections.Generic;
using UnityEngine;

#if UNITY_ANDROID

namespace Douyin.Game
{
    public static class AndroidGameRoleServiceBridgeFactory
    {
        public static readonly string GameRolePackageName =
            "com.bytedance.ttgame.tob.optional.aweme.api.IGameRoleService";
        private static readonly AndroidJavaClass GameRoleServiceClass =
            new AndroidJavaClass(GameRolePackageName);
        public static readonly AndroidJavaClass GameRoleReportResultClass =
            new AndroidJavaClass("com.bytedance.ttgame.tob.optional.aweme.api.callback.IGameRoleReportResult");

        //public static AndroidJavaObject GameRoleService => AndroidCommonServiceBridgeFactory.GetService(GameRoleServiceClass);

        public static AndroidJavaObject CSharpDouYinInfoToJavaObject(GameAccountRole role)
        {
            var androidJavaObject =
                new AndroidJavaObject("com.bytedance.ttgame.tob.optional.aweme.api.GameAccountRole",
                    role.RoleId, role.RoleName, role.RoleLevel, role.ServerId, role.ServerName,role.AvatarUrl,
                    AndroidSDKInternalHelper.CCharpDictionaryToJavaJsonObject(role.Extra)
                );
            return androidJavaObject;
        }
        
    }
}

#endif