using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
   
    public class ArenaDungeonComponent : Entity, IAwake, IDestroy
    {
        public M2C_AreneInfoResult M2C_AreneInfoResult = new M2C_AreneInfoResult();
    }
}
