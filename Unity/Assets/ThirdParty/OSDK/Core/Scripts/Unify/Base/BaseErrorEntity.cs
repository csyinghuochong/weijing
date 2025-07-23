using System;

namespace Douyin.Game
{
    public class BaseErrorEntity<T> where T : Enum
    {
        // 错误枚举
        public T ErrorEnum;

        // 错误信息
        public string Message;
    }
}