using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 数据统计。。
    /// </summary>
    public class DataCollationComponent : Entity, IAwake, ITransfer, IUnitCache
    {

        //    userid,

        //名称
        public string Name;

        //等级
        public string Lv;

        //第一职业（用文字 法师/战士）
        public string Occ;

        //转职（用文字 元素剑士/驭剑士……）
        public string OccTwo;

        //战斗力
        public int Combat;

        //金币额度
        public long Gold;

        //钻石额度
        public long Diamond;

        //充值额度
        public long Recharge;

        //在线时间

        //创建角色时间

        //上次登录时间

        //当前主线ID

        //宠物ID {宠物ID,宠物评分
        //}

        //家族名称

        //家园等级

        //家园资金

        //体力值

        //活力值

        //当前生活技能类型 (这里最好用文字表示  炼金 锻造)

        //生活技能熟练度

        //宠物探险关卡

        //试炼之地关卡

        //(幸运探宝)抽奖次数

        //宠物探索次数

        //宠物兑换次数

        //当前身上橙色装备数量

        //洗炼经验

        //上次封印之塔层数（不是最高, 上一次即可）

        //（单独处理一下两个, 花费类型高的排在前面）

        //金币消耗

        //钻石消耗

    }
}
