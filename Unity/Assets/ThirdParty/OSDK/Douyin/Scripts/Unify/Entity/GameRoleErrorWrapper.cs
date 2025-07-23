namespace Douyin.Game
{
    public class GameRoleErrorWrapper : BaseErrorWrapper<RoleReportErrorEnum, BaseErrorEntity<RoleReportErrorEnum>>
    {
        protected override RoleReportErrorEnum ConvertCode(int code)
        {
            switch (code)
            {
                case 9999:
                    return RoleReportErrorEnum.UnKnown;
                case -10001:
                    return RoleReportErrorEnum.DelegateNull;
                case -10002:
                    return RoleReportErrorEnum.TokenOrUidNull;
                case -10003:
                    return RoleReportErrorEnum.TokenInvalid;
                case -10004:
                    return RoleReportErrorEnum.ServerError;
                case -10005:
                    return RoleReportErrorEnum.IOSUserIDNull;
                case -10006:
                    return RoleReportErrorEnum.RoleIDNull;
                default:
                    return  RoleReportErrorEnum.UnKnown;
            }
        }
    }
}