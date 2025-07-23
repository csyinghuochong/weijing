

using System;

namespace Douyin.Game
{
    public interface IGameRoleService
    {
        /// <summary>
        /// 提供游戏账号信息与抖音账号的关联
        /// </summary>
        /// <param name="gameUserId">游戏账号唯一标识,如UID</param>
        /// <param name="role">游戏角色基础信息</param>
        /// <param name="onSuccess">关联成功回调</param>
        /// <param name="onFailed">关联失败错误回调</param>
        void ReportGameRole(string gameUserId, GameAccountRole role, Action onSuccess, Action<BaseErrorEntity<RoleReportErrorEnum>> onFailed);
    }
}