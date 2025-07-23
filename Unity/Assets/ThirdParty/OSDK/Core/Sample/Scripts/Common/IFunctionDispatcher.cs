namespace Douyin.Game
{
    // 功能分发器
    public interface IFunctionDispatcher
    {
        // 分发功能，itemNameId -> 对应的功能Id
        void FunctionDispatch(string itemNameId);
    }
}