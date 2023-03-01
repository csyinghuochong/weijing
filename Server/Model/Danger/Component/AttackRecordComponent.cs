using System.Collections.Generic;

namespace ET
{
    public class AttackRecordComponent : Entity, IAwake, IDestroy
    {

        public long AttackingId;

        /// <summary>
        /// 抢夺BOSS显示当前怪物掉落归属 怪物表 DropType 字段为1 的显示 [掉落归属是统计玩家伤害最高的,
        /// 如果脱离战斗或者死亡清空伤害数据]
        /// </summary>
        public int DropType = 0;
        /// <summary>
        /// 玩家ID
        /// </summary>
        public Dictionary<long, long> BeAttackPlayerList = new Dictionary<long, long>();

        public long LastTime;

        public List<KeyValuePairInt> ValuePairInts = new List<KeyValuePairInt>();
    }
}
