using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class M2C_SoloDungeonHandle : AMHandler<M2C_SoloDungeon>
    {
        protected override void Run(Session session, M2C_SoloDungeon message)
        {
            Log.Debug("恭喜你！竞技场获胜...." + message.SoloResult);
        }
    }
}
