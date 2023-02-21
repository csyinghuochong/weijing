using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ArenaInfo : Entity, IAwake
    {
        public long FubenId = 0;
        public long FubenInstanceId = 0;
        public int SceneId = 0;

        public Dictionary<long, ArenaPlayerStatu> PlayerList = new Dictionary<long, ArenaPlayerStatu>();
    }

    public struct ArenaPlayerStatu
    {
        public int States;   //0关闭之后离开  1关闭之后离开  2 结束时还在
        public int KillNumber;
        public int RankId;
        public long UnitId;
    }

    public class ArenaSceneComponent : Entity, IAwake, IDestroy
    {

        public long Timer;

        public bool AreneSceneOpen;

        public bool ArenaSceneClose;

        public bool ArenaSceneOver;
    }
}
