using System.Collections;
using System.Collections.Generic;

namespace ET
{
    public class BattleMessageComponent : Entity, IAwake
    {

        public M2C_HappyInfoResult M2C_HappyInfoResult;
        public M2C_BattleInfoResult M2C_BattleInfoResult;
        public M2C_AreneInfoResult M2C_AreneInfoResult;
        public M2C_RankRunRaceMessage M2C_RankRunRaceMessage;
        public M2C_RunRaceBattleInfo M2C_RunRaceBattleInfo;

        //竞技场开始匹配时间戳
        public long SoloPiPeiStartTime;
        //竞技场胜负记录
        public int SoloNum_Win;
        public int SoloNum_Fail;

        //召唤机器人时间戳
        public long CallTeamRobotTime;

        /// <summary>
        /// 骑乘状态
        /// </summary>
        public long RideForbidTime;

        public long RideTargetUnit;


        public long UploadMemoryTime;

        public int LastDungeonId;

        public Dictionary<long, long> PetFightCD = new Dictionary<long, long>();

        // 组队喊话频率
        public long ShoutInterval;

        public int FirstWinBossId;

        public bool ShowPetChouKaGet = false;
        public List<EventType.RolePetAdd> RolePetAdds = new List<EventType.RolePetAdd>();
    }
}
