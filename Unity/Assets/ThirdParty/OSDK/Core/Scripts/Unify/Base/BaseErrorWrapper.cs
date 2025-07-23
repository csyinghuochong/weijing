using System;

namespace Douyin.Game
{
    /// <summary>
    /// 原生返回的错误都需要进行包装（包含Android、iOS平台）
    /// </summary>
    /// <typeparam name="E">枚举类型，标识返回的错误类型</typeparam>
    /// <typeparam name="R">ErrorEntity的子类，包装后的试题类型</typeparam>
    public abstract class BaseErrorWrapper<E, R> : IErrorWrapper<E, R> where E : Enum where R : BaseErrorEntity<E>
    {
        public R Wrapper(R entity, int code, string message)
        {
            entity.ErrorEnum = ConvertCode(code);
            entity.Message = ConvertMessage(code, message);
            return entity;
        }

        /// <summary>
        /// 错误转换
        /// </summary>
        /// <param name="code">原始错误码</param>
        /// <returns></returns>
        protected abstract E ConvertCode(int code);

        /// <summary>
        /// 转化message，默认实现不转化
        /// </summary>
        /// <param name="code">原始错误码</param>
        /// <param name="message">原始message</param>
        /// <returns>转化后的message</returns>
        protected virtual string ConvertMessage(int code, string message)
        {
            return $"errorCode:{code},errorMsg:{message}";
        }
    }
}