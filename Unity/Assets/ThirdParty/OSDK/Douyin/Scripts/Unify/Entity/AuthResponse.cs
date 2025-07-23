namespace Douyin.Game
{
    public class AuthResponse : BaseErrorEntity<DouyinAuthorizeErrorEnum>
    {
        // 用于服务端换取 access_token 与 open_id
        public string AuthCode;

        // 获取的权限域（scope），一般不需要关心
        public string GrantedPermissions;
    }
}