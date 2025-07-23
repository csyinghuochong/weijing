using System;

namespace Douyin.Game
{
    public interface IDouyinService
    {
        /// <summary>
        /// 抖音授权登录.
        /// </summary>
        /// <param name="scope">默认填 "user_info"即可，可以获取用户昵称和头像。多个权限时用英文逗号分隔，权限的定义详见抖音开平文档。</param>
        /// <param name="authCallback">授权回调</param>
        void Authorize(string scope, Action<AuthResponse> authCallback);

        /// <summary>
        /// 设置获取授权信息回调。在SDK需要授权信息时，SDK自动调用此回调。
        /// 开发者操作：在回调中返回授权信息，详见模板代码。
        /// </summary>
        /// <param name="getCallback">获取授权信息回调，成功时AuthError传空，失败时AuthInfo传空</param>
        void SetAuthInfoGetCallback(Action<Action<AuthInfo, AuthError>> getCallback);

        /// <summary>
        /// 设置更新授权信息回调。若AuthInfoGetCallback方法未获取到授权信息，或授权信息过期，SDK自动调用此回调。
        /// 开发者操作：在回调中返回授权信息，详见模板代码。
        /// </summary>
        /// <param name="updateCallback">获取授权信息回调，成功时AuthError传空，失败时AuthInfo传空</param>
        void SetAuthInfoUpdateCallback(Action<Action<AuthInfo, AuthError>> updateCallback);

        /// <summary>
        /// 清除SDK缓存的授权信息open_id和access_token
        /// </summary>
        void ClearDouYinAuthInfo();
    }
}