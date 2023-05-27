using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BattleMessageComponent : Entity, IAwake
    {
        public M2C_BattleInfoResult M2C_BattleInfoResult;
        public M2C_AreneInfoResult M2C_AreneInfoResult;

        //竞技场开始匹配时间戳
        public long SoloPiPeiStartTime;

        //召唤机器人时间戳
        public long CallTeamRobotTime;
    }
}
