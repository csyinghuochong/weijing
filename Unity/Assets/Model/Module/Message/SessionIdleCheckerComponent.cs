namespace ET
{

    /// <summary>
    /// 心跳组件 。创建 Session的时候 添加到Session的组件列表
    /// </summary>
    public class SessionIdleCheckerComponent: Entity, IAwake<int>, IDestroy
    {
        public long RepeatedTimer;
    }
}