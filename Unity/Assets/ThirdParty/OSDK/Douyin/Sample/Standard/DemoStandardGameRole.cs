using UnityEngine;
using Douyin.Game;

namespace Demo.Douyin.Game
{
    // 注意：此脚本请挂载到游戏物体上，顺序位于SDK初始化脚本之后

    /// <summary>
    /// 游戏账号绑定
    /// </summary>
    public class DemoStandardGameRole : MonoBehaviour
    {
        //【以下代码，外部方法】------------------------------------------------------------------
        
        /// <summary>
        /// 游戏账号与抖音账号的绑定
        /// </summary>
        /// <param name="gameUserId"></param>
        /// <param name="role"></param>
        public void ReportGameRole(string gameUserId, GameAccountRole role)
        {
            DemoLog.D("调用账号绑定方法");
            OSDK.GetService<IGameRoleService>().ReportGameRole(gameUserId, role, RoleBindSuccess, RoleBindFailed);
        }
        
        
        //【以下代码，需要开发者完善】------------------------------------------------------------------
        private void RoleBindSuccess()
        {
            DemoLog.D("调用账号绑定方法==> Success");
            ShowToastAndPrint("成功");
        }
        
        private void RoleBindFailed(BaseErrorEntity<RoleReportErrorEnum> entity)
        {
            DemoLog.D("调用账号绑定方法==> Failed");
            ShowToastAndPrint("失败，code="+entity.ErrorEnum + ",msg="+entity.Message);
        }
        
        //【以下代码，开发者无需关注】------------------------------------------------------------------

        public static DemoStandardGameRole Instance => DemoGameObjectUtils.GetOrCreateGameObject<DemoStandardGameRole>();


        public static void ShowToastAndPrint(string message)
        {
            message = "账号绑定 " + message;
            DemoLog.D(message);
            ToastManager.Instance.ShowToast(message);
        }
    }
}
