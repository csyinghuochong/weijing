using System.Collections.Generic;

namespace ET
{

    public enum ChengJiuTypeEnum : int
    { 
        None = 0,
        GuanKa = 1,
        TanSuo = 2,
        ShouJi = 3,
        Number = 4,
    }

    //1.击杀指定怪物ID的数量
    //2.击杀任意怪物数量
    //3.击杀任意BOSS
    //4.击杀普通难度BOSS
    //5.击杀挑战难度BOSS
    //6.击杀地狱难度BOSS

    //11.通关普通难度ID副本N次
    //12.通关挑战难度ID副本N次
    //13.通关地狱难度ID副本N次
    //14.完美(三星)通关地狱难度ID副本N次

    //201 累计获得金币
    //202 累计十连抽
    //203 累计装备洗练
    //204 累计复活
    //205 玩家等级
    //301 获取ID宠物
    //302 累计宠物总数量
    //303 累计合成宠物
    //304 累计宠物洗练
    //305 拥有N技能宠物一只

    public enum ChengJiuTargetEnum : int
    {
        None,
        KillIDMonster_1 = 1,
        KillTotalMonster_2 = 2,
        KillTotalBoss_3 = 3,
        KillNormalBoss_4 = 4,
        KillChallengeBoss_5 = 5,
        KillInfernalBoss_6 = 6,

        PassNormalFubenID_11 = 11,
        PassChallengeFubenID_12 = 12,
        PassInfernalFubenID_13 = 13,
        PerfectPassInfernalFubenID_14 = 14,

        TotalCoin_201 = 201,
        TotalChouKaTen = 202,
        TotalEquipXiLian = 203,
        TotalRevive = 204,
        PlayerLevel = 205,
        PetIdNumber = 301,
        TotalPetNumber = 302,
        TotalPetHeCheng = 303,
        TotalPetXiLian = 304,
        PetNSkill = 305,
    }

    public class ChengJiuComponent : Entity, IAwake, ITransfer, IUnitCache
    {
#if SERVER
        public List<ChengJiuInfo> ChengJiuProgessList = new List<ChengJiuInfo>();
#else
        public Dictionary<int, ChengJiuInfo> ChengJiuProgessList = new Dictionary<int, ChengJiuInfo>();
#endif

        public int TotalChengJiuPoint = 0;
        public List<int> AlreadReceivedId = new List<int>();
        public List<int> ChengJiuCompleteList = new List<int>();
    }
}
