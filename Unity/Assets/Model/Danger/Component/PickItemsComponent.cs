using System.Collections.Generic;

namespace ET
{
    /// <summary>
    /// 将短时间内拾取道具的消息合并，防止一瞬间发送太多
    /// </summary>
    public class PickItemsComponent : Entity, IAwake, IDestroy
    {
        public List<Unit> UnitDrops = new List<Unit>();

        public List<long> PickItemIds = new List<long>();

        public long SyncTime = 0;
        public long SyncTimerId = 0;
        public long LastSendTime = 0;
    }
}