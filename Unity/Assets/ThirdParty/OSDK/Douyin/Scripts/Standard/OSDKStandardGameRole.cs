using UnityEngine;

namespace Douyin.Game
{
    // 注意：此脚本请挂载到游戏物体上，顺序位于SDK初始化脚本之后

    /// <summary>
    /// 游戏账号绑定
    /// </summary>
    public class OSDKStandardGameRole : MonoBehaviour
    {
        //【以下代码，外部方法】------------------------------------------------------------------
        
        /// <summary>
        /// 游戏账号与抖音账号的绑定
        /// </summary>
        /// <param name="gameUserId"></param>
        /// <param name="role"></param>
        public void ReportGameRole(string gameUserId, GameAccountRole role)
        {
            OSDK.GetService<IGameRoleService>().ReportGameRole(gameUserId, role, RoleBindSuccess, RoleBindFailed);
        }
        
        
        //【以下代码，需要开发者完善】------------------------------------------------------------------
        private void RoleBindSuccess()
        {
            // TODO 请处理账号绑定成功后的游戏逻辑
            
        }
        
        private void RoleBindFailed(BaseErrorEntity<RoleReportErrorEnum> entity)
        {
            // TODO 请处理账号绑定失败后的游戏逻辑
            
        }

    }
}