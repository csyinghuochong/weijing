
namespace ET
{


    /// <summary>
    /// 道具获取方式[0系统默认1]
    /// </summary>
    public static class ItemGetWay
    {
        public const int System = 1;               //系统赠与
        public const int FubenGetReward = 2;        //副本结算领取
        public const int ChouKa = 3;                //抽卡
        public const int Energy = 4;                //正能量
        public const int GM = 5;                    //GM
        public const int ItemBox = 6;               //道具盒子
        public const int XiLianLevel = 7;           //洗练大师
        public const int LingDiReward = 8;          //领地
        public const int MysteryBuy = 9;            //神秘商店
        public const int PetFubenReward = 10;       //宠物副本奖励
        public const int PetHeXinHeCheng = 11;      //宠物之核合成
        public const int RandomTowerReward = 12;    //随机塔奖励
        public const int ShoujiReward = 13;         //收集奖励
        public const int StoreBuy = 14;             //商店购买
        public const int TaskCountry = 15;          //活跃任务
        public const int YueKaReward = 16;          //月卡奖励
        public const int ChengJiuRward = 17;        //成就奖励
        public const int RankReward = 18;           //排行榜奖励
        public const int FirstWin = 19;             //首胜
        public const int PickItem = 20;             //拾取
        public const int PaiMaiShop = 21;           //拍賣处购买
        public const int PetEggDuiHuan = 22;        //宠物蛋兑换
        public const int TaskReward = 23;           //宠物分解
        public const int PetFenjie = 24;            //任务奖励

        public const int Activity = 100;
    }

    //道具类型
    //1：消耗性道具
    //2：材料
    //3：装备
    //4：宝石
    public static class ItemTypeEnum
    {
        public const int ALL = 0;
        public const int Consume = 1;
        public const int Material = 2;
        public const int Equipment = 3;
        public const int Gemstone = 4;
        public const int PetHeXin = 5;
    }

    //装备类型细分
    //0:通用
    //1:剑
    //2:刀
    //3:法杖
    //4:魔法书
    //11:布甲
    //12:轻甲
    //13:重甲
    public enum ItemEquipType : int
    {
        Common = 0,
        Sword = 1,
        Knife = 2,
        Wand = 3,
        Book = 4,
        Bujia =11,
        QingJia = 12,
        ZhongJia= 13,
    }

    //道具存放位置
    //0背包
    //1装备
    //2仓库1
    //3仓库2
    //4仓库3
    //5仓库4
    public enum ItemLocType : int
    {
        ItemLocBag = 0,
        ItemPetHeXinBag = 1,
        ItemLocEquip = 2,
        ItemLocGem = 3,
        ItemPetHeXinEquip = 4,
        ItemWareHouse1 = 5,
        ItemWareHouse2 = 6,
        ItemWareHouse3 = 7,
        ItemWareHouse4 = 8,
        ItemLocMax,
    }

    //道具装备位置
    //1 武器
    //2 衣服
    //3 护符
    //4 戒指
    //5 饰品
    //6 鞋子
    //7 裤子
    //8 腰带
    //9 手镯
    //10 头盔
    //11 项链
    //12 宠物之核
    public enum ItemSubTypeEnum : int
    {
        Wuqi    = 1,
        Yifu    = 2,
        Fuhu    = 3,
        Jiezhi  =4,
        Shiping =5,
        Xiezi   =6,
        Kuzi    =7,
        Yaodai  =8,
        Shouzhuo=9,
        Toukui  =10,
        Xianglian=11,
    }

    //1:白色
    //2：绿色
    //3：紫色
    //4：橙色
    //5：金色
    public enum ItemQualityEnem : int
    {
        Quality1 = 1,
        Quality2,
        Quality3,
        Quality4,
        Quality5
    }

    public enum ItemOperateEnum : int
    { 
        None = 0,
        Bag = 1,                    //背包打开显示对应功能按钮
        Juese = 2,                  //角色栏打开显示对应功能按钮
        Shop = 3,                   //商店查看属性
        Cangku = 4,                 //仓库查看属性
        Watch = 5,                   //查看其他玩家
        HuishouBag = 6,             //回收背包打开
        HuishouShow = 7,            //回收列表展示
        XiangQianGem = 8,          //镶嵌在装备上的宝石
        Muchang = 9,                //牧场  不显示任何按钮
        MuchangCangku = 10,         //牧场仓库  显示出售按钮
        PetXiLian = 11,
        SkillSet = 12,
        CangkuBag = 13,             //仓库背包
        MakeItem = 14,
        MailReward = 15,
        ItemXiLian = 16,
        PaiMaiSell = 17,            //拍卖出售
        TaskItem = 18,              //任务
        XiangQianBag = 19,          //在镶嵌切页的背包中
        PetHeXinBag = 20,
    }

}
