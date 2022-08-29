using System.Collections.Generic;

namespace ET
{

    public class EnergyComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        //可否领取早睡奖励
        public bool EarlySleepReward = true;

        //领取过奖励的记录
        public List<int> GetRewards = new List<int>() { 0, 0, 0};

        //答题列表
        public List<int> QuestionList = new List<int>();

        public int QuestionIndex = 0;

    }
}
