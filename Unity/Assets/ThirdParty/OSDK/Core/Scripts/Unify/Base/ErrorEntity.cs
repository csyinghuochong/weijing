namespace Douyin.Game
{
    public class ErrorEntity 
    {
        // 错误枚举
        public int Code;

        // 错误信息
        public string Message;

        public ErrorEntity(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}