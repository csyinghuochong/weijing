

namespace ET
{

    public struct CreateMonsterInfo
    {
        public int SkillId;             //魔能房间台子技能
        public int PlayerLevel;
        public string AttributeParams;
        public int Camp;            //阵营
        public long MasterID;
        public int Rotation;         //朝向
    }

    public static class TeamFubenType
    {
        public const int Normal = 1;
        public const int XieZhu = 2;
        public const int ShenYuan = 3;
    }

    public static class FubenDifficulty
    {
        public const int None = 0;
        public const int Normal = 1;
        public const int TiaoZhan = 2;
        public const int DiYu = 3;
    }

    //NONE = 0,
    //INIT = 1,
    //LOGIN = 2,
    //MAIN_CITY = 3,
    //BATTLE = 4,
    //FUBEN = 5,
    public static class SceneTypeEnum
    {
        public const int NONE = 0;
        public const int InitScene = 1;
        public const int LoginScene = 2;         //登录scene
        public const int MainCityScene = 3;      //主城
        public const int CellDungeon = 4;       //格子副本
        public const int TeamDungeon = 5;        //组队副本
        public const int PetTianTi = 6;         //宠物天梯
        public const int BaoZang = 7;        //野外地图 [宝藏之地]
        public const int Tower = 8;             //爬塔   别名挑战之地
        public const int LocalDungeon = 9;      //本地副本
        public const int PetDungeon = 10;       //宠物闯关副本
        public const int RandomTower = 11;       //通天塔
        public const int Battle = 12;           //阵营战场
        public const int TrialDungeon = 13;     //试炼副本
        public const int MiJing = 14;        //野外地图 [秘境]
        public const int Arena = 15;        //角斗场
        public const int JiaYuan = 16;       //家园
    }
}
