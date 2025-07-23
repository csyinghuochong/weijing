using System;

namespace Douyin.Game
{
    public class EditorGameRoleServiceImpl : IGameRoleService
    {
        public void ReportGameRole(string gameUserId, GameAccountRole role, Action onSuccess, Action<BaseErrorEntity<RoleReportErrorEnum>> onFailed)
        {
            DemoLog.D("==> ReportGameRole");
            if (OSDKIntegration.GameRoleBindMock == OSDKMockStatus.Success)
            {
                DemoLog.D("==> game role success");
                onSuccess?.Invoke();
            }
            else
            {                
                DemoLog.D("==> game role fail");
                var errorWrapper = new GameRoleErrorWrapper();
                var errorEntity = new BaseErrorEntity<RoleReportErrorEnum>();
                var wrapperEntity = errorWrapper.Wrapper(errorEntity, 9999, "模拟验证 - 绑定失败");
                onFailed.Invoke(wrapperEntity);
            }
        }
    }
}