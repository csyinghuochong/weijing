namespace Douyin.Game
{
    /// <summary>
    /// 获取抖音授权错误类，Code和Message由开发者自定义
    /// </summary>
    public class AuthError
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public int Code;
        
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message;
    }
}