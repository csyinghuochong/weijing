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
    }
}
