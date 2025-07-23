using System;

namespace Douyin.Game
{
    public interface IErrorWrapper<E, R> where E : Enum where R : BaseErrorEntity<E>
    {
        R Wrapper(R entity, int code, string message);
    }
}