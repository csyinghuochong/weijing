namespace ET
{
    public class PingComponent: Entity, IAwake, IDestroy
    {
        [NoMemoryCheck]
        public C2G_Ping C2G_Ping = new C2G_Ping();

        public long Ping; //延迟值

        public int DisconnectType = 0;	//0意外断开 1 主动断开不处理 3错误吗

        public int SessionType = 0; //0 Gate 1 account  2 queue
    }
}